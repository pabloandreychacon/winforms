using CursosEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosEntities.Dtos
{
    public class CursosDtos
    {
        public class CursosListSearch {
            public int Id { get; set; }
            public string Descrip { get; set; }
            public bool Activo { get; set; }
            public int Key { get; set; }
        }
        public class CorreoListSearch
        {
            public int Port { get; set; }
            public int TimeOut { get; set; }
            public string Host { get; set; }
            public bool UserName { get; set; }
            public bool Password { get; set; }
            public bool From { get; set; }
            public bool DisplayName { get; set; }
        }
        public class CursosHorarioListSearch
        {
            public int Id { get; set; }
            public string Descrip { get; set; }
            public bool Activo { get; set; }
            public int Key { get; set; }
            public string Horario { get; set; }
        }
        public class EstudiantesListSearch
        {
            public int Id { get; set; }
            public string Identific { get; set; }
            public string Nombre { get; set; }
            public bool Activo { get; set; }
            public int Key { get; set; }
        }
        public class ProfesoresListSearch
        {
            public int Id { get; set; }
            public string Identific { get; set; }
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public int Key { get; set; }
        }
        public class HorariosListSearch
        {
            public int Id { get; set; }
            public string Descrip { get; set; }
            public int Key { get; set; }
        }
        public class UsuariosListSearch
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
        public class CursosProfesorList
        {
            public int IdCurso { get; set; }
            public string Descrip { get; set; }
            public string Horario { get; set; }
            public bool Activo { get; set; }
            public DateTime? FechaInicial { get; set; }
            public DateTime? FechaFinal { get; set; }
            public int Ausencias { get; set; }
            public int IdProfesor { get; set; }
            public int IdCursosHorarios { get; set; }
        }
        public class CursosProfesorCerrarList
        {
            public int Id { get; set; }
            public string Descrip { get; set; }
            public string Codigo { get; set; }
            public bool Cerrar { get; set; }
            public string Horario { get; set; }
            public int IdCursosHorarios { get; set; }
        }
        public class CursosEstudiantesList
        {
            public int Id { get; set; }
            public string Estudiante { get; set; }
            public DateTime? Fecha { get; set; }
            public int IdCurso { get; set; }
            public int IdEstudiante { get; set; }
        }
        public class AusenciasEstudiantesList
        {
            public int Id { get; set; }
            public string Estudiante { get; set; }
            public bool Ausente { get; set; }
        }
        public class AusenciasCursoList
        {
            public int IdAusencia { get; set; }
            public string Estudiante { get; set; }
            public bool Ausente { get; set; }
            public DateTime? Fecha { get; set; }
        }
        public class ReporteCursosList
        {
            public int? IdCurso { get; set; }
            public string NombreCurso { get; set; }
            public int? LimiteAusencias { get; set; }
            public int? IdProfesor { get; set; }
            public string NombreProfesor { get; set; }
            public int? IdHorario { get; set; }
            public string DescripcionHorario { get; set; }
            public int? IdEstudiante { get; set; }
            public string NombreEstudiante { get; set; }
        }
        public class ReporteAusenciasList
        {
            public int? IdCurso { get; set; }
            public int? IdEstudiante { get; set; }
            public int? IdHorario { get; set; }
            public int? IdProfesor { get; set; }
            public string NombreEstudiante { get; set; }
            public string Correo { get; set; }
            public string Telefono { get; set; }
            public bool Ausente { get; set; }
            public DateTime Fecha { get; set; }
        }
        public class InventarioDtos
        {
            public class ExistenciasCantidad
            {
                public decimal CantidadTotal { get; set; }
            }

            public class ProdListSearch
            {
                public int Id { get; set; }
                public string Codigo { get; set; }
                public string Descrip { get; set; }
                public decimal Precio { get; set; }
            }
        }
    }
}
