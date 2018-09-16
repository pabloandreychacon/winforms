using CursosBusiness.Business;
using CursosEntities.Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using CursosBusiness.BusinessHelpers;
using BaseForms.Forms;

namespace Cursos.Presentation.Forms.Consultas
{
    public partial class ConsEstudiantesForm : Basic
    {
        CommonB commB = new CommonB();
        public ConsEstudiantesForm()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource1 = new ReportDataSource();
            //this.bindingSource1.DataSource = typeof(CursosEntities.Entities.Curso);
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bindingSource1;
            var viewer = new Reports.ReportViewer();
            viewer.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            viewer.reportViewer1.LocalReport.ReportEmbeddedResource =
                "Cursos.Presentation.Reports.Estudiantes.Estudiantes.rdlc";
            try
            {
                var query = commB.ReporteEstudiantes();
                //commB.Refresh<Estudiante>(query);
                if (!string.IsNullOrWhiteSpace(txtContiene.Text))
                {
                    switch (cboFiltros.SelectedValue.ToString())
                    {   
                        case "Nombre":
                            query = query.Where(q => q.Nombre.ToUpper().Contains(txtContiene.Text.Trim().ToUpper()));
                            break;
                        case "Direccion":
                            query = query.Where(q => q.Direccion.ToUpper().Contains(txtContiene.Text.Trim().ToUpper()));
                            break;
                        case "Identificacion":
                            query = query.Where(q => q.Identificacion.ToUpper().Contains(txtContiene.Text.Trim().ToUpper()));
                            break;
                        default:
                            break;
                    }
                }
                if (numEdadInicial.Value>0 && numEdadFinal.Value < 100)
                {
                    query = query.Where(q => q.Edad >= numEdadInicial.Value && q.Edad <= numEdadFinal.Value);
                }
                if (!chkActivos.Checked)
                {
                    query = query.Where(q => q.Activo == false);
                }
                if (!chkInactivos.Checked)
                {
                    query = query.Where(q => q.Activo);
                }
                List<Estudiante> ls = query.ToList();
                //foreach (var item in ls)
                //{
                //    Debug.WriteLine(item.NombreCurso);
                //} 
                List<ReportParameter> paramList = new List<ReportParameter>();
                string parameterNombre = commB.GetList<Parametro>().FirstOrDefault().Nombre;
                paramList.Add(new ReportParameter("pParametrosNombre", @parameterNombre));
                viewer.reportViewer1.LocalReport.SetParameters(paramList);
                bindingSource1.DataSource = ls;
                viewer.ShowDialog();
                viewer.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void EstudiantesForm_Load(object sender, EventArgs e)
        {
            var estList = new List<FiltrosEstudiantes>();
            var filNombre = new FiltrosEstudiantes() {MascaraCampo = "Nombre", NombreCampo = "Nombre"};
            var filIdentificacion = new FiltrosEstudiantes() {MascaraCampo = "Identificación", NombreCampo = "Identificacion"};
            var filDireccion = new FiltrosEstudiantes() {MascaraCampo = "Dirección", NombreCampo = "Direccion"};
            estList.Add(filNombre);
            estList.Add(filIdentificacion);
            estList.Add(filDireccion);
            cboFiltros.DataSource = estList;
            cboFiltros.DisplayMember = "MascaraCampo";
            cboFiltros.ValueMember = "NombreCampo";
        }

        public class FiltrosEstudiantes
        {
            public string NombreCampo { get; set; }
            public string MascaraCampo { get; set; }
        }
    }
}
