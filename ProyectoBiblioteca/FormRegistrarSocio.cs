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
    public partial class FormRegistrarSocio : Form
    {
        //Declaro la herramienta para conectar con la capa de negocio
        private SocioService socioService;

        public FormRegistrarSocio()
        {
            InitializeComponent();
            //Preparo la herramienta para conectar con la capa de negocio
            socioService = new SocioService();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Socios nuevoSocio = new Socios();
                nuevoSocio.NombreUsuario = txtNombreUsuario.Text;
                nuevoSocio.Contraseña = txtContraseña.Text;
                nuevoSocio.Nombres = txtNombres.Text;
                nuevoSocio.ApellidoPaterno = txtApellidoPaterno.Text;
                nuevoSocio.ApellidoMaterno = txtApellidoMaterno.Text;
                nuevoSocio.Direccion = txtDireccion.Text;
                nuevoSocio.Telefono = txtTelefono.Text;
                nuevoSocio.Correo = txtCorreo.Text;
                nuevoSocio.IDAdminRegistra = Sesion.IDAdmin;
                //Guardamos el socio usando la capa de negocio
                socioService.RegistrarSocio(nuevoSocio);
                MessageBox.Show("Socio registrado correctamente");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtNombres.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

       
    }
}
