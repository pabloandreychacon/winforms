using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosEntities.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Mantenimientos
{
    public partial class MantEstudiantesForm : Maintenance
    {
        CommonB commB = new CommonB();
        public MantEstudiantesForm()
        {
            InitializeComponent();
        }

        private void EstudiantesForm_Load(object sender, EventArgs e)
        {
            CargarBusqueda();
        }

        public override bool ValidateFields()
        {
            return Validator(nombreTextBox, ValidationTypes.Text, "Debe digitar una descripción válida.");
        }

        private void estudianteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                estudianteBindingSource.EndEdit();
                var selectedCurso = commB.SetEntity<Estudiante>(estudianteBindingSource.Current);
                if (selectedCurso != null) commB.UpdateEntity<Estudiante>(selectedCurso);
                estudianteBindingSource.ResetBindings(true);
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (CursosBusiness.BusinessHelpers.LocalData.searchEstudiantesList != null &&
                CursosBusiness.BusinessHelpers.LocalData.searchEstudiantesList.Count > 0)
            {
                var searchTable = CursosBusiness.BusinessHelpers.LocalData.searchEstudiantesList.AsDataTable(); // transforma en dataTable
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
                var estudListBind = commB.GetBindList<Estudiante>();//.ToList();

                estudianteBindingSource.DataSource = estudListBind;
                estudianteBindingNavigator.BindingSource = estudianteBindingSource;

                if (estudListBind.Count > 0)
                {
                    CursosBusiness.BusinessHelpers.LocalData.searchEstudiantesList =
                        commB.GetEstudiantesSearchDtos(estudListBind.ToList());
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
            //activoCheckBox.Checked = true;
            var selectedEst = commB.SetEntity<Estudiante>(estudianteBindingSource.Current);
            selectedEst.Activo = true;
            activoCheckBox.CheckState = CheckState.Checked;
            nombreTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                estudianteBindingSource.EndEdit();
                var selectedEst = commB.SetEntity<Estudiante>(estudianteBindingSource.Current);
                if (selectedEst != null)
                {
                    var ce = commB.FindCursoEstudianteByIdEstudiante(selectedEst.IdEstudiante);
                    if (ce != null)
                    {
                        MessageBox.Show("No se pueden borrar estudiantes que están relacionados en la tabla de CursosEstudiantes", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        //base.
                        return;
                    }
                    else
                    {
                        commB.DeleteEntity<Estudiante>(selectedEst);
                        //horarioBindingSource.RemoveCurrent();
                    }
                }
                estudianteBindingSource.ResetBindings(true);
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void asignaCursoBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcEstudiantesCursosForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Procesos.ProcEstudiantesCursosForm() { MdiParent = formParent };
            formToShow.txtIdEstudiante.Text = this.idEstudianteTextBox.Text;
            formToShow.txtEstudiante.Text = this.nombreTextBox.Text;
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
