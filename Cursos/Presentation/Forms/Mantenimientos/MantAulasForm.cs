using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosBusiness.BusinessHelpers;
using CursosEntities.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Mantenimientos
{
	public partial class MantAulasForm : Maintenance
	{
		CommonB commB = new CommonB();
		public MantAulasForm()
		{
			InitializeComponent();
		}

		private void MantAulasForm_Load(object sender, EventArgs e)
		{
			CargarBusqueda();
		}

		private void CargarBusqueda()
		{
			try
            {
				
				// aula
                var aulaListBind = commB.GetBindList<Aula>();//.ToList();

                aulaBindingSource.DataSource = aulaListBind;
                aulaBindingNavigator.BindingSource = aulaBindingSource;

                if (aulaListBind.Count > 0)
                {
					LocalData.searchAulasList =
                        commB.GetAulasSearchDtos(aulaListBind.ToList());
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

		private void aulaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (!ValidateFields()) return;
				aulaBindingSource.EndEdit();
				var selectedAula = commB.SetEntity<Aula>(aulaBindingSource.Current);
				if (selectedAula != null) commB.UpdateEntity<Aula>(selectedAula);
				//commB.SaveBitacora(" guardado: "+ selectedAula.IdUsuario, false, Tools.UserCredentials.UserId);
				aulaBindingSource.ResetBindings(true);
				btnFind.Enabled = true;
				lblInfoMessage.Text = "Aula guardada satisfactoriamente";
			}
			catch (Exception ex)
			{
				General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
		}

		public override bool ValidateFields()
        {
            return Validator(descripcionTextBox, ValidationTypes.Text, "Descripción no válida.") &&
                   Validator(codigoTextBox, ValidationTypes.Text, "Código no válido.") &&
				   Validator(descripcionTextBox, ValidationTypes.Text, "Descripción no válida.");
        }

		private void btnFind_Click(object sender, EventArgs e)
		{
			CargarBusqueda();
            if (CursosBusiness.BusinessHelpers.LocalData.searchAulasList != null &&
                CursosBusiness.BusinessHelpers.LocalData.searchAulasList.Count > 0)
            {
                var searchTable = CursosBusiness.BusinessHelpers.LocalData.searchAulasList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Nombre", "Id");
                searchForm.ShowDialog();
                this.bindingNavigatorPositionItem.Text = searchForm.SelectedKey;
                this.bindingNavigatorPositionItem.Focus();
                this.btnFind.Focus();
            }
		}

		private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
		{
			try
			{

				if (!ValidateFields()) return;
				aulaBindingSource.EndEdit();
				var selectedAula = commB.SetEntity<Aula>(aulaBindingSource.Current);
				if (selectedAula != null)
				{
					var p = commB.FindCursoByIdAula(selectedAula.IdAula);
					if (p != null)
					{
						MessageBox.Show("No se pueden borrar aulas que están relacionados en la tabla de Cursos", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
						return;
					}
					else
					{
						commB.DeleteEntity<Aula>(selectedAula);
						lblInfoMessage.Text = "Aula borrada satisfactoriamente";
						btnFind.Enabled = true;
					}
				}
				aulaBindingSource.ResetBindings(true);
			}
			catch (Exception ex)
			{
				CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
		}

		private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
		{
			var selectedAula = commB.SetEntity<Aula>(aulaBindingSource.Current);
            selectedAula.Disponible = true;
			disponibleCheckBox.CheckState = CheckState.Checked;
			selectedAula.Capacidad = 1;
			capacidadNumericUpDown.Value = 1;
            descripcionTextBox.Focus();			
			btnFind.Enabled = false;
		}
	}
}
