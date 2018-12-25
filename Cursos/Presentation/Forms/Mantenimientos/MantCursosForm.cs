using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosEntities.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Mantenimientos
{
    public partial class MantCursosForm : Maintenance
    {
        CommonB commB = new CommonB();
        public MantCursosForm()
        {
            InitializeComponent();
        }

        private void CursosForm_Load(object sender, EventArgs e)
        {
			foreach (Control c in this.Controls)
			{
				if (c is BindingNavigator)
				{
					this.bindingNavigatorAddNewItem.Text = "Nuevo";
					this.bindingNavigatorCountItem.Text = "de {0}";
					this.bindingNavigatorCountItem.ToolTipText = "Total de items";
					this.bindingNavigatorMoveFirstItem.Text = "Primero";
					this.bindingNavigatorMovePreviousItem.Text = "Anterior";
					this.bindingNavigatorPositionItem.ToolTipText = "Actual";
					this.bindingNavigatorMoveNextItem.Text = "Siguiente";
					this.bindingNavigatorMoveLastItem.Text = "Ultimo";
					this.bindingNavigatorDeleteItem.Text = "Borrar";
					this.cursoBindingNavigatorSaveItem.Text = "Guardar";
					break;
				}
			}
            CargarBusqueda();
            //var horarList = commB.GetList<Horario>();
            //idHorarrioComboBox.DataSource = horarList;
            //idHorarrioComboBox.DisplayMember = "Descripcion";
            //idHorarrioComboBox.ValueMember = "IdHorario";
            //idHorarrioComboBox.DataBindings.Add("SelectedValue", cursoBindingSource, "IdHorario", true);
        }

        private void CargarBusqueda()
        {
            try
            {
                var cursListBind = commB.GetBindList<Curso>();//.ToList();

                cursoBindingSource.DataSource = cursListBind;
                cursoBindingNavigator.BindingSource = cursoBindingSource;

                if (cursListBind.Count > 0)
                {
                    CursosBusiness.BusinessHelpers.LocalData.searchCursosList =
                        commB.GetCursosSearchDtos(cursListBind.ToList());
                }
                else
                {
                    btnFind.Enabled = false;
                }
                
				var aulasListBind = commB.GetBindList<Aula>();//.ToList();

				aulaBindingSource.DataSource = aulasListBind;
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        public override bool ValidateFields()
        {
            //return Validator(descripcionTextBox, ValidationTypes.Text, "Debe digitar una descripción válida.") &&
            //       (Validator(idHorarrioComboBox, ValidationTypes.Text, "Debe seleccionar un horario."));
            return Validator(descripcionTextBox, ValidationTypes.Text, "Debe digitar una descripción válida.") &&
                Validator(cantidadEstudiantesNumericUpDown, ValidationTypes.PositiveNumeric, "Debe digitar una cantidad de estudiantes válida.") &&
                Validator(cantidadHorasNumericUpDown, ValidationTypes.Numeric, "Debe digitar una cantidad de horas válida.") && 
				Validator(nombreCursoTextBox, ValidationTypes.Text, "Debe digitar una descripción válida.");
        }

        private void cursoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                cursoBindingSource.EndEdit();
                var selectedCurso = commB.SetEntity<Curso>(cursoBindingSource.Current);
                if (selectedCurso != null) commB.UpdateEntity<Curso>(selectedCurso);
                cursoBindingSource.ResetBindings(true);
				commB.SaveBitacora(this.Name + " Guardado curso: "+  selectedCurso.IdCurso, false, Tools.UserCredentials.UserId);
				lblInfoMessage.Text = "Curso guardado satisfactoriamente";
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (CursosBusiness.BusinessHelpers.LocalData.searchCursosList != null &&
                CursosBusiness.BusinessHelpers.LocalData.searchCursosList.Count > 0)
            {
                var searchTable = CursosBusiness.BusinessHelpers.LocalData.searchCursosList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, OrderKeys, "Id");
                searchForm.ShowDialog();
                this.bindingNavigatorPositionItem.Text = searchForm.SelectedKey;
                this.bindingNavigatorPositionItem.Focus();
                this.btnFind.Focus();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var selectedCur = commB.SetEntity<Curso>(cursoBindingSource.Current);
            selectedCur.Activo = true;
            activoCheckBox.CheckState = CheckState.Checked;
            descripcionTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                cursoBindingSource.EndEdit();
                var selectedCurso = commB.SetEntity<Curso>(cursoBindingSource.Current);
                if (selectedCurso != null)
                {
                    var ce = commB.FindCursoEstudianteByIdCurso(selectedCurso.IdCurso);
                    var cp = commB.FindCursoProfesorByIdCurso(selectedCurso.IdCurso);
                    if (ce != null)
                    {
                        MessageBox.Show("No se pueden borrar usuarios que están relacionados en la tabla de CursosEstudiantes", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        //base.

                        return;
                    }
                    else
                    {
                        if (cp != null)
                        {
                            MessageBox.Show("No se pueden borrar usuarios que están relacionados en la tabla de CursosProfesores", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            commB.DeleteEntity<Curso>(selectedCurso);
							commB.SaveBitacora(this.Name+"Curso borrado: "+selectedCurso.IdCurso, false, Tools.UserCredentials.UserId);
							lblInfoMessage.Text = "Curso borrado satisfactoriamente";
                        }
                        //horarioBindingSource.RemoveCurrent();
                    }
                }
                cursoBindingSource.ResetBindings(true);
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void asignaProfesorBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcAsignacionCursosForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Procesos.ProcAsignacionCursosForm(false) { MdiParent = formParent };
            formToShow.txtIdCurso.Text = this.idCursoTextBox.Text;
            formToShow.txtCurso.Text = this.descripcionTextBox.Text;
            var curHor = commB.FindCursosHorariosByIdCurso(
                Convert.ToInt32(idCursoTextBox.Text));
            if (curHor != null) formToShow.txtIdCursoHorario.Text = curHor.IdCursosHorarios.ToString();
            this.closeButton1.PerformClick();
            formToShow.Show();
        }

        private void creaProfesorBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("MantProfesoresForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Mantenimientos.MantProfesoresForm() { MdiParent = formParent };
            this.closeButton1.PerformClick();            
            formToShow.Show();
            formToShow.bindingNavigatorAddNewItem.PerformClick();
        }

        private void asignaEstudianteBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcAsignacionCursosForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Procesos.ProcEstudiantesCursosForm() { MdiParent = formParent };
            formToShow.txtIdCurso.Text = this.idCursoTextBox.Text;
            formToShow.txtCurso.Text = this.descripcionTextBox.Text;
            var curHor = commB.FindCursosHorariosByIdCurso(
                Convert.ToInt32(idCursoTextBox.Text));
            if (curHor != null) formToShow.txtIdCursoHorario.Text = curHor.IdCursosHorarios.ToString();
            formToShow.CargarEstudiantes();
            this.closeButton1.PerformClick();
            formToShow.Show();
        }

        private void creaEstudianteBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("MantEstudiantesForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Mantenimientos.MantEstudiantesForm() { MdiParent = formParent };
            this.closeButton1.PerformClick();
            formToShow.Show();
            formToShow.bindingNavigatorAddNewItem.PerformClick();
        }

        private void asignaHorarioBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcHorariosCursosForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Procesos.ProcHorariosCursosForm() { MdiParent = formParent };
            formToShow.txtIdCurso.Text = this.idCursoTextBox.Text;
            formToShow.txtCurso.Text = this.descripcionTextBox.Text;
            formToShow.CargarHorarios();
            this.closeButton1.PerformClick();
            formToShow.Show();
        }

        private void creaHorarioBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("MantHorariosForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Mantenimientos.MantHorariosForm() { MdiParent = formParent };
            this.closeButton1.PerformClick();
            formToShow.Show();
            formToShow.bindingNavigatorAddNewItem.PerformClick();
        }

        private void asignaAusenciasBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcHorariosCursosForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Procesos.ProcAusenciasForm() { MdiParent = formParent };
            formToShow.txtIdCurso.Text = this.idCursoTextBox.Text;
            formToShow.txtCurso.Text = this.descripcionTextBox.Text;
            var curHor = commB.FindCursosHorariosByIdCurso(
                Convert.ToInt32(idCursoTextBox.Text));
            if (curHor != null) formToShow.txtIdCursoHorario.Text = curHor.IdCursosHorarios.ToString();
            if (!string.IsNullOrWhiteSpace(formToShow.txtIdCursoHorario.Text))
            {
                var profe = commB.FindCursoProfesorByIdCursoHorario(Convert.ToInt32(formToShow.txtIdCursoHorario.Text));
                if (profe != null)
                {
                    formToShow.txtIdProfesor.Text = profe.Profesore.IdProfesor.ToString();
                    var profname = commB.FindProfesorById(profe.IdProfesor);
                    if (profname != null)
                    {
                        formToShow.txtProfesor.Text = profname.Nombre;
                    }
                }
            }
            formToShow.CargarEstudiantes();
            this.closeButton1.PerformClick();
            formToShow.Show();
        }

    }
}
