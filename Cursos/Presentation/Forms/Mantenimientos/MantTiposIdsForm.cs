﻿using BaseForms.Forms;
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
	}
}