using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosBusiness.BusinessHelpers;
using CursosEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Mantenimientos
{
    public partial class MantUsuariosForm : Maintenance
    {
        CommonB commB = new CommonB();
        public MantUsuariosForm()
        {
            InitializeComponent();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            CargarBusqueda();
			cargarCombos();
        }

        public override bool ValidateFields()
        {
            return Validator(nombreTextBox, ValidationTypes.Text, "Debe digitar un nombre válido.") &&
                   (Validator(claveTextBox, ValidationTypes.Text, "Clave no válida.")) &&
				   (Validator(cboRoles, ValidationTypes.Text, "Rol no válido."))
				   ;
        }

        private void claveTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter)) return;
            e.KeyChar = (char)(Convert.ToByte(e.KeyChar) + 1);
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                usuarioBindingSource.EndEdit();
                var selectedUsuario = commB.SetEntity<Usuario>(usuarioBindingSource.Current);
                if (selectedUsuario != null) commB.UpdateEntity<Usuario>(selectedUsuario);
				commB.SaveBitacora("Usuario guardado: "+ selectedUsuario.IdUsuario, false, Tools.UserCredentials.UserId);
                usuarioBindingSource.ResetBindings(true);
				lblInfoMessage.Text = "Usuario guardado satisfactoriamente";
            }
            catch (Exception ex)
            {
                General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var selectedUser = commB.SetEntity<Usuario>(usuarioBindingSource.Current);
            selectedUser.Activo = true;
            activoCheckBox.CheckState = CheckState.Checked;
            nombreTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
             {
				
                if (!ValidateFields()) return;
                usuarioBindingSource.EndEdit();
                var selectedUsuario = commB.SetEntity<Usuario>(usuarioBindingSource.Current);
                if (selectedUsuario != null)
                {
                    var p = commB.FindCursoEstudianteByIdUsuario(selectedUsuario.IdUsuario);
                    //var b = commB.FindBitacoraByIdUsuario(selectedUsuario.IdUsuario);
                    if (p != null)
                    {
                        MessageBox.Show("No se pueden borrar usuarios que están relacionados en la tabla de CursosEstudiantes", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        //base.

                        return;
                    }
                    else
                    {
                        //if (b != null)
                        //{
                        //    MessageBox.Show("No se pueden borrar usuarios que están relacionados en la tabla de Bitacora", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        //}
                        //else
                        //{
                            commB.DeleteEntity<Usuario>(selectedUsuario);
							commB.SaveBitacora(this.Name+"Usuario borrado: "+selectedUsuario.IdUsuario, false, Tools.UserCredentials.UserId);
						lblInfoMessage.Text = "Usuario borrado satisfactoriamente";
                        //}                        
                        //horarioBindingSource.RemoveCurrent();
                    }
                }
                usuarioBindingSource.ResetBindings(true);
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //CargarBusqueda();
            if (CursosBusiness.BusinessHelpers.LocalData.searchUsuariosList != null &&
                CursosBusiness.BusinessHelpers.LocalData.searchUsuariosList.Count > 0)
            {
                var searchTable = CursosBusiness.BusinessHelpers.LocalData.searchUsuariosList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Nombre", "Id");
                searchForm.ShowDialog();
                this.bindingNavigatorPositionItem.Text = searchForm.SelectedKey;
                this.bindingNavigatorPositionItem.Focus();
                this.btnFind.Focus();
            }
        }

		private void cargarCombos()
		{
			//// combo de roles
				var roleListBind = commB.GetBindList<Role>();
				roleBindingSource.DataSource = roleListBind;
				// si lo hago visual entoces llego hasta aquí, si no continúo con las siguientes 4 líneas
				cboRoles.DataSource = roleListBind;
				cboRoles.DisplayMember = "Descripcion";
				cboRoles.ValueMember = "IdRole";
				cboRoles.DataBindings.Add(new Binding("SelectedValue", this.usuarioBindingSource, "IdRole", true));
		}
        private void CargarBusqueda()
        {
            try
            {
				
				// usuario
                var userListBind = commB.GetBindList<Usuario>();//.ToList();

                usuarioBindingSource.DataSource = userListBind;
                usuarioBindingNavigator.BindingSource = usuarioBindingSource;

                if (userListBind.Count > 0)
                {
                    LocalData.searchUsuariosList =
                        commB.GetUsuariosSearchDtos(userListBind.ToList());
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

		private void usuarioBindingNavigator_RefreshItems(object sender, EventArgs e)
		{

		}
	}
}
