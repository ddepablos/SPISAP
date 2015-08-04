using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using SPISAP.Models;

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

        /* DFAMILIAR : Datos Familiares */
        public DFAMILIAR DATOS_FAMILIARES { get; set; }

        /* GÉNERO */
        public List<GenericModel> Generos;

        /* DDISCAPACIDAD */
        public List<DDISCAPACIDAD> Discapacidades; //{ set; get; }

        /* DATOS FAMILIARES */
        public List<DFAMILIAR> Familiares;

        /* DATOS DE FORMACIÓN */
        public List<DFORMACION> Formaciones;

        /* DATOS DE EXPERIENCIA LABORAL */
        public List<DEXPERIENCIA> Experiencias;

        /* Estructuras de Listas */
        #region DATOS_PERSONALES
        public List<PAIS> Paises;
        public List<NACIONALIDAD> Nacionalidades;
        public List<PAIS_ESTADO> Estados;
        public List<GenericModel> EstadoCivil;
        public List<AREA_PERSONAL> NivelCargo;

        public List<SUCURSAL> Sucursales;
        public List<GRUPO_PERSONAL> GrupoPersonal;
        public List<string> Tratamiento;
        public List<GenericModel> TallaChemise;
        public List<GenericModel> TallaPantalon;
        public List<GenericModel> TallaCalzado;
        #endregion

        #region DIRECCION
        public List<ESTADO_SSO> EstadoSSO;
        public List<MUNICIPIO_SSO> MunicipioSSO;
        public List<PARROQUIA_SSO> ParroquiaSSO;
        public List<PARENTESCO> Parentescos;
        #endregion

        public EmployeeViewModel()
        {

            //FillDummyRecord();
            FillListas();

        }

        private void FillListas()
        {
            Generos = ListViewModel.FillGeneros();
            Paises = ListViewModel.FillPaises();
            Nacionalidades = ListViewModel.Nacionalidades();
            Estados = ListViewModel.Estados();
            EstadoCivil = ListViewModel.EstadoCivil();
            NivelCargo = ListViewModel.AreaPersonal();

            Sucursales = ListViewModel.Sucursales();
            GrupoPersonal = ListViewModel.GrupoPersonal();
            Tratamiento = ListViewModel.Tratamiento();
            TallaChemise = ListViewModel.FillTallaChemise();
            TallaPantalon = ListViewModel.FillTallaPantalon();
            TallaCalzado = ListViewModel.FillTallaCalzado();

            #region DIRECCION
            EstadoSSO = ListViewModel.GetEstadoSSO();
            MunicipioSSO = ListViewModel.GetMunicipioSSO();
            ParroquiaSSO = ListViewModel.GetParroquiaSSO();
            Parentescos = ListViewModel.GetParentesco();
            #endregion


        }

        private void FillDummyRecord()
        {

            /* Datos Personales */
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
            FECHA_NACIMIENTO = DateTime.Parse("1976-01-18", CultureInfo.InvariantCulture);
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

            /* Dirección */
            CALLE = "CALLEJÓN MACHADO";
            EDIFICIO = "RESD.LOS GRANADILLOS";
            PISO = "14";
            NUMERO = "141B";
            URBANIZACION = "EL PARAÍSO";
            COD_ESTADO = "";
            COD_PAIS = "";
            TELEFONOS = "0124835448";
            COD_ESTADO_SSO = "NUE";
            COD_MUNICIPIO_SSO = "217";
            COD_PARROQUIA_SSO = "1191";

            /* Discapacidad : 'ZA', 'ZB', 'ZC' */
            Discapacidades = new List<DDISCAPACIDAD>();
            Discapacidades.Add(new DDISCAPACIDAD { CEDULA = "12919906", GRUPO_DISCAPACIDAD = "ZA", COD_USER_INS = "CROSARIO", FECHA_INS = System.DateTime.Now, COD_USER_UPD = "CROSARIO", FECHA_UPD = null });
            Discapacidades.Add(new DDISCAPACIDAD { CEDULA = "12919906", GRUPO_DISCAPACIDAD = "ZB", COD_USER_INS = "CROSARIO", FECHA_INS = System.DateTime.Now, COD_USER_UPD = "CROSARIO", FECHA_UPD = null });

            /* Familiares */
            Familiares = new List<DFAMILIAR>();
            Familiares.Add(new DFAMILIAR { CEDULA = "12919906", COD_PARENTESCO = "1", PRIMER_APELLIDO = "DEPABLOS", SEGUNDO_APELLIDO = "SILVA", NOMBRES = "DANIEL JOSÉ", FECHA_NACIMIENTO = DateTime.Parse("1974-04-05", CultureInfo.InvariantCulture), LUGAR_NACIMIENTO = "CARACAS", COD_PAIS = "VE", COD_NACIONALIDAD = "VE", CEDULA_FAMILIAR = "11681109", SEXO = "M" });
            Familiares.Add(new DFAMILIAR { CEDULA = "12919906", COD_PARENTESCO = "2", PRIMER_APELLIDO = "DEPABLOS", SEGUNDO_APELLIDO = "GONZALEZ", NOMBRES = "NICOLLE", FECHA_NACIMIENTO = DateTime.Parse("2016-04-05", CultureInfo.InvariantCulture), LUGAR_NACIMIENTO = "PORLAMAR", COD_PAIS = "VE", COD_NACIONALIDAD = "VE", CEDULA_FAMILIAR = "", SEXO = "F" });

            /* Formación */
            Formaciones = new List<DFORMACION>();
            Formaciones.Add(new DFORMACION { CEDULA = "12919906", COD_CLASE = "V1", COD_FORMACION = "7", INSTITUO = "UNEFA", COD_PAIS = "VE", CT_COD_CLASE = "V1", CT_COD_TITULO = "2", DURACION = "5", UNIDAD_TIEMPO = "Años", CE_COD_ESPECIALIDAD = "00094", CE_COD_CLASE = "V1", FECHA_INICIO = DateTime.Parse("2010-01-01", CultureInfo.InvariantCulture), FECHA_FIN = DateTime.Parse("2015-01-01", CultureInfo.InvariantCulture), COD_USER_INS = "CROSARIO", FECHA_INS = System.DateTime.Now, COD_USER_UPD = null, FECHA_UPD = System.DateTime.Now });

            /* Experiencia */
            Experiencias = new List<DEXPERIENCIA>();
            Experiencias.Add(new DEXPERIENCIA { CEDULA = "12919906", FECHA_INICIO = DateTime.Parse("2000-01-01", CultureInfo.InvariantCulture), FECHA_FIN = DateTime.Parse("2010-01-01", CultureInfo.InvariantCulture), EMPRESA = "GOOGLE INC", CIUDAD = "SEATTLE", PAIS = "VE", COD_RAMO = "01", COD_ACTIVIDAD = "01", COD_RELACION = "5", COD_USER_INS = "CROSARIO", FECHA_INS = System.DateTime.Now, COD_USER_UPD = null, FECHA_UPD = System.DateTime.Now });

            /* Usuario */
            COD_USER_INS = "CROSARIO";
            FECHA_INS = System.DateTime.Now;
            COD_USER_UPD = null;
            FECHA_UPD = System.DateTime.Now;
        
        }

        // estructura de registro de item dummy.
        public class GENERO
        {
            public string CODIGO { get; set; }
            public string DESCRIPCION { get; set; }
        }

    }
}