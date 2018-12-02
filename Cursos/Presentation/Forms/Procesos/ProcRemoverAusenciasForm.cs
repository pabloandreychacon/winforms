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
    public partial class ProcRemoverAusenciasForm : Basic
    {
        CommonB commB = new CommonB();
        List<CursosDtos.AusenciasCursoList> ac;
        public ProcRemoverAusenciasForm()
        {
            InitializeComponent();
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
            CargarAusentes();
        }
        private void ClearData()
        {
            txtIdCurso.Text = "";
            txtCurso.Text = "";
            txtIdProfesor.Text = "";
            txtProfesor.Text = "";
            gvAusentes.DataSource = null;
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
                General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void CargarAusentes()
        {
            gvAusentes.DataSource = null;
            if (!string.IsNullOrEmpty(txtIdCurso.Text.Trim()))
            {
                ac = commB.GetAusenciasCursoDtos(Convert.ToInt32(txtIdCurso.Text.Trim()), 
                    Convert.ToInt32(txtIdCursoHorario.Text.Trim()),
                    dtFecha.Value.Date);
                if (ac.Count() > 0 && ac != null)
                {
                    gvAusentes.DataSource = ac;
                    for (int i = 0; i < gvAusentes.Columns.Count; i++)
                    {
                        //gridResults.Columns[i].Width = ColumnSizesArray[i];
                        gvAusentes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                    gvAusentes.Columns["IdAusencia"].ReadOnly = true;
                    gvAusentes.Columns["Estudiante"].ReadOnly = true;
                    gvAusentes.Columns["Fecha"].ReadOnly = true;
                }
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            var quitarAusencias = (from a in ac
                                where !a.Ausente
                                select a).Count();
            if (quitarAusencias > 0)
            {
                foreach (CursosDtos.AusenciasCursoList item in ac)
                {
                    if (!item.Ausente)
                    {
                        try
                        {
                            var au = commB.FindAusenciaCursoByIdAusencia(item.IdAusencia);
                            commB.DeleteEntity<Ausencia>(au);
                        }
                        catch (Exception ex)
                        {
                            General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
                //ClearData();
                CargarAusentes();
                MessageBox.Show("Proceso terminado", "Ausencias",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Debe desmarcar al menos una ausencia", "Ausencias",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarAusentes();
        }
    }
}
