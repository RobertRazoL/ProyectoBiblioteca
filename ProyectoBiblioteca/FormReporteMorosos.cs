using Microsoft.Reporting.WinForms;
using ProyectoBiblioteca.Data.Repositories;
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
    public partial class FormReporteMorosos : Form
    {
        public FormReporteMorosos()
        {
            InitializeComponent();
        }

        private void FormReporteMorosos_Load(object sender, EventArgs e)
        {

            try
            {
                // 1. Obtener datos
                PrestamoDAO dao = new PrestamoDAO();
                List<ReporteMoroso> datos = dao.ObtenerReporteMorosos();

                // 2. Vincular al reporte
                // "DSMorosos" debe ser IGUAL al nombre que pusiste en el Paso 4-C
                ReportDataSource fuente = new ReportDataSource("DSMorosos", datos);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(fuente);

                // Indica la ruta del reporte si no lo encuentra automático
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoBiblioteca.RptMorosos.rdlc";

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
