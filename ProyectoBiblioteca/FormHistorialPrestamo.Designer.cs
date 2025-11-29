namespace ProyectoBiblioteca
{
    partial class FormHistorialPrestamo
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
            this.dgvHistorialPrestamo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialPrestamo
            // 
            this.dgvHistorialPrestamo.AllowUserToAddRows = false;
            this.dgvHistorialPrestamo.AllowUserToDeleteRows = false;
            this.dgvHistorialPrestamo.AllowUserToResizeColumns = false;
            this.dgvHistorialPrestamo.AllowUserToResizeRows = false;
            this.dgvHistorialPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorialPrestamo.Location = new System.Drawing.Point(0, 0);
            this.dgvHistorialPrestamo.Name = "dgvHistorialPrestamo";
            this.dgvHistorialPrestamo.Size = new System.Drawing.Size(800, 450);
            this.dgvHistorialPrestamo.TabIndex = 0;
            // 
            // FormHistorialPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHistorialPrestamo);
            this.Name = "FormHistorialPrestamo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHistorialPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPrestamo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorialPrestamo;
    }
}