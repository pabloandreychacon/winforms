using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosEntities.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Mantenimientos
{
    public partial class MantEstudiantesForm : Maintenance
    {
        CommonB commB = new CommonB();
        public MantEstudiantesForm()
        {
            InitializeComponent();
        }

        private void EstudiantesForm_Load(object sender, EventArgs e)
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
					this.estudianteBindingNavigatorSaveItem.Text = "Guardar";
					break;
				}
			}
            CargarBusqueda();
			CargarCombos();
        }

		private void CargarCombos()
		{
			var idsListBind = commB.GetBindList<TipoId>();//.ToList();
			tipoIdBindingSource.DataSource = idsListBind;

            var distListBind = commB.GetBindList<Distrito>();
            distritosBindingSource.DataSource = distListBind;
            cboDistritos.DataSource = distritosBindingSource;
            cboDistritos.DisplayMember = "Nombre";
            cboDistritos.ValueMember = "IdDistrito";
            cboDistritos.DataBindings.Add(new Binding("SelectedValue", this.estudianteBindingSource, "IdDistrito", true));

            var cantonesListBind = commB.GetBindList<Cantone>();
            cantonesBindingSource.DataSource = cantonesListBind;
            cboCantones.DataSource = cantonesBindingSource;
            cboCantones.DisplayMember = "Nombre";
            cboCantones.ValueMember = "IdCanton";
            cboCantones.DataBindings.Add(new Binding("SelectedValue", this.estudianteBindingSource, "IdCanton", true));

            var provListBind = commB.GetBindList<Provincia>();
            provinciasBindingSource.DataSource = provListBind;
            cboProvincias.DataSource = provinciasBindingSource;
            cboProvincias.DisplayMember = "Nombre";
            cboProvincias.ValueMember = "IdProvincia";
            cboProvincias.DataBindings.Add(new Binding("SelectedValue", this.estudianteBindingSource, "IdProvincia", true));

            var dist2ListBind = commB.GetBindList<Distrito>();
            cboListaDistritos.DataSource = dist2ListBind;
            cboListaDistritos.DisplayMember = "Nombre";
            cboListaDistritos.ValueMember = "IdDistrito";

            var cant2ListBind = commB.GetBindList<Cantone>();
            cboListaCantones.DataSource = cant2ListBind;
            cboListaCantones.DisplayMember = "Nombre";
            cboListaCantones.ValueMember = "IdCanton";

            var prov2ListBind = commB.GetBindList<Provincia>();
            cboListaProvincias.DataSource = prov2ListBind;
            cboListaProvincias.DisplayMember = "Nombre";
            cboListaProvincias.ValueMember = "IdProvincia";
        }

        public override bool ValidateFields()
        {
            return (Validator(nombreTextBox, ValidationTypes.Text, "Debe digitar un nombre válida.")
				&& Validator(apellidoTextBox, ValidationTypes.Text, "Debe digitar un apellido válido.")
				&& Validator(correoTextBox, ValidationTypes.Email, "Debe digitar un correo válido.")
				//&& Validator(telefonoMaskedTextBox, ValidationTypes.PositiveNumeric, "Debe digitar un teléfono válido.")
				//&& Validator(celularMaskedTextBox, ValidationTypes.PositiveNumeric, "Debe digitar un celular válido.")
				&& Validator(edadNumericUpDown, ValidationTypes.PositiveNumeric, "Debe digitar una edad válida.")
				//&& Validator(identificacionMaskedTextBox, ValidationTypes.PositiveNumeric, "Debe digitar una identificación válida.")
				);
        }

        private void estudianteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                cboCantones.SelectedValue = cboListaCantones.SelectedValue;
                cboProvincias.SelectedValue = cboListaProvincias.SelectedValue;
                cboDistritos.SelectedValue = cboListaDistritos.SelectedValue;
                if (!ValidateFields()) return;
                estudianteBindingSource.EndEdit();
                var selectedEstudiante = commB.SetEntity<Estudiante>(estudianteBindingSource.Current);
                if (selectedEstudiante != null) commB.UpdateEntity<Estudiante>(selectedEstudiante);
                estudianteBindingSource.ResetBindings(true);
				commB.SaveBitacora(this.Name + " Guardado estudiante: "+ selectedEstudiante.IdEstudiante, false, Tools.UserCredentials.UserId);
				lblInfoMessage.Text = "Estudiante guardado satisfactoriamente";
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (CursosBusiness.BusinessHelpers.LocalData.searchEstudiantesList != null &&
                CursosBusiness.BusinessHelpers.LocalData.searchEstudiantesList.Count > 0)
            {
                var searchTable = CursosBusiness.BusinessHelpers.LocalData.searchEstudiantesList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, OrderKeys, "Id");
                searchForm.ShowDialog();
                this.bindingNavigatorPositionItem.Text = searchForm.SelectedKey;
                this.bindingNavigatorPositionItem.Focus();
                this.btnFind.Focus();
            }
        }

        private void CargarBusqueda()
        {
            try
            {
                var estudListBind = commB.GetBindList<Estudiante>();//.ToList();

                estudianteBindingSource.DataSource = estudListBind;
                estudianteBindingNavigator.BindingSource = estudianteBindingSource;

                if (estudListBind.Count > 0)
                {
                    CursosBusiness.BusinessHelpers.LocalData.searchEstudiantesList =
                        commB.GetEstudiantesSearchDtos(estudListBind.ToList());
                }
                else
                {
                    btnFind.Enabled = false;
                }
				var currTipo = commB.SetEntity<TipoId>(tipoIdBindingSource.Current);
				if (currTipo != null) identificacionMaskedTextBox.Mask = currTipo.Mask;
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //activoCheckBox.Checked = true;
            var selectedEst = commB.SetEntity<Estudiante>(estudianteBindingSource.Current);
            selectedEst.Activo = true;
            activoCheckBox.CheckState = CheckState.Checked;
            nombreTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                estudianteBindingSource.EndEdit();
                var selectedEst = commB.SetEntity<Estudiante>(estudianteBindingSource.Current);
                if (selectedEst != null)
                {
                    var ce = commB.FindCursoEstudianteByIdEstudiante(selectedEst.IdEstudiante);
                    if (ce != null)
                    {
                        MessageBox.Show("No se pueden borrar estudiantes que están relacionados en la tabla de CursosEstudiantes", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        //base.
                        return;
                    }
                    else
                    {
                        commB.DeleteEntity<Estudiante>(selectedEst);
						commB.SaveBitacora(this.Name+"Estudiante borrado: "+selectedEst.IdEstudiante, false, Tools.UserCredentials.UserId);
						lblInfoMessage.Text = "Estudiante borrado satisfactoriamente";
                        //horarioBindingSource.RemoveCurrent();
                    }
                }
                estudianteBindingSource.ResetBindings(true);
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void asignaCursoBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcEstudiantesCursosForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Procesos.ProcEstudiantesCursosForm() { MdiParent = formParent };
            formToShow.txtIdEstudiante.Text = this.idEstudianteTextBox.Text;
            formToShow.txtEstudiante.Text = this.nombreTextBox.Text;
            this.closeButton1.PerformClick();
            formToShow.Show();
        }

        private void creaCursoBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("MantCursosForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Mantenimientos.MantCursosForm() { MdiParent = formParent };
            this.closeButton1.PerformClick();
            formToShow.Show();
            formToShow.bindingNavigatorAddNewItem.PerformClick();
        }

		private void setIdMask()
		{
            var selectedTipo = cboTiposIds.SelectedValue;
            if (selectedTipo == null) return;
            selectedTipo.ToString();
            var selectedMask = commB.GetTipoIdMaskByTipoId(Convert.ToInt32(selectedTipo));
            if (selectedMask != null)
            {
                identificacionMaskedTextBox.Mask = selectedMask;
                identificacionMaskedTextBox.Focus();
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var selectedCantones = commB.FindCantonByIdProvincia(Convert.ToInt32(cboProvincia.SelectedValue));
            //cantonesBindingSource.DataSource = selectedCantones;
        }

        private void cboCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var selectedDistritos = commB.FindDistritoByIdCanton(Convert.ToInt32(cboCanton.SelectedValue));
            //distritosBindingSource.DataSource = selectedDistritos;
        }

        private void cboTiposIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            setIdMask();
            
        }

        private void estudianteBindingSource_PositionChanged(object sender, EventArgs e)
        {
            setIdMask();
            if (cboProvincias.SelectedValue != null)
                cboListaProvincias.SelectedValue = cboProvincias.SelectedValue;
            
            if (cboCantones.SelectedValue != null)
                cboListaCantones.SelectedValue = cboCantones.SelectedValue;

            if (cboDistritos.SelectedValue != null)
                cboListaDistritos.SelectedValue = cboDistritos.SelectedValue;
        }

        private void cboListaProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboListaProvincias.SelectedValue == null || cboListaProvincias.SelectedValue.GetType() != typeof(int)) return;
            var selectedCantones = commB.FindCantonByIdProvincia(Convert.ToInt32(cboListaProvincias.SelectedValue.ToString()));
            cboListaCantones.DataSource = selectedCantones;

        }

        private void cboListaCantones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboListaCantones.SelectedValue == null || cboListaCantones.SelectedValue.GetType() != typeof(int)) return;
            var selectedDistritos = commB.FindDistritoByIdCanton(Convert.ToInt32(cboListaCantones.SelectedValue.ToString()));
            cboListaDistritos.DataSource = selectedDistritos;
        }
    }
}
