using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPISAP.Models;
using System.Globalization;
using System.Data.Entity.Validation;
using System.Data;

namespace SPISAP.Repositories
{
    public class EmployeeRepository
    {

        EmployeeViewModel empleado;

        static bool FORMAT_DATE_PRODUCCION = false;

        public EmployeeRepository()
        { 
            //by default.
        }

        public EmployeeRepository(EmployeeViewModel Empleado)
        {

            #region DATA_EMPLOYEE_TEST
            ////DATOS PERSONALES
            //Empleado.FICHA = "123456789012";
            //Empleado.CEDULA = "12919906";
            //Empleado.COD_SUCURSAL = "1001";
            //Empleado.COD_GRUPO = "1";
            //Empleado.COD_AREA_PERSONAL = "VK";
            //Empleado.CARGO = "CARGO";
            //Empleado.TRATAMIENTO = "Sra.";
            //Empleado.PRIMER_APELLIDO = "GONZALEZ";
            //Empleado.SEGUNDO_APELLIDO = "LOPEZ";
            //Empleado.NOMBRE = "FLOR MARINA";
            //Empleado.FECHA_NACIMIENTO = "1978/01/18";
            //Empleado.CIUDAD_NACIMIENTO = "PORLAMAR";
            //Empleado.COD_PAIS = "VE";
            //Empleado.COD_ESTADO = "NE";
            //Empleado.COD_NACIONALIDAD = "PA";
            //Empleado.ESTADO_CIVIL = "Cas.";
            //Empleado.SEXO = "M";
            //Empleado.RIF = "J129199060";
            //Empleado.CALZADO = "34";
            //Empleado.CHEMISE = "36";
            //Empleado.PANTALON = "36";

            //Empleado.COD_CLASE_CELULAR = "04128094599";
            //Empleado.COD_CLASE_CORREO = "flormaringl@gmail.com";

            //// DATOS DIRECCIÓN
            //Empleado.CALLE = "CALLEJÓN MACHADO";
            //Empleado.EDIFICIO = "RESD.LOS GRANADILLOS";
            //Empleado.PISO = "14";
            //Empleado.NUMERO = "141";
            //Empleado.URBANIZACION = "EL PARAÍSO";
            ////Empleado.COD_ESTADO = "DC";
            //Empleado.COD_PAIS = "VE";
            //Empleado.TELEFONOS = "4835448";
            //Empleado.COD_ESTADO_SSO = "DC";
            //Empleado.COD_MUNICIPIO_SSO = "1";
            //Empleado.COD_PARROQUIA_SSO = "663";
            //Empleado.CIUDAD = "CARACAS";

            //// DATOS DISCAPACIDAD
            //Empleado.COD_DISCAPACIDAD_MOTRIZ = true;
            //Empleado.COD_DISCAPACIDAD_SENSORIAL = false;
            //Empleado.COD_DISCAPACIDAD_INTELECTUAL = true;

            //// DATOS FAMILIARES
            //Empleado.FAM1_COD_PARENTESCO = "1";
            //Empleado.FAM1_PRIMER_APELLIDO = "DEPABLOS";
            //Empleado.FAM1_SEGUNDO_APELLIDO = "SILVA";
            //Empleado.FAM1_NOMBRES = "DANIEL JOSÉ";
            //Empleado.FAM1_FECHA_NACIMIENTO = "05/04/1974";
            //Empleado.FAM1_LUGAR_NACIMIENTO = "CARACAS";
            //Empleado.FAM1_COD_PAIS = "VE";
            //Empleado.FAM1_COD_NACIONALIDAD = "VE";
            //Empleado.FAM1_CEDULA_FAMILIAR = "11681109";
            //Empleado.FAM1_SEXO = "M";

            //// DATOS FORMACIÓN
            //Empleado.FRM1_COD_CLASE = "V8";
            //Empleado.FRM1_COD_FORMACION = "15";
            //Empleado.FRM1_INSTITUTO = "HARVARD";
            //Empleado.FRM1_COD_PAIS = "VE";
            //Empleado.FRM1_CT_COD_CLASE = "V8";
            //Empleado.FRM1_CT_COD_TITULO = "2";
            //Empleado.FRM1_DURACION = "10";
            //Empleado.FRM1_UNIDAD_TIEMPO = "3";
            //Empleado.FRM1_CE_COD_CLASE = "V8";
            //Empleado.FRM1_CE_COD_ESPECIALIDAD = "00207";
            //Empleado.FRM1_FECHA_INICIO = "01/10/2000";
            //Empleado.FRM1_FECHA_FIN = "01/10/2000";

            //// DATOS EXPERIENCIA LABORAL
            //Empleado.EXP1_FECHA_INICIO = "01/01/2000";
            //Empleado.EXP1_FECHA_FIN = "31/01/2000";
            //Empleado.EXP1_EMPRESA = "EMPRESA 1";
            //Empleado.EXP1_CIUDAD = "CIUDAD 1";
            //Empleado.EXP1_PAIS = "VE";
            //Empleado.EXP1_COD_RAMO = "01";
            //Empleado.EXP1_COD_ACTIVIDAD = "01";
            //Empleado.EXP1_COD_RELACION = "4";
            #endregion

            // agregar valores por defecto.
            Empleado.COD_PAIS_DIRECCION = "VE";
            Empleado.NEXTVAL = GetOracleNextVal();
            Empleado.COD_USER = (string) HttpContext.Current.Session["COD_USER"];

            empleado = Empleado;
        }

        public EmployeeViewModel GetEmployee()
        { 
            EmployeeViewModel employee = new EmployeeViewModel();

            return employee;
        }

        public bool IsValid()
        {
            return true;
        }

        public bool IsNotValid()
        {
            return false;
        }

        public bool IsFound()
        {
            return true;
        }

        public List<EmployeeRepository> GetEmployees()
        {
            return null;
        }

