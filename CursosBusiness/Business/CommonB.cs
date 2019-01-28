using BaseHelpers.Helpers;
using CursosData.DataRepository;
using CursosEntities.Dtos;
using CursosEntities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CursosBusiness.Business
{
    public class CommonB
    {
        private CommonR commonR;
        public CommonB()
        {
            commonR = new CommonR();
        }

        public CommonB(CommonR commonRepo)
        {
            commonR = commonRepo;
        }

        public void BeginTran()
        {
            commonR.BeginTran();
        }

        public void Commit()
        {
            commonR.Commit();
        }

        public void Rollback()
        {
            commonR.Rollback();
        }
        public int ExecuteSql(string sql)
        {
            return commonR.ExecuteSql(sql);
        }
        public string GetConnection()
        {
            return commonR.GetConnection();
        }
        public void Reload<E>(E entity) where E : class
        {
            commonR.ReloadEntity(entity);
        }
        public void Refresh<E>(E entity) where E : class
        {
            commonR.Refresh(entity);
        }
        public E SetEntity<E>(object obj) where E : class
        {
            return commonR.SetEntity<E>(obj);
        }

        public void AddEntity<E>(E entity) where E : class
        {
            commonR.AddEntity<E>(entity);
        }

        public void CreateEntity<E>(E entity) where E : class
        {
            commonR.CreateEntity<E>(entity);
        }

        public void UpdateEntity<E>(Object objProd) where E : class
        {
            var curProd = commonR.SetEntity<E>(objProd);
            try
            {
                commonR.UpdateEntity(curProd);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void DeleteEntity<E>(E entity) where E : class
        {
            try
            {
                commonR.DeleteEntity<E>(entity);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public IEnumerable<E> GetList<E>() where E : class
        {
            return commonR.GetList<E>();
        }

        public BindingList<E> GetBindList<E>() where E : class
        {
            return commonR.GetBindList<E>();
        }

        #region tipos id
        public String GetTipoIdMaskByTipoId(int idtipo)
        {
            return commonR.GetTipoIdMaskByTipoId(idtipo);
        }
        #endregion
        #region usuarios
        public IEnumerable<Usuario> GetUsuario(string name, string pass)
        {
            // ejemplo de BLL rules
            // el try catch debe estar en la capa de presentacion
            // tambien puede haber validacion en la presentacion layer
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(pass))
            {
                var newListUsuario = new List<Usuario>();
                var newUsuario = new Usuario()  {  
                    Activo = false, 
                    IdRole = 0,
                    Clave = "",
                    Consultas = false,
                    IdUsuario = 0,
                    Mantenimientos = false,
                    Nombre = "",
                    Procesos = false,
                    Seguridad = false
                     };
                     newListUsuario.Add(newUsuario);
                return newListUsuario;
            }
            return commonR.GetUsuario(name, pass);
        }
        public IEnumerable<Usuario> GetUsuarioById(int id)
        {
            return commonR.GetUsuarioById(id);
        }
        public List<CursosDtos.UsuariosListSearch> GetUsuariosSearchDtos(List<Usuario> usuList)
        {
            return commonR.GetUsuariosSearchDtos(usuList);
        }
        #endregion

		#region aulas
        //public IEnumerable<Aula> GetAulaById(int id)
        //{
        //    return commonR.GetUsuarioById(id);
        //}
		public String GetAulaNameFromId(int id)
		{
			return commonR.GetAulaNameFromId(id);
		}
        public List<CursosDtos.AulasListSearch> GetAulasSearchDtos(List<Aula> aulList)
        {
            return commonR.GetAulasSearchDtos(aulList);
        }
		public Aula FindAulaById(int idAula)
        {
            return commonR.FindAulaById(idAula);
        }
        #endregion

        #region bitacora
        public void SaveBitacora(string descripcion, bool isError, int userId)
        {
            try
            {
                commonR.SaveBitacora(descripcion, isError, userId);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
        public Bitacora FindBitacoraByIdUsuario(int idusuario)
        {
            return commonR.FindBitacoraByIdUsuario(idusuario);
        }
        #endregion

        #region cursoshorarios
		//public IEnumerable<CursosDtos.DiasHorariosList> getDayName(int intDay)
  //      {
  //          return commonR.GetCursosHorariosByIdHorarioList(idHorario);
  //      }
        public IEnumerable<CursosHorario> GetCursosHorariosByIdHorarioList(int idHorario)
        {
            return commonR.GetCursosHorariosByIdHorarioList(idHorario);
        }
		public IEnumerable<CursosDtos.DiasHorariosList> GetDiasHorarios()
        {
            return commonR.GetDiasHorariosList();
        }
        public CursosHorario FindCursosHorariosByIdCurso(int idcurso)
        {
            return commonR.FindCursosHorariosByIdCurso(idcurso);
        }
        public IEnumerable<CursosHorario> GetCursosHorariosByIdCursoList(int idcurso)
        {
            return commonR.GetCursosHorariosByIdCursoList(idcurso);
        }
        public CursosHorario FindCursohorarioByIdCursoAndIdhorario(int idcurso, int idhorario)
        {
            return commonR.FindCursoHorarioByIdCursoAndIdhorario(idcurso, idhorario);
        }
		public CursosHorario FindCursoHorarioByIdCursoAndIdhorarioAndIdAulaAndIdDia(int idcurso, int idhorario, int 
			idaula, int iddia)
        {
            return commonR.FindCursoHorarioByIdCursoAndIdhorarioAndIdAulaAndIdDia(idcurso, idhorario, idaula, iddia);
        }
        public CursosHorario FindCursoHorarioByIdCursosHorarios(int idcursohorario)
        {
            return commonR.FindCursoHorarioByIdCursosHorarios(idcursohorario);
        }
        public void SaveCursoHorario(int idcurso, int idhorario)
        {
            commonR.SaveCursoHorario(idcurso, idhorario);
        }
		public void SaveCursoHorarioAulaDia(int idcurso, int idhorario, int idaula, int iddia)
        {
            commonR.SaveCursoHorarioAulaDia(idcurso, idhorario, idaula, iddia);
        }
        public CursosHorario FindCursoHorarioByIdAula(int idaul)
        {
            return commonR.FindCursoHorarioByIdAula(idaul);
        }
        #endregion cursoshorarios

        #region cursos
        public Curso FindCursoById(int idCurso)
        {
            return commonR.FindCursoById(idCurso);
        }
        public List<CursosDtos.CursosListSearch> GetCursosSearchDtos(List<Curso> cursoList)
        {
            return commonR.GetCursosSearchDtos(cursoList);
        }
        public List<CursosDtos.CursosHorarioListSearch> GetCursosHorarioSearchDtos()
        {
            return commonR.GetCursosHorariosSearchDtos();
        }
        #endregion

        #region provincias, cantones, distritos
        public IEnumerable<Cantone> FindCantonByIdProvincia(int idprov)
        {
            return commonR.FindCantonByIdProvincia(idprov);
        }

		public IEnumerable<Distrito> FindDistritoByIdCanton(int idcant)
        {
            return commonR.FindDistritoByIdCanton(idcant);
        }
		#endregion

		#region estudiantes
		public List<CursosDtos.EstudiantesListSearch> GetEstudiantesSearchDtos(List<Estudiante> estudList)
        {
            return commonR.GetEstudiantesSearchDtos(estudList);
        }
        public Estudiante FindEstudianteById(int idestudiante)
        {
            return commonR.FindEstudianteById(idestudiante);
        }
        #endregion

        #region profesores
        public List<CursosDtos.ProfesoresListSearch> GetProfesoresSearchDtos(List<Profesore> profList)
        {
            return commonR.GetProfesoresSearchDtos(profList);
        }
        public Profesore FindProfesorById(int idProfe)
        {
            return commonR.FindProfesorById(idProfe);
        }
        public List<Profesore> GetProfesorByIdCurso(int idcurso, int idhorario)
        {
            return commonR.GetProfesorByIdCurso(idcurso, idhorario);
        }
        #endregion

        #region horarios
        public IEnumerable<Horario> GetHorarioById(int idHorario) 
        {
            return commonR.GetHorarioById(idHorario);
        }
        public List<CursosDtos.HorariosListSearch> GetHorariosSearchDtos(List<Horario> estudList)
        {
            return commonR.GetHorariosSearchDtos(estudList);
        }
        public Horario FindHorarioById(int idhorario)
        {
            return commonR.FindHorarioById(idhorario);
        }
        public List<CursosDtos.HorariosListSearch> GetHorariosList(int idcurso)
        {
            return commonR.GetHorariosList(idcurso);
        }
        public List<Horario> GetHorarioByIdCurso(int idcurso)
        {
            return commonR.GetHorarioByIdCurso(idcurso);
        }
        #endregion

        #region cursosProfesor
        public List<CursosDtos.CursosProfesorList> GetCursosProfesorDtos(int idProfesor)
        {
            return commonR.GetCursosProfesorDtos(idProfesor);
        }
        public List<CursosDtos.CursosProfesorCerrarList> GetCursosProfesorCerrarDtos(int prof)
        {
            return commonR.GetCursosProfesorCerrarDtos(prof);
        }
        public void SaveCursoProfesor(int idcurso, int idprofesor, bool activo, DateTime fechainicio,
            DateTime fechafinal, int ausencias)
        { 
            commonR.SaveCursoProfesor(idcurso, idprofesor, activo, fechainicio, fechafinal, ausencias);
        }
        public IEnumerable<CursosProfesor> GetCursoProfesorByIdCursoList(int idCurso)
        {
            return commonR.GetCursoProfesorByIdCursoList(idCurso);
        }
        public CursosProfesor FindCursoProfesorByIdCursoProfesor(int idcursohorario, int idprofesor)
        {
            return commonR.FindCursoProfesorByIdCursoProfesor(idcursohorario, idprofesor);
        }
        public List<CursosProfesor> GetCursoProfesorByIdCursoHorarioIdProfesor(int idcursohorario, int idprofesor)
        {
            return commonR.GetCursoProfesorByIdCursoHorarioIdProfesor(idcursohorario, idprofesor);
        }
        public CursosProfesor FindCursoProfesorByIdCursoHorario(int idcursohorario)
        {
            return commonR.FindCursoProfesorByIdCursoHorario(idcursohorario);
        }
        public CursosProfesor FindCursoProfesorByIdCurso(int idcurso)
        {
            return commonR.FindCursoProfesorByIdCurso(idcurso);
        }
        public CursosProfesor FindCursoProfesorByIdProfesor(int idprofesor)
        {
            return commonR.FindCursoProfesorByIdProfesor(idprofesor);
        }
        public CursosProfesor FindCursoProfesorByIdCursoHorarioIdProfesor(int idcursohorario, int idprofesor)
        {
            return commonR.FindCursoProfesorByIdCursoHorarioIdProfesor(idcursohorario, idprofesor);
        }
        #endregion

        #region cursosestudiantes
        public List<CursosDtos.CursosEstudiantesList> GetEstudiantesCursoList(int idcursohorario)
        {
            return commonR.GetEstudiantesCursoList(idcursohorario);
        }
        public CursosEstudiante FindCursoEstudianteByIdCursoAndIdEstudiante(int idcursohorario, int idestudiante)
        {
            return commonR.FindCursoEstudianteByIdCursoAndIdEstudiante(idcursohorario, idestudiante);
        }
        public CursosEstudiante FindCursoEstudianteByIdCurso(int idcurso)
        {
            return commonR.FindCursoEstudianteByIdCurso(idcurso);
        }
        public CursosEstudiante FindCursoEstudianteByIdUsuario(int idusuario)
        {
            return commonR.FindCursoEstudianteByIdUsuario(idusuario);
        }
        public CursosEstudiante FindCursoEstudianteByIdEstudiante(int idestudiante)
        {
            return commonR.FindCursoEstudianteByIdEstudiante(idestudiante);
        }
        public void SaveCursoEstudiante(int idcurso, int idestudiante, int idcursoshorarios)
        {
            commonR.SaveCursoEstudiante(idcurso, idestudiante, idcursoshorarios, Tools.UserCredentials.UserId);
        }
        public List<CursosDtos.CursosEstudiantesList> GetCursosEstudiantesList(int idcursohorario)
        {
            return commonR.GetCursosEstudiantesList(idcursohorario);
        }
        #endregion

        #region ausencias
        public List<CursosDtos.AusenciasEstudiantesList> GetAusenciasEstudiantesDtos(int idcurso, int idcursoshorarios)
        {
            return commonR.GetAusenciasEstudiantesDtos(idcurso, idcursoshorarios);
        }
        public void SaveAusencia(int cursoestudiante, bool ausente, DateTime fecha)
        {
            try
            {
                commonR.SaveAusencia(cursoestudiante, ausente, fecha);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Ausencia> GetAusencias(int cursoestudiante, DateTime fecha) 
        {
            return commonR.GetAusencias(cursoestudiante, fecha);
        }
        public List<CursosDtos.AusenciasCursoList> GetAusenciasCursoDtos(int idcurso, int idcursoshorarios, DateTime fecha)
        {
            return commonR.GetAusenciasCursoDtos(idcurso, idcursoshorarios, fecha);
        }
        public Ausencia FindAusenciaCursoByIdAusencia(int idau)
        {
            return commonR.FindAusenciaCursoByIdAusencia(idau);
        }

        #endregion

        #region reportes
        public IEnumerable<CursosDtos.ReporteCursosList> ReporteCursosDtos()
        {
            return commonR.ReporteCursosDtos();
        }
        public IEnumerable<Estudiante> ReporteEstudiantes()
        {
            return commonR.ReporteEstudiantes();
        }
        public IEnumerable<Profesore> ReporteProfesores()
        {
            return commonR.ReporteProfesores();
        }
        public object ReporteCursosA()
        {
            return commonR.ReporteCursosA();
        }
        public IEnumerable<CursosDtos.ReporteAusenciasList> ReporteAusenciasDtos()
        {
            return commonR.ReporteAusenciasDtos();
        }
        #endregion
    }
}
