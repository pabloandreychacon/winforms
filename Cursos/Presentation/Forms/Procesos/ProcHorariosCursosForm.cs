using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosBusiness.BusinessHelpers;
using CursosEntities.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
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

		private void CargarDias()
		{
			throw new NotImplementedException();
		}

		private void CargarAulas()
		{
			throw new NotImplementedException();
		}

		public void CargarHorarios()
        {
            gvHorariosAsignados.DataSource = null;

            if (!string.IsNullOrEmpty(txtIdCurso.Text.Trim()))
            {
                var h = commB.GetHorariosList(Convert.ToInt32(txtIdCurso.Text.Trim()));
                if (h.Count() > 0 && h != null)
                {
					LocalData.cursosHorariosList = new List<CursosEntities.Dtos.CursosDtos.CursosHorariosList>{};
					for (int i = 0; i < h.Count; i++)
					{
						LocalData.cursosHorariosList.Add(
							new CursosEntities.Dtos.CursosDtos.CursosHorariosList
							{
								Id = h[i].Id,
								Descrip = h[i].Descrip,
								Aula = commB.GetAulaNameFromId(h[i].Aula),
								Dia = Tools.TimeTools.DayOfWeekToSpanish(Enum.GetName(typeof(DayOfWeek),h[i].Dia))
							}
							);
					}

                    gvHorariosAsignados.DataSource = LocalData.cursosHorariosList;
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
				var aulaList = commB.GetList<Aula>().Where(a => a.Disponible).ToList();

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

				if (aulaList.Count() > 0)
                {
                    LocalData.searchAulasList =
                        commB.GetAulasSearchDtos(aulaList);
                }
                else
                {
                    btnBuscaAula.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                Validator(txtIdHorario, ValidationTypes.Text, "Debe seleccionar un horario") 
				&& Validator(txtIdAula, ValidationTypes.Text, "Debe seleccionar un aula") && 
				Validator(cboDayOfWeek, ValidationTypes.Text, "Debe seleccionar un dïa"))
            {
				//valida que no se haya asignado el horario al curso
                var cursoAsignadoList = commB.FindCursoHorarioByIdCursoAndIdhorarioAndIdAulaAndIdDia(
                    Convert.ToInt32(txtIdCurso.Text), Convert.ToInt32(txtIdHorario.Text), Convert.ToInt32(txtIdAula.Text), 
					Convert.ToInt32(cboDayOfWeek.SelectedValue));
                if (cursoAsignadoList != null)
                {
                    MessageBox.Show("Es horario y esa aula y ese día ya están asignados", "Asignar", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
				else
				{
					try
					{
						commB.SaveCursoHorarioAulaDia(Convert.ToInt32(txtIdCurso.Text), Convert.ToInt32(txtIdHorario.Text), Convert.ToInt32(txtIdAula.Text), 
							Convert.ToInt32(cboDayOfWeek.SelectedValue));
						commB.SaveBitacora(this.Name + " Curso asignado: " + txtIdCurso.Text, false, Tools.UserCredentials.UserId);
						lblInfoMessage.Text = "Curso asignado";
					}
					catch (Exception ex)
					{
						General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
					commB.SaveBitacora(this.Name + " Curso borrado: "+txtIdCurso.Text, false,		Tools.UserCredentials.UserId);
						lblInfoMessage.Text = "Curso borrado";	
                    CargarHorarios(); 
                    this.btnBuscaCurso.Focus(); // hace que se valide el position text                    
                }
            }
            catch (Exception ex)
            {
                General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }								

		private void ProcHorariosCursosForm_Load(object sender, EventArgs e)
		{
						
			cboDayOfWeek.Items.Clear();
			LocalData.diasHorariosList = commB.GetDiasHorarios().ToList();
            	
			cboDayOfWeek.DataSource = LocalData.diasHorariosList;
			cboDayOfWeek.DisplayMember = "Descrip";
			cboDayOfWeek.ValueMember = "Id";
			
		}

		private void btnBuscaAula_Click(object sender, EventArgs e)
		{
			CargarBusqueda();
            if (LocalData.searchAulasList != null &&
                LocalData.searchAulasList.Count > 0)
            {
                var searchTable = LocalData.searchAulasList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Descripcion", "Key");
                searchForm.ShowDialog();
                if (searchForm.SelectedKey != null)
                {
                    var curKey = Convert.ToInt32(searchForm.SelectedKey);
                    var aul = commB.FindAulaById(curKey);
                    if (aul != null)
                    {
                        txtIdAula.Text = aul.IdAula.ToString();
                        txtAula.Text = aul.Descripcion;
                    }
                }
            }
		}
	}
}
