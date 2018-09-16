using CursosBusiness.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursosBusiness.BusinessHelpers
{
    public class General
    {
        static CommonB genB = new CommonB();

        public static void DoError(Exception ex, string caption, MessageBoxButtons buttons,
                MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DoErrorExtra(ex, "", caption, buttons, icon, defaultButton);
        }

        public static void DoErrorExtra(Exception ex, string extra, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            var message = "";
            try
            {
                if (ex.InnerException != null)
                {
                    if (!string.IsNullOrEmpty(ex.InnerException.Message))
                        message += ex.InnerException.Message;

                    if ((ex.InnerException).InnerException != null)
                    {
                        if (!string.IsNullOrEmpty((ex.InnerException).InnerException.Message))
                            message += (ex.InnerException).InnerException.Message;
                    }
                }
                message += " " + ex.Message + " " + ex.StackTrace + " " + extra;
                Clipboard.SetText(message);
                MessageBox.Show(message, caption, buttons, icon,
                    defaultButton);

                genB.SaveBitacora(message, true, BaseHelpers.Helpers.Tools.UserCredentials.UserId);

                //EventLogEntryType entry = EventLogEntryType.Error;
                //switch (icon)
                //{
                //    case MessageBoxIcon.Asterisk:
                //        entry = EventLogEntryType.Information;
                //        break;
                //    case MessageBoxIcon.Error:
                //        entry = EventLogEntryType.Error;
                //        break;
                //    case MessageBoxIcon.Exclamation:
                //        entry = EventLogEntryType.Information;
                //        break;
                //    case MessageBoxIcon.None:
                //        entry = EventLogEntryType.Information;
                //        break;
                //    case MessageBoxIcon.Question:
                //        entry = EventLogEntryType.Information;
                //        break;
                //    default:
                //        entry = EventLogEntryType.Information;
                //        break;
                //}
                //if (!EventLog.SourceExists("ControlApp"))
                //    EventLog.CreateEventSource("ControlApp", "Application");

                //EventLog.WriteEntry("ControlApp", message, entry);                    
            }
            catch (Exception exc)
            {
                Clipboard.SetText(exc.Message);
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }

        }
    }
}
