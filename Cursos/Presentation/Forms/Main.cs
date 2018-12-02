using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosEntities.Entities;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms
{
    public partial class Main : Mdi
    {
        CommonB commB = new CommonB();
        public Main()
        {
            InitializeComponent();
        }        

        private void Main_Load(object sender, EventArgs e)
        {
            Text += " - " + Tools.UserCredentials.UserName.Trim();
            SetMenu();
            confirmarSalirToolStripMenuItem.Checked = PromptOnExit;
            var selectedParameter = commB.GetList<Parametro>();
            toolStripStatusLabel1.Text = selectedParameter.FirstOrDefault().Nombre;
            if (!string.IsNullOrEmpty(selectedParameter.FirstOrDefault().RutaLogo))
            {
                if (File.Exists(selectedParameter.FirstOrDefault().RutaLogo)) BackgroundImage = new Bitmap(selectedParameter.FirstOrDefault().RutaLogo);
            }
        }

        private void SetMenu()
        {
            var curUser = commB.GetUsuarioById(Tools.UserCredentials.UserId);
            if (curUser.Any())
            {
                foreach (var usuarioActivo in curUser)
                {
                    if (usuarioActivo.Mantenimientos) mantenimientosToolStripMenuItem.Enabled = true;
                    if (usuarioActivo.Procesos) procesosToolStripMenuItem.Enabled = true;
                    if (usuarioActivo.Consultas) consultasToolStripMenuItem.Enabled = true;
                    if (usuarioActivo.Seguridad) seguridadToolStripMenuItem.Enabled = true;
                    // algunos items deben ser solo para usuario tipo administrador
                    if (Tools.UserCredentials.IsAdmin) usuariosToolStripMenuItem1.Enabled = true;
                }
            }
        }

        #region sistema
        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var Login = new Login();
            Login.Show();
        }

        private void confirmarSalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confirmarSalirToolStripMenuItem.Checked = !(confirmarSalirToolStripMenuItem.Checked);
            PromptOnExit = confirmarSalirToolStripMenuItem.Checked;
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\LunaSoftwareDevelopment\Control\", "PromptOnExit", PromptOnExit);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region mantenimientos
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("MantUsuariosForm")) return;
            var formToShow = new Forms.Mantenimientos.MantUsuariosForm { MdiParent = this };
            formToShow.Show();
        }
        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("MantParametrosForm")) return;
            var formToShow = new Forms.Mantenimientos.MantParametrosForm { MdiParent = this };
            formToShow.Show();
        }
        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("MantHorariosForm")) return;
            var formToShow = new Forms.Mantenimientos.MantHorariosForm { MdiParent = this };
            formToShow.Show();
        }
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("MantCursosForm")) return;
            var formToShow = new Forms.Mantenimientos.MantCursosForm { MdiParent = this };
            formToShow.Show();
        }
        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("MantEstudiantesForm")) return;
            var formToShow = new Forms.Mantenimientos.MantEstudiantesForm { MdiParent = this };
            formToShow.Show();
        }
        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("MantProfesoresForm")) return;
            var formToShow = new Forms.Mantenimientos.MantProfesoresForm { MdiParent = this };
            formToShow.Show();
        }

		private void tiposIdentificacionesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Tools.FormManager.FindAndOpenForm("MantTiposIdsForm")) return;
            var formToShow = new Forms.Mantenimientos.MantTiposIdsForm { MdiParent = this };
            formToShow.Show();
		}
		private void usuariosToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			if (Tools.FormManager.FindAndOpenForm("MantUsuariosForm")) return;
            var formToShow = new Forms.Mantenimientos.MantUsuariosForm { MdiParent = this };
            formToShow.Show();
		}
        #endregion        

        #region seguridad
        private void crearRespaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var conn = commB.GetConnection();
            if (Tools.FormManager.FindAndOpenForm("SeguRespaldosForm")) return;
            var formToShow = new Forms.Seguridad.SeguRespaldosForm { MdiParent = this };
            formToShow.txtConexion.Text = conn;
            formToShow.Show();
        }

        private void restaurarRespaldoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var conn = commB.GetConnection();
            if (Tools.FormManager.FindAndOpenForm("SeguRestauraForm")) return;
            var formToShow = new Forms.Seguridad.SeguRestauraForm { MdiParent = this };
            formToShow.txtConexion.Text = conn;
            formToShow.Show();
        }
        #endregion

        #region consultas
        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("CursosReportForm")) return;
            var formToShow = new Presentation.Forms.Consultas.CursosReportForm { MdiParent = this };
            formToShow.Show();
        }
        private void ausenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ConsAusenciasForm")) return;
            var formToShow = new Presentation.Forms.Consultas.ConsAusenciasForm { MdiParent = this };
            formToShow.Show();
        }
        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ConsEstudiantesForm")) return;
            var formToShow = new Presentation.Forms.Consultas.ConsEstudiantesForm { MdiParent = this };
            formToShow.Show();
        }

        private void profesoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ConsProfesoresForm")) return;
            var formToShow = new Presentation.Forms.Consultas.ConsProfesoresForm { MdiParent = this };
            formToShow.Show();
        }
        #endregion

        #region ayuda
        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process mydoc = new Process();
            mydoc.StartInfo.FileName = "ManualDeUsuario.pdf";
            mydoc.Start();
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("AboutBox1")) return;
            var formToShow = new Presentation.Forms.AboutBox1 { MdiParent = this };
            formToShow.Show();
        }
        private void correoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var parames = commB.GetList<Parametro>().FirstOrDefault();
            if (Tools.FormManager.FindAndOpenForm("Email")) return;
            if (!string.IsNullOrWhiteSpace(parames.PasswordCorreo))
            {
                var formToShow = new Email(parames.PortCorreo,
                    parames.TimeOutCorreo, parames.HostCorreo, parames.UserNameCorreo,
                    Tools.CodeDecode.Decode(parames.PasswordCorreo),
                    parames.FromCorreo, parames.DisplayNameCorreo) { MdiParent = this };
                formToShow.Show();
            }
            else
            {
                MessageBox.Show("No están definidos los parámetros para el envío de correos electrónicos, por favor verifique los parámetros del sistema.","Correo",
                    MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            }
        }
        private void scriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var conn = commB.GetConnection();
            if (Tools.FormManager.FindAndOpenForm("Scripts")) return;
            var formToShow = new Scripts() { MdiParent = this };
            formToShow.txtConexion.Text = conn;
            formToShow.Show();
        }
        #endregion

        #region procesos
        private void asiganciondecursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcAsignacionCursosForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcAsignacionCursosForm(false) { MdiParent = this };
            formToShow.Show();
        }
        private void cambiosyajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcAsignacionCursosForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcAsignacionCursosForm(true) { MdiParent = this };
            formToShow.Show();
        }
        private void transferenciaestudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcTransferenciaEstudiantesForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcTransferenciaEstudiantesForm { MdiParent = this };
            formToShow.Show();
        }
        private void estudiantesycursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcEstudiantesCursosForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcEstudiantesCursosForm { MdiParent = this };
            formToShow.Show();
        }
        private void ausenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcAusenciasForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcAusenciasForm { MdiParent = this };
            formToShow.Show();
        }
        private void removerAusenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcRemoverAusenciasForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcRemoverAusenciasForm { MdiParent = this };
            formToShow.Show();
        }
        private void cerrarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcCerrarCursosForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcCerrarCursosForm { MdiParent = this };
            formToShow.Show();
        }
        private void horariosCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcHorariosCursosForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcHorariosCursosForm { MdiParent = this };
            formToShow.Show();
        }
        private void asignacionCursosProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcAsignacionCursosForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcAsignacionCursosForm(false) { MdiParent = this };
            formToShow.Show();
        }
        private void cambiosAjustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcAsignacionCursosForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcAsignacionCursosForm(true) { MdiParent = this };
            formToShow.Show();
        }
        private void transferenciaEstudiantesCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcTransferenciaEstudiantesForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcTransferenciaEstudiantesForm { MdiParent = this };
            formToShow.Show();
        }
        private void asignacionEstudiantesCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcEstudiantesCursosForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcEstudiantesCursosForm { MdiParent = this };
            formToShow.Show();
        }
        
               
        private void asignarAusenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcAusenciasForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcAusenciasForm { MdiParent = this };
            formToShow.Show();
        }
		

        private void removerAusenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcRemoverAusenciasForm")) return;
            var formToShow = new Presentation.Forms.Procesos.ProcRemoverAusenciasForm { MdiParent = this };
            formToShow.Show();
        }
		#endregion

        

		
	}
}
