using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosBusiness.BusinessHelpers;
using CursosEntities.Dtos;
using CursosEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cursos.Presentation.Forms.Procesos
{
    public partial class ProcCerrarCursosForm : Basic
    {
        CommonB commB = new CommonB();
        List<CursosDtos.CursosProfesorCerrarList> cp;
        public ProcCerrarCursosForm()
        {
            InitializeComponent();
        }

        private void btnBuscaProfesor_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (LocalData.searchProfesoresList != null &&
                LocalData.searchProfesoresList.Count > 0)
            {
                var searchTable = LocalData.searchProfesoresList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Nombre,Identific,Correo", "Key");
                searchForm.ShowDialog();
                if (searchForm.SelectedKey != null)
                {
                    var curKey = Convert.ToInt32(searchForm.SelectedKey);
                    var profe = commB.FindProfesorById(curKey);
                    if (profe != null)
                    {
                        txtIdProfesor.Text = profe.IdProfesor.ToString();
                        txtProfesor.Text = profe.Nombre;
                    }
                }
            }
            CargarCursos();
        }

        private void CargarCursos()
        {
            gvCursosAsignados.DataSource = null;
            if (!string.IsNullOrEmpty(txtIdProfesor.Text.Trim()))
            {
                cp = commB.GetCursosProfesorCerrarDtos(Convert.ToInt32(txtIdProfesor.Text.Trim()));
                if (cp.Count() > 0 && cp != null)
                {
                    gvCursosAsignados.DataSource = cp;
                    for (int i = 0; i < gvCursosAsignados.Columns.Count; i++)
                    {
                        //gridResults.Columns[i].Width = ColumnSizesArray[i];
                        gvCursosAsignados.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                    gvCursosAsignados.Columns["Id"].ReadOnly = true;
                    gvCursosAsignados.Columns["Descrip"].ReadOnly = true;
                    gvCursosAsignados.Columns["Codigo"].ReadOnly = true;
                    //gvEstudiantes.Columns["Fecha"].Visible = false;

                }
            }
        }

        private void CargarBusqueda()
        {
            try
            {
                var profList = commB.GetList<Profesore>().Where(p => p.Activo).ToList();
                if (profList.Count() > 0)
                {
                    LocalData.searchProfesoresList =
                        commB.GetProfesoresSearchDtos(profList);
                }
                else
                {
                    btnBuscaProfesor.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            var hayCerrar = (from a in cp
                                where a.Cerrar
                                select a).Count();
            if (hayCerrar > 0)
            {
                foreach (CursosDtos.CursosProfesorCerrarList item in cp)
                {
                        if (item.Cerrar)
                        {
                            try
                            {
                                var curp = commB.FindCursoProfesorByIdCursoHorarioIdProfesor(item.IdCursosHorarios,
                                    Convert.ToInt32(txtIdProfesor.Text));
                                curp.Activo = false;
                                commB.UpdateEntity<CursosProfesor>(curp);
                            }
                            catch (Exception ex)
                            {
                                General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        }                    
                }
                CargarCursos();
                MessageBox.Show("Proceso terminado", "Cerrar Cursos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Debe marcar al menos un curso a cerrar", "Cerrar Cursos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
