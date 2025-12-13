using ProyectoBiblioteca.Business.Services;
using ProyectoBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoBiblioteca
{
    public partial class FormPrestarLibro : Form
    {
        // Declaramos los servicios que usaremos
        private readonly PrestamoService prestamoService;
        private readonly LibroService libroService;
        private readonly SocioService socioService; // Asumo que tienes este servicio para listar socios
        public FormPrestarLibro()
        {
            InitializeComponent();

            prestamoService = new PrestamoService();
            libroService = new LibroService();
            socioService = new SocioService(); // Si no tienes SocioService, avísame para crearlo
        }

        private void FormPrestarLibro_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            // 1. LLENAR COMBO DE LIBROS
            // Nota: Usamos el método Listar() que seguramente ya tienes en LibroService
            List<Libros> listaLibros = libroService.ListarLibros();

            cboLibro.DataSource = listaLibros;
            cboLibro.DisplayMember = "Titulo";  // Lo que se ve
            cboLibro.ValueMember = "IDLibro";   // El valor oculto (ID)
            cboLibro.SelectedIndex = -1;        // Empezar vacío

            // 2. LLENAR COMBO DE SOCIOS
            // Nota: Si no tienes SocioService.Listar(), avísame.
            List<Socios> listaSocios = socioService.ListarSocios();

            cboSocio.DataSource = listaSocios;
            // Aquí puedes concatenar en el servicio o usar solo NombreUsuario
            cboSocio.DisplayMember = "NombreUsuario";
            cboSocio.ValueMember = "IDSocio";
            cboSocio.SelectedIndex = -1;
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            // Validar visualmente que haya seleccionado algo
            if (cboLibro.SelectedIndex == -1 || cboSocio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Libro y un Socio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear el objeto con los datos seleccionados
            Prestamos nuevoPrestamo = new Prestamos()
            {
                IDLibro = Convert.ToInt32(cboLibro.SelectedValue),
                IDSocio = Convert.ToInt32(cboSocio.SelectedValue),
                // El ID del admin lo tomamos de la sesión global (quien se logueó)
                IDAdminRegistra = Sesion.IDAdmin
            };

            string mensaje = string.Empty;

            // Llamar al servicio
            bool resultado = prestamoService.RegistrarPrestamo(nuevoPrestamo, out mensaje);

            if (resultado)
            {
                MessageBox.Show("Préstamo registrado con éxito.\nEl stock del libro ha disminuido.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerramos la ventana
            }
            else
            {
                MessageBox.Show("No se pudo registrar: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
