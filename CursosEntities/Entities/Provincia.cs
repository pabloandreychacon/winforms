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
    
    public partial class Provincia
    {
        public Provincia()
        {
            this.Cantones = new HashSet<Cantone>();
        }
    
        public int IdProvincia { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<Cantone> Cantones { get; set; }
    }
}
