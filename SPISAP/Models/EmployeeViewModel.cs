using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using SPISAP.Models;
using System.ComponentModel.DataAnnotations;

namespace SPISAP.Models
{
    public class EmployeeViewModel
    {


        #region EMPLOYEE_ATRIBUTOS

        #region DATOS_PERSONALES

        public string ERROR { get; set; }

        [Required(ErrorMessage = "El campo Ficha es requerido.")]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Ficha permite únicamente números.")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "El campo Ficha debe contener entre 6 y 12 dígitos.")]
        public string FICHA { get; set; }

        [Required(ErrorMessage = "El campo Cédula es requerido.")]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula permite únicamente números.")]
        [StringLength(8, MinimumLength = 6, ErrorMessage = "El campo Cédula debe contener entre 6 y 8 dígitos.")]
        public string CEDULA { get; set; }

        [Required(ErrorMessage = "El campo Sucursal es requerido.")]
        public string COD_SUCURSAL { get; set; }

        [Required(ErrorMessage = "El campo Tipo de Contratación es requerido.")]
        public string COD_GRUPO { get; set; }

        [Required(ErrorMessage = "El campo Nivel de Cargo es requerido.")]
        public string COD_AREA_PERSONAL { get; set; }

        [Required(ErrorMessage = "El campo Cargo es requerido.")]
        public string CARGO { get; set; }

        public string TRATAMIENTO { get; set; }

        [Required(ErrorMessage = "El campo Primer Apellido es requerido.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido debe contener entre 3 y 40 carácteres.")]
        public string PRIMER_APELLIDO { get; set; }

        [Required(ErrorMessage = "El campo Segundo Apellido es requerido.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Segundo Apellido debe contener entre 3 y 40 carácteres.")]
        public string SEGUNDO_APELLIDO { get; set; }

        [Required(ErrorMessage = "El campo Nombres es requerido.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombres debe contener entre 3 y 40 carácteres.")]
        public string NOMBRE { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es requerido.")]
        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Nacimiento no posee un formato válido : (dd/mm/yyyy)")]
        public string FECHA_NACIMIENTO { get; set; }
        
        public Nullable<System.DateTime> FECHA_NACIMIENTO_DATE { get; set; }

        //"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$"
        //[RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
        //    ErrorMessage="El campo Fecha de Nacimiento no posee un formato válido : (dd/mm/yyyy)")]
        //public string FECHA_NACIMIENTO_STRING { get; set; }

        [Required(ErrorMessage = "El campo Ciudad de Nacimiento es requerido.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Ciudad de Nacimiento debe contener entre 3 y 40 carácteres.")]
        public string CIUDAD_NACIMIENTO { get; set; }

        [Required(ErrorMessage = "El campo País de Nacimiento es requerido.")]
        public string COD_PAIS { get; set; }

        [Required(ErrorMessage = "El campo Estado de Nacimiento es requerido.")]
        public string COD_ESTADO { get; set; }

        [Required(ErrorMessage = "El campo Nacionalidad es requerido.")]
        public string COD_NACIONALIDAD { get; set; }

        [Required(ErrorMessage = "El campo Estado Civil es requerido.")]
        public string ESTADO_CIVIL { get; set; }

        [Required(ErrorMessage = "El campo Sexo es requerido.")]
        public string SEXO { get; set; }

        //[Required(ErrorMessage = "El campo RIF es requerido.")]
        public string RIF { get; set; }

        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                    ErrorMessage = "El campo Correo Electrónico no contiene el formato válido : usuario@correo.com.")]
        public string COD_CLASE_CORREO { get; set; }

        [Required(ErrorMessage = "El campo Teléfono Celular es requerido.")]
        [RegularExpression(@"^[0-9]\d*$", ErrorMessage = "El campo Teléfono Celular permite únicamente números.")]
        public string COD_CLASE_CELULAR { get; set; }

        [Required(ErrorMessage = "El campo Nro. de Zapato es requerido.")]
        public string CALZADO { get; set; }

        [Required(ErrorMessage = "El campo Talla de Camisa es requerido.")]
        public string CHEMISE { get; set; }

        [Required(ErrorMessage = "El campo Talla de Pantalón es requerido.")]
        public string PANTALON { get; set; }
        #endregion

