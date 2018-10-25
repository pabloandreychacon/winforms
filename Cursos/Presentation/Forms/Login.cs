using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms
{
    public partial class Login : Basic
    {
        CommonB commB = new CommonB();
        public Login()
        {
            InitializeComponent();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (Validator(txtUser, ValidationTypes.Text, "Debe digitar un usuario válido.") &&
                   (Validator(txtPass, ValidationTypes.Text, "Password no válido.")))
            {
                var encodedPassword = Tools.CodeDecode.Encode(txtPass.Text.Trim());
                try
                {
                    var curUser = commB.GetUsuario(txtUser.Text.Trim(), encodedPassword);
                    if (curUser.Any())
                    {
                        foreach (var UsuarioActivo in curUser)
                        {
                            if (UsuarioActivo.Activo == false)
                            {
                                MessageBox.Show("Usuario inactivo. Por favor verifique.");
                                return;
                            }
                            Tools.UserCredentials.UserName = txtUser.Text.Trim();
                            Tools.UserCredentials.UserId = UsuarioActivo.IdUsuario;
                            Tools.UserCredentials.IsAdmin = UsuarioActivo.Role.IsAdmin;
                        }
                        Tools.FormManager.DestroyForm("Main");
                        //#if !DEBUG
                        commB.SaveBitacora("Entrada al sistema Control",
                            false, Tools.UserCredentials.UserId);
                        //#endif
                        var main = new Cursos.Presentation.Forms.Main();
                        main.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o clave incorrectos. Por favor verifique.");
						commB.SaveBitacora("Error en entrada al sistema Control. User text: " + txtUser.Text.Trim() + " Password text: " + txtPass.Text.Trim(),
                            false, 0);
						errorContainer1.Control = txtUser;
                        errorContainer1.Message = "Usuario o clave incorrectos. Por favor verifique.";
                        txtUser.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    CursosBusiness.BusinessHelpers.General.DoError(ex, "Cursos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                txtUser.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
#if DEBUG
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["User"])) txtUser.Text = ConfigurationManager.AppSettings["User"].ToString();
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["Password"])) txtPass.Text = ConfigurationManager.AppSettings["Password"].ToString();
#endif
        }
    }
}
