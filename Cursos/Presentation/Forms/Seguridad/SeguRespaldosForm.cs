using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosBusiness.BusinessHelpers;
using CursosEntities.Entities;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Seguridad
{
    public partial class SeguRespaldosForm : Basic
    {
        CommonB commB = new CommonB();
        public SeguRespaldosForm()
        {
            InitializeComponent();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            var strBackup = "BACKUP DATABASE [Cursos] TO  DISK = N'" +
                txtPath.Text.Trim() + "\\Cursos.bak' WITH NOFORMAT, INIT,  NAME = N'Cursos-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
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
                    General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("El folder seleccionado es inválido!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }            
        }

        private void RespaldosForm_Load(object sender, EventArgs e)
        {
            string parameterRutaSistema = commB.GetList<Parametro>().FirstOrDefault().RutaSistema;
            if (!string.IsNullOrWhiteSpace(parameterRutaSistema))
            {
                txtPath.Text = parameterRutaSistema.Trim();
            }
            else
            {
                txtPath.Text = Path.GetDirectoryName(Application.ExecutablePath);
            }            
        }

        private void okButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
                //string[] files = Directory.GetFiles(fbd.SelectedPath);
                //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
        }
    }
}
