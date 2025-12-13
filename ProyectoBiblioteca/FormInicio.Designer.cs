namespace ProyectoBiblioteca
{
    partial class FormInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.btnHistorialPrestamo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPrestarLibro = new System.Windows.Forms.Button();
            this.btnVerSocio = new System.Windows.Forms.Button();
            this.btnVerLibro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrarLibro = new System.Windows.Forms.Button();
            this.btnRegistrarSocio = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnReporteMorosos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnReporteMorosos);
            this.panel1.Controls.Add(this.btnVerReporte);
            this.panel1.Controls.Add(this.btnHistorialPrestamo);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnPrestarLibro);
            this.panel1.Controls.Add(this.btnVerSocio);
            this.panel1.Controls.Add(this.btnVerLibro);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRegistrarLibro);
            this.panel1.Controls.Add(this.btnRegistrarSocio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 674);
            this.panel1.TabIndex = 0;
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Location = new System.Drawing.Point(24, 483);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(184, 37);
            this.btnVerReporte.TabIndex = 9;
            this.btnVerReporte.Text = "Reporte de Prestamos";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // btnHistorialPrestamo
            // 
            this.btnHistorialPrestamo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHistorialPrestamo.FlatAppearance.BorderSize = 0;
            this.btnHistorialPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialPrestamo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnHistorialPrestamo.Location = new System.Drawing.Point(22, 429);
            this.btnHistorialPrestamo.Name = "btnHistorialPrestamo";
            this.btnHistorialPrestamo.Size = new System.Drawing.Size(187, 41);
            this.btnHistorialPrestamo.TabIndex = 8;
            this.btnHistorialPrestamo.Text = "Historial de Prestamo";
            this.btnHistorialPrestamo.UseVisualStyleBackColor = false;
            this.btnHistorialPrestamo.Click += new System.EventHandler(this.btnHistorialPrestamo_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(22, 585);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(187, 41);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPrestarLibro
            // 
            this.btnPrestarLibro.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPrestarLibro.FlatAppearance.BorderSize = 0;
            this.btnPrestarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestarLibro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestarLibro.ForeColor = System.Drawing.Color.White;
            this.btnPrestarLibro.Location = new System.Drawing.Point(22, 382);
            this.btnPrestarLibro.Name = "btnPrestarLibro";
            this.btnPrestarLibro.Size = new System.Drawing.Size(187, 41);
            this.btnPrestarLibro.TabIndex = 5;
            this.btnPrestarLibro.Text = "Prestar Libro";
            this.btnPrestarLibro.UseVisualStyleBackColor = false;
            this.btnPrestarLibro.Click += new System.EventHandler(this.btnPrestarLibro_Click);
            // 
            // btnVerSocio
            // 
            this.btnVerSocio.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVerSocio.FlatAppearance.BorderSize = 0;
            this.btnVerSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSocio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSocio.ForeColor = System.Drawing.Color.White;
            this.btnVerSocio.Location = new System.Drawing.Point(22, 335);
            this.btnVerSocio.Name = "btnVerSocio";
            this.btnVerSocio.Size = new System.Drawing.Size(187, 41);
            this.btnVerSocio.TabIndex = 4;
            this.btnVerSocio.Text = "Ver Lista de Socios";
            this.btnVerSocio.UseVisualStyleBackColor = false;
            this.btnVerSocio.Click += new System.EventHandler(this.btnVerSocio_Click);
            // 
            // btnVerLibro
            // 
            this.btnVerLibro.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVerLibro.FlatAppearance.BorderSize = 0;
            this.btnVerLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerLibro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerLibro.ForeColor = System.Drawing.Color.White;
            this.btnVerLibro.Location = new System.Drawing.Point(22, 288);
            this.btnVerLibro.Name = "btnVerLibro";
            this.btnVerLibro.Size = new System.Drawing.Size(187, 41);
            this.btnVerLibro.TabIndex = 3;
            this.btnVerLibro.Text = "Ver Lista de Libros";
            this.btnVerLibro.UseVisualStyleBackColor = false;
            this.btnVerLibro.Click += new System.EventHandler(this.btnVerLibro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrarLibro
            // 
            this.btnRegistrarLibro.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrarLibro.FlatAppearance.BorderSize = 0;
            this.btnRegistrarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarLibro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarLibro.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarLibro.Location = new System.Drawing.Point(22, 194);
            this.btnRegistrarLibro.Name = "btnRegistrarLibro";
            this.btnRegistrarLibro.Size = new System.Drawing.Size(187, 41);
            this.btnRegistrarLibro.TabIndex = 1;
            this.btnRegistrarLibro.Text = "Registrar Nuevo Libro";
            this.btnRegistrarLibro.UseVisualStyleBackColor = false;
            this.btnRegistrarLibro.Click += new System.EventHandler(this.btnRegistrarLibro_Click);
            // 
            // btnRegistrarSocio
            // 
            this.btnRegistrarSocio.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrarSocio.FlatAppearance.BorderSize = 0;
            this.btnRegistrarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSocio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSocio.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarSocio.Location = new System.Drawing.Point(22, 241);
            this.btnRegistrarSocio.Name = "btnRegistrarSocio";
            this.btnRegistrarSocio.Size = new System.Drawing.Size(187, 41);
            this.btnRegistrarSocio.TabIndex = 2;
            this.btnRegistrarSocio.Text = "Registrar Nuevo Socio";
            this.btnRegistrarSocio.UseVisualStyleBackColor = false;
            this.btnRegistrarSocio.Click += new System.EventHandler(this.btnRegistrarSocio_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(228, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(728, 674);
            this.pnlContenedor.TabIndex = 2;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // btnReporteMorosos
            // 
            this.btnReporteMorosos.Location = new System.Drawing.Point(27, 535);
            this.btnReporteMorosos.Name = "btnReporteMorosos";
            this.btnReporteMorosos.Size = new System.Drawing.Size(180, 30);
            this.btnReporteMorosos.TabIndex = 10;
            this.btnReporteMorosos.Text = "Ver Reporte Morosos";
            this.btnReporteMorosos.UseVisualStyleBackColor = true;
            this.btnReporteMorosos.Click += new System.EventHandler(this.btnReporteMorosos_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 674);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPrestarLibro;
        private System.Windows.Forms.Button btnVerSocio;
        private System.Windows.Forms.Button btnVerLibro;
        private System.Windows.Forms.Button btnRegistrarLibro;
        private System.Windows.Forms.Button btnRegistrarSocio;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnHistorialPrestamo;
        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.Button btnReporteMorosos;
    }
}