using Microsoft.Reporting.WinForms; // <--- OJO AQUÍ
using ProyectoBiblioteca.Data.Repositories;
using ProyectoBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ProyectoBiblioteca
{
    public partial class FormReportePrestamos : Form
    {
        public FormReportePrestamos()
        {
            InitializeComponent();
        }

        private void FormReportePrestamos_Load(object sender, EventArgs e)
        {
            try
            {
                //Obtener la lista de datos usando el NUEVO método
                PrestamoDAO dao = new PrestamoDAO();
                List<ReportePrestamo> misDatos = dao.ObtenerDatosReporte();

                //Crear la fuente de datos para el reporte
                
                ReportDataSource fuente = new ReportDataSource("DataSet1", misDatos);

                //Limpiar y asignar al visor
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(fuente);

                //Refrescar el reporte para que se dibuje
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reporte: " + ex.Message);
            }

        }
    }
}
