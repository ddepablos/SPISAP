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
    
    public partial class PAIS
    {
        public PAIS()
        {
            this.DEXPERIENCIAS = new HashSet<DEXPERIENCIA>();
            this.DFAMILIARES = new HashSet<DFAMILIAR>();
            this.DFORMACIONES = new HashSet<DFORMACION>();
            this.PAIS_ESTADO = new HashSet<PAIS_ESTADO>();
        }
    
        public string COD_PAIS { get; set; }
        public string DES_PAIS { get; set; }
    
        public virtual ICollection<DEXPERIENCIA> DEXPERIENCIAS { get; set; }
        public virtual ICollection<DFAMILIAR> DFAMILIARES { get; set; }
        public virtual ICollection<DFORMACION> DFORMACIONES { get; set; }
        public virtual ICollection<PAIS_ESTADO> PAIS_ESTADO { get; set; }
    }
}