        #region DATOS_DIRECCION
        [Required(ErrorMessage = "El campo Calle es requerido.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Calle debe contener entre 3 y 40 carácteres.")]
        public string CALLE { get; set; }

        [Required(ErrorMessage = "El campo Edificio/Casa/Escalera es requerido.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Edificio/Casa/Escalera debe contener entre 3 y 40 carácteres.")]
        public string EDIFICIO { get; set; }

        [Required(ErrorMessage = "El campo Piso es requerido.")]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Piso permite únicamente números.")]
        public string PISO { get; set; }

        [Required(ErrorMessage = "El campo Número es requerido.")]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Número (Dirección) permite únicamente números.")]
        public string NUMERO { get; set; }

        [Required(ErrorMessage = "El campo Ciudad (Dirección) es requerido.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Ciudad (Dirección) debe contener entre 3 y 40 carácteres.")]
        public string CIUDAD { get; set; }

        [Required(ErrorMessage = "El campo Urbanización/Zona es requerido.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Urbanización/Zona debe contener entre 3 y 40 carácteres.")]
        public string URBANIZACION { get; set; }

        //[Required(ErrorMessage = "El campo País (Dirección) es requerido.")]
        public string COD_PAIS_DIRECCION { get; set; }

        //[Required(ErrorMessage = "El campo Estado (Dirección) es requerido.")]
        public string COD_ESTADO_DIRECCION { get; set; }

        [Required(ErrorMessage = "El campo Teléfono de Habitación es requerido.")]
        [RegularExpression(@"^[0-9]\d*$", ErrorMessage = "El campo Teléfono de Habitación permite únicamente números.")]
        [StringLength(40, MinimumLength = 7, ErrorMessage = "El campo Teléfono de Habitación debe contener entre 7 y 40 carácteres.")]
        public string TELEFONOS { get; set; }

        [Required(ErrorMessage = "El campo Estado (Dirección) es requerido.")]
        public string COD_ESTADO_SSO { get; set; }

        [Required(ErrorMessage = "El campo Municipio (Dirección) es requerido.")]
        public string COD_MUNICIPIO_SSO { get; set; }

        [Required(ErrorMessage = "El campo Parroquia (Dirección) es requerido.")]
        public string COD_PARROQUIA_SSO { get; set; }
        #endregion

        #region DATOS_DISCAPACIDAD
        public bool COD_DISCAPACIDAD_MOTRIZ { get; set; }
        public bool COD_DISCAPACIDAD_INTELECTUAL { get; set; }
        public bool COD_DISCAPACIDAD_SENSORIAL { get; set; }
        #endregion

