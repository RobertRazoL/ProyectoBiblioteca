using ProyectoBiblioteca.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBiblioteca.Entities;

namespace ProyectoBiblioteca
{
    public partial class FormLibros : Form
    {
        //Declaro la herramienta para conectar con la capa de negocio
        private LibroService libroService;
        public FormLibros()
        {
            InitializeComponent();
            //Preparo la herramienta para conectar con la capa de negocio
            libroService = new LibroService();
        }


        private void FormLibros_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                //Otener la lista de libros desde el servicio
                List<Libros> lista = libroService.ListarLibros();
                dgvLibros.AutoGenerateColumns = true;
                dgvLibros.DataSource = lista;

                //Cambiar los encabezados de las columnas para mayor claridad
                if (dgvLibros.Columns.Count > 0){
                    dgvLibros.Columns["IDLibro"].HeaderText = "ID Libro";
                    dgvLibros.Columns["ISBN"].HeaderText = "ISBN";
                    dgvLibros.Columns["Titulo"].HeaderText = "Título";
                    dgvLibros.Columns["Autor"].HeaderText = "Autor";
                    dgvLibros.Columns["Año"].HeaderText = "Año";
                    dgvLibros.Columns["Stock"].HeaderText = "Stock";
                    dgvLibros.Columns["IDAdminRegistra"].HeaderText = "Admin ID";

                    if (dgvLibros.Columns.Contains("Administradores"))
                    {
                        dgvLibros.Columns["Administradores"].Visible = false;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los libros: " + ex.Message);
            }
        }
    }
}
