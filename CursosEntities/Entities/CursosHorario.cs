//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CursosEntities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class CursosHorario
    {
        public CursosHorario()
        {
            this.CursosProfesors = new HashSet<CursosProfesor>();
        }
    
        public int IdCursosHorarios { get; set; }
        public int IdCurso { get; set; }
        public int IdHorario { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Dia { get; set; }
        public int Aula { get; set; }
    
        public virtual ICollection<CursosProfesor> CursosProfesors { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Horario Horario { get; set; }
    }
}
