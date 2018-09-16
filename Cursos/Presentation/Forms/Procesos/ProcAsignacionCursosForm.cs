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
    public partial class ProcAsignacionCursosForm : Basic
    {
        CommonB commB = new CommonB();
        bool Ajustes;
        public ProcAsignacionCursosForm(bool ajustes)
        {
            InitializeComponent();
            Ajustes = ajustes;
        }

        private void AsignacionCursosForm_Load(object sender, EventArgs e)
        {
            //CargarBusqueda();
            if (Ajustes) {
                chkActivo.Enabled = !Ajustes;
                dtFechaInicio.Enabled = !Ajustes;
                dtFechaFinal.Enabled = !Ajustes;
                txtAusencias.Enabled = !Ajustes;
                btnEliminar.Enabled = Ajustes;
                btnEliminar.Visible = Ajustes;
                btnAsignar.Visible = !Ajustes;
                btnBuscaCurso.Enabled = !Ajustes;
            }
        }

        private void CargarBusqueda()
        {
            try
            {
                var profList = commB.GetList<Profesore>().Where(p => p.Activo).ToList();
                var cursList = commB.GetList<Curso>().Where(c => c.Activo).ToList();
                if (profList.Count() > 0)
                {
                    LocalData.searchProfesoresList =
                        commB.GetProfesoresSearchDtos(profList);
                }
                else
                {
                    btnBuscaProfesor.Enabled = false;
                }
                if (cursList.Count() > 0)
                {

                    LocalData.searchCursosHorariosList =
                        commB.GetCursosHorarioSearchDtos();
                    
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

        private void btnBuscaProfesor_Click(object sender, EventArgs e)
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
            CargarCursos();
        }
        
        private void btnBuscaCurso_Click(object sender, EventArgs e)
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
            else
            {
                if (LocalData.searchCursosHorariosList.Count <= 0)
                {
                    MessageBox.Show("No hay cursos con horarios asignados, por favor asigne horarios a los cursos", "Asignar", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
            }
            //CargarCursos();
        }

        public void CargarCursos()
        {
            if (!string.IsNullOrEmpty(txtIdProfesor.Text.Trim()))
            {
                var cp = commB.GetCursosProfesorDtos(Convert.ToInt32(txtIdProfesor.Text.Trim()));
                if (cp.Count() > 0 && cp != null)
                {
                    gvCursosAsignados.DataSource = cp;
                    for (int i = 0; i < gvCursosAsignados.Columns.Count; i++)
                    {
                        //gridResults.Columns[i].Width = ColumnSizesArray[i];
                        gvCursosAsignados.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
                else
                {
                    gvCursosAsignados.DataSource = null;
                }
            }
            //throw new NotImplementedException();
        }        
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (Validator(txtAusencias, ValidationTypes.PositiveNumeric,
                "Debe seleccionar el número máximo de ausencias") &&
                Validator(txtIdCurso, ValidationTypes.Text, "Debe seleccionar un curso") &&
                Validator(txtIdCursoHorario, ValidationTypes.Text, "Debe seleccionar un curso") &&
                Validator(txtIdProfesor, ValidationTypes.Text, "Debe seleccionar un profesor") &&
                Validator(dtFechaInicio, ValidationTypes.Text, "Digite la fecha inicial") &&
                Validator(dtFechaFinal, ValidationTypes.Text, "Digite la fecha final"))
            {

                var cursoAsignado = commB.GetCursoProfesorByIdCursoHorarioIdProfesor(Convert.ToInt32(txtIdCursoHorario.Text),
                    Convert.ToInt32(txtIdProfesor.Text));
                if (cursoAsignado.Count > 0)
                {
                    MessageBox.Show("Es curso ya está asignado", "Asignar", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    //var cursoHorario = commB.GetCursosHorariosByIdCurso(Convert.ToInt32(txtIdCursoHorario.Text));
                    //if (cursoHorario != null)
                    //{
                    try
                    {
                        commB.SaveCursoProfesor(Convert.ToInt32(txtIdCursoHorario.Text),
                            Convert.ToInt32(txtIdProfesor.Text), chkActivo.Checked, dtFechaInicio.Value,
                            dtFechaFinal.Value, Convert.ToInt32(txtAusencias.Text));
                    }
                    catch (Exception ex)
                    {
                        General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Es curso no tiene horario asignado", "Asignar", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    //        MessageBoxDefaultButton.Button1);
                    //}
                }
                CargarCursos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvCursosAsignados.CurrentRow != null)
                {
                    var curCodeCursoHorario = gvCursosAsignados.CurrentRow.Cells["IdCursosHorarios"].Value;
                    var curCodeProfesor = gvCursosAsignados.CurrentRow.Cells["IdProfesor"].Value;
                    var cp = commB.FindCursoProfesorByIdCursoProfesor(Convert.ToInt32(curCodeCursoHorario), Convert.ToInt32(curCodeProfesor));
                    if (cp != null) commB.DeleteEntity<CursosProfesor>(cp);
                    CargarCursos();
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
