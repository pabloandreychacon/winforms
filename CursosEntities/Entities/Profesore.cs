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
    
    public partial class Profesore
    {
        public Profesore()
        {
            this.CursosProfesors = new HashSet<CursosProfesor>();
        }
    
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Correo { get; set; }
        public string Phone { get; set; }
        public bool Activo { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Institucion { get; set; }
        public string Apellido { get; set; }
        public string ApellidoFinal { get; set; }
        public int IdTipoId { get; set; }
    
        public virtual ICollection<CursosProfesor> CursosProfesors { get; set; }
        public virtual TipoId TipoId { get; set; }
    }
}
