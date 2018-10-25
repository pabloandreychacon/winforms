using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosEntities.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Mantenimientos
{
    public partial class MantProfesoresForm : Maintenance
    {
        CommonB commB = new CommonB();
        public MantProfesoresForm()
        {
            InitializeComponent();
        }

        private void ProfesoresForm_Load(object sender, EventArgs e)
        {
            CargarBusqueda();
        }
        public override bool ValidateFields()
        {
            return (Validator(nombreTextBox, ValidationTypes.Text, "Debe digitar un nombre válida.")
				&& Validator(apellidoTextBox, ValidationTypes.Text, "Debe digitar un apellido válido."));
        }

        private void profesoreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                profesoreBindingSource.EndEdit();
                var selectedCurso = commB.SetEntity<Profesore>(profesoreBindingSource.Current);
                if (selectedCurso != null) commB.UpdateEntity<Profesore>(selectedCurso);
                profesoreBindingSource.ResetBindings(true);
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (CursosBusiness.BusinessHelpers.LocalData.searchProfesoresList != null &&
                CursosBusiness.BusinessHelpers.LocalData.searchProfesoresList.Count > 0)
            {
                var searchTable = CursosBusiness.BusinessHelpers.LocalData.searchProfesoresList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, OrderKeys, "Id");
                searchForm.ShowDialog();
                this.bindingNavigatorPositionItem.Text = searchForm.SelectedKey;
                this.bindingNavigatorPositionItem.Focus();
                this.btnFind.Focus();
            }
        }

        private void CargarBusqueda()
        {
            try
            {
                var profListBind = commB.GetBindList<Profesore>();//.ToList();

                profesoreBindingSource.DataSource = profListBind;
                profesoreBindingNavigator.BindingSource = profesoreBindingSource;

                if (profListBind.Count > 0)
                {
                    CursosBusiness.BusinessHelpers.LocalData.searchProfesoresList =
                        commB.GetProfesoresSearchDtos(profListBind.ToList());
                }
                else
                {
                    btnFind.Enabled = false;
                }                
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var selectedProf = commB.SetEntity<Profesore>(profesoreBindingSource.Current);
            selectedProf.Activo = true;
            activoCheckBox.CheckState = CheckState.Checked;
            nombreTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                profesoreBindingSource.EndEdit();
                var selectedProfe = commB.SetEntity<Profesore>(profesoreBindingSource.Current);
                if (selectedProfe != null)
                {
                    var ce = commB.FindCursoProfesorByIdProfesor(selectedProfe.IdProfesor);
                    if (ce != null)
                    {
                        MessageBox.Show("No se pueden borrar profesores que están relacionados en la tabla de CursosProfesores", 
                            "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        //base.
                        return;
                    }
                    else
                    {
                        commB.DeleteEntity<Profesore>(selectedProfe);
                        //horarioBindingSource.RemoveCurrent();
                    }
                }
                profesoreBindingSource.ResetBindings(true);
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void asignaCursoBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcHorariosCursosForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Procesos.ProcAsignacionCursosForm(false) { MdiParent = formParent };
            formToShow.txtIdProfesor.Text = this.idProfesorTextBox.Text;
            formToShow.txtProfesor.Text = this.nombreTextBox.Text;
            formToShow.CargarCursos();
            this.closeButton1.PerformClick();
            formToShow.Show();
        }

        private void creaCursoBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("MantCursosForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Mantenimientos.MantCursosForm() { MdiParent = formParent };
            this.closeButton1.PerformClick();
            formToShow.Show();
            formToShow.bindingNavigatorAddNewItem.PerformClick();        
        }
    }
}
