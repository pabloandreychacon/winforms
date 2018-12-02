using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosBusiness.BusinessHelpers;
using CursosEntities.Entities;

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
	}
}