        public EmployeeViewModel FindEmployee(string value)
        {

            using ( SPISAPEntities db = new SPISAPEntities() )
            {

                EmployeeViewModel record = (from dp in db.DPERSONALES
                                            join dd in db.DDIRECCIONES on dp.CEDULA equals dd.CEDULA
                                            where dp.CEDULA.Equals(value)
                                            select new EmployeeViewModel()
                                            {
                                                FICHA = dp.FICHA,
                                                PRIMER_APELLIDO = dp.PRIMER_APELLIDO,
                                                SEGUNDO_APELLIDO = dp.SEGUNDO_APELLIDO,
                                                NOMBRE = dp.NOMBRE,
                                                CEDULA = dp.CEDULA,
                                                SEXO = dp.SEXO,
                                                FECHA_NACIMIENTO_DATE = dp.FECHA_NACIMIENTO, 
                                                CIUDAD_NACIMIENTO = dp.CIUDAD_NACIMIENTO,
                                                COD_PAIS = dp.COD_PAIS,
                                                COD_NACIONALIDAD = dp.COD_NACIONALIDAD,
                                                COD_ESTADO = dp.COD_ESTADO,
                                                COD_ESTADO_DIRECCION = dp.COD_ESTADO,
                                                ESTADO_CIVIL = dp.ESTADO_CIVIL,
                                                RIF = dp.RIF, 
                                                COD_AREA_PERSONAL = dp.COD_AREA_PERSONAL,
                                                CARGO = dp.CARGO,
                                                COD_SUCURSAL = dp.COD_SUCURSAL,
                                                COD_GRUPO = dp.COD_GRUPO,
                                                TRATAMIENTO = dp.TRATAMIENTO,
                                                CHEMISE = dp.CHEMISE,
                                                PANTALON = dp.PANTALON,
                                                CALZADO = dp.CALZADO,
                                                CALLE = dd.CALLE,
                                                EDIFICIO = dd.EDIFICIO,
                                                PISO = dd.PISO,
                                                NUMERO = dd.NUMERO,
                                                URBANIZACION = dd.URBANIZACION,
                                                COD_PARROQUIA_SSO = dd.COD_PARROQUIA_SSO,
                                                COD_MUNICIPIO_SSO = dd.COD_MUNICIPIO_SSO,
                                                CIUDAD = dd.CIUDAD,
                                                COD_ESTADO_SSO = dd.COD_ESTADO_SSO,
                                                COD_PAIS_DIRECCION = dd.COD_PAIS,
                                                TELEFONOS = dd.TELEFONOS
                                            }).SingleOrDefault();

                record.FECHA_NACIMIENTO = OracleDateToString(record.FECHA_NACIMIENTO_DATE);

                // DATOS DE COMUNICACIÓN
                record.COD_CLASE_CORREO = FindDComunicacion("correo" , record.CEDULA);
                record.COD_CLASE_CELULAR = FindDComunicacion("cell" , record.CEDULA);

                // DATOS DE DISCAPACIDAD
                record.COD_DISCAPACIDAD_MOTRIZ = FindDDiscapacidad("motriz", record.CEDULA);
                record.COD_DISCAPACIDAD_INTELECTUAL = FindDDiscapacidad("intelectual", record.CEDULA);
                record.COD_DISCAPACIDAD_SENSORIAL = FindDDiscapacidad("sensorial", record.CEDULA);

                // DATOS DE FAMILIARES
                #region TABLA_DATOS_FAMILIARES

                // llenar los datos familiares.
                List<DFAMILIAR> query = db.DFAMILIARES.Where(x => x.CEDULA_FAMILIAR.Equals(record.CEDULA)).ToList();

                for (int i = 0; i < query.Count(); i++)
                {

                    switch (i)
                    {
                        case 0:
                            record.FAM1_COD_PARENTESCO = query[i].COD_PARENTESCO;
                            record.FAM1_PRIMER_APELLIDO = query[i].PRIMER_APELLIDO;
                            record.FAM1_SEGUNDO_APELLIDO = query[i].SEGUNDO_APELLIDO;
                            record.FAM1_NOMBRES = query[i].NOMBRES;
                            record.FAM1_FECHA_NACIMIENTO = OracleDateToString(query[i].FECHA_NACIMIENTO);
                            record.FAM1_LUGAR_NACIMIENTO = query[i].LUGAR_NACIMIENTO;
                            record.FAM1_COD_PAIS = query[i].COD_PAIS;
                            record.FAM1_COD_NACIONALIDAD = query[i].COD_NACIONALIDAD;
                            record.FAM1_CEDULA_FAMILIAR = query[i].CEDULA;
                            record.FAM1_SEXO = query[i].SEXO;
                            break;
                        case 1:
                            record.FAM2_COD_PARENTESCO = query[i].COD_PARENTESCO;
                            record.FAM2_PRIMER_APELLIDO = query[i].PRIMER_APELLIDO;
                            record.FAM2_SEGUNDO_APELLIDO = query[i].SEGUNDO_APELLIDO;
                            record.FAM2_NOMBRES = query[i].NOMBRES;
                            record.FAM2_FECHA_NACIMIENTO = OracleDateToString(query[i].FECHA_NACIMIENTO);
                            record.FAM2_LUGAR_NACIMIENTO = query[i].LUGAR_NACIMIENTO;
                            record.FAM2_COD_PAIS = query[i].COD_PAIS;
                            record.FAM2_COD_NACIONALIDAD = query[i].COD_NACIONALIDAD;
                            record.FAM2_CEDULA_FAMILIAR = query[i].CEDULA;
                            record.FAM2_SEXO = query[i].SEXO;
                            break;
                        case 2:
                            record.FAM3_COD_PARENTESCO = query[i].COD_PARENTESCO;
                            record.FAM3_PRIMER_APELLIDO = query[i].PRIMER_APELLIDO;
                            record.FAM3_SEGUNDO_APELLIDO = query[i].SEGUNDO_APELLIDO;
                            record.FAM3_NOMBRES = query[i].NOMBRES;
                            record.FAM3_FECHA_NACIMIENTO = OracleDateToString(query[i].FECHA_NACIMIENTO);
                            record.FAM3_LUGAR_NACIMIENTO = query[i].LUGAR_NACIMIENTO;
                            record.FAM3_COD_PAIS = query[i].COD_PAIS;
                            record.FAM3_COD_NACIONALIDAD = query[i].COD_NACIONALIDAD;
                            record.FAM3_CEDULA_FAMILIAR = query[i].CEDULA;
                            record.FAM3_SEXO = query[i].SEXO;
                            break;
                        case 3:
                            record.FAM4_COD_PARENTESCO = query[i].COD_PARENTESCO;
                            record.FAM4_PRIMER_APELLIDO = query[i].PRIMER_APELLIDO;
                            record.FAM4_SEGUNDO_APELLIDO = query[i].SEGUNDO_APELLIDO;
                            record.FAM4_NOMBRES = query[i].NOMBRES;
                            record.FAM4_FECHA_NACIMIENTO = OracleDateToString(query[i].FECHA_NACIMIENTO);
                            record.FAM4_LUGAR_NACIMIENTO = query[i].LUGAR_NACIMIENTO;
                            record.FAM4_COD_PAIS = query[i].COD_PAIS;
                            record.FAM4_COD_NACIONALIDAD = query[i].COD_NACIONALIDAD;
                            record.FAM4_CEDULA_FAMILIAR = query[i].CEDULA;
                            record.FAM4_SEXO = query[i].SEXO;
                            break;
                        case 4:
                            record.FAM5_COD_PARENTESCO = query[i].COD_PARENTESCO;
                            record.FAM5_PRIMER_APELLIDO = query[i].PRIMER_APELLIDO;
                            record.FAM5_SEGUNDO_APELLIDO = query[i].SEGUNDO_APELLIDO;
                            record.FAM5_NOMBRES = query[i].NOMBRES;
                            record.FAM5_FECHA_NACIMIENTO = OracleDateToString(query[i].FECHA_NACIMIENTO);
                            record.FAM5_LUGAR_NACIMIENTO = query[i].LUGAR_NACIMIENTO;
                            record.FAM5_COD_PAIS = query[i].COD_PAIS;
                            record.FAM5_COD_NACIONALIDAD = query[i].COD_NACIONALIDAD;
                            record.FAM5_CEDULA_FAMILIAR = query[i].CEDULA;
                            record.FAM5_SEXO = query[i].SEXO;
                            break;
                        case 5:
                            record.FAM6_COD_PARENTESCO = query[i].COD_PARENTESCO;
                            record.FAM6_PRIMER_APELLIDO = query[i].PRIMER_APELLIDO;
                            record.FAM6_SEGUNDO_APELLIDO = query[i].SEGUNDO_APELLIDO;
                            record.FAM6_NOMBRES = query[i].NOMBRES;
                            record.FAM6_FECHA_NACIMIENTO = OracleDateToString(query[i].FECHA_NACIMIENTO);
                            record.FAM6_LUGAR_NACIMIENTO = query[i].LUGAR_NACIMIENTO;
                            record.FAM6_COD_PAIS = query[i].COD_PAIS;
                            record.FAM6_COD_NACIONALIDAD = query[i].COD_NACIONALIDAD;
                            record.FAM6_CEDULA_FAMILIAR = query[i].CEDULA;
                            record.FAM6_SEXO = query[i].SEXO;
                            break;
                        case 6:
                            record.FAM7_COD_PARENTESCO = query[i].COD_PARENTESCO;
                            record.FAM7_PRIMER_APELLIDO = query[i].PRIMER_APELLIDO;
                            record.FAM7_SEGUNDO_APELLIDO = query[i].SEGUNDO_APELLIDO;
                            record.FAM7_NOMBRES = query[i].NOMBRES;
                            record.FAM7_FECHA_NACIMIENTO = OracleDateToString(query[i].FECHA_NACIMIENTO);
                            record.FAM7_LUGAR_NACIMIENTO = query[i].LUGAR_NACIMIENTO;
                            record.FAM7_COD_PAIS = query[i].COD_PAIS;
                            record.FAM7_COD_NACIONALIDAD = query[i].COD_NACIONALIDAD;
                            record.FAM7_CEDULA_FAMILIAR = query[i].CEDULA;
                            record.FAM7_SEXO = query[i].SEXO;
                            break;
                        case 7:
                            record.FAM8_COD_PARENTESCO = query[i].COD_PARENTESCO;
                            record.FAM8_PRIMER_APELLIDO = query[i].PRIMER_APELLIDO;
                            record.FAM8_SEGUNDO_APELLIDO = query[i].SEGUNDO_APELLIDO;
                            record.FAM8_NOMBRES = query[i].NOMBRES;
                            record.FAM8_FECHA_NACIMIENTO = OracleDateToString(query[i].FECHA_NACIMIENTO);
                            record.FAM8_LUGAR_NACIMIENTO = query[i].LUGAR_NACIMIENTO;
                            record.FAM8_COD_PAIS = query[i].COD_PAIS;
                            record.FAM8_COD_NACIONALIDAD = query[i].COD_NACIONALIDAD;
                            record.FAM8_CEDULA_FAMILIAR = query[i].CEDULA;
                            record.FAM8_SEXO = query[i].SEXO;
                            break;
                        case 8:
                            record.FAM9_COD_PARENTESCO = query[i].COD_PARENTESCO;
                            record.FAM9_PRIMER_APELLIDO = query[i].PRIMER_APELLIDO;
                            record.FAM9_SEGUNDO_APELLIDO = query[i].SEGUNDO_APELLIDO;
                            record.FAM9_NOMBRES = query[i].NOMBRES;
                            record.FAM9_FECHA_NACIMIENTO = OracleDateToString(query[i].FECHA_NACIMIENTO);
                            record.FAM9_LUGAR_NACIMIENTO = query[i].LUGAR_NACIMIENTO;
                            record.FAM9_COD_PAIS = query[i].COD_PAIS;
                            record.FAM9_COD_NACIONALIDAD = query[i].COD_NACIONALIDAD;
                            record.FAM9_CEDULA_FAMILIAR = query[i].CEDULA;
                            record.FAM9_SEXO = query[i].SEXO;
                            break;
                        case 9:
                            record.FAM10_COD_PARENTESCO = query[i].COD_PARENTESCO;
                            record.FAM10_PRIMER_APELLIDO = query[i].PRIMER_APELLIDO;
                            record.FAM10_SEGUNDO_APELLIDO = query[i].SEGUNDO_APELLIDO;
                            record.FAM10_NOMBRES = query[i].NOMBRES;
                            record.FAM10_FECHA_NACIMIENTO = OracleDateToString(query[i].FECHA_NACIMIENTO);
                            record.FAM10_LUGAR_NACIMIENTO = query[i].LUGAR_NACIMIENTO;
                            record.FAM10_COD_PAIS = query[i].COD_PAIS;
                            record.FAM10_COD_NACIONALIDAD = query[i].COD_NACIONALIDAD;
                            record.FAM10_CEDULA_FAMILIAR = query[i].CEDULA;
                            record.FAM10_SEXO = query[i].SEXO;
                            break;
                    }
                }
                #endregion

                // DATOS DE FORMACIÓN ACADÉMICA
                #region TABLA_DATOS_FORMACIÓN
                List<DFORMACION> form = db.DFORMACIONES.Where(x => x.CEDULA.Equals(record.CEDULA)).ToList();

                for (int i = 0; i < form.Count(); i++)
                {

                    switch (i)
                    {
                        case 0:
                            record.FRM1_COD_CLASE = form[i].COD_CLASE;
                            record.FRM1_CT_COD_CLASE = form[i].CT_COD_CLASE;
                            record.FRM1_CT_COD_TITULO = form[i].CT_COD_TITULO;
                            record.FRM1_CE_COD_CLASE = form[i].CE_COD_CLASE;
                            record.FRM1_CE_COD_ESPECIALIDAD = form[i].CE_COD_ESPECIALIDAD;
                            record.FRM1_INSTITUTO = form[i].INSTITUTO;
                            record.FRM1_DURACION = form[i].DURACION;
                            record.FRM1_UNIDAD_TIEMPO = form[i].UNIDAD_TIEMPO;
                            record.FRM1_FECHA_INICIO = OracleDateToString(form[i].FECHA_INICIO);
                            record.FRM1_FECHA_FIN = OracleDateToString(form[i].FECHA_FIN);
                            record.FRM1_COD_PAIS = form[i].COD_PAIS;
                            break;
                        case 1:
                            record.FRM2_COD_CLASE = form[i].COD_CLASE;
                            record.FRM2_CT_COD_CLASE = form[i].CT_COD_CLASE;
                            record.FRM2_CT_COD_TITULO = form[i].CT_COD_TITULO;
                            record.FRM2_CE_COD_CLASE = form[i].CE_COD_CLASE;
                            record.FRM2_CE_COD_ESPECIALIDAD = form[i].CE_COD_ESPECIALIDAD;
                            record.FRM2_INSTITUTO = form[i].INSTITUTO;
                            record.FRM2_DURACION = form[i].DURACION;
                            record.FRM2_UNIDAD_TIEMPO = form[i].UNIDAD_TIEMPO;
                            record.FRM2_FECHA_INICIO = OracleDateToString(form[i].FECHA_INICIO);
                            record.FRM2_FECHA_FIN = OracleDateToString(form[i].FECHA_FIN);
                            record.FRM2_COD_PAIS = form[i].COD_PAIS;
                            break;
                        case 2:
                            record.FRM3_COD_CLASE = form[i].COD_CLASE;
                            record.FRM3_CT_COD_CLASE = form[i].CT_COD_CLASE;
                            record.FRM3_CT_COD_TITULO = form[i].CT_COD_TITULO;
                            record.FRM3_CE_COD_CLASE = form[i].CE_COD_CLASE;
                            record.FRM3_CE_COD_ESPECIALIDAD = form[i].CE_COD_ESPECIALIDAD;
                            record.FRM3_INSTITUTO = form[i].INSTITUTO;
                            record.FRM3_DURACION = form[i].DURACION;
                            record.FRM3_UNIDAD_TIEMPO = form[i].UNIDAD_TIEMPO;
                            record.FRM3_FECHA_INICIO = OracleDateToString(form[i].FECHA_INICIO);
                            record.FRM3_FECHA_FIN = OracleDateToString(form[i].FECHA_FIN);
                            record.FRM3_COD_PAIS = form[i].COD_PAIS;
                            break;
                    }

                }
                #endregion

                // DATOS DE EXPERIENCIA LABORAL
                #region TABLA_DATOS_EXPERIENCIA_LABORAL
                List<DEXPERIENCIA> exp = db.DEXPERIENCIAS.Where(x => x.CEDULA.Equals(record.CEDULA)).ToList();

                for (int i = 0; i < exp.Count(); i++)
                {
                    switch (i)
                    {
                        case 0:
                            record.EXP1_EMPRESA = exp[i].EMPRESA;
                            record.EXP1_COD_ACTIVIDAD = exp[i].COD_ACTIVIDAD;
                            record.EXP1_FECHA_INICIO = OracleDateToString(exp[i].FECHA_INICIO);
                            record.EXP1_FECHA_FIN = OracleDateToString(exp[i].FECHA_FIN);
                            record.EXP1_COD_RAMO = exp[i].COD_RAMO;
                            record.EXP1_COD_RELACION = exp[i].COD_RELACION;
                            record.EXP1_CIUDAD = exp[i].CIUDAD;
                            record.EXP1_PAIS = exp[i].PAIS;
                            break;
                        case 1:
                            record.EXP2_EMPRESA = exp[i].EMPRESA;
                            record.EXP2_COD_ACTIVIDAD = exp[i].COD_ACTIVIDAD;
                            record.EXP2_FECHA_INICIO = OracleDateToString(exp[i].FECHA_INICIO);
                            record.EXP2_FECHA_FIN = OracleDateToString(exp[i].FECHA_FIN);
                            record.EXP2_COD_RAMO = exp[i].COD_RAMO;
                            record.EXP2_COD_RELACION = exp[i].COD_RELACION;
                            record.EXP2_CIUDAD = exp[i].CIUDAD;
                            record.EXP2_PAIS = exp[i].PAIS;
                            break;
                        case 2:
                            record.EXP3_EMPRESA = exp[i].EMPRESA;
                            record.EXP3_COD_ACTIVIDAD = exp[i].COD_ACTIVIDAD;
                            record.EXP3_FECHA_INICIO = OracleDateToString(exp[i].FECHA_INICIO);
                            record.EXP3_FECHA_FIN = OracleDateToString(exp[i].FECHA_FIN);
                            record.EXP3_COD_RAMO = exp[i].COD_RAMO;
                            record.EXP3_COD_RELACION = exp[i].COD_RELACION;
                            record.EXP3_CIUDAD = exp[i].CIUDAD;
                            record.EXP3_PAIS = exp[i].PAIS;
                            break;
                    }
                }

                #endregion

                return record;

            }

        }

