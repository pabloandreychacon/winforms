using BaseForms.Forms;
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
    }
}
