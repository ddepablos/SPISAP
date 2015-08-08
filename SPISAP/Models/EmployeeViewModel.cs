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

        /* DATOS DE SESIÓN */
        public string COD_USER { get; set; } 

        /* DPERSONALES : Datos Personales */
        public DPERSONALES DATOS_PERSONALES { get; set; }

        /* DDIRECCION : Dirección del Trabajador */
        public DDIRECCION DATOS_DIRECCION { get; set; }

        /* DCOMUNICACION : Datos de Comunicación : Número de Teléfono y/o Correo Electrónico */
        public DCOMUNICACION DATOS_COMUNICACION { get; set; }

        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                    ErrorMessage = "El campo Correo Electrónico no contiene el formato válido : usuario@correo.com.")]
        public string COD_CLASE_CORREO { get; set; }

        [Required(ErrorMessage = "El campo Teléfono Celular es requerido.")]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Teléfono Celular permite únicamente números.")]
        public string COD_CLASE_CELULAR { get; set; }

        /* DDISCAPACIDAD : Datos de Discapacidad */
        public DDISCAPACIDAD DATOS_DISCAPACIDAD { get; set; }
        public bool COD_DISCAPACIDAD_MOTRIZ { get; set; }
        public bool COD_DISCAPACIDAD_INTELECTUAL { get; set; }
        public bool COD_DISCAPACIDAD_SENSORIAL { get; set; }

        /* DFAMILIAR */
        public DFAMILIAR DATOS_FAMILIARES { get; set; }
        
        // * * * D A T O S  F A M I L I A R E S * * *
        // FAMILIAR # 1
        public string FAM1_COD_PARENTESCO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido (Familiar # 1) debe contener entre 3 y 40 carácteres.")]       
        public string FAM1_PRIMER_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Segundo Apellido (Familiar # 1) debe contener entre 3 y 40 carácteres.")]
        public string FAM1_SEGUNDO_APELLIDO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombres (Familiar # 1) debe contener entre 3 y 40 carácteres.")]
        public string FAM1_NOMBRES { get; set; }

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

        public string FAM10_FECHA_NACIMIENTO { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Lugar de Nacimiento (Familiar # 10) debe contener entre 3 y 40 carácteres.")]
        public string FAM10_LUGAR_NACIMIENTO { get; set; }

        public string FAM10_COD_PAIS { get; set; }
        public string FAM10_COD_NACIONALIDAD { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula (Familiar # 10) permite únicamente números.")]
        public string FAM10_CEDULA_FAMILIAR { get; set; }

        public string FAM10_SEXO { get; set; }

        // * * * FORMACIÓN ACADÉMICA * * * //
 
        // FORMACIÓN # 1
        [Required(ErrorMessage = "El campo Nivel de Estudio es requerido.")]
        public string FRM1_COD_CLASE { get; set; }

        // PENDIENTE POR ANALIZAR SU VALOR.
        public string FRM1_COD_FORMACION { get; set; }

        [Required(ErrorMessage = "El campo Nombre del Instituto es requerido.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombre del Instituto (Formación # 1) debe contener entre 3 y 40 carácteres.")]
        public string FRM1_INSTITUO { get; set; }

        [Required(ErrorMessage = "El campo País (Formación # 1) es requerido.")]
        public string FRM1_COD_PAIS { get; set; }

        public string FRM1_CT_COD_CLASE { get; set; }

        [Required(ErrorMessage = "El campo Condición es requerido.")]
        public string FRM1_CT_COD_TITULO { get; set; }

        [Required(ErrorMessage = "El campo Duración (Número) es requerido.")]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Duración (Formación # 1) permite únicamente números.")]
        public string FRM1_DURACION { get; set; }

        [Required(ErrorMessage = "El campo Duración (Tiempo) es requerido.")]
        public string FRM1_UNIDAD_TIEMPO { get; set; }

        [Required(ErrorMessage = "El campo Especialidad es requerido.")]
        public string FRM1_CE_COD_ESPECIALIDAD { get; set; }

        public string FRM1_CE_COD_CLASE { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Inicio (Formación # 1) es requerido.")]
        public string FRM1_FECHA_INICIO { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Finalización (Formación # 1) es requerido.")]
        public string FRM1_FECHA_FIN { get; set; }

        // FORMACIÓN # 2
        public string FRM2_COD_CLASE { get; set; }
        public string FRM2_COD_FORMACION { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Nombre del Instituto (Formación # 2) debe contener entre 3 y 40 carácteres.")]
        public string FRM2_INSTITUO { get; set; }
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
        public string FRM3_INSTITUO { get; set; }
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

        // * * * EXPERIENCIA LABORAL * * *                 
        // EXPERIENCIA # 1
        public string EXP1_CEDULA { get; set; }
        public string EXP1_FECHA_INICIO { get; set; }
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
        public string EXP2_CEDULA { get; set; }
        public string EXP2_FECHA_INICIO { get; set; }
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
        public string EXP3_CEDULA { get; set; }
        public string EXP3_FECHA_INICIO { get; set; }
        public string EXP3_FECHA_FIN { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Empresa (Experiencia # 3) debe contener entre 3 y 40 carácteres.")]
        public string EXP3_EMPRESA { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Ciudad (Experiencia # 3) debe contener entre 3 y 40 carácteres.")]
        public string EXP3_CIUDAD { get; set; }

        public string EXP3_PAIS { get; set; }
        public string EXP3_COD_RAMO { get; set; }
        public string EXP3_COD_ACTIVIDAD { get; set; }
        public string EXP3_COD_RELACION { get; set; }

        /* ESTRUCTURAS DE LISTAS */
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

        public EmployeeViewModel()
        {

            DPERSONALES DATOS_PERSONALES = new DPERSONALES();

            //FillDummyRecord();
            FillListas();

        }

        private void FillListas()
        {
            Generos = ListViewModel.FillGeneros();
            Paises = ListViewModel.FillPaises();
            Nacionalidades = ListViewModel.Nacionalidades();
            Estados = ListViewModel.GetPaisEstados().Where(e => e.COD_PAIS=="VE").ToList();
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
            //MunicipioSSO = ListViewModel.GetMunicipioSSO();
            //ParroquiaSSO = ListViewModel.GetParroquiaSSO();
            Parentescos = ListViewModel.GetParentesco();
            #endregion

            #region FORMACION
            //Formaciones = ListViewModel.GetFormacion();
            NivelEstudio = ListViewModel.GetNivelEstudio();
            //Condiciones = ListViewModel.GetCondiciones();
            //Especialidades = ListViewModel.GetEspecialidades();
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

            //DATOS_PERSONALES.FICHA = "123456789012";
            //DATOS_PERSONALES.CEDULA = "12919906";
            //DATOS_PERSONALES.COD_SUCURSAL = "1001";
            //DATOS_PERSONALES.COD_GRUPO = "1";
            //DATOS_PERSONALES.COD_AREA_PERSONAL = "VK";
            //DATOS_PERSONALES.CARGO = "CARGO";
            //DATOS_PERSONALES.TRATAMIENTO = "Sra.";
            //DATOS_PERSONALES.PRIMER_APELLIDO = "GONZALEZ";
            //DATOS_PERSONALES.SEGUNDO_APELLIDO = "LOPEZ";
            //DATOS_PERSONALES.NOMBRE = "FLOR MARINA";
            //DATOS_PERSONALES.FECHA_NACIMIENTO = DateTime.Parse("1976-01-18", CultureInfo.InvariantCulture);
            //DATOS_PERSONALES.CIUDAD_NACIMIENTO = "PORLAMAR";
            //DATOS_PERSONALES.COD_PAIS = "VE";
            //DATOS_PERSONALES.COD_ESTADO = "NE";
            //DATOS_PERSONALES.COD_NACIONALIDAD = "PA";
            //DATOS_PERSONALES.ESTADO_CIVIL = "Cas.";
            //DATOS_PERSONALES.SEXO = "F";
            //DATOS_PERSONALES.RIF = "J129199060";
            //DATOS_PERSONALES.CALZADO = "34";
            //DATOS_PERSONALES.CHEMISE = "S";
            //DATOS_PERSONALES.PANTALON = "8";

            /* Dirección */

            //DDIRECCION DATOS_DIRECCION = new DDIRECCION();

            //DATOS_DIRECCION.CALLE = "CALLEJÓN MACHADO";
            //DATOS_DIRECCION.EDIFICIO = "RESD.LOS GRANADILLOS";
            //DATOS_DIRECCION.PISO = "14";
            //DATOS_DIRECCION.NUMERO = "141B";
            //DATOS_DIRECCION.URBANIZACION = "EL PARAÍSO";
            //DATOS_DIRECCION.COD_ESTADO = "";
            //DATOS_DIRECCION.COD_PAIS = "";
            //DATOS_DIRECCION.TELEFONOS = "0124835448";
            //DATOS_DIRECCION.COD_ESTADO_SSO = "NUE";
            //DATOS_DIRECCION.COD_MUNICIPIO_SSO = "217";
            //DATOS_DIRECCION.COD_PARROQUIA_SSO = "1191";

            /* DISCAPACIDAD */
            //COD_DISCAPACIDAD_MOTRIZ = true;
            //COD_DISCAPACIDAD_SENSORIAL = true;
            //COD_DISCAPACIDAD_INTELECTUAL = false;

            /* FAMILIARES */


            ///* Discapacidad : 'ZA', 'ZB', 'ZC' */
            //Discapacidades = new List<DDISCAPACIDAD>();
            //Discapacidades.Add(new DDISCAPACIDAD { CEDULA = "12919906", GRUPO_DISCAPACIDAD = "ZA", COD_USER_INS = "CROSARIO", FECHA_INS = System.DateTime.Now, COD_USER_UPD = "CROSARIO", FECHA_UPD = null });
            //Discapacidades.Add(new DDISCAPACIDAD { CEDULA = "12919906", GRUPO_DISCAPACIDAD = "ZB", COD_USER_INS = "CROSARIO", FECHA_INS = System.DateTime.Now, COD_USER_UPD = "CROSARIO", FECHA_UPD = null });

            ///* Familiares */
            //Familiares = new List<DFAMILIAR>();
            //Familiares.Add(new DFAMILIAR { CEDULA = "12919906", COD_PARENTESCO = "1", PRIMER_APELLIDO = "DEPABLOS", SEGUNDO_APELLIDO = "SILVA", NOMBRES = "DANIEL JOSÉ", FECHA_NACIMIENTO = DateTime.Parse("1974-04-05", CultureInfo.InvariantCulture), LUGAR_NACIMIENTO = "CARACAS", COD_PAIS = "VE", COD_NACIONALIDAD = "VE", CEDULA_FAMILIAR = "11681109", SEXO = "M" });
            //Familiares.Add(new DFAMILIAR { CEDULA = "12919906", COD_PARENTESCO = "2", PRIMER_APELLIDO = "DEPABLOS", SEGUNDO_APELLIDO = "GONZALEZ", NOMBRES = "NICOLLE", FECHA_NACIMIENTO = DateTime.Parse("2016-04-05", CultureInfo.InvariantCulture), LUGAR_NACIMIENTO = "PORLAMAR", COD_PAIS = "VE", COD_NACIONALIDAD = "VE", CEDULA_FAMILIAR = "", SEXO = "F" });

            ///* Formación */
            //DFormaciones = new List<DFORMACION>();
            //DFormaciones.Add(new DFORMACION { CEDULA = "12919906", COD_CLASE = "V1", COD_FORMACION = "7", INSTITUO = "UNEFA", COD_PAIS = "VE", CT_COD_CLASE = "V1", CT_COD_TITULO = "2", DURACION = "5", UNIDAD_TIEMPO = "Años", CE_COD_ESPECIALIDAD = "00094", CE_COD_CLASE = "V1", FECHA_INICIO = DateTime.Parse("2010-01-01", CultureInfo.InvariantCulture), FECHA_FIN = DateTime.Parse("2015-01-01", CultureInfo.InvariantCulture), COD_USER_INS = "CROSARIO", FECHA_INS = System.DateTime.Now, COD_USER_UPD = null, FECHA_UPD = System.DateTime.Now });

            ///* Experiencia */
            //Experiencias = new List<DEXPERIENCIA>();
            //Experiencias.Add(new DEXPERIENCIA { CEDULA = "12919906", FECHA_INICIO = DateTime.Parse("2000-01-01", CultureInfo.InvariantCulture), FECHA_FIN = DateTime.Parse("2010-01-01", CultureInfo.InvariantCulture), EMPRESA = "GOOGLE INC", CIUDAD = "SEATTLE", PAIS = "VE", COD_RAMO = "01", COD_ACTIVIDAD = "01", COD_RELACION = "5", COD_USER_INS = "CROSARIO", FECHA_INS = System.DateTime.Now, COD_USER_UPD = null, FECHA_UPD = System.DateTime.Now });

            /* Usuario */
            //COD_USER_INS = "CROSARIO";
            //FECHA_INS = System.DateTime.Now;
            //COD_USER_UPD = null;
            //FECHA_UPD = System.DateTime.Now;
        
        }

        // estructura de registro de item dummy.
        public class GENERO
        {
            public string CODIGO { get; set; }
            public string DESCRIPCION { get; set; }
        }

    }
}