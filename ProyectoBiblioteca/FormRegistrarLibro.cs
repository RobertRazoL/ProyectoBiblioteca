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
using ProyectoBiblioteca.Business.Services;

namespace ProyectoBiblioteca
{
    public partial class FormRegistrarLibro : Form
    {
        //Declaro la herramienta para conectar con la capa de negocio
        private LibroService libroService;
        public FormRegistrarLibro()
        {
            InitializeComponent();
            //Preparo la herramienta para conectar con la capa de negocio
            libroService = new LibroService();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Libros nuevoLibro = new Libros();
                nuevoLibro.ISBN = txtISBN.Text;
                nuevoLibro.Titulo = txtTitulo.Text;
                nuevoLibro.Autor = txtAutor.Text;
                nuevoLibro.Año = int.Parse(txtAño.Text);
                nuevoLibro.Stock = int.Parse(txtStock.Text);
                nuevoLibro.IDAdminRegistra = Sesion.IDAdmin;
                libroService.RegistrarLibro(nuevoLibro);
                MessageBox.Show("Libro registrado correctamente");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtISBN.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtAño.Text = ""; 
            txtStock.Text = "";
        }

       
    }
}
