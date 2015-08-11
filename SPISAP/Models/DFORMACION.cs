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
    
    public partial class DFORMACION
    {
        public string CEDULA { get; set; }
        public string COD_CLASE { get; set; }
        public string INSTITUTO { get; set; }
        public string COD_PAIS { get; set; }
        public string CT_COD_CLASE { get; set; }
        public string CT_COD_TITULO { get; set; }
        public string DURACION { get; set; }
        public string UNIDAD_TIEMPO { get; set; }
        public string CE_COD_ESPECIALIDAD { get; set; }
        public string CE_COD_CLASE { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public System.DateTime FECHA_FIN { get; set; }
        public string COD_USER_INS { get; set; }
        public System.DateTime FECHA_INS { get; set; }
        public string COD_USER_UPD { get; set; }
        public System.DateTime FECHA_UPD { get; set; }
        public decimal ID_FORMACION { get; set; }
    
        public virtual CLASE_ESPECIALIDAD CLASE_ESPECIALIDAD { get; set; }
        public virtual CLASE_INSTITUTO CLASE_INSTITUTO { get; set; }
        public virtual CLASE_TITULO CLASE_TITULO { get; set; }
        public virtual DPERSONALES DPERSONALE { get; set; }
        public virtual DUSUARIO DUSUARIO { get; set; }
        public virtual DUSUARIO DUSUARIO1 { get; set; }
        public virtual PAIS PAI { get; set; }
    }
}
