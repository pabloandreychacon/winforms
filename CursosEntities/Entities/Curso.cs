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
    
    public partial class Curso
    {
        public Curso()
        {
            this.CursosHorarios = new HashSet<CursosHorario>();
        }
    
        public int IdCurso { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public string Codigo { get; set; }
        public decimal CantidadHoras { get; set; }
        public int CantidadEstudiantes { get; set; }
        public string NombreCurso { get; set; }
        public int IdAula { get; set; }
    
        public virtual ICollection<CursosHorario> CursosHorarios { get; set; }
        public virtual Aula Aula { get; set; }
    }
}
