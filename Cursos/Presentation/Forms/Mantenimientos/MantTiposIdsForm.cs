using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosEntities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Mantenimientos
{
	public partial class MantTiposIdsForm : Maintenance
	{
		CommonB commB = new CommonB();
		public MantTiposIdsForm()
		{
			InitializeComponent();
		}

		private void MantTiposIdsForm_Load(object sender, EventArgs e)
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
					this.tipoIdBindingNavigatorSaveItem.Text = "Guardar";
					break;
				}
			}
			CargarBusqueda();
		}

		private void CargarBusqueda()
        {
            try
            {
                var idsListBind = commB.GetBindList<TipoId>();//.ToList();

				tipoIdBindingSource.DataSource = idsListBind;
                tipoIdBindingNavigator.BindingSource = tipoIdBindingSource;

                btnFind.Enabled = false;
                
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

		private void tipoIdBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			try
            {
                if (!ValidateFields()) return;
                tipoIdBindingSource.EndEdit();
                var selectedTipoId = commB.SetEntity<TipoId>(tipoIdBindingSource.Current);
                if (selectedTipoId != null) commB.UpdateEntity<TipoId>(selectedTipoId);
                tipoIdBindingSource.ResetBindings(true);
				commB.SaveBitacora(this.Name + " Guardado tipo Id: "+  selectedTipoId.IdTipoId, false, Tools.UserCredentials.UserId);
				lblInfoMessage.Text = "Tipo Id guardado satisfactoriamente";
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
                tipoIdBindingSource.EndEdit();
                var selectedTipoId = commB.SetEntity<TipoId>(tipoIdBindingSource.Current);
                commB.DeleteEntity<TipoId>(selectedTipoId);
                tipoIdBindingSource.ResetBindings(true);
				commB.SaveBitacora(this.Name+"Tipo Id borrado: "+selectedTipoId.IdTipoId, false, Tools.UserCredentials.UserId);
						lblInfoMessage.Text = "Tipo Id borrado satisfactoriamente";
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
		}
	}
}
