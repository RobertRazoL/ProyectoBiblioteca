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

namespace ProyectoBiblioteca
{
    public partial class FormSocios : Form
    {
        //Declaro la herramienta para conectar con la capa de negocio
        private SocioService socioService;


        public FormSocios()
        {
            InitializeComponent();
            //Preparo la herramienta para conectar con la capa de negocio
            socioService = new SocioService();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                //Otener la lista de socios desde el servicio
                List<Entities.Socios> lista = socioService.ListarSocios();
                dgvSocios.AutoGenerateColumns = true;
                dgvSocios.DataSource = lista;
                //Cambiar los encabezados de las columnas para mayor claridad
                if (dgvSocios.Columns.Count > 0)
                {
                    dgvSocios.Columns["IDSocio"].HeaderText = "ID Socio";
                    dgvSocios.Columns["Nombres"].HeaderText = "Nombres";
                    dgvSocios.Columns["Apellidos"].HeaderText = "Apellidos";
                    dgvSocios.Columns["Direccion"].HeaderText = "Dirección";
                    dgvSocios.Columns["Telefono"].HeaderText = "Teléfono";
                    dgvSocios.Columns["Correo"].HeaderText = "Correo";
                    dgvSocios.Columns["IDAdminRegistra"].HeaderText = "Admin ID";

                    if (dgvSocios.Columns.Contains("Prestamos"))
                    {
                        dgvSocios.Columns["Prestamos"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los socios: " + ex.Message);
            }
        }
    }
}
