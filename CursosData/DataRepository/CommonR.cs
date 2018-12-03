using CursosEntities.Dtos;
using CursosEntities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosData.DataRepository
{
    public class CommonR : CursosData.DataRepository.Abstract.CursosBase
    {
        public CommonR()
        {
        }

        public CommonR(CursosEntity passedCtx) : base(passedCtx)
        {
        }

        #region usuarios
        public IEnumerable<Usuario> GetUsuario(string name, string pass)
        {
            
            return dbCtx.Usuarios.Where(u => u.Nombre == name && u.Clave == pass).Take(1).ToList();
        }        
        public IEnumerable<Usuario> GetUsuarioById(int id)
        {
            return dbCtx.Usuarios.Where(u => u.IdUsuario == id).Take(1).ToList();
        }
        public List<CursosDtos.UsuariosListSearch> GetUsuariosSearchDtos(List<Usuario> cursosList)
        {
            var localList = new List<CursosDtos.UsuariosListSearch>();
            for (int i = 0; i < cursosList.Count; i++)
            {
                localList.Add(new CursosDtos.UsuariosListSearch
                {
                    Id = i + 1,                    
                    Nombre = cursosList[i].Nombre
                });
            }
            return localList;
        }
		#endregion

		#region aulas
		public List<CursosDtos.AulasListSearch> GetAulasSearchDtos(List<Aula> aulasList)
        {
            var localList = new List<CursosDtos.AulasListSearch>();
            for (int i = 0; i < aulasList.Count; i++)
            {
                localList.Add(new CursosDtos.AulasListSearch
                {
                    Id = i + 1,                    
                    Nombre = aulasList[i].Descripcion
                });
            }
            return localList;
        }
		#endregion

		#region bitacora
		public void SaveBitacora(string descripcion, bool isError, int userId)
        {
            var NewBitacoraRecord = new Bitacora
            {
                IdUsuario = userId,
                Descripcion = descripcion,
                Fecha = DateTime.Now,
                Error = isError
            };
            try
            {
                dbCtx.Bitacoras.Add(NewBitacoraRecord);
                dbCtx.SaveChanges();
            }
            catch (Exception)
            {
                ReloadEntity(NewBitacoraRecord);
                throw;
            }
        }
        public Bitacora FindBitacoraByIdUsuario(int idusuario)
        {
            var curest = from ce in dbCtx.Bitacoras
                         where ce.IdUsuario == idusuario
                         select ce;
            return curest.FirstOrDefault();
        }
        #endregion

        #region CursosHorarios
        public IEnumerable<CursosHorario> GetCursosHorariosByIdHorarioList(int idHorario)
        {
            return dbCtx.CursosHorarios.Where(p => p.IdHorario == idHorario).ToList();
        }
        public IEnumerable<CursosHorario> GetCursosHorariosByIdCursoList(int idCurso)
        {
            return dbCtx.CursosHorarios.Where(p => p.IdCurso == idCurso).ToList();
        }
        public CursosHorario FindCursosHorariosByIdCurso(int idCurso)
        {
            return dbCtx.CursosHorarios.Where(p => p.IdCurso == idCurso)
                .FirstOrDefault();
        }
        public CursosHorario FindCursoHorarioByIdCursoAndIdhorario(int idcurso, int idhorario)
        {
            var curest = from ce in dbCtx.CursosHorarios
                         where ce.IdCurso == idcurso && ce.IdHorario == idhorario
                         select ce;
            return curest.FirstOrDefault();
        }
        public CursosHorario FindCursoHorarioByIdCursosHorarios(int idcursohorario)
        {
            var curhor = from ce in dbCtx.CursosHorarios
                         where ce.IdCursosHorarios == idcursohorario
                         select ce;
            return curhor.FirstOrDefault();
        }
        public void SaveCursoHorario(int idcurso, int idhorario)
        {
            var NewCursoHorarioRecord = new CursosHorario
            {
                IdCurso = idcurso,
                IdHorario = idhorario,
                Fecha = DateTime.Now,
            };
            try
            {
                dbCtx.CursosHorarios.Add(NewCursoHorarioRecord);
                dbCtx.SaveChanges();
            }
            catch (Exception)
            {
                ReloadEntity(NewCursoHorarioRecord);
                throw;
            }
        }
        #endregion

        #region cursos
        public List<CursosDtos.CursosListSearch> GetCursosSearchDtos(List<Curso> cursosList)
        {
            var localList = new List<CursosDtos.CursosListSearch>();
            for (int i = 0; i < cursosList.Count; i++)
            {
                localList.Add(new CursosDtos.CursosListSearch
                {
                    Id = i + 1,                    
                    Descrip = cursosList[i].Descripcion,
                    Activo = cursosList[i].Activo,
                    Key = cursosList[i].IdCurso
                });
            }
            return localList;
        }
        public List<CursosDtos.CursosHorarioListSearch> GetCursosHorariosSearchDtos()
        {
            var cursosList = (from c in dbCtx.Cursos
                              join ch in dbCtx.CursosHorarios on c.IdCurso equals ch.IdCurso
                              join cp in dbCtx.CursosProfesors on ch.IdCursosHorarios equals cp.IdCursosHorarios into JoinedCP
                              from cp in JoinedCP.DefaultIfEmpty()
                              join h in dbCtx.Horarios on ch.IdHorario equals h.IdHorario into JoinedH
                              from h in JoinedH.DefaultIfEmpty()
                              where cp.Activo
                              select new { 
                                  c.Descripcion, 
                                  c.Activo, 
                                  ch.IdCursosHorarios, 
                                  Horario = h.Descripcion 
                              }
                              ).ToList();
            var localList = new List<CursosDtos.CursosHorarioListSearch>();
            for (int i = 0; i < cursosList.Count; i++)
            {
                localList.Add(new CursosDtos.CursosHorarioListSearch
                {
                    Id = i + 1,
                    Descrip = cursosList[i].Descripcion,
                    Activo = cursosList[i].Activo,
                    Key = cursosList[i].IdCursosHorarios,
                    Horario = cursosList[i].Horario
                });
            }
            return localList;
        }
        public Curso FindCursoById(int idCurso)
        {
            return dbCtx.Cursos.FirstOrDefault(p => p.IdCurso == idCurso);
        }
		public Curso FindCursoByIdAula(int idaul)
        {
            return dbCtx.Cursos.FirstOrDefault(p => p.IdAula == idaul);
        }
		#endregion

		#region provincias, cantones, distritos
		public IEnumerable<Cantone> FindCantonByIdProvincia(int idprov)
        {
            return dbCtx.Cantones.Where(p => p.IdProvincia == idprov).ToList();
        }
		#endregion

		#region estudiantes
		public List<CursosDtos.EstudiantesListSearch> GetEstudiantesSearchDtos(List<Estudiante> cursosList)
        {
            var localList = new List<CursosDtos.EstudiantesListSearch>();
            for (int i = 0; i < cursosList.Count; i++)
            {
                localList.Add(new CursosDtos.EstudiantesListSearch
                {
                    Id = i + 1,
                    Identific = cursosList[i].Identificacion,
                    Nombre = cursosList[i].Nombre,
                    Activo = cursosList[i].Activo,
                    Key = cursosList[i].IdEstudiante
                });
            }
            return localList;
        }
        public Estudiante FindEstudianteById(int idestudiante)
        {
            return dbCtx.Estudiantes.FirstOrDefault(p => p.IdEstudiante == idestudiante);
        }
        #endregion

        #region profesores
        public List<CursosDtos.ProfesoresListSearch> GetProfesoresSearchDtos(List<Profesore> cursosList)
        {
            var localList = new List<CursosDtos.ProfesoresListSearch>();
            for (int i = 0; i < cursosList.Count; i++)
            {
                localList.Add(new CursosDtos.ProfesoresListSearch
                {
                    Id = i + 1,
                    Identific = cursosList[i].Identificacion,
                    Nombre = cursosList[i].Nombre,
                    Correo = cursosList[i].Correo,
                    Key = cursosList[i].IdProfesor
                });
            }
            return localList;
        }
        public Profesore FindProfesorById(int idProfe)
        {
            return dbCtx.Profesores.FirstOrDefault(p => p.IdProfesor == idProfe);
        }
        public List<Profesore> GetProfesorByIdCurso(int idcurso, int idhorario)
        {
            var queryJoin = from p in dbCtx.Profesores
                            from cp in dbCtx.CursosProfesors.Where(cp => cp.IdProfesor == p.IdProfesor).DefaultIfEmpty()
                            from ch in dbCtx.CursosHorarios.Where(ch => ch.IdCursosHorarios == cp.IdCursosHorarios).DefaultIfEmpty()
                            where ch.IdCurso == idcurso && ch.IdHorario == idhorario
                            select p;
            return queryJoin.ToList();
        }
        #endregion

        #region horarios
        public IEnumerable<Horario> GetHorarioById(int idHorario) {
            return dbCtx.Horarios.Where(p => p.IdHorario == idHorario)
                .Take(1).ToList();
        }
        public List<CursosDtos.HorariosListSearch> GetHorariosSearchDtos(List<Horario> cursosList)
        {
            var localList = new List<CursosDtos.HorariosListSearch>();
            for (int i = 0; i < cursosList.Count; i++)
            {
                localList.Add(new CursosDtos.HorariosListSearch
                {
                    Id = i + 1,
                    Descrip = cursosList[i].Descripcion,
                    Key = cursosList[i].IdHorario
                });
            }
            return localList;
        }
        public List<CursosDtos.HorariosListSearch> GetHorariosList(int idcurso)
        {
            var queryJoin = from h in dbCtx.Horarios
                            from ch in dbCtx.CursosHorarios
                            where ch.IdHorario == h.IdHorario && ch.IdCurso == idcurso
                            select new CursosDtos.HorariosListSearch
                            {
                                Id = h.IdHorario,
                                Descrip = h.Descripcion,
                                Key = ch.IdCursosHorarios
                            };
            return queryJoin.ToList();
            //return dbCtx.CursosProfesors.Where(p => p.IdProfesor == idProfe).ToList();
        }
        public Horario FindHorarioById(int idhorario)
        {
            return dbCtx.Horarios.FirstOrDefault(p => p.IdHorario == idhorario);
        }
        public List<Horario> GetHorarioByIdCurso(int idcurso)
        {
            var queryJoin = from h in dbCtx.Horarios
                            from ch in dbCtx.CursosHorarios
                            where ch.IdHorario == h.IdHorario && ch.IdCurso == idcurso
                            select h;
            return queryJoin.ToList();
        }
        #endregion

        #region cursosProfesor
        public List<CursosDtos.CursosProfesorList> GetCursosProfesorDtos(int idProfe)
        {
            var queryJoin = from c in dbCtx.Cursos
                            join ch in dbCtx.CursosHorarios on c.IdCurso equals ch.IdCurso
                            join cp in dbCtx.CursosProfesors on ch.IdCursosHorarios equals cp.IdCursosHorarios
                            where cp.IdProfesor == idProfe
                            select new CursosDtos.CursosProfesorList
                            {
                                IdCurso = ch.IdCurso,
                                Horario = ch.Horario.Descripcion,
                                IdProfesor = cp.IdProfesor,
                                Descrip = c.Descripcion,
                                Activo = cp.Activo,
                                FechaInicial = cp.FechaInicio,
                                FechaFinal = cp.FechaFinal,
                                Ausencias = cp.LimiteAusencias,
                                IdCursosHorarios = ch.IdCursosHorarios
                            };
            return queryJoin.ToList();
            //return dbCtx.CursosProfesors.Where(p => p.IdProfesor == idProfe).ToList();
        }
        public List<CursosDtos.CursosProfesorCerrarList> GetCursosProfesorCerrarDtos(int idprofesor)
        {
            var queryJoin = from cp in dbCtx.CursosProfesors
                            from ch in dbCtx.CursosHorarios.Where(ch => ch.IdCursosHorarios == cp.IdCursosHorarios).DefaultIfEmpty()
                            from h in dbCtx.Horarios.Where(h => h.IdHorario == ch.IdHorario).DefaultIfEmpty()
                            from c in dbCtx.Cursos.Where(c => c.IdCurso == ch.IdCurso).DefaultIfEmpty()
                            where c.IdCurso == ch.IdCurso && cp.IdProfesor == idprofesor
                                && cp.Activo
                            select new CursosDtos.CursosProfesorCerrarList
                            {
                                Id = ch.IdCurso,
                                Descrip = c.Descripcion,
                                Codigo = c.Codigo,
                                Cerrar = false,
                                Horario = h.Descripcion,
                                IdCursosHorarios = ch.IdCursosHorarios
                            };
            return queryJoin.ToList();
        }
        public void SaveCursoProfesor(int idcursohorario, int idprofesor, bool activo, DateTime fechainicio,
            DateTime fechafinal, int ausencias)
        {
            var NewCursoProfesorRecord = new CursosProfesor
            {
                IdCursosHorarios = idcursohorario,
                IdProfesor = idprofesor,
                Activo = activo,
                FechaInicio = fechainicio,
                FechaFinal = fechafinal,
                LimiteAusencias = ausencias
            };
            try
            {
                dbCtx.CursosProfesors.Add(NewCursoProfesorRecord);
                dbCtx.SaveChanges();
            }
            catch (Exception)
            {
                ReloadEntity(NewCursoProfesorRecord);
                throw;
            }
        }
        // ienumerable es m'as basico y primitvo que List<>
        public IEnumerable<CursosProfesor> GetCursoProfesorByIdCursoList(int idcursohorario)
        {
            return dbCtx.CursosProfesors.Where(p => p.IdCursosHorarios == idcursohorario).ToList();
        }
        // List implementa IEnumerable
        public List<CursosProfesor> GetCursoProfesorByIdCursoHorarioIdProfesor(int idcursohorario, int idprofesor)
        {
            var query = from cp in dbCtx.CursosProfesors
                        where cp.IdCursosHorarios == idcursohorario && cp.IdProfesor == idprofesor
                        select cp;
            return query.ToList();
            //return dbCtx.CursosProfesors.Where(p => p.IdProfesor == idprofesor).
            //    Where(ch => ch.CursosHorario.IdCurso == idcursohorario).ToList();
        }
        public CursosProfesor FindCursoProfesorByIdCursoHorario(int idcursohorario)
        {
            var query = from cp in dbCtx.CursosProfesors
                        where cp.IdCursosHorarios == idcursohorario
                        select cp;
            return query.FirstOrDefault();
            //return dbCtx.CursosProfesors.Where(p => p.IdProfesor == idprofesor).
            //    Where(ch => ch.CursosHorario.IdCurso == idcursohorario).ToList();
        }
        public CursosProfesor FindCursoProfesorByIdCursoProfesor(int idcursohorario, int idprofesor)
        {
            return dbCtx.CursosProfesors.Where(p => p.IdProfesor == idprofesor).Where(p => p.IdCursosHorarios == idcursohorario).FirstOrDefault();
        }
        public CursosProfesor FindCursoProfesorByIdCurso(int idcursohorario)
        {
            return dbCtx.CursosProfesors.FirstOrDefault(p => p.IdCursosHorarios == idcursohorario);
        }
        public CursosProfesor FindCursoProfesorByIdProfesor(int idprofesor)
        {
            return dbCtx.CursosProfesors.FirstOrDefault(p => p.IdProfesor == idprofesor);
        }
        public CursosProfesor FindCursoProfesorByIdCursoHorarioIdProfesor(int idcursohorario, int idprofesor)
        {
            var query = from cp in dbCtx.CursosProfesors
                        where cp.IdCursosHorarios == idcursohorario && cp.IdProfesor == idprofesor
                        select cp;
            return query.FirstOrDefault();
        }
        #endregion

        #region cursosestudiantes
        public List<CursosDtos.CursosEstudiantesList> GetEstudiantesCursoList(int idcursohorario)
        {
            var queryJoin = from ce in dbCtx.CursosEstudiantes
                            from e in dbCtx.Estudiantes
                            where e.IdEstudiante == ce.IdEstudiante && ce.IdCursosHorarios == idcursohorario
                            select new CursosDtos.CursosEstudiantesList
                            {
                                Id = ce.IdCursosEstudiantes,
                                Estudiante = e.Nombre,
                                Fecha = ce.Fecha,
                                IdCurso = ce.IdCurso,
                                IdEstudiante = ce.IdEstudiante
                            };
            return queryJoin.ToList();
        }
        public CursosEstudiante FindCursoEstudianteByIdCursoAndIdEstudiante(int idcursohorario, int idestudiante)
        {
            var curest = from ce in dbCtx.CursosEstudiantes
                         where ce.IdCursosHorarios == idcursohorario && ce.IdEstudiante == idestudiante
                         select ce;
            return curest.FirstOrDefault();
        }
        public CursosEstudiante FindCursoEstudianteByIdCurso(int idcurso)
        {
            var curest = from ce in dbCtx.CursosEstudiantes
                         where ce.IdCurso == idcurso
                         select ce;
            return curest.FirstOrDefault();
        }
        public CursosEstudiante FindCursoEstudianteByIdUsuario(int idusuario)
        {
            var curest = from ce in dbCtx.CursosEstudiantes
                         where ce.IdUsuario == idusuario
                         select ce;
            return curest.FirstOrDefault();
        }
        public CursosEstudiante FindCursoEstudianteByIdEstudiante(int idestudiante)
        {
            var curest = from ce in dbCtx.CursosEstudiantes
                         where ce.IdEstudiante == idestudiante
                         select ce;
            return curest.FirstOrDefault();
        }  
        public void SaveCursoEstudiante(int idcurso, int idestudiante, int idcursoshorarios, int idusuario)
        {
            var NewCursoEstudianteRecord = new CursosEstudiante
            {
                IdCurso = idcurso,
                IdEstudiante = idestudiante,
                IdUsuario = idusuario,
                Fecha = DateTime.Now,
                IdCursosHorarios = idcursoshorarios
            };
            try
            {
                dbCtx.CursosEstudiantes.Add(NewCursoEstudianteRecord);
                dbCtx.SaveChanges();
            }
            catch (Exception)
            {
                //ReloadEntity(NewCursoEstudianteRecord);
                throw;
            }
        }
        public List<CursosDtos.CursosEstudiantesList> GetCursosEstudiantesList(int idcursohorario)
        {
            var queryJoin = from ce in dbCtx.CursosEstudiantes
                            from e in dbCtx.Estudiantes
                            where e.IdEstudiante == ce.IdEstudiante && ce.IdCursosHorarios == idcursohorario
                            select new CursosDtos.CursosEstudiantesList
                            {
                                Id = ce.IdCursosEstudiantes,
                                Estudiante = e.Nombre,
                                Fecha = ce.Fecha,
                                IdCurso = ce.IdCurso,
                                IdEstudiante = ce.IdEstudiante
                            };
            return queryJoin.ToList();
            //return dbCtx.CursosProfesors.Where(p => p.IdProfesor == idProfe).ToList();
        }
        #endregion

        #region ausencias
        public List<CursosDtos.AusenciasEstudiantesList> GetAusenciasEstudiantesDtos(int idcurso, int idcursoshorarios)
        {
            var queryJoin = from ce in dbCtx.CursosEstudiantes
                            from e in dbCtx.Estudiantes
                            where e.IdEstudiante == ce.IdEstudiante && ce.IdCurso == idcurso 
                                && ce.IdCursosHorarios == idcursoshorarios
                            select new CursosDtos.AusenciasEstudiantesList
                            {
                                Id = ce.IdCursosEstudiantes,
                                Estudiante = e.Nombre,
                                Ausente = false                                
                            };
            return queryJoin.ToList();
        }
        public void SaveAusencia(int cursoestudiante, bool ausente, DateTime fecha)
        {
            var NewAusenciaRecord = new Ausencia
            {
                IdCursosEstudiantes = cursoestudiante,
                Ausente = ausente,
                Fecha = fecha
            };
            try
            {
                dbCtx.Ausencias.Add(NewAusenciaRecord);
                dbCtx.SaveChanges();
            }
            catch (Exception)
            {
                //ReloadEntity(NewAusenciaRecord);
                throw;
            }
        }
        public List<Ausencia> GetAusencias(int cursoestudiante, DateTime fecha)
        {
            var query = from a in dbCtx.Ausencias
                        where a.IdCursosEstudiantes == cursoestudiante && a.Fecha == fecha.Date
                        select a;
            return query.ToList();
            //return dbCtx.Ausencias.Where(p => p.IdCursoEstudiante == cursoestudiante)
            //    .Take(1).ToList();
        }
        public List<CursosDtos.AusenciasCursoList> GetAusenciasCursoDtos(int idcurso, int idcursoshorarios, DateTime fecha)
        {
            var queryJoin = from ce in dbCtx.CursosEstudiantes
                            from e in dbCtx.Estudiantes
                            from a in dbCtx.Ausencias
                            where e.IdEstudiante == ce.IdEstudiante && ce.IdCurso == idcurso 
                                && ce.IdCursosEstudiantes == a.IdCursosEstudiantes && a.Fecha == fecha.Date
                                && ce.IdCursosHorarios == idcursoshorarios
                            select new CursosDtos.AusenciasCursoList
                            {
                                IdAusencia = a.IdAusencia,
                                Estudiante = e.Nombre,
                                Ausente = a.Ausente,
                                Fecha = a.Fecha
                            };
            return queryJoin.ToList();
        }
        public Ausencia FindAusenciaCursoByIdAusencia(int idau)
        {
            return dbCtx.Ausencias.FirstOrDefault(p => p.IdAusencia == idau);
        }
        #endregion

        #region reportes
        public object ReporteCursosA()
        {
            var queryAnonymous = from ce in dbCtx.CursosEstudiantes
                                 from ch in dbCtx.CursosHorarios
                                 from cp in dbCtx.CursosProfesors
                                 select new
                                 {
                                     IdCurso = (int?)ce.IdCurso,
                                     ch.Curso.Descripcion,
                                     ch.Fecha,
                                     cp.LimiteAusencias,
                                     IdProfesor = (int?)cp.Profesore.IdProfesor,
                                     cp.Profesore.Nombre,
                                     IdHorario = (int?)ch.Horario.IdHorario,
                                     Horario = ch.Horario.Descripcion,
                                     IdEstudiante = (int?)ce.Estudiante.IdEstudiante,
                                     Estudiante = ce.Estudiante.Nombre
                                 };
            return queryAnonymous;
        }
        public IEnumerable<CursosDtos.ReporteCursosList> ReporteCursosDtos()
        {
            var query = from c in dbCtx.Cursos                        
                        join ch in dbCtx.CursosHorarios
                            on c.IdCurso equals ch.IdCurso into JoinedCH
                        from ch in JoinedCH.DefaultIfEmpty()
                        join h in dbCtx.Horarios
                            on ch.IdHorario equals h.IdHorario into JoinedH
                        from h in JoinedH.DefaultIfEmpty()
                        join cp in dbCtx.CursosProfesors
                            on ch.IdCursosHorarios equals cp.IdCursosHorarios into JoinedCP
                        from cp in JoinedCP.DefaultIfEmpty()
                        join p in dbCtx.Profesores
                            on cp.IdProfesor equals p.IdProfesor into JoinedP
                        from p in JoinedP.DefaultIfEmpty()
                        join ce in dbCtx.CursosEstudiantes
                            on ch.IdCursosHorarios equals ce.IdCursosHorarios into JoinedCE
                        from ce in JoinedCE.DefaultIfEmpty()
                        join e in dbCtx.Estudiantes
                            on ce.IdEstudiante equals e.IdEstudiante into JoinedE
                        from e in JoinedE.DefaultIfEmpty()
                        orderby c.IdCurso
                        select new CursosDtos.ReporteCursosList
                            {
                                IdCurso = (int?)c.IdCurso,
                                NombreCurso = c.Descripcion,
                                LimiteAusencias = cp.LimiteAusencias,
                                IdProfesor = (int?)p.IdProfesor,
                                NombreProfesor = p.Nombre,
                                IdHorario = (int?)h.IdHorario,
                                DescripcionHorario = h.Descripcion,
                                IdEstudiante = (int?)e.IdEstudiante,
                                NombreEstudiante = e.Nombre
                            };
            return query;

            // comp[act version + lamda
            //from c in Cursos
            //    from ch in CursosHorarios.Where(ch=>ch.IdCurso == c.IdCurso).DefaultIfEmpty()
            //    from h in Horarios.Where(h=>h.IdHorario == ch.IdHorario).DefaultIfEmpty()
            //    select new
            //    {
            //        c.IdCurso, NombreCurso = c.Descripcion, DescripcionHorario = h.Descripcion
            //    }
        }
        public IEnumerable<Estudiante> ReporteEstudiantes()
        {
            var query = from e in dbCtx.Estudiantes
                        orderby e.IdEstudiante
                        select e;
            return query;
        }
        public IEnumerable<Profesore> ReporteProfesores()
        {
            var query = from p in dbCtx.Profesores
                        orderby p.IdProfesor
                        select p;
            return query;
        }
        public IEnumerable<CursosDtos.ReporteAusenciasList> ReporteAusenciasDtos()
        {
            var query = from e in dbCtx.Estudiantes
                        from ce in dbCtx.CursosEstudiantes.Where(ce => ce.IdEstudiante == e.IdEstudiante)
                        from a in dbCtx.Ausencias.Where(a => a.IdCursosEstudiantes == ce.IdCursosEstudiantes)
                        from c in dbCtx.Cursos.Where(cu => ce.IdCurso == cu.IdCurso)
                        from ch in dbCtx.CursosHorarios.Where(cuh => ce.IdCursosHorarios == cuh.IdCursosHorarios)
                        from cp in dbCtx.CursosProfesors.Where(cuPro=>ch.IdCursosHorarios == cuPro.IdCursosHorarios )
                        from p in dbCtx.Profesores.Where(p=>cp.IdProfesor == p.IdProfesor)
                        where a.Ausente
                        orderby e.Nombre
                        select new CursosDtos.ReporteAusenciasList
                        {
                            IdEstudiante = e.IdEstudiante,
                            NombreEstudiante = e.Nombre,
                            Telefono = e.Telefono,
                            Correo = e.Correo,
                            Ausente = a.Ausente,
                            Fecha = a.Fecha,
                            IdCurso = ce.IdCurso,
                            IdHorario = ch.IdHorario,
                            IdProfesor = p.IdProfesor
                        };
            return query;            
        }
        #endregion
    }
}
