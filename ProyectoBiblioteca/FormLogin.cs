using System;
using System.Windows.Forms;
using ProyectoBiblioteca.Business.Service;
using ProyectoBiblioteca.Entities;

namespace ProyectoBiblioteca
{
    public partial class FormLogin : Form
    {
        private readonly LoginService loginservice;

        public FormLogin()
        {
            InitializeComponent();
            loginservice = new LoginService();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                Administradores administradores = loginservice.Login(txtNombreUsuario.Text, txtClave.Text);

                if (administradores!=null)
                {
                    //Guardamos los datos de inicio de sesión en la clase Sesion
                    Sesion.IDAdmin = administradores.IDAdmin;
                    Sesion.NombreCompleto = administradores.NombreCompleto;
                    Sesion.Rol = administradores.Rol;
                    MessageBox.Show(
                    // Mensaje de bienvenida
                    $"Bienvenido {administradores.NombreCompleto}",
                    "Sistema de Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    FormInicio formInicio = new FormInicio();
                    formInicio.Show();
                    this.Hide();

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