        private string FindDComunicacion( string fieldname, string value)
        {
        
            using (SPISAPEntities db = new SPISAPEntities())
            {
                string thevalue;

                if (fieldname.Equals("correo"))
                {
                    thevalue = (from c in db.DCOMUNICACIONES
                                       where c.CEDULA.Equals(value) && c.COD_CLASE.Equals("0010")
                                       select c.IDENTIFICADOR).SingleOrDefault();
                }
                else
                {
                    thevalue = (from c in db.DCOMUNICACIONES
                                       where c.CEDULA.Equals(value) && c.COD_CLASE.Equals("CELL")
                                       select c.IDENTIFICADOR).SingleOrDefault();
                }

                return thevalue;
            }

        }

        private bool FindDDiscapacidad(string field, string value)
        {
            using (SPISAPEntities db = new SPISAPEntities())
            {
                int thevalue = 0;

                if (field.Equals("motriz"))
                {
                    thevalue = (from c in db.DDISCAPACIDADES
                                where c.CEDULA.Equals(value) && c.GRUPO_DISCAPACIDAD.Equals("ZA")
                                select c.GRUPO_DISCAPACIDAD).Count();
                }
                else if (field.Equals("intelectual"))
                {
                    thevalue = (from c in db.DDISCAPACIDADES
                                where c.CEDULA.Equals(value) && c.GRUPO_DISCAPACIDAD.Equals("ZB")
                                select c.GRUPO_DISCAPACIDAD).Count();
                }
                else
                {
                    thevalue = (from c in db.DDISCAPACIDADES
                                where c.CEDULA.Equals(value) && c.GRUPO_DISCAPACIDAD.Equals("ZC")
                                select c.GRUPO_DISCAPACIDAD).Count();
                }

                return (thevalue > 0);
            }        
        }

        // validar si existe la cédula registrada.
        public bool IsCedulaAlert()
        {
            using (SPISAPEntities db = new SPISAPEntities())
            {
                var record = db.DPERSONALES.Where(r => r.CEDULA.Equals(empleado.CEDULA)).FirstOrDefault();
                return (record != null);
            }
        }
        // validar si existe el número de ficha registrada.
        public bool IsFichaAlert()
        {
            using (SPISAPEntities db = new SPISAPEntities())
            {
                var record = db.DPERSONALES.Where(r => r.FICHA.Equals(empleado.FICHA)).FirstOrDefault();
                return (record != null);
            }
        }

