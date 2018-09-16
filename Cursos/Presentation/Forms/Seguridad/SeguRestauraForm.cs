using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosBusiness.BusinessHelpers;
using CursosEntities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Seguridad
{
    public partial class SeguRestauraForm : Basic
    {
        CommonB commB = new CommonB();
        public SeguRestauraForm()
        {
            InitializeComponent();
        }

        private void SeguRestauraForm_Load(object sender, EventArgs e)
        {
            string parameterRutaSistema = commB.GetList<Parametro>().FirstOrDefault().RutaSistema;
            if (!string.IsNullOrWhiteSpace(parameterRutaSistema))
            {
                txtPath.Text = parameterRutaSistema.Trim() + "\\Cursos.bak";
            }
            else
            {
                txtPath.Text = Path.GetDirectoryName(Application.ExecutablePath) + "\\Cursos.bak";
            }
        }

        private void buscaRespaldoBtn_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup files|*.bak";
            ofd.InitialDirectory = txtPath.Text;
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
                //string[] files = Directory.GetFiles(fbd.SelectedPath);
                //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            var strBackup = "";
            //var strBackup = "RESTORE DATABASE [Cursos] FROM  DISK = N'" +
            //    txtPath.Text.Trim() + 
            //    "' WITH  FILE = 1,  MOVE N'Cursos' TO N'" + 
            //    C:\\Data\\Cursos.mdf + 
            //        "',  MOVE N'Cursos_log' TO N'" + C:\\Data\\Cursos_log.ldf + 
            //            "',  NOUNLOAD,  REPLACE,  STATS = 5";
            if (!string.IsNullOrWhiteSpace(txtPath.Text.Trim()))
            {
                DirectoryInfo df = new DirectoryInfo(txtPath.Text.Trim());
                try
                {
                    if (df.Exists)
                    {
                        // send backup
                        // usuario de bases de datos debe tener permisos db backupoperator, on user mapping, database role memebership
                        //int count = AdoDataMethods.ExecuteSql(commB.GetConnection(), strBackup);
                        int count = AdoDataMethods.ExecuteSql(txtConexion.Text.Trim(), strBackup);
                        //int count = commB.ExecuteSql(strBackup);
                        MessageBox.Show("Respaldo realizado!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("El folder seleccionado es inaccesible o no existe!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception ex)
                {
                    General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("El folder seleccionado es inválido!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }   
        }
    }
}
