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
    
    public partial class DCUENTA
    {
        public string CEDULA { get; set; }
        public string CLAVE_BANCO { get; set; }
        public string CUENTA_BANCARIA { get; set; }
        public string TIPO_CUENTA { get; set; }
        public string VIA_PAGO { get; set; }
        public string COD_USER_INS { get; set; }
        public System.DateTime FECHA_INS { get; set; }
        public string COD_USER_UPD { get; set; }
        public System.DateTime FECHA_UPD { get; set; }
    
        public virtual DPERSONALES DPERSONALE { get; set; }
        public virtual DUSUARIO DUSUARIO { get; set; }
        public virtual DUSUARIO DUSUARIO1 { get; set; }
    }
}