        public bool IsFamiliar2Valid()
        {
            return (empleado.FAM2_NOMBRES == null && empleado.FAM2_COD_PARENTESCO == null && empleado.FAM2_PRIMER_APELLIDO == null && empleado.FAM2_FECHA_NACIMIENTO == null && empleado.FAM2_LUGAR_NACIMIENTO == null && empleado.FAM2_COD_PAIS == null && empleado.FAM2_COD_NACIONALIDAD == null && empleado.FAM2_SEXO == null ||
                    empleado.FAM2_NOMBRES != null && empleado.FAM2_COD_PARENTESCO != null && empleado.FAM2_PRIMER_APELLIDO != null && empleado.FAM2_FECHA_NACIMIENTO != null && empleado.FAM2_LUGAR_NACIMIENTO != null && empleado.FAM2_COD_PAIS != null && empleado.FAM2_COD_NACIONALIDAD != null && empleado.FAM2_SEXO != null);
        }
        public bool IsFamiliar3Valid()
        {
            return (empleado.FAM3_NOMBRES == null && empleado.FAM3_COD_PARENTESCO == null && empleado.FAM3_PRIMER_APELLIDO == null && empleado.FAM3_FECHA_NACIMIENTO == null && empleado.FAM3_LUGAR_NACIMIENTO == null && empleado.FAM3_COD_PAIS == null && empleado.FAM3_COD_NACIONALIDAD == null && empleado.FAM3_SEXO == null ||
                    empleado.FAM3_NOMBRES != null && empleado.FAM3_COD_PARENTESCO != null && empleado.FAM3_PRIMER_APELLIDO != null && empleado.FAM3_FECHA_NACIMIENTO != null && empleado.FAM3_LUGAR_NACIMIENTO != null && empleado.FAM3_COD_PAIS != null && empleado.FAM3_COD_NACIONALIDAD != null && empleado.FAM3_SEXO != null);
        }
        public bool IsFamiliar4Valid()
        {
            return (empleado.FAM4_NOMBRES == null && empleado.FAM4_COD_PARENTESCO == null && empleado.FAM4_PRIMER_APELLIDO == null && empleado.FAM4_FECHA_NACIMIENTO == null && empleado.FAM4_LUGAR_NACIMIENTO == null && empleado.FAM4_COD_PAIS == null && empleado.FAM4_COD_NACIONALIDAD == null && empleado.FAM4_SEXO == null ||
                    empleado.FAM4_NOMBRES != null && empleado.FAM4_COD_PARENTESCO != null && empleado.FAM4_PRIMER_APELLIDO != null && empleado.FAM4_FECHA_NACIMIENTO != null && empleado.FAM4_LUGAR_NACIMIENTO != null && empleado.FAM4_COD_PAIS != null && empleado.FAM4_COD_NACIONALIDAD != null && empleado.FAM4_SEXO != null);
        }
        public bool IsFamiliar5Valid()
        {
            return (empleado.FAM5_NOMBRES == null && empleado.FAM5_COD_PARENTESCO == null && empleado.FAM5_PRIMER_APELLIDO == null && empleado.FAM5_FECHA_NACIMIENTO == null && empleado.FAM5_LUGAR_NACIMIENTO == null && empleado.FAM5_COD_PAIS == null && empleado.FAM5_COD_NACIONALIDAD == null && empleado.FAM5_SEXO == null ||
                    empleado.FAM5_NOMBRES != null && empleado.FAM5_COD_PARENTESCO != null && empleado.FAM5_PRIMER_APELLIDO != null && empleado.FAM5_FECHA_NACIMIENTO != null && empleado.FAM5_LUGAR_NACIMIENTO != null && empleado.FAM5_COD_PAIS != null && empleado.FAM5_COD_NACIONALIDAD != null && empleado.FAM5_SEXO != null);
        }
        public bool IsFamiliar6Valid()
        {
            return (empleado.FAM6_NOMBRES == null && empleado.FAM6_COD_PARENTESCO == null && empleado.FAM6_PRIMER_APELLIDO == null && empleado.FAM6_FECHA_NACIMIENTO == null && empleado.FAM6_LUGAR_NACIMIENTO == null && empleado.FAM6_COD_PAIS == null && empleado.FAM6_COD_NACIONALIDAD == null && empleado.FAM6_SEXO == null ||
                    empleado.FAM6_NOMBRES != null && empleado.FAM6_COD_PARENTESCO != null && empleado.FAM6_PRIMER_APELLIDO != null && empleado.FAM6_FECHA_NACIMIENTO != null && empleado.FAM6_LUGAR_NACIMIENTO != null && empleado.FAM6_COD_PAIS != null && empleado.FAM6_COD_NACIONALIDAD != null && empleado.FAM6_SEXO != null);
        }
        public bool IsFamiliar7Valid()
        {
            return (empleado.FAM7_NOMBRES == null && empleado.FAM7_COD_PARENTESCO == null && empleado.FAM7_PRIMER_APELLIDO == null && empleado.FAM7_FECHA_NACIMIENTO == null && empleado.FAM7_LUGAR_NACIMIENTO == null && empleado.FAM7_COD_PAIS == null && empleado.FAM7_COD_NACIONALIDAD == null && empleado.FAM7_SEXO == null ||
                    empleado.FAM7_NOMBRES != null && empleado.FAM7_COD_PARENTESCO != null && empleado.FAM7_PRIMER_APELLIDO != null && empleado.FAM7_FECHA_NACIMIENTO != null && empleado.FAM7_LUGAR_NACIMIENTO != null && empleado.FAM7_COD_PAIS != null && empleado.FAM7_COD_NACIONALIDAD != null && empleado.FAM7_SEXO != null);
        }
        public bool IsFamiliar8Valid()
        {
            return (empleado.FAM8_NOMBRES == null && empleado.FAM8_COD_PARENTESCO == null && empleado.FAM8_PRIMER_APELLIDO == null && empleado.FAM8_FECHA_NACIMIENTO == null && empleado.FAM8_LUGAR_NACIMIENTO == null && empleado.FAM8_COD_PAIS == null && empleado.FAM8_COD_NACIONALIDAD == null && empleado.FAM8_SEXO == null ||
                    empleado.FAM8_NOMBRES != null && empleado.FAM8_COD_PARENTESCO != null && empleado.FAM8_PRIMER_APELLIDO != null && empleado.FAM8_FECHA_NACIMIENTO != null && empleado.FAM8_LUGAR_NACIMIENTO != null && empleado.FAM8_COD_PAIS != null && empleado.FAM8_COD_NACIONALIDAD != null && empleado.FAM8_SEXO != null);
        }
        public bool IsFamiliar9Valid()
        {
            return (empleado.FAM9_NOMBRES == null && empleado.FAM9_COD_PARENTESCO == null && empleado.FAM9_PRIMER_APELLIDO == null && empleado.FAM9_FECHA_NACIMIENTO == null && empleado.FAM9_LUGAR_NACIMIENTO == null && empleado.FAM9_COD_PAIS == null && empleado.FAM9_COD_NACIONALIDAD == null && empleado.FAM9_SEXO == null ||
                    empleado.FAM9_NOMBRES != null && empleado.FAM9_COD_PARENTESCO != null && empleado.FAM9_PRIMER_APELLIDO != null && empleado.FAM9_FECHA_NACIMIENTO != null && empleado.FAM9_LUGAR_NACIMIENTO != null && empleado.FAM9_COD_PAIS != null && empleado.FAM9_COD_NACIONALIDAD != null && empleado.FAM9_SEXO != null);
        }
        public bool IsFamiliar10Valid()
        {
            return (empleado.FAM10_NOMBRES == null && empleado.FAM10_COD_PARENTESCO == null && empleado.FAM10_PRIMER_APELLIDO == null && empleado.FAM10_FECHA_NACIMIENTO == null && empleado.FAM10_LUGAR_NACIMIENTO == null && empleado.FAM10_COD_PAIS == null && empleado.FAM10_COD_NACIONALIDAD == null && empleado.FAM10_SEXO == null ||
                    empleado.FAM10_NOMBRES != null && empleado.FAM10_COD_PARENTESCO != null && empleado.FAM10_PRIMER_APELLIDO != null && empleado.FAM10_FECHA_NACIMIENTO != null && empleado.FAM10_LUGAR_NACIMIENTO != null && empleado.FAM10_COD_PAIS != null && empleado.FAM10_COD_NACIONALIDAD != null && empleado.FAM10_SEXO != null);
        }
        // FORMACIÓN ACADÉMICA
        public bool IsFormacion2Alert()
        {
            return (empleado.FRM2_COD_CLASE == null && empleado.FRM2_CT_COD_TITULO == null && empleado.FRM2_CE_COD_ESPECIALIDAD == null && empleado.FRM2_INSTITUTO == null && empleado.FRM2_UNIDAD_TIEMPO == null && empleado.FRM2_DURACION == null && empleado.FRM2_FECHA_INICIO == null && empleado.FRM2_FECHA_FIN == null && empleado.FRM2_COD_PAIS == null ||
                    empleado.FRM2_COD_CLASE != null && empleado.FRM2_CT_COD_TITULO != null && empleado.FRM2_CE_COD_ESPECIALIDAD != null && empleado.FRM2_INSTITUTO != null && empleado.FRM2_UNIDAD_TIEMPO != null && empleado.FRM2_DURACION != null && empleado.FRM2_FECHA_INICIO != null && empleado.FRM2_FECHA_FIN != null && empleado.FRM2_COD_PAIS != null);
        }
        public bool IsFormacion3Alert()
        {
            return (empleado.FRM3_COD_CLASE == null && empleado.FRM3_CT_COD_TITULO == null && empleado.FRM3_CE_COD_ESPECIALIDAD == null && empleado.FRM3_INSTITUTO == null && empleado.FRM3_UNIDAD_TIEMPO == null && empleado.FRM3_DURACION == null && empleado.FRM3_FECHA_INICIO == null && empleado.FRM3_FECHA_FIN == null && empleado.FRM3_COD_PAIS == null ||
                    empleado.FRM3_COD_CLASE != null && empleado.FRM3_CT_COD_TITULO != null && empleado.FRM3_CE_COD_ESPECIALIDAD != null && empleado.FRM3_INSTITUTO != null && empleado.FRM3_UNIDAD_TIEMPO != null && empleado.FRM3_DURACION != null && empleado.FRM3_FECHA_INICIO != null && empleado.FRM3_FECHA_FIN != null && empleado.FRM3_COD_PAIS != null);
        }

