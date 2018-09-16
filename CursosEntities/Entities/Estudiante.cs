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
    
    public partial class Estudiante
    {
        public Estudiante()
        {
            this.CursosEstudiantes = new HashSet<CursosEstudiante>();
        }
    
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
    
        public virtual ICollection<CursosEstudiante> CursosEstudiantes { get; set; }
    }
}
