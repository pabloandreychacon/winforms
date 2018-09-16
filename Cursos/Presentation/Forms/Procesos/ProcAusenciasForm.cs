using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosBusiness.BusinessHelpers;
using CursosEntities.Dtos;
using CursosEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Procesos
{
    public partial class ProcAusenciasForm : Basic
    {
        CommonB commB = new CommonB();
        List<CursosDtos.AusenciasEstudiantesList> ce;
        public ProcAusenciasForm()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            txtIdCurso.Text = "";
            txtCurso.Text = "";
            txtIdProfesor.Text = "";
            txtProfesor.Text = "";
            gvEstudiantes.DataSource = null;
        }
        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            ClearData();
            if (LocalData.searchCursosHorariosList != null &&
                LocalData.searchCursosHorariosList.Count > 0)
            {
                var searchTable = LocalData.searchCursosHorariosList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Descrip", "Key");
                searchForm.ShowDialog();
                if (searchForm.SelectedKey != null)
                {
                    var curKey = Convert.ToInt32(searchForm.SelectedKey);
                    var curso = commB.FindCursoHorarioByIdCursosHorarios(curKey);
                    if (curso != null)
                    {
                        txtIdCurso.Text = curso.IdCurso.ToString();
                        txtIdCursoHorario.Text = curso.IdCursosHorarios.ToString();
                        txtCurso.Text = curso.Curso.Descripcion;
                        var profe = commB.FindCursoProfesorByIdCursoHorario(curso.IdCursosHorarios);
                        if (profe != null)
                        {
                            txtIdProfesor.Text = profe.Profesore.IdProfesor.ToString();
                            var profname = commB.FindProfesorById(profe.IdProfesor);
                            if (profname != null)
                            {
                                txtProfesor.Text = profname.Nombre;
                            }
                        }
                    }
                }
            }
            CargarEstudiantes();
        }
        private void CargarBusqueda()
        {
            try
            {
                var cursList = commB.GetList<Curso>().Where(c => c.Activo).ToList();
                if (cursList.Count() > 0)
                {
                    LocalData.searchCursosHorariosList =
                        commB.GetCursosHorarioSearchDtos();
                }
                else
                {
                    btnBuscarCurso.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        public void CargarEstudiantes()
        {
            gvEstudiantes.DataSource = null;
            if (!string.IsNullOrEmpty(txtIdCurso.Text.Trim()) && !string.IsNullOrEmpty(txtIdCursoHorario.Text.Trim()))
            {
                ce = commB.GetAusenciasEstudiantesDtos(Convert.ToInt32(txtIdCurso.Text.Trim()), Convert.ToInt32(txtIdCursoHorario.Text.Trim()));
                if (ce.Count() > 0 && ce != null)
                {
                    gvEstudiantes.DataSource = ce;
                    for (int i = 0; i < gvEstudiantes.Columns.Count; i++)
                    {
                        //gridResults.Columns[i].Width = ColumnSizesArray[i];
                        gvEstudiantes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                    gvEstudiantes.Columns["Id"].ReadOnly = true;
                    gvEstudiantes.Columns["Estudiante"].ReadOnly = true;
                    //gvEstudiantes.Columns["Fecha"].Visible = false;

                }
                else
                {
                    MessageBox.Show("No hay estudiantes asignados a este curso, por favor asignar estudiantes.", "Ausencias",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            var hayAusencias = (from a in ce
                               where a.Ausente
                               select a).Count();
            if (hayAusencias > 0)
            {
                foreach (CursosDtos.AusenciasEstudiantesList item in ce)
                {
                    var ausencias = commB.GetAusencias(item.Id, dtFecha.Value);
                    if (ausencias.Count() > 0) 
                    { 
                        // solo lo ignora
                    }
                    else
                    {
                        if (item.Ausente)
                        {
                            try
                            {
                                commB.SaveAusencia(item.Id, true, dtFecha.Value.Date);
                            }
                            catch (Exception ex)
                            {
                                General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        }
                    }
                }
                CargarEstudiantes();
                MessageBox.Show("Proceso terminado", "Ausencias",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Debe marcar al menos una ausencia", "Ausencias",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}