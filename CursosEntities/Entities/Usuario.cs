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
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.CursosEstudiantes = new HashSet<CursosEstudiante>();
            this.Bitacoras = new HashSet<Bitacora>();
        }
    
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public int IdRole { get; set; }
        public string Clave { get; set; }
        public bool Activo { get; set; }
        public bool Mantenimientos { get; set; }
        public bool Procesos { get; set; }
        public bool Consultas { get; set; }
        public bool Seguridad { get; set; }
    
        public virtual ICollection<CursosEstudiante> CursosEstudiantes { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Bitacora> Bitacoras { get; set; }
    }
}
