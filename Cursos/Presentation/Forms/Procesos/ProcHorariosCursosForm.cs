using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosBusiness.BusinessHelpers;
using CursosEntities.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Procesos
{
    public partial class ProcHorariosCursosForm : Basic
    {
        CommonB commB = new CommonB();
        public ProcHorariosCursosForm()
        {
            InitializeComponent();
        }

        private void btnBuscaCurso_Click(object sender, EventArgs e)
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
            CargarHorarios();
        }

        public void CargarHorarios()
        {
            gvHorariosAsignados.DataSource = null;
            if (!string.IsNullOrEmpty(txtIdCurso.Text.Trim()))
            {
                var h = commB.GetHorariosList(Convert.ToInt32(txtIdCurso.Text.Trim()));
                if (h.Count() > 0 && h != null)
                {
                    gvHorariosAsignados.DataSource = h;
                    for (int i = 0; i < gvHorariosAsignados.Columns.Count; i++)
                    {
                        //gridResults.Columns[i].Width = ColumnSizesArray[i];
                        gvHorariosAsignados.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }
        }

        private void CargarBusqueda()
        {
            try
            {
                var horaList = commB.GetList<Horario>().ToList();
                var cursList = commB.GetList<Curso>().Where(c => c.Activo).ToList();
                if (horaList.Count() > 0)
                {
                    LocalData.searchHorariosList =
                        commB.GetHorariosSearchDtos(horaList);
                }
                else
                {
                    btnBuscaHorario.Enabled = false;
                }
                if (cursList.Count() > 0)
                {
                    LocalData.searchCursosList =
                        commB.GetCursosSearchDtos(cursList);
                }
                else
                {
                    btnBuscaCurso.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnBuscaHorario_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (LocalData.searchHorariosList != null &&
                LocalData.searchHorariosList.Count > 0)
            {
                var searchTable = LocalData.searchHorariosList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Descrip", "Key");
                searchForm.ShowDialog();
                if (searchForm.SelectedKey != null)
                {
                    var curKey = Convert.ToInt32(searchForm.SelectedKey);
                    var hora = commB.FindHorarioById(curKey);
                    if (hora != null)
                    {
                        txtIdHorario.Text = hora.IdHorario.ToString();
                        txtHorario.Text = hora.Descripcion;
                    }
                }
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (Validator(txtIdCurso, ValidationTypes.Text, "Debe seleccionar un curso") &&
                Validator(txtIdHorario, ValidationTypes.Text, "Debe seleccionar un horario"))
            {
                var cursoAsignadoList = commB.FindCursohorarioByIdCursoAndIdhorario(
                    Convert.ToInt32(txtIdCurso.Text), Convert.ToInt32(txtIdHorario.Text));
                if (cursoAsignadoList != null)
                {
                    MessageBox.Show("Es horario ya está asignado", "Asignar", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    try
                    {
                        commB.SaveCursoHorario(Convert.ToInt32(txtIdCurso.Text), Convert.ToInt32(txtIdHorario.Text));
                    }
                    catch (Exception ex)
                    {
                        General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }                    
                }
                CargarHorarios();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvHorariosAsignados.CurrentRow != null)
                {
                    var curCode = gvHorariosAsignados.CurrentRow.Cells["Id"].Value;
                    var ch = commB.FindCursohorarioByIdCursoAndIdhorario(Convert.ToInt32(txtIdCurso.Text),
                        Convert.ToInt32(curCode));
                    if (ch != null) commB.DeleteEntity<CursosHorario>(ch);
                    CargarHorarios();
                    this.btnBuscaCurso.Focus(); // hace que se valide el position text                    
                }
            }
            catch (Exception ex)
            {
                General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
