//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPISAP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NACIONALIDAD
    {
        public NACIONALIDAD()
        {
            this.DPERSONALES = new HashSet<DPERSONALES>();
            this.DFAMILIARES = new HashSet<DFAMILIAR>();
        }
    
        public string COD_NACIONALIDAD { get; set; }
        public string DES_NACIONALIDAD { get; set; }
    
        public virtual ICollection<DPERSONALES> DPERSONALES { get; set; }
        public virtual ICollection<DFAMILIAR> DFAMILIARES { get; set; }
    }
}