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
using CursosBusiness.Business;

namespace Cursos.Presentation.Forms.Consultas
{
    public partial class ConsAusenciasForm : Basic
    {
        CommonB commB = new CommonB();
        public ConsAusenciasForm()
        {
            InitializeComponent();
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
                        ValidateCurso();
                    }
                }
            }
        }

        private void CargarBusqueda()
        {
            try
            {
                var cursList = commB.GetList<Curso>().Where(c => c.Activo).ToList();
                var estuList = commB.GetList<Estudiante>().Where(c => c.Activo).ToList();
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
            if (!ValidateCurso())
            {
                e.Cancel = true;
            }
        }

        private bool ValidateCurso()
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
                //e.Cancel = true;
                txtCurso.Text = "";
                errorContainer1.errorProvider1.SetError(txtIdCurso, "Curso incorrecto");
                txtIdCurso.Select(0, txtIdCurso.Text.Length);
                txtIdCurso.Focus();
                CleanCombos();

            }
            else
            {
                errorContainer1.errorProvider1.Clear();
                LoadCombos();
            }
            return continuar;
        }

        private void LoadCombos()
        {
            var horarList = commB.GetHorarioByIdCurso(Convert.ToInt32(txtIdCurso.Text.Trim()));
			if(horarList.Count> 0)
			{
				cboHorario.DataSource = horarList;
				cboHorario.DisplayMember = "Descripcion";
				cboHorario.ValueMember = "IdHorario";
				cboHorario.Enabled = true;

				var profeList = commB.GetProfesorByIdCurso(Convert.ToInt32(txtIdCurso.Text.Trim()),
					Convert.ToInt32(cboHorario.SelectedValue));
				cboProfesor.DataSource = profeList;
				cboProfesor.DisplayMember = "Nombre";
				cboProfesor.ValueMember = "IdProfesor";
				cboProfesor.Enabled = true;

				cboHorario.SelectedIndex = 0;
			}
            
        }

        private void CleanCombos()
        {
            cboHorario.DataSource = null;
            cboHorario.Enabled = false;

            cboProfesor.DataSource = null;
            cboProfesor.Enabled = false;
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
                txtIdEstudiante.Focus();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCurso.Text))
            {
                txtCurso.Text = "";
                errorContainer1.errorProvider1.SetError(txtIdCurso, "Debe seleccionar un curso.");
                txtIdCurso.Select(0, txtIdCurso.Text.Length);
                txtIdCurso.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cboHorario.Text))
            {
                cboHorario.Text = "";
                errorContainer1.errorProvider1.SetError(cboHorario, "Debe seleccionar un horario.");
                cboHorario.Select(0, cboHorario.Text.Length);
                cboHorario.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cboProfesor.Text))
            {
                cboProfesor.Text = "";
                errorContainer1.errorProvider1.SetError(cboProfesor, "Debe seleccionar un profesor.");
                cboProfesor.Select(0, cboProfesor.Text.Length);
                cboProfesor.Focus();
                return;
            }
            ReportDataSource reportDataSource1 = new ReportDataSource();
            //this.bindingSource1.DataSource = typeof(CursosEntities.Entities.Curso);
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bindingSource1;
            var viewer = new Reports.ReportViewer();
            viewer.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            viewer.reportViewer1.LocalReport.ReportEmbeddedResource =
                "Cursos.Presentation.Reports.Ausencias.Ausencias.rdlc";
            try
            {
                //var query = from u in commB.GetList<Curso>()
                //                select u;
                var query = commB.ReporteAusenciasDtos();
                if (!string.IsNullOrEmpty(txtIdCurso.Text))
                {
                    query = query.Where(q => q.IdCurso == Convert.ToInt32(txtIdCurso.Text));
                }
                if (!string.IsNullOrEmpty(txtIdEstudiante.Text))
                {
                    query = query.Where(q => q.IdEstudiante == Convert.ToInt32(txtIdEstudiante.Text));
                }
                query = query.Where(q => q.IdHorario == Convert.ToInt32(cboHorario.SelectedValue));
                query = query.Where(q => q.IdProfesor == Convert.ToInt32(cboProfesor.SelectedValue));
                List<CursosDtos.ReporteAusenciasList> ls = query.ToList();
                foreach (var item in ls)
                {
                    Debug.WriteLine(item.NombreEstudiante);
                }
                List<ReportParameter> paramList = new List<ReportParameter>();
                string parameterNombre = commB.GetList<Parametro>().FirstOrDefault().Nombre;

                string cursosDescripcion = commB.GetList<Curso>().
                    Where(c => c.IdCurso == Convert.ToInt32(txtIdCurso.Text.Trim())).FirstOrDefault().Descripcion;
                
                // nombre profesor
                //string profesoresNombre = "Sin profesor";
                //if (cboProfesor.SelectedValue!=null)
                string profesoresNombre= commB.GetList<Profesore>().
                    Where(h => h.IdProfesor == Convert.ToInt32(cboProfesor.SelectedValue)).FirstOrDefault().Nombre;
                //List<CursosProfesor> lsP = new List<CursosProfesor>();
                //lsP = commB.GetList<CursosProfesor>().Where(c => c.IdCurso == Convert.ToInt32(txtIdCurso.Text.Trim())).ToList();
                //if (lsP.Count > 0)
                //{
                //    profesoresNombre = commB.GetList<Profesore>().FirstOrDefault().
                //        lsP.Where
                //    profesoresNombre = commB.GetList<Curso>().FirstOrDefault().CursosProfesors.
                //        Where(c => c.IdCurso == Convert.ToInt32(txtIdCurso.Text.Trim())).
                //        FirstOrDefault().Profesore.Nombre;
                //}

                string horariosDescripcion = commB.GetList<Horario>().
                    Where(h => h.IdHorario == Convert.ToInt32(cboHorario.SelectedValue)).FirstOrDefault().Descripcion;

                paramList.Add(new ReportParameter("pParametrosNombre", @parameterNombre));
                paramList.Add(new ReportParameter("pCursosDescripcion", @cursosDescripcion));
                paramList.Add(new ReportParameter("pProfesoresNombre", @profesoresNombre));
                paramList.Add(new ReportParameter("pHorariosDescripcion", @horariosDescripcion));
                viewer.reportViewer1.LocalReport.SetParameters(paramList);

                bindingSource1.DataSource = ls;
                viewer.ShowDialog();
                viewer.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                General.LogInfo(ex, "Cursos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void AusenciasReportForm_Load(object sender, EventArgs e)
        {

        }

        private void cboHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHorario.SelectedValue == null) return;
            cboProfesor.DataSource = null;
            cboProfesor.Enabled = false;
            var horario = commB.SetEntity<Horario>(cboHorario.SelectedItem);
            var profeList = commB.GetProfesorByIdCurso(Convert.ToInt32(txtIdCurso.Text.Trim()),
                Convert.ToInt32(horario.IdHorario));
            cboProfesor.DataSource = profeList;
            cboProfesor.DisplayMember = "Nombre";
            cboProfesor.ValueMember = "IdProfesor";
            cboProfesor.Enabled = true;
        }

        private void txtIdCurso_Leave(object sender, EventArgs e)
        {
            if (!ValidateCurso())
            {
                //e. = true;
            }
        }
    }
}
