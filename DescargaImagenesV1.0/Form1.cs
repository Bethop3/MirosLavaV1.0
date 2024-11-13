using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace DescargaImagenesV1._0
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private readonly List<string> resultados = new List<string>();
        private readonly object bloqueo = new object();
        private readonly string carpetaDestino;
        private readonly ProgressBar[] barrasProgreso;
        private readonly List<Thread> hilosDescarga = new List<Thread>();
        private readonly List<string> rutasImagenes = new List<string> { null, null, null };
        private int descargasEnProgreso = 0;

        public Form1()
        {
            InitializeComponent();

            // Crear la carpeta "Imágenes Miroslava" en el escritorio
            carpetaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Imágenes Miroslava");
            if (!Directory.Exists(carpetaDestino))
            {
                Directory.CreateDirectory(carpetaDestino);
            }

            // Inicializar las barras de progreso
            barrasProgreso = new ProgressBar[] { ProgresoDescarga1, ProgresoDescarga2, ProgresoDescarga3 };
        }

        private void ButtonDescargar_MouseClick(object sender, MouseEventArgs e)
        {
            // Obtener URL ingresada
            string url = URLImagen.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Por favor, inserte una URL válida.", "Error");
                return;
            }

            // Verificar si hay descargas disponibles
            if (descargasEnProgreso >= 3)
            {
                MessageBox.Show("Todas las descargas están en progreso. Espere a que finalicen para iniciar una nueva.", "Cola llena");
                return;
            }

            // Verificar si hay una barra de progreso disponible
            int index = ObtenerBarraDisponible();
            if (index == -1)
            {
                MessageBox.Show("No hay barras de progreso disponibles. Intente más tarde.", "Cola llena");
                return;
            }

            // Incrementar el contador de descargas en progreso
            descargasEnProgreso++;

            // Crear y empezar un hilo para la descarga
            Thread hilo = new Thread(() => DescargarImagen(url, barrasProgreso[index], $"Descarga No.{index + 1}", index));
            hilosDescarga.Add(hilo);
            hilo.Start();
        }

        private int ObtenerBarraDisponible()
        {
            // Buscar una barra de progreso disponible
            for (int i = 0; i < barrasProgreso.Length; i++)
            {
                if (barrasProgreso[i].Value == 0 || barrasProgreso[i].Value == 100)
                {
                    return i;
                }
            }
            return -1; // No hay barras disponibles
        }

        private void DescargarImagen(string url, ProgressBar progressBar, string nombreDescarga, int indice)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    // Establecer un User-Agent para evitar restricciones del servidor
                    webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");

                    // Obtener el nombre del archivo de la URL
                    var nombreArchivo = Path.GetFileName(new Uri(url).AbsolutePath);
                    var rutaArchivo = Path.Combine(carpetaDestino, nombreArchivo);

                    // Simulación de descarga (30 segundos)
                    MessageBox.Show($"Iniciando la simulación de descarga para {nombreDescarga}. Esta tomará 30 segundos.", "Simulación de Descarga");
                    for (int i = 0; i <= 100; i++)
                    {
                        progressBar.Invoke(new Action(() =>
                        {
                            progressBar.Value = i;
                        }));
                        Thread.Sleep(300); // 300 ms * 100 iteraciones = 30 segundos
                    }

                    // Descargar la imagen real después de la simulación
                    webClient.DownloadFile(new Uri(url), rutaArchivo);

                    // Registro de la descarga
                    lock (bloqueo)
                    {
                        resultados.Add($"Descargado: {nombreArchivo} - Guardado en: {rutaArchivo}");
                        rutasImagenes[indice] = rutaArchivo;
                    }

                    MessageBox.Show($"Descargado: {nombreDescarga} - {nombreArchivo}", "Descarga Completada");

                    // Mostrar la imagen descargada
                    MostrarImagen(rutaArchivo);

                    // Reiniciar el ProgressBar para estar disponible para otra descarga
                    progressBar.Invoke(new Action(() => progressBar.Value = 0));

                    // Decrementar el contador de descargas en progreso
                    descargasEnProgreso--;
                }
            }
            catch (Exception ex)
            {
                lock (bloqueo)
                {
                    resultados.Add($"Error al descargar {url}: {ex.Message}");
                }

                MessageBox.Show($"Error al descargar {url}: {ex.Message}", "Error");

                // Decrementar el contador de descargas en progreso en caso de error
                descargasEnProgreso--;
            }
        }

        private void MostrarImagen(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                var vistaImagen = new PictureBox
                {
                    Image = Image.FromFile(rutaArchivo),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 400,
                    Height = 400,
                    BorderStyle = BorderStyle.FixedSingle
                };

                var formImagen = new Form
                {
                    Text = "Vista Previa de la Imagen",
                    Width = 450,
                    Height = 450
                };
                formImagen.Controls.Add(vistaImagen);
                formImagen.ShowDialog();
            }
            else
            {
                MessageBox.Show("La imagen no se encontró.", "Error");
            }
        }

        private void VerImagen1_MouseClick(object sender, MouseEventArgs e)
        {
            if (rutasImagenes[0] != null)
            {
                MostrarImagen(rutasImagenes[0]);
            }
            else
            {
                MessageBox.Show("No hay imagen descargada para mostrar.", "Información");
            }
        }

        private void ButtonVerImagen2_MouseClick(object sender, MouseEventArgs e)
        {
            if (rutasImagenes[1] != null)
            {
                MostrarImagen(rutasImagenes[1]);
            }
            else
            {
                MessageBox.Show("No hay imagen descargada para mostrar.", "Información");
            }
        }

        private void ButtonVerImagen3_MouseClick(object sender, MouseEventArgs e)
        {
            if (rutasImagenes[2] != null)
            {
                MostrarImagen(rutasImagenes[2]);
            }
            else
            {
                MessageBox.Show("No hay imagen descargada para mostrar.", "Información");
            }
        }
    }
}
