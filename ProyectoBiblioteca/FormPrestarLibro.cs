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
    public partial class FormPrestarLibro : Form
    {
        public FormPrestarLibro()
        {
            InitializeComponent();
        }

        private void FormPrestarLibro_Load(object sender, EventArgs e)
        {
            dgvLibros.ColumnCount = 4;
            dgvLibros.Columns[0].Name = "ID Libro";
            dgvLibros.Columns[1].Name = "ISBN";
            dgvLibros.Columns[2].Name = "Titulo";
            dgvLibros.Columns[3].Name = "Stock";

            dgvSocios.ColumnCount = 3;
            dgvSocios.Columns[0].Name = "ID Socio";
            dgvSocios.Columns[1].Name = "Nombres";
            dgvSocios.Columns[2].Name = "Apellidos";
           
        }
    }
}
