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
    
    public partial class TipoId
    {
        public TipoId()
        {
            this.Estudiantes = new HashSet<Estudiante>();
            this.Profesores = new HashSet<Profesore>();
        }
    
        public int IdTipoId { get; set; }
        public string Descripcion { get; set; }
        public string Mask { get; set; }
    
        public virtual ICollection<Estudiante> Estudiantes { get; set; }
        public virtual ICollection<Profesore> Profesores { get; set; }
    }
}