        // EXPERIENCIA LABORAL
        public bool IsExperiencia1Alert()
        {
            return (empleado.EXP1_EMPRESA == null && empleado.EXP1_COD_ACTIVIDAD == null && empleado.EXP1_FECHA_INICIO == null && empleado.EXP1_FECHA_FIN == null && empleado.EXP1_COD_RAMO == null && empleado.EXP1_COD_RELACION == null && empleado.EXP1_CIUDAD == null && empleado.EXP1_PAIS == null ||
                    empleado.EXP1_EMPRESA != null && empleado.EXP1_COD_ACTIVIDAD != null && empleado.EXP1_FECHA_INICIO != null && empleado.EXP1_FECHA_FIN != null && empleado.EXP1_COD_RAMO != null && empleado.EXP1_COD_RELACION != null && empleado.EXP1_CIUDAD != null && empleado.EXP1_PAIS != null);
        }
        public bool IsExperiencia2Alert()
        {
            return (empleado.EXP2_EMPRESA == null && empleado.EXP2_COD_ACTIVIDAD == null && empleado.EXP2_FECHA_INICIO == null && empleado.EXP2_FECHA_FIN == null && empleado.EXP2_COD_RAMO == null && empleado.EXP2_COD_RELACION == null && empleado.EXP2_CIUDAD == null && empleado.EXP2_PAIS == null ||
                    empleado.EXP2_EMPRESA != null && empleado.EXP2_COD_ACTIVIDAD != null && empleado.EXP2_FECHA_INICIO != null && empleado.EXP2_FECHA_FIN != null && empleado.EXP2_COD_RAMO != null && empleado.EXP2_COD_RELACION != null && empleado.EXP2_CIUDAD != null && empleado.EXP2_PAIS != null);
        }
        public bool IsExperiencia3Alert()
        {
            return (empleado.EXP3_EMPRESA == null && empleado.EXP3_COD_ACTIVIDAD == null && empleado.EXP3_FECHA_INICIO == null && empleado.EXP3_FECHA_FIN == null && empleado.EXP3_COD_RAMO == null && empleado.EXP3_COD_RELACION == null && empleado.EXP3_CIUDAD == null && empleado.EXP3_PAIS == null ||
                    empleado.EXP3_EMPRESA != null && empleado.EXP3_COD_ACTIVIDAD != null && empleado.EXP3_FECHA_INICIO != null && empleado.EXP3_FECHA_FIN != null && empleado.EXP3_COD_RAMO != null && empleado.EXP3_COD_RELACION != null && empleado.EXP3_CIUDAD != null && empleado.EXP3_PAIS != null);
        }

        public bool IsDatosFamiliarAlert()
        {
            return false;
        }
        public bool IsDatosFormacionAlert()
        {
            return false;
        }
        public bool IsExperienciaLaboralAlert()
        {
            return false;
        }

        public List<DPERSONALES> Find()
        {
            using ( SPISAPEntities db = new SPISAPEntities() )
            {
                return db.DPERSONALES.OrderBy(x => x.PRIMER_APELLIDO).ToList();
            }
        }

        public List<DPERSONALES> FindByCedula( string value )
        {
            return Find().Where(x => x.CEDULA.Equals(value)).ToList();
        }
        public List<DPERSONALES> FindByFicha(string value)
        {
            return Find().Where(x => x.FICHA.Equals(value)).ToList();
        }
        public List<DPERSONALES> FindByLastName( string value )
        {
            using (SPISAPEntities db = new SPISAPEntities())
            {
                return db.DPERSONALES.Where(x => x.PRIMER_APELLIDO.ToUpper().Contains(value.ToUpper())).OrderBy( x => x.CEDULA ).ToList();
            }
        }

