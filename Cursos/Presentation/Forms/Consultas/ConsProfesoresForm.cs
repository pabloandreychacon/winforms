using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CursosBusiness.Business;
using CursosEntities.Entities;
using Microsoft.Reporting.WinForms;
using CursosBusiness.BusinessHelpers;
using BaseForms.Forms;

namespace Cursos.Presentation.Forms.Consultas
{
    public partial class ConsProfesoresForm : Basic
    {
        CommonB commB = new CommonB();
        public ConsProfesoresForm()
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
                "Cursos.Presentation.Reports.Profesores.Profesores.rdlc";
            try
            {
                //var query = from u in commB.GetList<Curso>()
                //                select u;
                var query = commB.ReporteProfesores();
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
                        case "Institucion":
                            query = query.Where(q => q.Institucion.ToUpper().Contains(txtContiene.Text.Trim().ToUpper()));
                            break;
                        default:
                            break;
                    }
                }
                if (!chkActivos.Checked)
                {
                    query = query.Where(q => q.Activo == false);
                }
                if (!chkInactivos.Checked)
                {
                    query = query.Where(q => q.Activo);
                }
                List<Profesore> ls = query.ToList();
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

        private void ProfesoresForm_Load(object sender, EventArgs e)
        {
            var profList = new List<FiltrosProfesores>();
            var filNombre = new FiltrosProfesores() { MascaraCampo = "Nombre", NombreCampo = "Nombre" };
            var filIdentificacion = new FiltrosProfesores() { MascaraCampo = "Identificación", NombreCampo = "Identificacion" };
            var filDireccion = new FiltrosProfesores() { MascaraCampo = "Dirección", NombreCampo = "Direccion" };
            var filInstitucion = new FiltrosProfesores() { MascaraCampo = "Institución", NombreCampo = "Institucion" };
            profList.Add(filNombre);
            profList.Add(filIdentificacion);
            profList.Add(filDireccion);
            profList.Add(filInstitucion);
            cboFiltros.DataSource = profList;
            cboFiltros.DisplayMember = "MascaraCampo";
            cboFiltros.ValueMember = "NombreCampo";
        }

        public class FiltrosProfesores
        {
            public string NombreCampo { get; set; }
            public string MascaraCampo { get; set; }
        }
    }
}
