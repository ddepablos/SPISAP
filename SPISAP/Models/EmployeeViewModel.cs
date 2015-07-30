using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPISAP.Models
{
    public class EmployeeViewModel
    {

        /* DPERSONALES : Datos Personales */
        public string FICHA { get; set; }
        public string CEDULA { get; set; }
        public string COD_SUCURSAL { get; set; }
        public string COD_GRUPO { get; set; }
        public string COD_AREA_PERSONAL { get; set; }
        public string CARGO { get; set; }
        public string TRATAMIENTO { get; set; }
        public string PRIMER_APELLIDO { get; set; }
        public string SEGUNDO_APELLIDO { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<System.DateTime> FECHA_NACIMIENTO { get; set; }
        public string CIUDAD_NACIMIENTO { get; set; }
        public string COD_PAIS { get; set; }
        public string COD_ESTADO { get; set; }
        public string COD_NACIONALIDAD { get; set; }
        public string ESTADO_CIVIL { get; set; }
        public string SEXO { get; set; }
        public string RIF { get; set; }
        public string CALZADO { get; set; }
        public string CHEMISE { get; set; }
        public string PANTALON { get; set; }
        public string COD_USER_INS { get; set; }
        public System.DateTime FECHA_INS { get; set; }
        public string COD_USER_UPD { get; set; }
        public System.DateTime FECHA_UPD { get; set; }

        /* DDIRECCION : Dirección del Trabajador */
        //public string CEDULA { get; set; }
        public string CALLE { get; set; }
        public string EDIFICIO { get; set; }
        public string PISO { get; set; }
        public string NUMERO { get; set; }
        public string CIUDAD { get; set; }
        public string URBANIZACION { get; set; }
        public string COD_ESTADO_DDIRECCION { get; set; }
        public string COD_PAIS_DDIRECCION { get; set; }
        public string TELEFONOS { get; set; }
        public string COD_ESTADO_SSO { get; set; }
        public string COD_MUNICIPIO_SSO { get; set; }
        public string COD_PARROQUIA_SSO { get; set; }

    }
}