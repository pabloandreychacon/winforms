using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosEntities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Mantenimientos
{
    public partial class MantParametrosForm : Maintenance
    {
        CommonB commB = new CommonB();
        public MantParametrosForm()
        {
            InitializeComponent();
        }

        private void ParametrosForm_Load(object sender, EventArgs e)
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
					this.parametrosGeneralBindingNavigatorSaveItem.Text = "Guardar";
					break;
				}
			}
            try
            {
                var paramListBind = commB.GetBindList<Parametro>();//.ToList();

                parametrosGeneralBindingSource.DataSource = paramListBind;
                parametrosGeneralBindingNavigator.BindingSource = parametrosGeneralBindingSource;

                //if (userListBind.Count > 0)
                //{
                //    userBl.searchList = SearchMethods.SetProdSearchList(userListBind.ToList()); // prepara busqueda
                //}
                //else
                //{
                btnFind.Enabled = false;
                //}
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public override bool ValidateFields()
        {
            return Validator(hostCorreoTextBox, ValidationTypes.Text, "Debe digitar un servidor válido.");
        }

        private void parametrosGeneralBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                parametrosGeneralBindingSource.EndEdit();
                var selectedParameter = commB.SetEntity<Parametro>(parametrosGeneralBindingSource.Current);
                if (selectedParameter != null) commB.UpdateEntity<Parametro>(selectedParameter);
                parametrosGeneralBindingSource.ResetBindings(true); 
				commB.SaveBitacora(this.Name + " Guardado parametro: "+  selectedParameter.IdParametro, false, Tools.UserCredentials.UserId);
				lblInfoMessage.Text = "Parametro guardado satisfactoriamente";
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }  
        }

        private void saveLogoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter =
                "Image Files(*.JPG;*.GIF;*.BMP;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
                + "|JPEG Compressed Image (*.jpg)|*.jpg" 
                + "|GIF Image(*.gif)|*.gif"
                + "|Bitmap Image(*.bmp)|*.bmp" 
                + "|PNG Image(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    logoPb.Image = new Bitmap(openFileDialog1.FileName);
                    rutaLogoTextBox.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image" + ex.Message);
                }
            }
        }

        private void parametrosGeneralBindingSource_PositionChanged(object sender, EventArgs e)
        {
            var selectedParameter = commB.SetEntity<Parametro>(parametrosGeneralBindingSource.Current);
            if (!string.IsNullOrEmpty(selectedParameter.RutaLogo))
            {
                if (File.Exists(selectedParameter.RutaLogo)) logoPb.Image = new Bitmap(selectedParameter.RutaLogo);
            }
        }

        private void saveRutaBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK) rutaSistemaTextBox.Text = fbd.SelectedPath;
        }

        private void portCorreoLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordCorreoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter)) return;
            e.KeyChar = (char)(Convert.ToByte(e.KeyChar) + 1);
        }

        private void passwordCorreoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameCorreoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeOutCorreoLabel_Click(object sender, EventArgs e)
        {

        }

        private void timeOutCorreoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordCorreoLabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameCorreoLabel_Click(object sender, EventArgs e)
        {

        }

        private void hostCorreoLabel_Click(object sender, EventArgs e)
        {

        }

        private void hostCorreoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromCorreoLabel_Click(object sender, EventArgs e)
        {

        }

        private void fromCorreoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayNameCorreoLabel_Click(object sender, EventArgs e)
        {

        }

        private void displayNameCorreoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void portCorreoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
