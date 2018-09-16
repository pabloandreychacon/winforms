using CursosEntities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosBusiness.BusinessHelpers
{
    public static class LocalData
    {
        public static List<CursosDtos.CursosListSearch> searchCursosList;
        public static List<CursosDtos.CursosHorarioListSearch> searchCursosHorariosList;
        public static List<CursosDtos.EstudiantesListSearch> searchEstudiantesList;
        public static List<CursosDtos.ProfesoresListSearch> searchProfesoresList;
        public static List<CursosDtos.HorariosListSearch> searchHorariosList;
        public static List<CursosDtos.UsuariosListSearch> searchUsuariosList;
    }

}
