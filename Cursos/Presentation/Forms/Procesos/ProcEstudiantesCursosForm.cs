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
    public partial class ProcEstudiantesCursosForm : Basic
    {
        CommonB commB = new CommonB();
        public ProcEstudiantesCursosForm()
        {
            InitializeComponent();
        }
        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
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
                    }
                }
            }
            CargarEstudiantes();
        }        
        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (LocalData.searchEstudiantesList != null &&
                LocalData.searchEstudiantesList.Count > 0)
            {
                var searchTable = LocalData.searchEstudiantesList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Identific,Nombre", "Key");
                searchForm.ShowDialog();
                if (searchForm.SelectedKey != null)
                {
                    var curKey = Convert.ToInt32(searchForm.SelectedKey);
                    var estud = commB.FindEstudianteById(curKey);
                    if (estud != null)
                    {
                        txtIdEstudiante.Text = estud.IdEstudiante.ToString();
                        txtEstudiante.Text = estud.Nombre;
                    }
                }
            }
        }
        private void CargarBusqueda()
        {
            try
            {
                var estList = commB.GetList<Estudiante>().Where(p => p.Activo).ToList();
                var cursList = commB.GetList<Curso>().Where(c => c.Activo).ToList();
                if (estList.Count() > 0)
                {
                    LocalData.searchEstudiantesList =
                        commB.GetEstudiantesSearchDtos(estList);
                }
                else
                {
                    btnBuscarEstudiante.Enabled = false;
                }
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
        public void CargarEstudiantes()
        {
            gvEstudiantes.DataSource = null;
            if (!string.IsNullOrEmpty(txtIdCursoHorario.Text.Trim()))
            {
                var ce = commB.GetCursosEstudiantesList(Convert.ToInt32(txtIdCursoHorario.Text.Trim()));
                if (ce.Count() > 0 && ce != null)
                {
                    gvEstudiantes.DataSource = ce;
                    for (int i = 0; i < gvEstudiantes.Columns.Count; i++)
                    {
                        //gridResults.Columns[i].Width = ColumnSizesArray[i];
                        gvEstudiantes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
                var cur = commB.FindCursoById(Convert.ToInt32(txtIdCurso.Text));
                if (ce.Count() >= cur.CantidadEstudiantes) 
                {
                    MessageBox.Show("No se pueden asignar más de " +
                    cur.CantidadEstudiantes.ToString() + 
                    " a este curso.", "Asignar", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    btnAsignar.Enabled = false;
                }
                else
                {
                    btnAsignar.Enabled = true;
                }
            }
            //throw new NotImplementedException();
        }
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (Validator(txtIdCurso, ValidationTypes.Text, "Debe seleccionar un curso") &&
                Validator(txtIdCursoHorario, ValidationTypes.Text, "Debe seleccionar un curso") &&
                Validator(txtIdEstudiante, ValidationTypes.Text, "Debe seleccionar un estudiante"))
            {
                var cursoAsignadoList = commB.FindCursoEstudianteByIdCursoAndIdEstudiante(
                    Convert.ToInt32(txtIdCursoHorario.Text), Convert.ToInt32(txtIdEstudiante.Text));
                if (cursoAsignadoList != null)
                {
                    MessageBox.Show("Es estudiante ya está asignado", "Asignar", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    try
                    {
                        //var curHor = commB.GetCursosHorariosByIdCurso(Convert.ToInt32(txtIdCurso.Text));
                        commB.SaveCursoEstudiante(Convert.ToInt32(txtIdCurso.Text), Convert.ToInt32(txtIdEstudiante.Text),
                            Convert.ToInt32(txtIdCursoHorario.Text));
                    }
                    catch (Exception ex)
                    {
                        General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    
                }
                CargarEstudiantes();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvEstudiantes.CurrentRow != null)
                {
                    var curCode = gvEstudiantes.CurrentRow.Cells["IdEstudiante"].Value;
                    var ce = commB.FindCursoEstudianteByIdCursoAndIdEstudiante(Convert.ToInt32(txtIdCursoHorario.Text), 
                        Convert.ToInt32(curCode));
                    if (ce != null) commB.DeleteEntity<CursosEstudiante>(ce);
                    CargarEstudiantes();
                    this.btnBuscarEstudiante.Focus(); // hace que se valide el position text                    
                }
            }
            catch (Exception ex)
            {
                General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }     
    }
}
