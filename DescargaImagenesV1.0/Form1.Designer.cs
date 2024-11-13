namespace DescargaImagenesV1._0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonVerImagen3 = new MaterialSkin.Controls.MaterialButton();
            this.ButtonVerImagen2 = new MaterialSkin.Controls.MaterialButton();
            this.ButtonVerImagen1 = new MaterialSkin.Controls.MaterialButton();
            this.ProgresoDescarga3 = new MaterialSkin.Controls.MaterialProgressBar();
            this.ProgresoDescarga2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.ProgresoDescarga1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonDescargar = new MaterialSkin.Controls.MaterialButton();
            this.URLImagen = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1199, 757);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1191, 731);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(752, 208);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(713, 126);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(40, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOLA ! Bienvendio al programa MirosLava v1.0";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.ButtonVerImagen3);
            this.tabPage2.Controls.Add(this.ButtonVerImagen2);
            this.tabPage2.Controls.Add(this.ButtonVerImagen1);
            this.tabPage2.Controls.Add(this.ProgresoDescarga3);
            this.tabPage2.Controls.Add(this.ProgresoDescarga2);
            this.tabPage2.Controls.Add(this.ProgresoDescarga1);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.ButtonDescargar);
            this.tabPage2.Controls.Add(this.URLImagen);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1191, 731);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Descargas";
            // 
            // ButtonVerImagen3
            // 
            this.ButtonVerImagen3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonVerImagen3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonVerImagen3.Depth = 0;
            this.ButtonVerImagen3.HighEmphasis = true;
            this.ButtonVerImagen3.Icon = null;
            this.ButtonVerImagen3.Location = new System.Drawing.Point(1046, 614);
            this.ButtonVerImagen3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonVerImagen3.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonVerImagen3.Name = "ButtonVerImagen3";
            this.ButtonVerImagen3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonVerImagen3.Size = new System.Drawing.Size(108, 36);
            this.ButtonVerImagen3.TabIndex = 14;
            this.ButtonVerImagen3.Text = "Ver imagen";
            this.ButtonVerImagen3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonVerImagen3.UseAccentColor = false;
            this.ButtonVerImagen3.UseVisualStyleBackColor = true;
            this.ButtonVerImagen3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonVerImagen3_MouseClick);
            // 
            // ButtonVerImagen2
            // 
            this.ButtonVerImagen2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonVerImagen2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonVerImagen2.Depth = 0;
            this.ButtonVerImagen2.HighEmphasis = true;
            this.ButtonVerImagen2.Icon = null;
            this.ButtonVerImagen2.Location = new System.Drawing.Point(1044, 470);
            this.ButtonVerImagen2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonVerImagen2.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonVerImagen2.Name = "ButtonVerImagen2";
            this.ButtonVerImagen2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonVerImagen2.Size = new System.Drawing.Size(108, 36);
            this.ButtonVerImagen2.TabIndex = 13;
            this.ButtonVerImagen2.Text = "Ver imagen";
            this.ButtonVerImagen2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonVerImagen2.UseAccentColor = false;
            this.ButtonVerImagen2.UseVisualStyleBackColor = true;
            this.ButtonVerImagen2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonVerImagen2_MouseClick);
            // 
            // ButtonVerImagen1
            // 
            this.ButtonVerImagen1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonVerImagen1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonVerImagen1.Depth = 0;
            this.ButtonVerImagen1.HighEmphasis = true;
            this.ButtonVerImagen1.Icon = null;
            this.ButtonVerImagen1.Location = new System.Drawing.Point(1046, 317);
            this.ButtonVerImagen1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonVerImagen1.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonVerImagen1.Name = "ButtonVerImagen1";
            this.ButtonVerImagen1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonVerImagen1.Size = new System.Drawing.Size(108, 36);
            this.ButtonVerImagen1.TabIndex = 12;
            this.ButtonVerImagen1.Text = "Ver Imagen";
            this.ButtonVerImagen1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonVerImagen1.UseAccentColor = false;
            this.ButtonVerImagen1.UseVisualStyleBackColor = true;
            this.ButtonVerImagen1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VerImagen1_MouseClick);
            // 
            // ProgresoDescarga3
            // 
            this.ProgresoDescarga3.Depth = 0;
            this.ProgresoDescarga3.Location = new System.Drawing.Point(39, 629);
            this.ProgresoDescarga3.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgresoDescarga3.Name = "ProgresoDescarga3";
            this.ProgresoDescarga3.Size = new System.Drawing.Size(974, 5);
            this.ProgresoDescarga3.TabIndex = 11;
            // 
            // ProgresoDescarga2
            // 
            this.ProgresoDescarga2.Depth = 0;
            this.ProgresoDescarga2.Location = new System.Drawing.Point(39, 483);
            this.ProgresoDescarga2.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgresoDescarga2.Name = "ProgresoDescarga2";
            this.ProgresoDescarga2.Size = new System.Drawing.Size(974, 5);
            this.ProgresoDescarga2.TabIndex = 10;
            // 
            // ProgresoDescarga1
            // 
            this.ProgresoDescarga1.Depth = 0;
            this.ProgresoDescarga1.Location = new System.Drawing.Point(39, 333);
            this.ProgresoDescarga1.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgresoDescarga1.Name = "ProgresoDescarga1";
            this.ProgresoDescarga1.Size = new System.Drawing.Size(974, 5);
            this.ProgresoDescarga1.TabIndex = 9;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(36, 563);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(105, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Descarga No.3";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(36, 418);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(105, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Descarga No.2";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(36, 274);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Descarga No.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Por favor inserte una URL de la imagen a descargar\r\n";
            // 
            // ButtonDescargar
            // 
            this.ButtonDescargar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDescargar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonDescargar.Depth = 0;
            this.ButtonDescargar.HighEmphasis = true;
            this.ButtonDescargar.Icon = null;
            this.ButtonDescargar.Location = new System.Drawing.Point(875, 175);
            this.ButtonDescargar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonDescargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDescargar.Name = "ButtonDescargar";
            this.ButtonDescargar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonDescargar.Size = new System.Drawing.Size(106, 36);
            this.ButtonDescargar.TabIndex = 4;
            this.ButtonDescargar.Text = "Descargar";
            this.ButtonDescargar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonDescargar.UseAccentColor = false;
            this.ButtonDescargar.UseVisualStyleBackColor = true;
            this.ButtonDescargar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonDescargar_MouseClick);
            // 
            // URLImagen
            // 
            this.URLImagen.AnimateReadOnly = false;
            this.URLImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URLImagen.Depth = 0;
            this.URLImagen.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.URLImagen.LeadingIcon = null;
            this.URLImagen.Location = new System.Drawing.Point(206, 175);
            this.URLImagen.MaxLength = 32767;
            this.URLImagen.MouseState = MaterialSkin.MouseState.OUT;
            this.URLImagen.Multiline = false;
            this.URLImagen.Name = "URLImagen";
            this.URLImagen.Size = new System.Drawing.Size(662, 50);
            this.URLImagen.TabIndex = 3;
            this.URLImagen.Text = "";
            this.URLImagen.TrailingIcon = null;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(416, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Miroslava v1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 824);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Text = "❤️❤️ MirosLava ❤️❤️";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox URLImagen;
        private MaterialSkin.Controls.MaterialButton ButtonDescargar;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton ButtonVerImagen3;
        private MaterialSkin.Controls.MaterialButton ButtonVerImagen2;
        private MaterialSkin.Controls.MaterialButton ButtonVerImagen1;
        private MaterialSkin.Controls.MaterialProgressBar ProgresoDescarga3;
        private MaterialSkin.Controls.MaterialProgressBar ProgresoDescarga2;
        private MaterialSkin.Controls.MaterialProgressBar ProgresoDescarga1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