        #region DATOS_FAMILIARES
        // FAMILIAR # 1
        public string FAM1_COD_PARENTESCO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido (Familiar # 1) debe contener entre 3 y 40 carácteres.")]
        public string FAM1_PRIMER_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Segundo Apellido (Familiar # 1) debe contener entre 3 y 40 carácteres.")]
        public string FAM1_SEGUNDO_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombres (Familiar # 1) debe contener entre 3 y 40 carácteres.")]
        public string FAM1_NOMBRES { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Nacimiento (Familiar # 1) no posee un formato válido : (dd/mm/yyyy)")]
        public string FAM1_FECHA_NACIMIENTO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Lugar de Nacimiento (Familiar # 1) debe contener entre 3 y 40 carácteres.")]
        public string FAM1_LUGAR_NACIMIENTO { get; set; }

        public string FAM1_COD_PAIS { get; set; }
        public string FAM1_COD_NACIONALIDAD { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula (Familiar # 1) permite únicamente números.")]
        public string FAM1_CEDULA_FAMILIAR { get; set; }

        public string FAM1_SEXO { get; set; }


        // FAMILIAR # 2
        public string FAM2_COD_PARENTESCO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido (Familiar # 2) debe contener entre 3 y 40 carácteres.")]
        public string FAM2_PRIMER_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Segundo Apellido (Familiar # 2) debe contener entre 3 y 40 carácteres.")]
        public string FAM2_SEGUNDO_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombres (Familiar # 2) debe contener entre 3 y 40 carácteres.")]
        public string FAM2_NOMBRES { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Nacimiento (Familiar # 2) no posee un formato válido : (dd/mm/yyyy)")]
        public string FAM2_FECHA_NACIMIENTO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Lugar de Nacimiento (Familiar # 2) debe contener entre 3 y 40 carácteres.")]
        public string FAM2_LUGAR_NACIMIENTO { get; set; }

        public string FAM2_COD_PAIS { get; set; }
        public string FAM2_COD_NACIONALIDAD { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula (Familiar # 2) permite únicamente números.")]
        public string FAM2_CEDULA_FAMILIAR { get; set; }

        public string FAM2_SEXO { get; set; }

        // FAMILIAR # 3
        public string FAM3_COD_PARENTESCO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido (Familiar # 3) debe contener entre 3 y 40 carácteres.")]
        public string FAM3_PRIMER_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Segundo Apellido (Familiar # 3) debe contener entre 3 y 40 carácteres.")]
        public string FAM3_SEGUNDO_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombres (Familiar # 3) debe contener entre 3 y 40 carácteres.")]
        public string FAM3_NOMBRES { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Nacimiento (Familiar # 3) no posee un formato válido : (dd/mm/yyyy)")]
        public string FAM3_FECHA_NACIMIENTO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Lugar de Nacimiento (Familiar # 3) debe contener entre 3 y 40 carácteres.")]
        public string FAM3_LUGAR_NACIMIENTO { get; set; }

        public string FAM3_COD_PAIS { get; set; }
        public string FAM3_COD_NACIONALIDAD { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula (Familiar # 3) permite únicamente números.")]
        public string FAM3_CEDULA_FAMILIAR { get; set; }

        public string FAM3_SEXO { get; set; }

        // FAMILIAR # 4
        public string FAM4_COD_PARENTESCO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido (Familiar # 4) debe contener entre 3 y 40 carácteres.")]
        public string FAM4_PRIMER_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Segundo Apellido (Familiar # 4) debe contener entre 3 y 40 carácteres.")]
        public string FAM4_SEGUNDO_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombres (Familiar # 4) debe contener entre 3 y 40 carácteres.")]
        public string FAM4_NOMBRES { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Nacimiento (Familiar # 4) no posee un formato válido : (dd/mm/yyyy)")]
        public string FAM4_FECHA_NACIMIENTO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Lugar de Nacimiento (Familiar # 4) debe contener entre 3 y 40 carácteres.")]
        public string FAM4_LUGAR_NACIMIENTO { get; set; }

        public string FAM4_COD_PAIS { get; set; }
        public string FAM4_COD_NACIONALIDAD { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula (Familiar # 4) permite únicamente números.")]
        public string FAM4_CEDULA_FAMILIAR { get; set; }

        public string FAM4_SEXO { get; set; }

        // FAMILIAR # 5
        public string FAM5_COD_PARENTESCO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido (Familiar # 5) debe contener entre 3 y 40 carácteres.")]
        public string FAM5_PRIMER_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Segundo Apellido (Familiar # 5) debe contener entre 3 y 40 carácteres.")]
        public string FAM5_SEGUNDO_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombres (Familiar # 5) debe contener entre 3 y 40 carácteres.")]
        public string FAM5_NOMBRES { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Nacimiento (Familiar # 5) no posee un formato válido : (dd/mm/yyyy)")]
        public string FAM5_FECHA_NACIMIENTO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Lugar de Nacimiento (Familiar # 5) debe contener entre 3 y 40 carácteres.")]
        public string FAM5_LUGAR_NACIMIENTO { get; set; }

        public string FAM5_COD_PAIS { get; set; }
        public string FAM5_COD_NACIONALIDAD { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula (Familiar # 5) permite únicamente números.")]
        public string FAM5_CEDULA_FAMILIAR { get; set; }

        public string FAM5_SEXO { get; set; }

        // FAMILIAR # 6
        public string FAM6_COD_PARENTESCO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido (Familiar # 6) debe contener entre 3 y 40 carácteres.")]
        public string FAM6_PRIMER_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Segundo Apellido (Familiar # 6) debe contener entre 3 y 40 carácteres.")]
        public string FAM6_SEGUNDO_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombres (Familiar # 6) debe contener entre 3 y 40 carácteres.")]
        public string FAM6_NOMBRES { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Nacimiento (Familiar # 6) no posee un formato válido : (dd/mm/yyyy)")]
        public string FAM6_FECHA_NACIMIENTO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Lugar de Nacimiento (Familiar # 6) debe contener entre 3 y 40 carácteres.")]
        public string FAM6_LUGAR_NACIMIENTO { get; set; }

        public string FAM6_COD_PAIS { get; set; }
        public string FAM6_COD_NACIONALIDAD { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula (Familiar # 6) permite únicamente números.")]
        public string FAM6_CEDULA_FAMILIAR { get; set; }

        public string FAM6_SEXO { get; set; }

        // FAMILIAR # 7
        public string FAM7_COD_PARENTESCO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido (Familiar # 7) debe contener entre 3 y 40 carácteres.")]
        public string FAM7_PRIMER_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Segundo Apellido (Familiar # 7) debe contener entre 3 y 40 carácteres.")]
        public string FAM7_SEGUNDO_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombres (Familiar # 7) debe contener entre 3 y 40 carácteres.")]
        public string FAM7_NOMBRES { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Nacimiento (Familiar # 7) no posee un formato válido : (dd/mm/yyyy)")]
        public string FAM7_FECHA_NACIMIENTO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Lugar de Nacimiento (Familiar # 7) debe contener entre 3 y 40 carácteres.")]
        public string FAM7_LUGAR_NACIMIENTO { get; set; }

        public string FAM7_COD_PAIS { get; set; }
        public string FAM7_COD_NACIONALIDAD { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula (Familiar # 7) permite únicamente números.")]
        public string FAM7_CEDULA_FAMILIAR { get; set; }

        public string FAM7_SEXO { get; set; }

        // FAMILIAR # 8
        public string FAM8_COD_PARENTESCO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido (Familiar # 8) debe contener entre 3 y 40 carácteres.")]
        public string FAM8_PRIMER_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Segundo Apellido (Familiar # 8) debe contener entre 3 y 40 carácteres.")]
        public string FAM8_SEGUNDO_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombres (Familiar # 8) debe contener entre 3 y 40 carácteres.")]
        public string FAM8_NOMBRES { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Nacimiento (Familiar # 8) no posee un formato válido : (dd/mm/yyyy)")]
        public string FAM8_FECHA_NACIMIENTO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Lugar de Nacimiento (Familiar # 8) debe contener entre 3 y 40 carácteres.")]
        public string FAM8_LUGAR_NACIMIENTO { get; set; }

        public string FAM8_COD_PAIS { get; set; }
        public string FAM8_COD_NACIONALIDAD { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula (Familiar # 8) permite únicamente números.")]
        public string FAM8_CEDULA_FAMILIAR { get; set; }

        public string FAM8_SEXO { get; set; }

        // FAMILIAR # 9
        public string FAM9_COD_PARENTESCO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido (Familiar # 9) debe contener entre 3 y 40 carácteres.")]
        public string FAM9_PRIMER_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Segundo Apellido (Familiar # 9) debe contener entre 3 y 40 carácteres.")]
        public string FAM9_SEGUNDO_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombres (Familiar # 9) debe contener entre 3 y 40 carácteres.")]
        public string FAM9_NOMBRES { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Nacimiento (Familiar # 9) no posee un formato válido : (dd/mm/yyyy)")]
        public string FAM9_FECHA_NACIMIENTO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Lugar de Nacimiento (Familiar # 9) debe contener entre 3 y 40 carácteres.")]
        public string FAM9_LUGAR_NACIMIENTO { get; set; }

        public string FAM9_COD_PAIS { get; set; }
        public string FAM9_COD_NACIONALIDAD { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula (Familiar # 9) permite únicamente números.")]
        public string FAM9_CEDULA_FAMILIAR { get; set; }

        public string FAM9_SEXO { get; set; }

        // FAMILIAR # 10
        public string FAM10_COD_PARENTESCO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido (Familiar # 10) debe contener entre 3 y 40 carácteres.")]
        public string FAM10_PRIMER_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Segundo Apellido (Familiar # 10) debe contener entre 3 y 40 carácteres.")]
        public string FAM10_SEGUNDO_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombres (Familiar # 10) debe contener entre 3 y 40 carácteres.")]
        public string FAM10_NOMBRES { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Nacimiento (Familiar # 10) no posee un formato válido : (dd/mm/yyyy)")]
        public string FAM10_FECHA_NACIMIENTO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Lugar de Nacimiento (Familiar # 10) debe contener entre 3 y 40 carácteres.")]
        public string FAM10_LUGAR_NACIMIENTO { get; set; }

        public string FAM10_COD_PAIS { get; set; }
        public string FAM10_COD_NACIONALIDAD { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula (Familiar # 10) permite únicamente números.")]
        public string FAM10_CEDULA_FAMILIAR { get; set; }

        public string FAM10_SEXO { get; set; }
        #endregion

        #region DATOS_FORMACION
        // FORMACIÓN # 1
        [Required(ErrorMessage = "El campo Nivel de Estudio (Formación # 1) es requerido.")]
        public string FRM1_COD_CLASE { get; set; }

        // PENDIENTE POR ANALIZAR SU VALOR.
        public string FRM1_COD_FORMACION { get; set; }

        [Required(ErrorMessage = "El campo Nombre del Instituto (Formación # 1) es requerido.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombre del Instituto (Formación # 1) debe contener entre 3 y 40 carácteres.")]
        public string FRM1_INSTITUTO { get; set; }

        [Required(ErrorMessage = "El campo País (Formación # 1) es requerido.")]
        public string FRM1_COD_PAIS { get; set; }

        public string FRM1_CT_COD_CLASE { get; set; }

        [Required(ErrorMessage = "El campo Condición (Formación # 1) es requerido.")]
        public string FRM1_CT_COD_TITULO { get; set; }

        [Required(ErrorMessage = "El campo Número de Duración (Formación # 1) es requerido.")]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Duración (Formación # 1) permite únicamente números.")]
        public string FRM1_DURACION { get; set; }

        [Required(ErrorMessage = "El campo Tiempo de Duración (Formación # 1) es requerido.")]
        public string FRM1_UNIDAD_TIEMPO { get; set; }

        [Required(ErrorMessage = "El campo Especialidad (Formación # 1) es requerido.")]
        public string FRM1_CE_COD_ESPECIALIDAD { get; set; }

        public string FRM1_CE_COD_CLASE { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Inicio (Formación # 1) no posee un formato válido : (dd/mm/yyyy)")]
        [Required(ErrorMessage = "El campo Fecha de Inicio (Formación # 1) es requerido.")]
        public string FRM1_FECHA_INICIO { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Fin (Formación # 1) no posee un formato válido : (dd/mm/yyyy)")]
        [Required(ErrorMessage = "El campo Fecha de Finalización (Formación # 1) es requerido.")]
        public string FRM1_FECHA_FIN { get; set; }

        // FORMACIÓN # 2
        public string FRM2_COD_CLASE { get; set; }
        public string FRM2_COD_FORMACION { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombre del Instituto (Formación # 2) debe contener entre 3 y 40 carácteres.")]
        public string FRM2_INSTITUTO { get; set; }
        public string FRM2_COD_PAIS { get; set; }
        public string FRM2_CT_COD_CLASE { get; set; }
        public string FRM2_CT_COD_TITULO { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Duración (Formación # 2) permite únicamente números.")]
        public string FRM2_DURACION { get; set; }
        public string FRM2_UNIDAD_TIEMPO { get; set; }
        public string FRM2_CE_COD_ESPECIALIDAD { get; set; }
        public string FRM2_CE_COD_CLASE { get; set; }
        public string FRM2_FECHA_INICIO { get; set; }
        public string FRM2_FECHA_FIN { get; set; }

        // FORMACIÓN # 3
        public string FRM3_COD_CLASE { get; set; }
        public string FRM3_COD_FORMACION { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombre del Instituto (Formación # 3) debe contener entre 3 y 40 carácteres.")]
        public string FRM3_INSTITUTO { get; set; }
        public string FRM3_COD_PAIS { get; set; }
        public string FRM3_CT_COD_CLASE { get; set; }
        public string FRM3_CT_COD_TITULO { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Duración (Formación # 3) permite únicamente números.")]
        public string FRM3_DURACION { get; set; }
        public string FRM3_UNIDAD_TIEMPO { get; set; }
        public string FRM3_CE_COD_ESPECIALIDAD { get; set; }
        public string FRM3_CE_COD_CLASE { get; set; }
        public string FRM3_FECHA_INICIO { get; set; }
        public string FRM3_FECHA_FIN { get; set; }
        #endregion

        #region DATOS_EXPERIENCIA_LABORAL
        // EXPERIENCIA # 1
        //public string EXP1_CEDULA { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Inicio (Experiencia Laboral # 1) no posee un formato válido : (dd/mm/yyyy)")]
        public string EXP1_FECHA_INICIO { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Fin (Experiencia Laboral # 1) no posee un formato válido : (dd/mm/yyyy)")]
        public string EXP1_FECHA_FIN { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Empresa (Experiencia # 1) debe contener entre 3 y 40 carácteres.")]
        public string EXP1_EMPRESA { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Ciudad (Experiencia # 1) debe contener entre 3 y 40 carácteres.")]
        public string EXP1_CIUDAD { get; set; }

        public string EXP1_PAIS { get; set; }
        public string EXP1_COD_RAMO { get; set; }
        public string EXP1_COD_ACTIVIDAD { get; set; }
        public string EXP1_COD_RELACION { get; set; }

        // EXPERIENCIA # 2
        //public string EXP2_CEDULA { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Inicio (Experiencia Laboral # 2) no posee un formato válido : (dd/mm/yyyy)")]
        public string EXP2_FECHA_INICIO { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Fin (Experiencia Laboral # 2) no posee un formato válido : (dd/mm/yyyy)")]
        public string EXP2_FECHA_FIN { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Empresa (Experiencia # 2) debe contener entre 3 y 40 carácteres.")]
        public string EXP2_EMPRESA { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Ciudad (Experiencia # 2) debe contener entre 3 y 40 carácteres.")]
        public string EXP2_CIUDAD { get; set; }

        public string EXP2_PAIS { get; set; }
        public string EXP2_COD_RAMO { get; set; }
        public string EXP2_COD_ACTIVIDAD { get; set; }
        public string EXP2_COD_RELACION { get; set; }

        // EXPERIENCIA # 3
        //public string EXP3_CEDULA { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Inicio (Experiencia Laboral # 3) no posee un formato válido : (dd/mm/yyyy)")]
        public string EXP3_FECHA_INICIO { get; set; }

        [RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4})$",
            ErrorMessage = "El campo Fecha de Fin (Experiencia Laboral # 3) no posee un formato válido : (dd/mm/yyyy)")]
        public string EXP3_FECHA_FIN { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Empresa (Experiencia # 3) debe contener entre 3 y 40 carácteres.")]
        public string EXP3_EMPRESA { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Ciudad (Experiencia # 3) debe contener entre 3 y 40 carácteres.")]
        public string EXP3_CIUDAD { get; set; }

        public string EXP3_PAIS { get; set; }
        public string EXP3_COD_RAMO { get; set; }
        public string EXP3_COD_ACTIVIDAD { get; set; }
        public string EXP3_COD_RELACION { get; set; }
        #endregion

        #region DATOS_SESSION
        public string COD_USER { get; set; }

        public string FIELD_WITHOUT_VALUE { get; set; }
        #endregion
        
        #endregion

        /* ORACLE NEXTVAL */
        public decimal NEXTVAL { get; set; }

        /* ESTRUCTURAS DE LISTAS */
        #region LISTAS_DE_ATRIBUTOS

        #region DATOS_PERSONALES
        public List<GenericModel> Generos;
        public List<PAIS> Paises;
        public List<NACIONALIDAD> Nacionalidades;
        public List<PAIS_ESTADO> Estados;
        public List<GenericModel> EstadoCivil;
        public List<AREA_PERSONAL> NivelCargo;
        public List<SUCURSAL> Sucursales;
        public List<GRUPO_PERSONAL> GrupoPersonal;
        public List<string> Tratamiento;
        public List<Generic2Model> TallaChemise;
        public List<Generic2Model> TallaPantalon;
        public List<GenericModel> TallaCalzado;
        #endregion

        #region DIRECCION
        public List<ESTADO_SSO> EstadoSSO;
        public List<MUNICIPIO_SSO> MunicipioSSO;
        public List<PARROQUIA_SSO> ParroquiaSSO;
        public List<PARENTESCO> Parentescos;
        #endregion

        #region DATOS_DISCAPACIDAD
        public List<DDISCAPACIDAD> Discapacidades;
        #endregion

        #region DATOS_FAMILIARES
        public List<DFAMILIAR> Familiares;
        #endregion

        #region FORMACION
        public List<DFORMACION> DFormaciones;
        public List<FORMACION> Formaciones;
        public List<CLASE_INSTITUTO> NivelEstudio;
        public List<CLASE_TITULO> Condiciones;
        public List<CLASE_ESPECIALIDAD> Especialidades;
        public List<GenericModel> UnidadesTiempo;
        #endregion

        #region EXPERIENCIA_LABORAL
        public List<DEXPERIENCIA> Experiencias;
        public List<ACTIVIDAD> UltimosCargos;
        public List<RAMO> Areas;
        public List<RELACION_LABORAL> TipoContratacion;
        #endregion

        #endregion


        public EmployeeViewModel()
        {

            //DPERSONALES DATOS_PERSONALES = new DPERSONALES();

            //FillDummyRecord();
            FillListas();

        }

        private void FillListas()
        {
            Generos = ListViewModel.FillGeneros();
            Paises = ListViewModel.FillPaises();
            Nacionalidades = ListViewModel.Nacionalidades();
            Estados = ListViewModel.GetPaisEstados().Where(e => e.COD_PAIS == "VE").ToList();
            EstadoCivil = ListViewModel.EstadoCivil();
            NivelCargo = ListViewModel.AreaPersonal();

            Sucursales = ListViewModel.Sucursales();
            GrupoPersonal = ListViewModel.GrupoPersonal();
            Tratamiento = ListViewModel.Tratamiento();
            TallaChemise = ListViewModel.GetTallaChemise();
            TallaPantalon = ListViewModel.GetTallaPantalon();
            TallaCalzado = ListViewModel.GetTallaCalzado();

            #region DIRECCION
            EstadoSSO = ListViewModel.GetEstadoSSO();
            MunicipioSSO = ListViewModel.GetMunicipioSSO();
            ParroquiaSSO = ListViewModel.GetParroquiaSSO();
            Parentescos = ListViewModel.GetParentesco();
            #endregion

            #region FORMACION
            //Formaciones = ListViewModel.GetFormacion();
            NivelEstudio = ListViewModel.GetNivelEstudio();
            Condiciones = ListViewModel.GetCondiciones();
            Especialidades = ListViewModel.GetEspecialidades();
            UnidadesTiempo = ListViewModel.GetUnidadTiempo();
            #endregion

            #region EXPERIENCIA_LABORAL
            UltimosCargos = ListViewModel.GetUltimoCargo();
            Areas = ListViewModel.GetArea();
            TipoContratacion = ListViewModel.GetTipoContratacion();
            #endregion

        }

        private void FillDummyRecord()
        {

            /* Datos Personales */

            //DPERSONALES DATOS_PERSONALES = new DPERSONALES();

            FICHA = "123456789012";
            CEDULA = "12919906";
            COD_SUCURSAL = "1001";
            COD_GRUPO = "1";
            COD_AREA_PERSONAL = "VK";
            CARGO = "CARGO";
            TRATAMIENTO = "Sra.";
            PRIMER_APELLIDO = "GONZALEZ";
            SEGUNDO_APELLIDO = "LOPEZ";
            NOMBRE = "FLOR MARINA";
            FECHA_NACIMIENTO = "18/01/1976";    // ("1976-01-18", CultureInfo.InvariantCulture);
            CIUDAD_NACIMIENTO = "PORLAMAR";
            COD_PAIS = "VE";
            COD_ESTADO = "NE";
            COD_NACIONALIDAD = "PA";
            ESTADO_CIVIL = "Cas.";
            SEXO = "F";
            RIF = "J129199060";
            CALZADO = "34";
            CHEMISE = "S";
            PANTALON = "8";
            COD_CLASE_CELULAR = "04128094599";
            COD_CLASE_CORREO = "flormarinagl@gmail.com";

            /* DIRECCIÓN */
            CALLE = "CALLEJÓN MACHADO";
            EDIFICIO = "RESD.LOS GRANADILLOS";
            PISO = "14";
            NUMERO = "141";
            URBANIZACION = "EL PARAÍSO";
            COD_PAIS = "VE";
            COD_ESTADO_DIRECCION = "DC";
            CIUDAD = "CARACAS";
            TELEFONOS = "0124835448";
            COD_ESTADO_SSO = "NUE";
            COD_MUNICIPIO_SSO = "217";
            COD_PARROQUIA_SSO = "1191";

            /* DISCAPACIDAD */
            COD_DISCAPACIDAD_MOTRIZ = false;
            COD_DISCAPACIDAD_SENSORIAL = false;
            COD_DISCAPACIDAD_INTELECTUAL = false;

            /* FAMILIARES */
            FAM1_COD_PARENTESCO = "1";
            FAM1_PRIMER_APELLIDO = "DEPABLOS";
            FAM1_SEGUNDO_APELLIDO = "SILVA";
            FAM1_NOMBRES = "DANIEL";
            FAM1_FECHA_NACIMIENTO = "05/04/1974";
            FAM1_LUGAR_NACIMIENTO = "CARACAS";
            FAM1_COD_PAIS = "VE";
            FAM1_COD_NACIONALIDAD = "VE";
            FAM1_CEDULA_FAMILIAR = "11681109";
            FAM1_SEXO = "M";

            FAM2_COD_PARENTESCO = "1";
            FAM2_PRIMER_APELLIDO = "DEPABLOS";
            FAM2_SEGUNDO_APELLIDO = "GONZALEZ";
            FAM2_NOMBRES = "NICOLE CELESTE";
            FAM2_FECHA_NACIMIENTO = "10/10/2016";
            FAM2_LUGAR_NACIMIENTO = "CARACAS";
            FAM2_COD_PAIS = "VE";
            FAM2_COD_NACIONALIDAD = "VE";
            FAM2_CEDULA_FAMILIAR = "";
            FAM2_SEXO = "F";            

            // DATOS DE FORMACIÓN //
            FRM1_COD_CLASE = "V1";
            FRM1_CT_COD_CLASE = "V1";
            FRM1_CT_COD_TITULO = "2";
            FRM1_CE_COD_CLASE = "V1";
            FRM1_CE_COD_ESPECIALIDAD = "00001";
            FRM1_INSTITUTO = "INSTITUTO 1";
            FRM1_DURACION = "5";
            FRM1_UNIDAD_TIEMPO = "Años";
            FRM1_FECHA_INICIO = "01/01/2000";
            FRM1_FECHA_FIN = "01/01/2005";
            FRM1_COD_PAIS = "VE";

            FRM2_COD_CLASE = "V1";
            FRM2_CT_COD_CLASE = "V1";
            FRM2_CT_COD_TITULO = "2";
            FRM2_CE_COD_CLASE = "V1";
            FRM2_CE_COD_ESPECIALIDAD = "00001";
            FRM2_INSTITUTO = "INSTITUTO 2";
            FRM2_DURACION = "5";
            FRM2_UNIDAD_TIEMPO = "Años";
            FRM2_FECHA_INICIO = "01/01/2005";
            FRM2_FECHA_FIN = "01/01/2010";
            FRM2_COD_PAIS = "VE";

            // DATOS EXPERIENCIA //
            EXP1_FECHA_INICIO = "01/01/2000";
            EXP1_FECHA_FIN = "01/01/2010";
            EXP1_EMPRESA = "EMPRESA 1";
            EXP1_CIUDAD = "CARACAS";
            EXP1_PAIS = "VE";
            EXP1_COD_RAMO = "36";
            EXP1_COD_ACTIVIDAD = "14";
            EXP1_COD_RELACION = "5";

            EXP2_FECHA_INICIO = "01/01/2010";
            EXP2_FECHA_FIN = "01/01/2011";
            EXP2_EMPRESA = "EMPRESA 2";
            EXP2_CIUDAD = "CARACAS";
            EXP2_PAIS = "VE";
            EXP2_COD_RAMO = "36";
            EXP2_COD_ACTIVIDAD = "14";
            EXP2_COD_RELACION = "6";


        }



    }
}