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
    
    public partial class Aula
    {
        public Aula()
        {
            this.Cursos = new HashSet<Curso>();
        }
    
        public int IdAula { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public int Capacidad { get; set; }
        public string Ubicacion { get; set; }
        public bool Accesibilidad { get; set; }
        public bool Disponible { get; set; }
    
        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
