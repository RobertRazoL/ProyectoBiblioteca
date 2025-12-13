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
            // 1. Instanciamos el formulario de Préstamo
            FormPrestarLibro formulario = new FormPrestarLibro();

            // 2. Lo mostramos como ventana Modal (bloquea la de atrás)
            // Esto es ideal para transacciones porque obliga a terminar o cancelar antes de seguir.
            formulario.ShowDialog();

            // (OPCIONAL) 
            // Si en tu FormInicio tienes una grilla mostrando los libros y su stock,
            // aquí deberías llamar a tu método de cargar para que se actualice el stock visualmente
            // justo después de cerrar la ventana de préstamo.
            // Ejemplo:
            // CargarGrillaLibros();
        }

        private void btnHistorialPrestamo_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormHistorialPrestamo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            // Crear la instancia del formulario del reporte
            FormReportePrestamos formReporte = new FormReportePrestamos();

            // Mostrarlo
            // ShowDialog() es mejor para reportes porque bloquea la ventana de atrás 
            // hasta que cierras el reporte (modo modal).
            formReporte.ShowDialog();
        }

        private void btnReporteMorosos_Click(object sender, EventArgs e)
        {
            // 1. Crear la instancia del formulario del reporte
            FormReporteMorosos reporte = new FormReporteMorosos();

            // 2. Mostrarlo
            // Usamos ShowDialog() para que se abra como una ventana "hija" (Modal)
            // y no deje tocar la ventana de atrás hasta que cierres el reporte.
            reporte.ShowDialog();
        }
    }
}
