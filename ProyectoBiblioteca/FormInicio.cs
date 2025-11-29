using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblioteca
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormEnPanel(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                pnlContenedor.Controls.RemoveAt(0);
            }
            formHijo.TopLevel = false;
            formHijo.WindowState=FormWindowState.Maximized;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();

        }

        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRegistrarLibro());
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRegistrarSocio());
        }

        private void btnVerLibro_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormLibros());
        }

        private void btnVerSocio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormSocios());
        }

        private void btnPrestarLibro_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormPrestarLibro());
        }

        private void btnHistorialPrestamo_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormHistorialPrestamo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
