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
    
    public partial class Cantone
    {
        public Cantone()
        {
            this.Distritos = new HashSet<Distrito>();
            this.Estudiantes = new HashSet<Estudiante>();
            this.Profesores = new HashSet<Profesore>();
        }
    
        public int IdCanton { get; set; }
        public string Nombre { get; set; }
        public int IdProvincia { get; set; }
    
        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<Distrito> Distritos { get; set; }
        public virtual ICollection<Estudiante> Estudiantes { get; set; }
        public virtual ICollection<Profesore> Profesores { get; set; }
    }
}
