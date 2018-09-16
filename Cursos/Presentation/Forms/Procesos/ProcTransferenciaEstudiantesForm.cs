using BaseForms.Forms;
using BaseHelpers.Helpers;
using CursosBusiness.Business;
using CursosBusiness.BusinessHelpers;
using CursosEntities.Entities;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using CursosEntities.Dtos;

namespace Cursos.Presentation.Forms.Procesos
{
    public partial class ProcTransferenciaEstudiantesForm : Basic
    {
        CommonB commB = new CommonB();
        public ProcTransferenciaEstudiantesForm()
        {
            InitializeComponent();
        }

        private void btnBuscarCursoOrigen_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (LocalData.searchCursosHorariosList != null &&
                LocalData.searchCursosHorariosList.Count > 0)
            {
                var searchTable = LocalData.searchCursosHorariosList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Descrip", "Key");
                searchForm.ShowDialog();
                if (searchForm.SelectedKey != null)
                {
                    var curKey = Convert.ToInt32(searchForm.SelectedKey);
                    var curso = commB.FindCursoHorarioByIdCursosHorarios(curKey);
                    if (curso != null)
                    {
                        txtIdCursoOrigen.Text = curso.IdCurso.ToString();
                        txtDescripcionCursoOrigen.Text = curso.Curso.Descripcion;
                        txtIdCursoHorarioOrigen.Text = curso.IdCursosHorarios.ToString();
                    }
                }
            }
            CargarCursos(true, txtIdCursoHorarioOrigen.Text);
        }

        private void CargarCursos(bool origen, string idCursoHorario)
        {
            if (!string.IsNullOrEmpty(idCursoHorario))
            {
                var ec = commB.GetEstudiantesCursoList(Convert.ToInt32(idCursoHorario.Trim()));
                if (ec.Count() > 0 && ec != null)
                {
                    if (origen)
                    {
                        lstOrigen.DataSource = ec;
                        lstOrigen.DisplayMember = "Estudiante";
                        lstOrigen.ValueMember = "Id";

                        //lstEstudiantesOrigen.Items.Clear();
                        //int i = 0;
                        //foreach (var item in ec)
                        //{
                        //    ///http://www.c-sharpcorner.com/UploadFile/9a3ae2/using-listview-control-windows-form-application3/
                        //    ///
                        //    lstEstudiantesOrigen.Items.Add(item.Descrip.ToString());
                        //    //lstEstudiantesOrigen.Items[i].SubItems.Add(item.Fecha.ToString());
                        //    //lstEstudiantesOrigen.Items[i].SubItems.Add(item.Caja.ToString());
                        //    //lstEstudiantesOrigen.Items[i].SubItems.Add(item.Cajero.ToString());
                        //    //lstEstudiantesOrigen.Items[i].SubItems.Add(String.Format("{0:C}", item.Total));
                        //    //total += Convert.ToDouble(item.Total);
                        //    i += 1;
                        //}
                        //for (int i = 0; i < gvCursosAsignados.Columns.Count; i++)
                        //{
                        //    //gridResults.Columns[i].Width = ColumnSizesArray[i];
                        //    gvCursosAsignados.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        //}
                    }
                    else
                    {
                        //lstEstudiantesDestino.Items.Clear();
                        //lstEstudiantesDestino.Items.AddRange(ec.ToArray());
                        lstDestino.DataSource = ec;
                        lstDestino.DisplayMember = "Estudiante";
                        lstDestino.ValueMember = "Id";
                    }
                }
                else
                {
                    if (origen) lstOrigen.DataSource = null;
                    if (!origen) lstDestino.DataSource = null;
                }
            }
            //throw new NotImplementedException();
        }     

        private void btnBuscarCursoDestino_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
            if (LocalData.searchCursosHorariosList != null &&
                LocalData.searchCursosHorariosList.Count > 0)
            {
                var searchTable = LocalData.searchCursosHorariosList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, "Descrip", "Key");
                searchForm.ShowDialog();
                if (searchForm.SelectedKey != null)
                {
                    var curKey = Convert.ToInt32(searchForm.SelectedKey);
                    var curso = commB.FindCursoHorarioByIdCursosHorarios(curKey);
                    if (curso != null)
                    {
                        if(txtIdCursoOrigen.Text.Trim().Equals(curso.IdCurso.ToString().Trim()) && 
                           txtIdCursoHorarioOrigen.Text.Trim().Equals(curso.IdCursosHorarios.ToString().Trim() ))
                        {
                            MessageBox.Show("Es curso destino no puede ser igual al curso de origen", "Transferir", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            txtIdCursoDestino.Text = "";
                            txtDescripcionCursoDestino.Text = "";
                            txtCursoHorarrioDestino.Text = "";
                        }
                        else
                        {
                            txtIdCursoDestino.Text = curso.IdCurso.ToString();
                            txtDescripcionCursoDestino.Text = curso.Curso.Descripcion;
                            txtCursoHorarrioDestino.Text = curso.IdCursosHorarios.ToString();
                        }
                    }
                }
            }
            CargarCursos(false, txtCursoHorarrioDestino.Text);
        }
        private void CargarBusqueda()
        {
            try
            {
                var cursList = commB.GetList<Curso>().Where(c => c.Activo).ToList();
                if (cursList.Count() > 0)
                {
                    LocalData.searchCursosHorariosList =
                        commB.GetCursosHorarioSearchDtos();
                }
                else
                {
                    btnBuscarCursoDestino.Enabled = false;
                    btnBuscarCursoOrigen.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void lstOrigen_DoubleClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdCursoOrigen.Text.Trim()) && !string.IsNullOrEmpty(txtIdCursoDestino.Text.Trim()))
            {
                //string stritem;
                foreach (CursosDtos.CursosEstudiantesList item in lstOrigen.SelectedItems)
                {

                    var ce = commB.FindCursoEstudianteByIdCursoAndIdEstudiante(Convert.ToInt32(txtCursoHorarrioDestino.Text.Trim()), item.IdEstudiante);
                    if (ce != null)
                    {
                        MessageBox.Show("El estudiante " + item.Estudiante + " ya existe en el curso destino", "Transferir",
                                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        try
                        {
                            //stritem = item.Estudiante;
                            //System.Diagnostics.Debug.WriteLine(stritem);
                            //var curHor = commB.GetCursosHorariosByIdCurso(Convert.ToInt32(txtIdCursoDestino.Text));
                            commB.SaveCursoEstudiante(Convert.ToInt32(txtIdCursoDestino.Text.Trim()),
                                item.IdEstudiante, Convert.ToInt32(txtCursoHorarrioDestino.Text.Trim()));
                        }
                        catch (Exception ex)
                        {
                            General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }                                                
                    }
                }
                CargarCursos(true, txtIdCursoHorarioOrigen.Text);
                CargarCursos(false, txtCursoHorarrioDestino.Text);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un curso de origen y un curso destino", "Transferir",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        
    }
}
