using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosEntities.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Mantenimientos
{
    public partial class MantHorariosForm : Maintenance
    {
        CommonB commB = new CommonB();
        public MantHorariosForm()
        {
            InitializeComponent();
        }

        private void HorariosForm_Load(object sender, EventArgs e)
        {
            CargarBusqueda();
        }

        public override bool ValidateFields()
        {
            return Validator(descripcionTextBox, ValidationTypes.Text, "Debe digitar una descripción válida.");
        }

        private void horarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                horarioBindingSource.EndEdit();
                var selectedHorario = commB.SetEntity<Horario>(horarioBindingSource.Current);
                if (selectedHorario != null) commB.UpdateEntity<Horario>(selectedHorario);
                horarioBindingSource.ResetBindings(true); 
				commB.SaveBitacora(this.Name + " Guardado horario: "+  selectedHorario.IdHorario, false, Tools.UserCredentials.UserId);
				lblInfoMessage.Text = "Horario guardado satisfactoriamente";
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            } 
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                horarioBindingSource.EndEdit();
                var selectedHorario = commB.SetEntity<Horario>(horarioBindingSource.Current);
                if (selectedHorario != null)
                {
                    var p = commB.GetCursosHorariosByIdHorarioList(selectedHorario.IdHorario);
                    if (p.Count() > 0)
                    {
                        MessageBox.Show("No se pueden borrar horarios que están relacionados en la tabla de cursos", "Borrar",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);                       
                        return;
                    }
                    else
                    {
                        commB.DeleteEntity<Horario>(selectedHorario);
						commB.SaveBitacora(this.Name+"Horario borrado: "+selectedHorario.IdHorario, false, Tools.UserCredentials.UserId);
						lblInfoMessage.Text = "Horario borrado satisfactoriamente";
                        //horarioBindingSource.RemoveCurrent();
                    }
                }
                horarioBindingSource.ResetBindings(true);
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (CursosBusiness.BusinessHelpers.LocalData.searchHorariosList != null &&
                CursosBusiness.BusinessHelpers.LocalData.searchHorariosList.Count > 0)
            {
                var searchTable = CursosBusiness.BusinessHelpers.LocalData.searchHorariosList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Descrip", "Id");
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
                var horarioListBind = commB.GetBindList<Horario>();//.ToList();

                horarioBindingSource.DataSource = horarioListBind;
                horarioBindingNavigator.BindingSource = horarioBindingSource;

                if (horarioListBind.Count > 0)
                {
                    CursosBusiness.BusinessHelpers.LocalData.searchHorariosList =
                        commB.GetHorariosSearchDtos(horarioListBind.ToList());
                }
                else
                {
                    btnFind.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void asignaCursoBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcHorariosCursosForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Procesos.ProcHorariosCursosForm() { MdiParent = formParent };
            formToShow.txtIdHorario.Text = this.idHorarioTextBox.Text;
            formToShow.txtHorario.Text = this.descripcionTextBox.Text;
            formToShow.CargarHorarios();
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
