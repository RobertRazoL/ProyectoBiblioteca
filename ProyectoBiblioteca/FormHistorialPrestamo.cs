using ProyectoBiblioteca.Business.Services;
using ProyectoBiblioteca.Entities;
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
    public partial class FormHistorialPrestamo : Form
    {
        //Declaro el servicio
        private PrestamoService prestamoService;
        
        //Constructor
        public FormHistorialPrestamo()
        {
            InitializeComponent();
            //Instancio el servicio
            prestamoService = new PrestamoService();
        }
        
        //Evento Load del formulario
        private void FormHistorialPrestamo_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        //Método para cargar la grilla
        private void CargarGrilla()
        {
            try
            {
                //1. Obtener la lista de préstamos desde el servicio
                List<DetallePrestamo> lista = prestamoService.VerHistorial();

                //2. Vincular la lista al DataGridView
                dgvHistorialPrestamo.DataSource = null;
                dgvHistorialPrestamo.AutoGenerateColumns = true;
                dgvHistorialPrestamo.DataSource = lista;

                //3. Configurar las columnas del DataGridView
                if (dgvHistorialPrestamo.Columns.Count > 0)
                {
                    dgvHistorialPrestamo.Columns["IDPrestamo"].HeaderText = "ID";
                    dgvHistorialPrestamo.Columns["IDPrestamo"].Width = 40;

                    dgvHistorialPrestamo.Columns["Libro"].Width = 200;
                    dgvHistorialPrestamo.Columns["Socio"].Width = 150;

                    dgvHistorialPrestamo.Columns["FechaPrestamo"].HeaderText = "F. Préstamo";
                    dgvHistorialPrestamo.Columns["FechaDevolucion"].HeaderText = "F. Devolución";
                    dgvHistorialPrestamo.Columns["RegistradoPor"].HeaderText = "Admin";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }
    }
}
