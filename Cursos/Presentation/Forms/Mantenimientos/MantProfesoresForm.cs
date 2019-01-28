using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosEntities.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Mantenimientos
{
    public partial class MantProfesoresForm : Maintenance
    {
        CommonB commB = new CommonB();
        public MantProfesoresForm()
        {
            InitializeComponent();
        }

        private void ProfesoresForm_Load(object sender, EventArgs e)
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
					this.profesoreBindingNavigatorSaveItem.Text = "Guardar";
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
            cboDistritos.DataBindings.Add(new Binding("SelectedValue", this.profesoreBindingSource, "IdDistrito", true));

            var cantonesListBind = commB.GetBindList<Cantone>();
            cantonesBindingSource.DataSource = cantonesListBind;
            cboCantones.DataSource = cantonesBindingSource;
            cboCantones.DisplayMember = "Nombre";
            cboCantones.ValueMember = "IdCanton";
            cboCantones.DataBindings.Add(new Binding("SelectedValue", this.profesoreBindingSource, "IdCanton", true));

            var provListBind = commB.GetBindList<Provincia>();
            provinciasBindingSource.DataSource = provListBind;
            cboProvincias.DataSource = provinciasBindingSource;
            cboProvincias.DisplayMember = "Nombre";
            cboProvincias.ValueMember = "IdProvincia";
            cboProvincias.DataBindings.Add(new Binding("SelectedValue", this.profesoreBindingSource, "IdProvincia", true));

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
				&& Validator(apellidoTextBox, ValidationTypes.Text, "Debe digitar un apellido válido."));
        }

        private void profesoreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                cboCantones.SelectedValue = cboListaCantones.SelectedValue;
                cboProvincias.SelectedValue = cboListaProvincias.SelectedValue;
                cboDistritos.SelectedValue = cboListaDistritos.SelectedValue;
                if (!ValidateFields()) return;
                profesoreBindingSource.EndEdit();
                var selectedProfesor = commB.SetEntity<Profesore>(profesoreBindingSource.Current);
                if (selectedProfesor != null) commB.UpdateEntity<Profesore>(selectedProfesor);
                profesoreBindingSource.ResetBindings(true);
				commB.SaveBitacora(this.Name + " Guardado profesor: "+  selectedProfesor.IdProfesor, false, Tools.UserCredentials.UserId);
				lblInfoMessage.Text = "Profesor guardado satisfactoriamente";
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (CursosBusiness.BusinessHelpers.LocalData.searchProfesoresList != null &&
                CursosBusiness.BusinessHelpers.LocalData.searchProfesoresList.Count > 0)
            {
                var searchTable = CursosBusiness.BusinessHelpers.LocalData.searchProfesoresList.AsDataTable(); // transforma en dataTable
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
                var profListBind = commB.GetBindList<Profesore>();//.ToList();

                profesoreBindingSource.DataSource = profListBind;
                profesoreBindingNavigator.BindingSource = profesoreBindingSource;

                if (profListBind.Count > 0)
                {
                    CursosBusiness.BusinessHelpers.LocalData.searchProfesoresList =
                        commB.GetProfesoresSearchDtos(profListBind.ToList());
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var selectedProf = commB.SetEntity<Profesore>(profesoreBindingSource.Current);
            selectedProf.Activo = true;
            activoCheckBox.CheckState = CheckState.Checked;
            nombreTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                profesoreBindingSource.EndEdit();
                var selectedProfe = commB.SetEntity<Profesore>(profesoreBindingSource.Current);
                if (selectedProfe != null)
                {
                    var ce = commB.FindCursoProfesorByIdProfesor(selectedProfe.IdProfesor);
                    if (ce != null)
                    {
                        MessageBox.Show("No se pueden borrar profesores que están relacionados en la tabla de CursosProfesores", 
                            "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        //base.
                        return;
                    }
                    else
                    {
                        commB.DeleteEntity<Profesore>(selectedProfe);
						commB.SaveBitacora(this.Name+"Profesor borrado: "+selectedProfe.IdProfesor, false, Tools.UserCredentials.UserId);
						lblInfoMessage.Text = "Profesor borrado satisfactoriamente";
                        //horarioBindingSource.RemoveCurrent();
                    }
                }
                profesoreBindingSource.ResetBindings(true);
            }
            catch (Exception ex)
            {
                CursosBusiness.BusinessHelpers.General.LogInfo(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void asignaCursoBtn_Click(object sender, EventArgs e)
        {
            if (Tools.FormManager.FindAndOpenForm("ProcHorariosCursosForm")) return;
            var formParent = this.Parent.FindForm();
            var formToShow = new Forms.Procesos.ProcAsignacionCursosForm(false) { MdiParent = formParent };
            formToShow.txtIdProfesor.Text = this.idProfesorTextBox.Text;
            formToShow.txtProfesor.Text = this.nombreTextBox.Text;
            formToShow.CargarCursos();
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

        private void cboTiposIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            setIdMask();
        }

        private void profesoreBindingSource_PositionChanged(object sender, EventArgs e)
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