        public bool AddNew()
        {

            try
            {

                using ( SPISAPEntities db = new SPISAPEntities())
                {

                    #region DATOS_PERSONALES
                    DPERSONALES DPersonales = new DPERSONALES()
                    {
                        FICHA = empleado.FICHA,
                        CEDULA = empleado.CEDULA,
                        COD_SUCURSAL = empleado.COD_SUCURSAL,
                        COD_GRUPO = empleado.COD_GRUPO,
                        COD_AREA_PERSONAL = empleado.COD_AREA_PERSONAL,
                        CARGO = empleado.CARGO,
                        TRATAMIENTO = empleado.TRATAMIENTO,
                        PRIMER_APELLIDO = empleado.PRIMER_APELLIDO,
                        SEGUNDO_APELLIDO = empleado.SEGUNDO_APELLIDO,
                        NOMBRE = empleado.NOMBRE,
                        FECHA_NACIMIENTO = OracleStringToDate(empleado.FECHA_NACIMIENTO), 
                        CIUDAD_NACIMIENTO = empleado.CIUDAD_NACIMIENTO,
                        COD_PAIS = empleado.COD_PAIS,
                        COD_ESTADO = empleado.COD_ESTADO,
                        COD_NACIONALIDAD = empleado.COD_NACIONALIDAD,
                        ESTADO_CIVIL = empleado.ESTADO_CIVIL,
                        SEXO = empleado.SEXO,
                        RIF = empleado.RIF,
                        CALZADO = empleado.CALZADO,
                        CHEMISE = empleado.CHEMISE,
                        PANTALON = empleado.PANTALON,
                        COD_USER_INS = empleado.COD_USER,
                        FECHA_INS = System.DateTime.Now,
                        COD_USER_UPD = empleado.COD_USER,
                        FECHA_UPD = System.DateTime.Now
                    };

                    db.DPERSONALES.Add(DPersonales);
                    #endregion

                    #region DATOS_COMUNICACION
                    if (empleado.COD_CLASE_CELULAR != null)
                    {

                        DCOMUNICACION DComunicacion = new DCOMUNICACION()
                        {
                            CEDULA = empleado.CEDULA,
                            COD_CLASE = "CELL",
                            IDENTIFICADOR = empleado.COD_CLASE_CELULAR,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now
                        };

                        db.DCOMUNICACIONES.Add(DComunicacion);

                    }
                    if (empleado.COD_CLASE_CORREO != null)
                    {

                        DCOMUNICACION DComunicacion = new DCOMUNICACION()
                        {
                            CEDULA = empleado.CEDULA,
                            COD_CLASE = "0010",
                            IDENTIFICADOR = empleado.COD_CLASE_CORREO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now
                        };

                        db.DCOMUNICACIONES.Add(DComunicacion);

                    }
                    #endregion

                    #region DATOS_DIRECCION

                    DDIRECCION DDireccion = new DDIRECCION()
                    {
                        CEDULA = empleado.CEDULA,
                        CALLE = empleado.CALLE,
                        EDIFICIO = empleado.EDIFICIO,
                        PISO = empleado.PISO,
                        NUMERO = empleado.NUMERO,
                        CIUDAD = empleado.CIUDAD,
                        URBANIZACION = empleado.URBANIZACION,
                        COD_PAIS = "VE",
                        COD_ESTADO = empleado.COD_ESTADO_DIRECCION,  
                        TELEFONOS = empleado.TELEFONOS,
                        COD_ESTADO_SSO = empleado.COD_ESTADO_SSO,
                        COD_MUNICIPIO_SSO = empleado.COD_MUNICIPIO_SSO,
                        COD_PARROQUIA_SSO = empleado.COD_PARROQUIA_SSO,
                        COD_USER_INS = empleado.COD_USER,
                        FECHA_INS = System.DateTime.Now,
                        COD_USER_UPD = empleado.COD_USER,
                        FECHA_UPD = System.DateTime.Now
                    };

                    db.DDIRECCIONES.Add(DDireccion);

                    #endregion

                    #region DATOS_DISCAPACIDAD

                    if (empleado.COD_DISCAPACIDAD_MOTRIZ == true)
                    {
                        DDISCAPACIDAD DDiscapacidad = new DDISCAPACIDAD()
                        {
                            CEDULA = empleado.CEDULA,
                            GRUPO_DISCAPACIDAD = "ZA",
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now
                        };
                        db.DDISCAPACIDADES.Add(DDiscapacidad);
                    }
                    if (empleado.COD_DISCAPACIDAD_INTELECTUAL == true)
                    {
                        DDISCAPACIDAD DDiscapacidad = new DDISCAPACIDAD()
                        {
                            CEDULA = empleado.CEDULA,
                            GRUPO_DISCAPACIDAD = "ZB",
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now
                        };
                        db.DDISCAPACIDADES.Add(DDiscapacidad);
                    }
                    if (empleado.COD_DISCAPACIDAD_SENSORIAL == true)
                    {
                        DDISCAPACIDAD DDiscapacidad = new DDISCAPACIDAD()
                        {
                            CEDULA = empleado.CEDULA,
                            GRUPO_DISCAPACIDAD = "ZC",
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now
                        };
                        db.DDISCAPACIDADES.Add(DDiscapacidad);
                    }

                    #endregion

                    #region DATOS_FAMILIARES

                    if (empleado.FAM1_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM1_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM1_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM1_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM1_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM1_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM1_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM1_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM1_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM1_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM1_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM2_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM2_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM2_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM2_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM2_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM2_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM2_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM2_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM2_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM2_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM2_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM3_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM3_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM3_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM3_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM3_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM3_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM3_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM3_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM3_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM3_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM3_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM4_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM4_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM4_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM4_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM4_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM4_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM4_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM4_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM4_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM4_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM4_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM5_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM5_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM5_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM5_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM5_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM5_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM5_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM5_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM5_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM5_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM5_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM6_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM6_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM6_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM6_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM6_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM6_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM6_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM6_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM6_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM6_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM6_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM7_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM7_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM7_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM7_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM7_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM7_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM7_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM7_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM7_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM7_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM7_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM8_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM8_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM8_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM8_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM8_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM8_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM8_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM8_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM8_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM8_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM8_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM9_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM9_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM9_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM9_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM9_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM9_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM9_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM9_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM9_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM9_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM9_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM10_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM10_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM10_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM10_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM10_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM10_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM10_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM10_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM10_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM10_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM10_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    #endregion

                    #region DATOS_FORMACIÓN_ACADÉMICA
                    if (empleado.FRM1_COD_CLASE != null)
                    {

                        DFORMACION DFormacion = new DFORMACION()
                        {
                            CEDULA = empleado.CEDULA,
                            COD_CLASE = empleado.FRM1_COD_CLASE,
                            INSTITUTO = empleado.FRM1_INSTITUTO,
                            COD_PAIS = empleado.FRM1_COD_PAIS,
                            CT_COD_CLASE = empleado.FRM1_COD_CLASE,
                            CT_COD_TITULO = empleado.FRM1_CT_COD_TITULO,
                            DURACION = empleado.FRM1_DURACION,
                            UNIDAD_TIEMPO = empleado.FRM1_UNIDAD_TIEMPO,
                            CE_COD_ESPECIALIDAD = empleado.FRM1_CE_COD_ESPECIALIDAD,
                            CE_COD_CLASE = empleado.FRM1_COD_CLASE,
                            FECHA_INICIO = OracleStringToDate(empleado.FRM1_FECHA_INICIO),
                            FECHA_FIN = OracleStringToDate(empleado.FRM1_FECHA_FIN),
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FORMACION = ++empleado.NEXTVAL
                        };

                        db.DFORMACIONES.Add(DFormacion);

                    }
                    if (empleado.FRM2_COD_CLASE != null)
                    {

                        DFORMACION DFormacion = new DFORMACION()
                        {
                            CEDULA = empleado.CEDULA,
                            COD_CLASE = empleado.FRM2_COD_CLASE,
                            INSTITUTO = empleado.FRM2_INSTITUTO,
                            COD_PAIS = empleado.FRM2_COD_PAIS,
                            CT_COD_CLASE = empleado.FRM2_COD_CLASE,
                            CT_COD_TITULO = empleado.FRM2_CT_COD_TITULO,
                            DURACION = empleado.FRM2_DURACION,
                            UNIDAD_TIEMPO = empleado.FRM2_UNIDAD_TIEMPO,
                            CE_COD_ESPECIALIDAD = empleado.FRM2_CE_COD_ESPECIALIDAD,
                            CE_COD_CLASE = empleado.FRM2_COD_CLASE,
                            FECHA_INICIO = OracleStringToDate(empleado.FRM2_FECHA_INICIO),
                            FECHA_FIN = OracleStringToDate(empleado.FRM2_FECHA_FIN),
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FORMACION = ++empleado.NEXTVAL
                        };

                        db.DFORMACIONES.Add(DFormacion);

                    }
                    if (empleado.FRM3_COD_CLASE != null)
                    {

                        DFORMACION DFormacion = new DFORMACION()
                        {
                            CEDULA = empleado.CEDULA,
                            COD_CLASE = empleado.FRM3_COD_CLASE,
                            INSTITUTO = empleado.FRM3_INSTITUTO,
                            COD_PAIS = empleado.FRM3_COD_PAIS,
                            CT_COD_CLASE = empleado.FRM3_COD_CLASE,
                            CT_COD_TITULO = empleado.FRM3_CT_COD_TITULO,
                            DURACION = empleado.FRM3_DURACION,
                            UNIDAD_TIEMPO = empleado.FRM3_UNIDAD_TIEMPO,
                            CE_COD_ESPECIALIDAD = empleado.FRM3_CE_COD_ESPECIALIDAD,
                            CE_COD_CLASE = empleado.FRM3_COD_CLASE,
                            FECHA_INICIO = OracleStringToDate(empleado.FRM3_FECHA_INICIO),
                            FECHA_FIN = OracleStringToDate(empleado.FRM3_FECHA_FIN),
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FORMACION = ++empleado.NEXTVAL
                        };

                        db.DFORMACIONES.Add(DFormacion);

                    }
                    #endregion

                    #region DATOS_EXPERIENCIA_LABORAL
                    if (empleado.EXP1_EMPRESA != null)
                    {
                        DEXPERIENCIA DExperiencia = new DEXPERIENCIA()
                        {
                            CEDULA = empleado.CEDULA,
                            FECHA_INICIO = OracleStringToDate(empleado.EXP1_FECHA_INICIO),
                            FECHA_FIN = OracleStringToDate(empleado.EXP1_FECHA_FIN),
                            EMPRESA = empleado.EXP1_EMPRESA,
                            CIUDAD = empleado.EXP1_CIUDAD,
                            PAIS = empleado.EXP1_PAIS,
                            COD_RAMO = empleado.EXP1_COD_RAMO,
                            COD_ACTIVIDAD = empleado.EXP1_COD_ACTIVIDAD,
                            COD_RELACION = empleado.EXP1_COD_RELACION,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_DEXPERIENCIA = ++empleado.NEXTVAL
                        };

                        db.DEXPERIENCIAS.Add(DExperiencia);
                    }
                    if (empleado.EXP2_EMPRESA != null)
                    {
                        DEXPERIENCIA DExperiencia = new DEXPERIENCIA()
                        {
                            CEDULA = empleado.CEDULA,
                            FECHA_INICIO = OracleStringToDate(empleado.EXP2_FECHA_INICIO),
                            FECHA_FIN = OracleStringToDate(empleado.EXP2_FECHA_FIN),
                            EMPRESA = empleado.EXP2_EMPRESA,
                            CIUDAD = empleado.EXP2_CIUDAD,
                            PAIS = empleado.EXP2_PAIS,
                            COD_RAMO = empleado.EXP2_COD_RAMO,
                            COD_ACTIVIDAD = empleado.EXP2_COD_ACTIVIDAD,
                            COD_RELACION = empleado.EXP2_COD_RELACION,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_DEXPERIENCIA = ++empleado.NEXTVAL
                        };

                        db.DEXPERIENCIAS.Add(DExperiencia);
                    }
                    if (empleado.EXP3_EMPRESA != null)
                    {
                        DEXPERIENCIA DExperiencia = new DEXPERIENCIA()
                        {
                            CEDULA = empleado.CEDULA,
                            FECHA_INICIO = OracleStringToDate(empleado.EXP3_FECHA_INICIO),
                            FECHA_FIN = OracleStringToDate(empleado.EXP3_FECHA_FIN),
                            EMPRESA = empleado.EXP3_EMPRESA,
                            CIUDAD = empleado.EXP3_CIUDAD,
                            PAIS = empleado.EXP3_PAIS,
                            COD_RAMO = empleado.EXP3_COD_RAMO,
                            COD_ACTIVIDAD = empleado.EXP3_COD_ACTIVIDAD,
                            COD_RELACION = empleado.EXP3_COD_RELACION,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_DEXPERIENCIA = ++empleado.NEXTVAL
                        };

                        db.DEXPERIENCIAS.Add(DExperiencia);
                    }
                    #endregion

                    db.SaveChanges();

                }

                return true;

            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        HttpContext.Current.Session["ERROR"] = validationError.PropertyName + "::::>" + validationError.ErrorMessage;
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                throw;

            }

        }

        public bool Update()
        {

            try
            {

                using (SPISAPEntities db = new SPISAPEntities())
                {

                    #region DATOS_PERSONALES
                    DPERSONALES dp = db.DPERSONALES.FirstOrDefault(x => x.FICHA.Equals(empleado.FICHA) );

                    if (dp != null)
                    {
                        dp.COD_SUCURSAL = empleado.COD_SUCURSAL;
                        dp.COD_GRUPO = empleado.COD_GRUPO;
                        dp.COD_AREA_PERSONAL = empleado.COD_AREA_PERSONAL;
                        dp.CARGO = empleado.CARGO;
                        dp.TRATAMIENTO = empleado.TRATAMIENTO;
                        dp.PRIMER_APELLIDO = empleado.PRIMER_APELLIDO;
                        dp.SEGUNDO_APELLIDO = empleado.SEGUNDO_APELLIDO;
                        dp.NOMBRE = empleado.NOMBRE;
                        dp.FECHA_NACIMIENTO = OracleStringToDate(empleado.FECHA_NACIMIENTO);
                        dp.CIUDAD_NACIMIENTO = empleado.CIUDAD_NACIMIENTO;
                        dp.COD_PAIS = empleado.COD_PAIS;
                        dp.COD_ESTADO = empleado.COD_ESTADO;
                        dp.COD_NACIONALIDAD = empleado.COD_NACIONALIDAD;
                        dp.ESTADO_CIVIL = empleado.ESTADO_CIVIL;
                        dp.SEXO = empleado.SEXO;
                        dp.RIF = empleado.RIF;
                        dp.CALZADO = empleado.CALZADO;
                        dp.CHEMISE = empleado.CHEMISE;
                        dp.PANTALON = empleado.PANTALON;
                        dp.COD_USER_UPD = empleado.COD_USER;
                        dp.FECHA_UPD = System.DateTime.Now;
                    }
                    db.Entry(dp).State = EntityState.Modified;
                    #endregion

                    #region DATOS_COMUNICACION
                    if (empleado.COD_CLASE_CELULAR != null)
                    {
                        
                        DCOMUNICACION dc = db.DCOMUNICACIONES.FirstOrDefault(x => x.CEDULA.Equals(empleado.CEDULA) && x.COD_CLASE.Equals("CELL"));
                        if (dc != null)
                        {

                            dc.CEDULA = empleado.CEDULA;
                            dc.COD_CLASE = "CELL";
                            dc.IDENTIFICADOR = empleado.COD_CLASE_CELULAR;
                            dc.COD_USER_UPD = empleado.COD_USER;
                            dc.FECHA_UPD = System.DateTime.Now;

                            db.Entry(dc).State = EntityState.Modified;
                        }
                        else 
                        {
                            DCOMUNICACION dcomunicacion1 = new DCOMUNICACION()
                            {
                                CEDULA = empleado.CEDULA,
                                COD_CLASE = "CELL",
                                IDENTIFICADOR = empleado.COD_CLASE_CELULAR,
                                COD_USER_INS = empleado.COD_USER,
                                FECHA_INS = System.DateTime.Now,
                                COD_USER_UPD = empleado.COD_USER,
                                FECHA_UPD = System.DateTime.Now
                            };

                            db.DCOMUNICACIONES.Add(dcomunicacion1);
                        }
                    
                    }
                    if (empleado.COD_CLASE_CORREO != null)
                    {
                    
                        DCOMUNICACION dcorreo = db.DCOMUNICACIONES.FirstOrDefault(x => x.CEDULA.Equals(empleado.CEDULA) && x.COD_CLASE.Equals("0010"));
                        if (dcorreo != null)
                        {
                            dcorreo.CEDULA = empleado.CEDULA;
                            dcorreo.COD_CLASE = "0010";
                            dcorreo.IDENTIFICADOR = empleado.COD_CLASE_CORREO;
                            dcorreo.COD_USER_UPD = empleado.COD_USER;
                            dcorreo.FECHA_UPD = System.DateTime.Now;

                            db.Entry(dcorreo).State = EntityState.Modified;
                        }
                        else 
                        {
                            DCOMUNICACION dcomunicacion2 = new DCOMUNICACION()
                            {
                                CEDULA = empleado.CEDULA,
                                COD_CLASE = "0010",
                                IDENTIFICADOR = empleado.COD_CLASE_CORREO,
                                COD_USER_INS = empleado.COD_USER,
                                FECHA_INS = System.DateTime.Now,
                                COD_USER_UPD = empleado.COD_USER,
                                FECHA_UPD = System.DateTime.Now
                            };

                            db.DCOMUNICACIONES.Add(dcomunicacion2);
                        }

                    }
                    #endregion
                    
                    #region DATOS_DIRECCION
                    DDIRECCION dd = db.DDIRECCIONES.FirstOrDefault(x => x.CEDULA.Equals(empleado.CEDULA));

                    if (dd != null)
                    {
                        dd.CEDULA = empleado.CEDULA;
                        dd.CALLE = empleado.CALLE;
                        dd.EDIFICIO = empleado.EDIFICIO;
                        dd.PISO = empleado.PISO;
                        dd.NUMERO = empleado.NUMERO;
                        dd.CIUDAD = empleado.CIUDAD;
                        dd.URBANIZACION = empleado.URBANIZACION;
                        dd.COD_ESTADO = empleado.COD_ESTADO_DIRECCION;  
                        dd.COD_PAIS = empleado.COD_PAIS;
                        dd.TELEFONOS = empleado.TELEFONOS;
                        dd.COD_ESTADO_SSO = empleado.COD_ESTADO_SSO;
                        dd.COD_MUNICIPIO_SSO = empleado.COD_MUNICIPIO_SSO;
                        dd.COD_PARROQUIA_SSO = empleado.COD_PARROQUIA_SSO;
                        dd.COD_USER_UPD = empleado.COD_USER;
                        dd.FECHA_UPD = System.DateTime.Now;
                    }
                    db.Entry(dd).State = EntityState.Modified;
                    #endregion

                    #region DATOS_DISCAPACIDAD
                    foreach (var item in db.DDISCAPACIDADES.Where(x => x.CEDULA.Equals(empleado.CEDULA)))
                    {
                        db.DDISCAPACIDADES.Remove(item);
                    }
                    if (empleado.COD_DISCAPACIDAD_MOTRIZ == true)
                    {
                        db.DDISCAPACIDADES.Add(new DDISCAPACIDAD { CEDULA = empleado.CEDULA, GRUPO_DISCAPACIDAD = "ZA", COD_USER_INS = empleado.COD_USER, COD_USER_UPD = empleado.COD_USER, FECHA_INS = System.DateTime.Now, FECHA_UPD = System.DateTime.Now });
                    }
                    if (empleado.COD_DISCAPACIDAD_INTELECTUAL == true)
                    {
                        db.DDISCAPACIDADES.Add(new DDISCAPACIDAD { CEDULA = empleado.CEDULA, GRUPO_DISCAPACIDAD = "ZB", COD_USER_INS = empleado.COD_USER, COD_USER_UPD = empleado.COD_USER, FECHA_INS = System.DateTime.Now, FECHA_UPD = System.DateTime.Now });
                    }
                    if (empleado.COD_DISCAPACIDAD_SENSORIAL == true)
                    {
                        db.DDISCAPACIDADES.Add(new DDISCAPACIDAD { CEDULA = empleado.CEDULA, GRUPO_DISCAPACIDAD = "ZC", COD_USER_INS = empleado.COD_USER, COD_USER_UPD = empleado.COD_USER, FECHA_INS = System.DateTime.Now, FECHA_UPD = System.DateTime.Now });
                    }
                    #endregion

                    #region DATOS_FAMILIARES
                    foreach (var item in db.DFAMILIARES.Where(x => x.CEDULA_FAMILIAR.Equals(empleado.CEDULA)))
                    {
                        db.DFAMILIARES.Remove(item);
                    }
                    if (empleado.FAM1_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM1_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM1_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM1_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM1_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM1_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM1_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM1_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM1_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM1_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM1_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM2_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM2_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM2_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM2_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM2_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM2_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM2_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM2_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM2_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM2_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM2_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM3_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM3_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM3_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM3_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM3_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM3_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM3_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM3_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM3_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM3_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM3_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM4_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM4_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM4_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM4_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM4_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM4_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM4_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM4_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM4_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM4_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM4_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM5_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM5_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM5_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM5_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM5_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM5_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM5_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM5_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM5_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM5_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM5_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM6_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM6_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM6_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM6_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM6_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM6_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM6_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM6_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM6_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM6_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM6_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM7_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM7_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM7_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM7_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM7_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM7_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM7_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM7_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM7_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM7_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM7_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM8_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM8_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM8_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM8_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM8_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM8_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM8_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM8_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM8_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM8_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM8_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM9_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM9_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM9_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM9_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM9_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM9_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM9_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM9_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM9_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM9_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM9_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    if (empleado.FAM10_COD_PARENTESCO != null)
                    {

                        DFAMILIAR DFamilar = new DFAMILIAR()
                        {
                            CEDULA = empleado.FAM10_CEDULA_FAMILIAR,
                            COD_PARENTESCO = empleado.FAM10_COD_PARENTESCO,
                            PRIMER_APELLIDO = empleado.FAM10_PRIMER_APELLIDO,
                            SEGUNDO_APELLIDO = empleado.FAM10_SEGUNDO_APELLIDO,
                            NOMBRES = empleado.FAM10_NOMBRES,
                            FECHA_NACIMIENTO = OracleStringToDate(empleado.FAM10_FECHA_NACIMIENTO),
                            LUGAR_NACIMIENTO = empleado.FAM10_LUGAR_NACIMIENTO,
                            COD_PAIS = empleado.FAM10_COD_PAIS,
                            COD_NACIONALIDAD = empleado.FAM10_COD_NACIONALIDAD,
                            CEDULA_FAMILIAR = empleado.CEDULA,
                            SEXO = empleado.FAM10_SEXO,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FAMILIARES = ++empleado.NEXTVAL
                        };

                        db.DFAMILIARES.Add(DFamilar);

                    }
                    #endregion

                    #region DATOS_FORMACIÓN_ACADÉMICA
                    foreach (var item in db.DFORMACIONES.Where(x => x.CEDULA.Equals(empleado.CEDULA)))
                    {
                        db.DFORMACIONES.Remove(item);
                    }
                    if (empleado.FRM1_COD_CLASE != null)
                    {

                        DFORMACION DFormacion = new DFORMACION()
                        {
                            CEDULA = empleado.CEDULA,
                            COD_CLASE = empleado.FRM1_COD_CLASE,
                            INSTITUTO = empleado.FRM1_INSTITUTO,
                            COD_PAIS = empleado.FRM1_COD_PAIS,
                            CT_COD_CLASE = empleado.FRM1_COD_CLASE,
                            CT_COD_TITULO = empleado.FRM1_CT_COD_TITULO,
                            DURACION = empleado.FRM1_DURACION,
                            UNIDAD_TIEMPO = empleado.FRM1_UNIDAD_TIEMPO,
                            CE_COD_ESPECIALIDAD = empleado.FRM1_CE_COD_ESPECIALIDAD,
                            CE_COD_CLASE = empleado.FRM1_COD_CLASE,
                            FECHA_INICIO = OracleStringToDate(empleado.FRM1_FECHA_INICIO),
                            FECHA_FIN = OracleStringToDate(empleado.FRM1_FECHA_FIN),
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FORMACION = ++empleado.NEXTVAL
                        };

                        db.DFORMACIONES.Add(DFormacion);

                    }
                    if (empleado.FRM2_COD_CLASE != null)
                    {

                        DFORMACION DFormacion = new DFORMACION()
                        {
                            CEDULA = empleado.CEDULA,
                            COD_CLASE = empleado.FRM2_COD_CLASE,
                            INSTITUTO = empleado.FRM2_INSTITUTO,
                            COD_PAIS = empleado.FRM2_COD_PAIS,
                            CT_COD_CLASE = empleado.FRM2_COD_CLASE,
                            CT_COD_TITULO = empleado.FRM2_CT_COD_TITULO,
                            DURACION = empleado.FRM2_DURACION,
                            UNIDAD_TIEMPO = empleado.FRM2_UNIDAD_TIEMPO,
                            CE_COD_ESPECIALIDAD = empleado.FRM2_CE_COD_ESPECIALIDAD,
                            CE_COD_CLASE = empleado.FRM2_COD_CLASE,
                            FECHA_INICIO = OracleStringToDate(empleado.FRM2_FECHA_INICIO),
                            FECHA_FIN = OracleStringToDate(empleado.FRM2_FECHA_FIN),
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FORMACION = ++empleado.NEXTVAL
                        };

                        db.DFORMACIONES.Add(DFormacion);

                    }
                    if (empleado.FRM3_COD_CLASE != null)
                    {

                        DFORMACION DFormacion = new DFORMACION()
                        {
                            CEDULA = empleado.CEDULA,
                            COD_CLASE = empleado.FRM3_COD_CLASE,
                            INSTITUTO = empleado.FRM3_INSTITUTO,
                            COD_PAIS = empleado.FRM3_COD_PAIS,
                            CT_COD_CLASE = empleado.FRM3_COD_CLASE,
                            CT_COD_TITULO = empleado.FRM3_CT_COD_TITULO,
                            DURACION = empleado.FRM3_DURACION,
                            UNIDAD_TIEMPO = empleado.FRM3_UNIDAD_TIEMPO,
                            CE_COD_ESPECIALIDAD = empleado.FRM3_CE_COD_ESPECIALIDAD,
                            CE_COD_CLASE = empleado.FRM3_COD_CLASE,
                            FECHA_INICIO = OracleStringToDate(empleado.FRM3_FECHA_INICIO),
                            FECHA_FIN = OracleStringToDate(empleado.FRM3_FECHA_FIN),
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_FORMACION = ++empleado.NEXTVAL
                        };

                        db.DFORMACIONES.Add(DFormacion);

                    }
                    #endregion

                    #region DATOS_EXPERIENCIA_LABORAL
                    foreach (var item in db.DEXPERIENCIAS.Where(x => x.CEDULA.Equals(empleado.CEDULA)))
                    {
                        db.DEXPERIENCIAS.Remove(item);
                    }
                    if (empleado.EXP1_EMPRESA != null)
                    {
                        DEXPERIENCIA DExperiencia = new DEXPERIENCIA()
                        {
                            CEDULA = empleado.CEDULA,
                            FECHA_INICIO = OracleStringToDate(empleado.EXP1_FECHA_INICIO),
                            FECHA_FIN = OracleStringToDate(empleado.EXP1_FECHA_FIN),
                            EMPRESA = empleado.EXP1_EMPRESA,
                            CIUDAD = empleado.EXP1_CIUDAD,
                            PAIS = empleado.EXP1_PAIS,
                            COD_RAMO = empleado.EXP1_COD_RAMO,
                            COD_ACTIVIDAD = empleado.EXP1_COD_ACTIVIDAD,
                            COD_RELACION = empleado.EXP1_COD_RELACION,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_DEXPERIENCIA = ++empleado.NEXTVAL
                        };

                        db.DEXPERIENCIAS.Add(DExperiencia);
                    }
                    if (empleado.EXP2_EMPRESA != null)
                    {
                        DEXPERIENCIA DExperiencia = new DEXPERIENCIA()
                        {
                            CEDULA = empleado.CEDULA,
                            FECHA_INICIO = OracleStringToDate(empleado.EXP2_FECHA_INICIO),
                            FECHA_FIN = OracleStringToDate(empleado.EXP2_FECHA_FIN),
                            EMPRESA = empleado.EXP2_EMPRESA,
                            CIUDAD = empleado.EXP2_CIUDAD,
                            PAIS = empleado.EXP2_PAIS,
                            COD_RAMO = empleado.EXP2_COD_RAMO,
                            COD_ACTIVIDAD = empleado.EXP2_COD_ACTIVIDAD,
                            COD_RELACION = empleado.EXP2_COD_RELACION,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_DEXPERIENCIA = ++empleado.NEXTVAL
                        };

                        db.DEXPERIENCIAS.Add(DExperiencia);
                    }
                    if (empleado.EXP3_EMPRESA != null)
                    {
                        DEXPERIENCIA DExperiencia = new DEXPERIENCIA()
                        {
                            CEDULA = empleado.CEDULA,
                            FECHA_INICIO = OracleStringToDate(empleado.EXP3_FECHA_INICIO),
                            FECHA_FIN = OracleStringToDate(empleado.EXP3_FECHA_FIN),
                            EMPRESA = empleado.EXP3_EMPRESA,
                            CIUDAD = empleado.EXP3_CIUDAD,
                            PAIS = empleado.EXP3_PAIS,
                            COD_RAMO = empleado.EXP3_COD_RAMO,
                            COD_ACTIVIDAD = empleado.EXP3_COD_ACTIVIDAD,
                            COD_RELACION = empleado.EXP3_COD_RELACION,
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now,
                            ID_DEXPERIENCIA = ++empleado.NEXTVAL
                        };

                        db.DEXPERIENCIAS.Add(DExperiencia);
                    }
                    #endregion

                    db.SaveChanges();

                }

            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        HttpContext.Current.Session["ERROR"] = validationError.PropertyName + "::::>" + validationError.ErrorMessage;
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                return false;
            }

            return true;

        }

        // retornar True/False si la edad del competidor es válida para el evento (Edad >=16).
        public bool IsEdadValid()
        {
            return (GetEdad() >= 16);
        }

        // retornar la edad a la fecha del evento.
        private int GetEdad()
        {

            int diaCumple = int.Parse( empleado.FECHA_NACIMIENTO.Substring(0, 2) );
            int mesCumple = int.Parse( empleado.FECHA_NACIMIENTO.Substring(3, 2) );
            int añoCumple = int.Parse( empleado.FECHA_NACIMIENTO.Substring(6, 4) );

            DateTime fechaNacimiento = new DateTime(añoCumple, mesCumple, diaCumple);
            DateTime fechaEvento = System.DateTime.Now;

            return ((fechaEvento.Subtract(fechaNacimiento)).Days / 365);
        }

        public bool IsRangeValid(string desde, string hasta)
        {

            if (desde != null && hasta != null)
            {
                DateTime date1 = new DateTime( int.Parse(desde.Substring(6, 4)) , int.Parse(desde.Substring(3, 2)), int.Parse(desde.Substring(0, 2)), 0, 0, 0);
                DateTime date2 = new DateTime(int.Parse(hasta.Substring(6, 4)), int.Parse(hasta.Substring(3, 2)), int.Parse(hasta.Substring(0, 2)), 0, 0, 0);
                return (DateTime.Compare(date1, date2) < 0);                
            }

            return true;

        }

        #region PRIVATES_METHODS

        private string OracleDateToString( DateTime? value )
        {

            string v = value.ToString().Replace(" 12:00:00 a.m.", "").Replace(" 12:00:00 AM", "");
            string[] dates = v.Split('/');

            if (FORMAT_DATE_PRODUCCION)
            {
                return dates[1].PadLeft(2, '0') + "/" + dates[0].PadLeft(2, '0') + "/" + dates[2].PadLeft(2, '0');
            }
            else 
            {
                return dates[0] + "/" + dates[1] + "/" + dates[2];
            }

        }

        private DateTime OracleStringToDate(string value)
        {
            value = value.Replace(".", "/").Replace("-", "/").Replace("\\", "/"); 

            string[] dates = value.Split('/');

            if (FORMAT_DATE_PRODUCCION)
            {
                return DateTime.Parse(dates[1] + "/" + dates[0] + "/" + dates[2]);
            }
            else
            {
                return DateTime.Parse(dates[0] + "/" + dates[1] + "/" + dates[2]);
            }

           // return DateTime.Parse(value.ToString().Substring(6, 4) + "/" + value.ToString().Substring(3, 2) + "/" + value.ToString().Substring(0, 2));
        }

        private decimal GetOracleNextVal()
        {
            Random rnd = new Random();
            return rnd.Next(1000000000);
        }
        #endregion

    }
}