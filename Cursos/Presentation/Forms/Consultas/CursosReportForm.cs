using CursosBusiness.Business;
using CursosEntities.Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using CursosBusiness.BusinessHelpers;
using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosEntities.Dtos;
using System.Diagnostics;

namespace Cursos.Presentation.Forms.Consultas
{
    public partial class CursosReportForm : Basic
    {
        CommonB commB = new CommonB();
        //int Curso;
        //int Profesor;
        //int Estudiante;
        public CursosReportForm()
        {
            InitializeComponent();
        }

        private void CursosReportForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource1 = new ReportDataSource();
            //this.bindingSource1.DataSource = typeof(CursosEntities.Entities.Curso);
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bindingSource1;
            var viewer = new Reports.ReportViewer();
            viewer.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            viewer.reportViewer1.LocalReport.ReportEmbeddedResource = "Cursos.Presentation.Reports.Cursos.Cursos.rdlc";
            try
            {
                //var query = from u in commB.GetList<Curso>()
                //                select u;
                var query = commB.ReporteCursosDtos();
                if (!string.IsNullOrEmpty(txtIdCurso.Text))
                {
                    query = query.Where(q => q.IdCurso == Convert.ToInt32(txtIdCurso.Text));
                }
                if (!string.IsNullOrEmpty(txtIdProfesor.Text))
                {
                    query = query.Where(q => q.IdProfesor == Convert.ToInt32(txtIdProfesor.Text));
                }
                if (!string.IsNullOrEmpty(txtIdEstudiante.Text))
                {
                    query = query.Where(q => q.IdEstudiante == Convert.ToInt32(txtIdEstudiante.Text));
                }
                List<CursosDtos.ReporteCursosList> ls = query.ToList();
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
                General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (LocalData.searchCursosList != null &&
                LocalData.searchCursosList.Count > 0)
            {
                var searchTable = LocalData.searchCursosList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Descrip", "Key");
                searchForm.ShowDialog();
                if (searchForm.SelectedKey != null)
                {
                    var curKey = Convert.ToInt32(searchForm.SelectedKey);
                    var curso = commB.FindCursoById(curKey);
                    if (curso != null)
                    {
                        txtIdCurso.Text = curso.IdCurso.ToString();
                        txtCurso.Text = curso.Descripcion;
                    }
                }
            }
        }

        private void CargarBusqueda()
        {
            try
            {
                var profList = commB.GetList<Profesore>().Where(p => p.Activo).ToList();
                var cursList = commB.GetList<Curso>().Where(c => c.Activo).ToList();
                var estuList = commB.GetList<Estudiante>().Where(c => c.Activo).ToList();
                if (profList.Count() > 0)
                {
                    LocalData.searchProfesoresList =
                        commB.GetProfesoresSearchDtos(profList);
                }
                else
                {
                    btnBuscarProfesor.Enabled = false;
                }
                if (cursList.Count() > 0)
                {
                    LocalData.searchCursosList =
                        commB.GetCursosSearchDtos(cursList);
                }
                else
                {
                    btnBuscarCurso.Enabled = false;
                }
                if (estuList.Count() > 0)
                {
                    LocalData.searchEstudiantesList =
                        commB.GetEstudiantesSearchDtos(estuList);
                }
                else
                {
                    btnBuscarCurso.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnBuscarProfesor_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (LocalData.searchProfesoresList != null &&
                LocalData.searchProfesoresList.Count > 0)
            {
                var searchTable = LocalData.searchProfesoresList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Nombre,Identific,Correo", "Key");
                searchForm.ShowDialog();
                if (searchForm.SelectedKey != null)
                {
                    var curKey = Convert.ToInt32(searchForm.SelectedKey);
                    var profe = commB.FindProfesorById(curKey);
                    if (profe != null)
                    {
                        txtIdProfesor.Text = profe.IdProfesor.ToString();
                        txtProfesor.Text = profe.Nombre;
                    }
                }
            }
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (LocalData.searchEstudiantesList != null &&
                LocalData.searchEstudiantesList.Count > 0)
            {
                var searchTable = LocalData.searchEstudiantesList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Nombre,Identific", "Key");
                searchForm.ShowDialog();
                if (searchForm.SelectedKey != null)
                {
                    var curKey = Convert.ToInt32(searchForm.SelectedKey);
                    var estu = commB.FindEstudianteById(curKey);
                    if (estu != null)
                    {
                        txtIdEstudiante.Text = estu.IdEstudiante.ToString();
                        txtEstudiante.Text = estu.Nombre;
                    }
                }
            }
        }

        private void txtIdCurso_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool continuar = true;
            if (string.IsNullOrWhiteSpace(txtIdCurso.Text) || !Tools.NumericValidators.IsPositiveNumeric(txtIdCurso.Text.Trim())) continuar = false;
            if (continuar)
            {
                var curCurso = commB.FindCursoById(Convert.ToInt16(txtIdCurso.Text.Trim()));
                if (curCurso != null)
                {
                    txtCurso.Text = curCurso.Descripcion;
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }                
            }
            if (!continuar)
            {
                e.Cancel = true;
                txtCurso.Text = "";
                errorContainer1.errorProvider1.SetError(txtIdCurso, "Curso incorrecto");
                txtIdCurso.Select(0, txtIdCurso.Text.Length);
                txtIdCurso.Focus();
            }
            else
            {
                errorContainer1.errorProvider1.Clear();
                txtIdProfesor.Focus();
            }
        }

        private void txtIdProfesor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool continuar = true;
            if (string.IsNullOrWhiteSpace(txtIdProfesor.Text) || !Tools.NumericValidators.IsPositiveNumeric(txtIdProfesor.Text.Trim())) continuar = false;
            if (continuar)
            {
                var curCurso = commB.FindProfesorById(Convert.ToInt16(txtIdProfesor.Text.Trim()));
                if (curCurso != null)
                {
                    txtProfesor.Text = curCurso.Nombre;
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }
                if (!continuar)
                {
                    e.Cancel = true;
                    txtProfesor.Text = "";
                    errorContainer1.errorProvider1.SetError(txtIdProfesor, "Profesor incorrecto");
                    txtIdProfesor.Select(0, txtIdProfesor.Text.Length);
                    txtIdProfesor.Focus();
                }
                else
                {
                    errorContainer1.errorProvider1.Clear();
                    txtIdEstudiante.Focus();
                }
            }
        }

        private void txtIdEstudiante_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool continuar = true;
            if (string.IsNullOrWhiteSpace(txtIdEstudiante.Text) || !Tools.NumericValidators.IsPositiveNumeric(txtIdEstudiante.Text.Trim())) continuar = false;
            if (continuar)
            {
                var curCurso = commB.FindEstudianteById(Convert.ToInt16(txtIdEstudiante.Text.Trim()));
                if (curCurso != null)
                {
                    txtEstudiante.Text = curCurso.Nombre;
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }                
            }
            if (!continuar)
            {
                e.Cancel = true;
                txtEstudiante.Text = "";
                errorContainer1.errorProvider1.SetError(txtIdEstudiante, "Estudiante incorrecto");
                txtIdEstudiante.Select(0, txtIdEstudiante.Text.Length);
                txtIdEstudiante.Focus();
            }
            else
            {
                errorContainer1.errorProvider1.Clear();
                btnConsultar.Focus();
            }
        }
    }
}
