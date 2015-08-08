using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPISAP.Models;
using System.Globalization;
using System.Data.Entity.Validation;

namespace SPISAP.Repositories
{
    public class EmployeeRepository
    {

        EmployeeViewModel empleado;

        public EmployeeRepository()
        { 
            //by default.
        }

        public EmployeeRepository(EmployeeViewModel Empleado)
        {

            // DATOS PERSONALES
//Empleado.DATOS_PERSONALES.FICHA = "123456789012";
//Empleado.DATOS_PERSONALES.CEDULA = "12919906";
//Empleado.DATOS_PERSONALES.COD_SUCURSAL = "1001";
//Empleado.DATOS_PERSONALES.COD_GRUPO = "1";
//Empleado.DATOS_PERSONALES.COD_AREA_PERSONAL = "VK";
//Empleado.DATOS_PERSONALES.CARGO = "CARGO";
//Empleado.DATOS_PERSONALES.TRATAMIENTO = "Sra.";
//Empleado.DATOS_PERSONALES.PRIMER_APELLIDO = "GONZALEZ";
//Empleado.DATOS_PERSONALES.SEGUNDO_APELLIDO = "LOPEZ";
//Empleado.DATOS_PERSONALES.NOMBRE = "FLOR MARINA";
//Empleado.DATOS_PERSONALES.FECHA_NACIMIENTO = DateTime.Parse("1976-01-18", CultureInfo.InvariantCulture);
//Empleado.DATOS_PERSONALES.CIUDAD_NACIMIENTO = "PORLAMAR";
//Empleado.DATOS_PERSONALES.COD_PAIS = "VE";
//Empleado.DATOS_PERSONALES.COD_ESTADO = "NE";
//Empleado.DATOS_PERSONALES.COD_NACIONALIDAD = "PA";
//Empleado.DATOS_PERSONALES.ESTADO_CIVIL = "Cas.";
//Empleado.DATOS_PERSONALES.SEXO = "M";
//Empleado.DATOS_PERSONALES.RIF = "J129199060";
//Empleado.DATOS_PERSONALES.CALZADO = "34";
//Empleado.DATOS_PERSONALES.CHEMISE = "36";
//Empleado.DATOS_PERSONALES.PANTALON = "36";

//Empleado.COD_CLASE_CELULAR = "04128094599";
//Empleado.COD_CLASE_CORREO = "flormaringl@gmail.com";
                
            //// DATOS DIRECCIÓN
//Empleado.DATOS_DIRECCION.CALLE = "CALLEJÓN MACHADO";
//Empleado.DATOS_DIRECCION.EDIFICIO = "RESD.LOS GRANADILLOS";
//Empleado.DATOS_DIRECCION.PISO = "14";
//Empleado.DATOS_DIRECCION.NUMERO = "141";
//Empleado.DATOS_DIRECCION.URBANIZACION = "EL PARAÍSO";
////Empleado.DATOS_DIRECCION.COD_ESTADO = "DC";
//Empleado.DATOS_DIRECCION.COD_PAIS = "VE";
//Empleado.DATOS_DIRECCION.TELEFONOS = "4835448";
//Empleado.DATOS_DIRECCION.COD_ESTADO_SSO = "DC";
//Empleado.DATOS_DIRECCION.COD_MUNICIPIO_SSO = "1";
//Empleado.DATOS_DIRECCION.COD_PARROQUIA_SSO = "663";
//Empleado.DATOS_DIRECCION.CIUDAD = "CARACAS";

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
            //Empleado.FRM1_INSTITUO = "HARVARD";
            //Empleado.FRM1_COD_PAIS = "VE";
            //Empleado.FRM1_CT_COD_CLASE = "V8";
            //Empleado.FRM1_CT_COD_TITULO = "2";
            //Empleado.FRM1_DURACION = "10";
            //Empleado.FRM1_UNIDAD_TIEMPO = "3";
            //Empleado.FRM1_CE_COD_CLASE = "V8";
            //Empleado.FRM1_CE_COD_ESPECIALIDAD = "00207";
            //Empleado.FRM1_FECHA_INICIO = "01/10/2000";
            //Empleado.FRM1_FECHA_FIN = "01/10/2000";

            // DATOS EXPERIENCIA LABORAL
//Empleado.EXP1_FECHA_INICIO = "01/01/2000";
//Empleado.EXP1_FECHA_FIN = "31/01/2000";
//Empleado.EXP1_EMPRESA = "EMPRESA 1";
//Empleado.EXP1_CIUDAD = "CIUDAD 1";
//Empleado.EXP1_PAIS = "VE";
//Empleado.EXP1_COD_RAMO = "01";
//Empleado.EXP1_COD_ACTIVIDAD = "01";
//Empleado.EXP1_COD_RELACION = "4";



            // TEMPORAL
            Empleado.COD_USER = "CROSARIO";
            //Empleado.DATOS_PERSONALES.CEDULA = "11681109";
            //Empleado.DATOS_PERSONALES.SEXO = "M";
            Empleado.FRM1_COD_FORMACION = "1";  // PENDIENTE POR DESTINO DEL CAMPO.

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

        public EmployeeRepository FindByCedula()
        {
            return null;
        }

        public EmployeeRepository FindByName()
        {
            return null;
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
                        FICHA = "F" + empleado.DATOS_PERSONALES.CEDULA,
                        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                        COD_SUCURSAL = empleado.DATOS_PERSONALES.COD_SUCURSAL,
                        COD_GRUPO = empleado.DATOS_PERSONALES.COD_GRUPO,
                        COD_AREA_PERSONAL = empleado.DATOS_PERSONALES.COD_AREA_PERSONAL,
                        CARGO = empleado.DATOS_PERSONALES.CARGO,
                        TRATAMIENTO = empleado.DATOS_PERSONALES.TRATAMIENTO,
                        PRIMER_APELLIDO = empleado.DATOS_PERSONALES.PRIMER_APELLIDO,
                        SEGUNDO_APELLIDO = empleado.DATOS_PERSONALES.SEGUNDO_APELLIDO,
                        NOMBRE = empleado.DATOS_PERSONALES.NOMBRE,
                        FECHA_NACIMIENTO = empleado.DATOS_PERSONALES.FECHA_NACIMIENTO,
                        CIUDAD_NACIMIENTO = empleado.DATOS_PERSONALES.CIUDAD_NACIMIENTO,
                        COD_PAIS = empleado.DATOS_PERSONALES.COD_PAIS,
                        COD_ESTADO = empleado.DATOS_PERSONALES.COD_ESTADO,
                        COD_NACIONALIDAD = empleado.DATOS_PERSONALES.COD_NACIONALIDAD,
                        ESTADO_CIVIL = empleado.DATOS_PERSONALES.ESTADO_CIVIL,
                        SEXO = empleado.DATOS_PERSONALES.SEXO,
                        RIF = empleado.DATOS_PERSONALES.RIF,
                        CALZADO = empleado.DATOS_PERSONALES.CALZADO,
                        CHEMISE = empleado.DATOS_PERSONALES.CHEMISE,
                        PANTALON = empleado.DATOS_PERSONALES.PANTALON,
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
                            CEDULA = empleado.DATOS_PERSONALES.CEDULA,
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
                            CEDULA = empleado.DATOS_PERSONALES.CEDULA,
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
                        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                        CALLE = empleado.DATOS_DIRECCION.CALLE,
                        EDIFICIO = empleado.DATOS_DIRECCION.EDIFICIO,
                        PISO = empleado.DATOS_DIRECCION.PISO,
                        NUMERO = empleado.DATOS_DIRECCION.NUMERO,
                        CIUDAD = empleado.DATOS_DIRECCION.CIUDAD,
                        URBANIZACION = empleado.DATOS_DIRECCION.URBANIZACION,
                        COD_ESTADO = empleado.DATOS_DIRECCION.COD_ESTADO_SSO,  // CONVERSAR CON CAROLINA //empleado.DATOS_DIRECCION.COD_ESTADO,
                        COD_PAIS = empleado.DATOS_DIRECCION.COD_PAIS,
                        TELEFONOS = empleado.DATOS_DIRECCION.TELEFONOS,
                        COD_ESTADO_SSO = empleado.DATOS_DIRECCION.COD_ESTADO_SSO,
                        COD_MUNICIPIO_SSO = empleado.DATOS_DIRECCION.COD_MUNICIPIO_SSO,
                        COD_PARROQUIA_SSO = empleado.DATOS_DIRECCION.COD_PARROQUIA_SSO,
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
                            CEDULA = empleado.DATOS_PERSONALES.CEDULA,
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
                            CEDULA = empleado.DATOS_PERSONALES.CEDULA,
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
                            CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                            GRUPO_DISCAPACIDAD = "ZC",
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now
                        };
                        db.DDISCAPACIDADES.Add(DDiscapacidad);
                    }

                    #endregion

                    //#region DATOS_FAMILIARES

                    //if (empleado.FAM1_COD_PARENTESCO != null)
                    //{

                    //    DFAMILIAR DFamilar = new DFAMILIAR()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        COD_PARENTESCO = empleado.FAM1_COD_PARENTESCO,
                    //        PRIMER_APELLIDO = empleado.FAM1_PRIMER_APELLIDO,
                    //        SEGUNDO_APELLIDO = empleado.FAM1_SEGUNDO_APELLIDO,
                    //        NOMBRES = empleado.FAM1_NOMBRES,
                    //        FECHA_NACIMIENTO = StringToDateTime(empleado.FAM1_FECHA_NACIMIENTO),
                    //        LUGAR_NACIMIENTO = empleado.FAM1_LUGAR_NACIMIENTO,
                    //        COD_PAIS = empleado.FAM1_COD_PAIS,
                    //        COD_NACIONALIDAD = empleado.FAM1_COD_NACIONALIDAD,
                    //        CEDULA_FAMILIAR = empleado.FAM1_CEDULA_FAMILIAR,
                    //        SEXO = empleado.FAM1_SEXO,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DFAMILIARES.Add(DFamilar);

                    //}
                    //if (empleado.FAM2_COD_PARENTESCO != null)
                    //{

                    //    DFAMILIAR DFamilar = new DFAMILIAR()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        COD_PARENTESCO = empleado.FAM2_COD_PARENTESCO,
                    //        PRIMER_APELLIDO = empleado.FAM2_PRIMER_APELLIDO,
                    //        SEGUNDO_APELLIDO = empleado.FAM2_SEGUNDO_APELLIDO,
                    //        NOMBRES = empleado.FAM2_NOMBRES,
                    //        FECHA_NACIMIENTO = StringToDateTime(empleado.FAM2_FECHA_NACIMIENTO),
                    //        LUGAR_NACIMIENTO = empleado.FAM2_LUGAR_NACIMIENTO,
                    //        COD_PAIS = empleado.FAM2_COD_PAIS,
                    //        COD_NACIONALIDAD = empleado.FAM2_COD_NACIONALIDAD,
                    //        CEDULA_FAMILIAR = empleado.FAM2_CEDULA_FAMILIAR,
                    //        SEXO = empleado.FAM2_SEXO,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DFAMILIARES.Add(DFamilar);

                    //}
                    //if (empleado.FAM3_COD_PARENTESCO != null)
                    //{

                    //    DFAMILIAR DFamilar = new DFAMILIAR()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        COD_PARENTESCO = empleado.FAM3_COD_PARENTESCO,
                    //        PRIMER_APELLIDO = empleado.FAM3_PRIMER_APELLIDO,
                    //        SEGUNDO_APELLIDO = empleado.FAM3_SEGUNDO_APELLIDO,
                    //        NOMBRES = empleado.FAM3_NOMBRES,
                    //        FECHA_NACIMIENTO = StringToDateTime(empleado.FAM3_FECHA_NACIMIENTO),
                    //        LUGAR_NACIMIENTO = empleado.FAM3_LUGAR_NACIMIENTO,
                    //        COD_PAIS = empleado.FAM3_COD_PAIS,
                    //        COD_NACIONALIDAD = empleado.FAM3_COD_NACIONALIDAD,
                    //        CEDULA_FAMILIAR = empleado.FAM3_CEDULA_FAMILIAR,
                    //        SEXO = empleado.FAM3_SEXO,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DFAMILIARES.Add(DFamilar);

                    //}
                    //if (empleado.FAM4_COD_PARENTESCO != null)
                    //{

                    //    DFAMILIAR DFamilar = new DFAMILIAR()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        COD_PARENTESCO = empleado.FAM4_COD_PARENTESCO,
                    //        PRIMER_APELLIDO = empleado.FAM4_PRIMER_APELLIDO,
                    //        SEGUNDO_APELLIDO = empleado.FAM4_SEGUNDO_APELLIDO,
                    //        NOMBRES = empleado.FAM4_NOMBRES,
                    //        FECHA_NACIMIENTO = StringToDateTime(empleado.FAM4_FECHA_NACIMIENTO),
                    //        LUGAR_NACIMIENTO = empleado.FAM4_LUGAR_NACIMIENTO,
                    //        COD_PAIS = empleado.FAM4_COD_PAIS,
                    //        COD_NACIONALIDAD = empleado.FAM4_COD_NACIONALIDAD,
                    //        CEDULA_FAMILIAR = empleado.FAM4_CEDULA_FAMILIAR,
                    //        SEXO = empleado.FAM4_SEXO,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DFAMILIARES.Add(DFamilar);

                    //}
                    //if (empleado.FAM5_COD_PARENTESCO != null)
                    //{

                    //    DFAMILIAR DFamilar = new DFAMILIAR()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        COD_PARENTESCO = empleado.FAM5_COD_PARENTESCO,
                    //        PRIMER_APELLIDO = empleado.FAM5_PRIMER_APELLIDO,
                    //        SEGUNDO_APELLIDO = empleado.FAM5_SEGUNDO_APELLIDO,
                    //        NOMBRES = empleado.FAM5_NOMBRES,
                    //        FECHA_NACIMIENTO = StringToDateTime(empleado.FAM5_FECHA_NACIMIENTO),
                    //        LUGAR_NACIMIENTO = empleado.FAM5_LUGAR_NACIMIENTO,
                    //        COD_PAIS = empleado.FAM5_COD_PAIS,
                    //        COD_NACIONALIDAD = empleado.FAM5_COD_NACIONALIDAD,
                    //        CEDULA_FAMILIAR = empleado.FAM5_CEDULA_FAMILIAR,
                    //        SEXO = empleado.FAM5_SEXO,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DFAMILIARES.Add(DFamilar);

                    //}
                    //if (empleado.FAM6_COD_PARENTESCO != null)
                    //{

                    //    DFAMILIAR DFamilar = new DFAMILIAR()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        COD_PARENTESCO = empleado.FAM6_COD_PARENTESCO,
                    //        PRIMER_APELLIDO = empleado.FAM6_PRIMER_APELLIDO,
                    //        SEGUNDO_APELLIDO = empleado.FAM6_SEGUNDO_APELLIDO,
                    //        NOMBRES = empleado.FAM6_NOMBRES,
                    //        FECHA_NACIMIENTO = StringToDateTime(empleado.FAM6_FECHA_NACIMIENTO),
                    //        LUGAR_NACIMIENTO = empleado.FAM6_LUGAR_NACIMIENTO,
                    //        COD_PAIS = empleado.FAM6_COD_PAIS,
                    //        COD_NACIONALIDAD = empleado.FAM6_COD_NACIONALIDAD,
                    //        CEDULA_FAMILIAR = empleado.FAM6_CEDULA_FAMILIAR,
                    //        SEXO = empleado.FAM6_SEXO,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DFAMILIARES.Add(DFamilar);

                    //}
                    //if (empleado.FAM7_COD_PARENTESCO != null)
                    //{

                    //    DFAMILIAR DFamilar = new DFAMILIAR()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        COD_PARENTESCO = empleado.FAM7_COD_PARENTESCO,
                    //        PRIMER_APELLIDO = empleado.FAM7_PRIMER_APELLIDO,
                    //        SEGUNDO_APELLIDO = empleado.FAM7_SEGUNDO_APELLIDO,
                    //        NOMBRES = empleado.FAM7_NOMBRES,
                    //        FECHA_NACIMIENTO = StringToDateTime(empleado.FAM7_FECHA_NACIMIENTO),
                    //        LUGAR_NACIMIENTO = empleado.FAM7_LUGAR_NACIMIENTO,
                    //        COD_PAIS = empleado.FAM7_COD_PAIS,
                    //        COD_NACIONALIDAD = empleado.FAM7_COD_NACIONALIDAD,
                    //        CEDULA_FAMILIAR = empleado.FAM7_CEDULA_FAMILIAR,
                    //        SEXO = empleado.FAM7_SEXO,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DFAMILIARES.Add(DFamilar);

                    //}
                    //if (empleado.FAM8_COD_PARENTESCO != null)
                    //{

                    //    DFAMILIAR DFamilar = new DFAMILIAR()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        COD_PARENTESCO = empleado.FAM8_COD_PARENTESCO,
                    //        PRIMER_APELLIDO = empleado.FAM8_PRIMER_APELLIDO,
                    //        SEGUNDO_APELLIDO = empleado.FAM8_SEGUNDO_APELLIDO,
                    //        NOMBRES = empleado.FAM8_NOMBRES,
                    //        FECHA_NACIMIENTO = StringToDateTime(empleado.FAM8_FECHA_NACIMIENTO),
                    //        LUGAR_NACIMIENTO = empleado.FAM8_LUGAR_NACIMIENTO,
                    //        COD_PAIS = empleado.FAM8_COD_PAIS,
                    //        COD_NACIONALIDAD = empleado.FAM8_COD_NACIONALIDAD,
                    //        CEDULA_FAMILIAR = empleado.FAM8_CEDULA_FAMILIAR,
                    //        SEXO = empleado.FAM8_SEXO,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DFAMILIARES.Add(DFamilar);

                    //}
                    //if (empleado.FAM9_COD_PARENTESCO != null)
                    //{

                    //    DFAMILIAR DFamilar = new DFAMILIAR()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        COD_PARENTESCO = empleado.FAM9_COD_PARENTESCO,
                    //        PRIMER_APELLIDO = empleado.FAM9_PRIMER_APELLIDO,
                    //        SEGUNDO_APELLIDO = empleado.FAM9_SEGUNDO_APELLIDO,
                    //        NOMBRES = empleado.FAM9_NOMBRES,
                    //        FECHA_NACIMIENTO = StringToDateTime(empleado.FAM9_FECHA_NACIMIENTO),
                    //        LUGAR_NACIMIENTO = empleado.FAM9_LUGAR_NACIMIENTO,
                    //        COD_PAIS = empleado.FAM9_COD_PAIS,
                    //        COD_NACIONALIDAD = empleado.FAM9_COD_NACIONALIDAD,
                    //        CEDULA_FAMILIAR = empleado.FAM9_CEDULA_FAMILIAR,
                    //        SEXO = empleado.FAM9_SEXO,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DFAMILIARES.Add(DFamilar);

                    //}
                    //if (empleado.FAM10_COD_PARENTESCO != null)
                    //{

                    //    DFAMILIAR DFamilar = new DFAMILIAR()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        COD_PARENTESCO = empleado.FAM10_COD_PARENTESCO,
                    //        PRIMER_APELLIDO = empleado.FAM10_PRIMER_APELLIDO,
                    //        SEGUNDO_APELLIDO = empleado.FAM10_SEGUNDO_APELLIDO,
                    //        NOMBRES = empleado.FAM10_NOMBRES,
                    //        FECHA_NACIMIENTO = StringToDateTime(empleado.FAM10_FECHA_NACIMIENTO),
                    //        LUGAR_NACIMIENTO = empleado.FAM10_LUGAR_NACIMIENTO,
                    //        COD_PAIS = empleado.FAM10_COD_PAIS,
                    //        COD_NACIONALIDAD = empleado.FAM10_COD_NACIONALIDAD,
                    //        CEDULA_FAMILIAR = empleado.FAM10_CEDULA_FAMILIAR,
                    //        SEXO = empleado.FAM10_SEXO,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DFAMILIARES.Add(DFamilar);

                    //}
                    //#endregion

                    #region DATOS_FORMACIÓN_ACADÉMICA
                    if (empleado.FRM1_COD_CLASE != null)
                    {

                        DFORMACION DFormacion = new DFORMACION()
                        {
                            CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                            COD_CLASE = empleado.FRM1_COD_CLASE,
                            COD_FORMACION = empleado.FRM1_COD_FORMACION,
                            INSTITUO = empleado.FRM1_INSTITUO,
                            COD_PAIS = empleado.FRM1_COD_PAIS,
                            CT_COD_CLASE = empleado.FRM1_COD_CLASE,
                            CT_COD_TITULO = empleado.FRM1_CT_COD_TITULO,
                            DURACION = empleado.FRM1_DURACION,
                            UNIDAD_TIEMPO = empleado.FRM1_DURACION,
                            CE_COD_ESPECIALIDAD = empleado.FRM1_CE_COD_ESPECIALIDAD,
                            CE_COD_CLASE = empleado.FRM1_COD_CLASE,
                            FECHA_INICIO = StringToDateTime(empleado.FRM1_FECHA_INICIO),
                            FECHA_FIN = StringToDateTime(empleado.FRM1_FECHA_FIN),
                            COD_USER_INS = empleado.COD_USER,
                            FECHA_INS = System.DateTime.Now,
                            COD_USER_UPD = empleado.COD_USER,
                            FECHA_UPD = System.DateTime.Now
                        };

                        db.DFORMACIONES.Add(DFormacion);

                    }
                    //if (empleado.FRM2_COD_CLASE != null)
                    //{

                    //    DFORMACION DFormacion = new DFORMACION()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        COD_CLASE = empleado.FRM2_COD_CLASE,
                    //        COD_FORMACION = empleado.FRM2_COD_FORMACION,
                    //        INSTITUO = empleado.FRM2_INSTITUO,
                    //        COD_PAIS = empleado.FRM2_COD_PAIS,
                    //        CT_COD_CLASE = empleado.FRM2_COD_CLASE,
                    //        CT_COD_TITULO = empleado.FRM2_CT_COD_TITULO,
                    //        DURACION = empleado.FRM2_DURACION,
                    //        UNIDAD_TIEMPO = empleado.FRM2_DURACION,
                    //        CE_COD_ESPECIALIDAD = empleado.FRM2_CE_COD_ESPECIALIDAD,
                    //        CE_COD_CLASE = empleado.FRM2_COD_CLASE,
                    //        FECHA_INICIO = StringToDateTime(empleado.FRM2_FECHA_INICIO),
                    //        FECHA_FIN = StringToDateTime(empleado.FRM2_FECHA_FIN),
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DFORMACIONES.Add(DFormacion);

                    //}
                    //if (empleado.FRM3_COD_CLASE != null)
                    //{

                    //    DFORMACION DFormacion = new DFORMACION()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        COD_CLASE = empleado.FRM3_COD_CLASE,
                    //        COD_FORMACION = empleado.FRM3_COD_FORMACION,
                    //        INSTITUO = empleado.FRM3_INSTITUO,
                    //        COD_PAIS = empleado.FRM3_COD_PAIS,
                    //        CT_COD_CLASE = empleado.FRM3_COD_CLASE,
                    //        CT_COD_TITULO = empleado.FRM3_CT_COD_TITULO,
                    //        DURACION = empleado.FRM3_DURACION,
                    //        UNIDAD_TIEMPO = empleado.FRM3_DURACION,
                    //        CE_COD_ESPECIALIDAD = empleado.FRM3_CE_COD_ESPECIALIDAD,
                    //        CE_COD_CLASE = empleado.FRM3_COD_CLASE,
                    //        FECHA_INICIO = StringToDateTime(empleado.FRM3_FECHA_INICIO),
                    //        FECHA_FIN = StringToDateTime(empleado.FRM3_FECHA_FIN),
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DFORMACIONES.Add(DFormacion);

                    //}
                    #endregion

                    //#region DATOS_EXPERIENCIA_LABORAL
                    //if (empleado.EXP1_EMPRESA != null)
                    //{
                    //    DEXPERIENCIA DExperiencia = new DEXPERIENCIA()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        FECHA_INICIO = StringToDateTime(empleado.EXP1_FECHA_INICIO),
                    //        FECHA_FIN = StringToDateTime(empleado.EXP1_FECHA_FIN),
                    //        EMPRESA = empleado.EXP1_EMPRESA,
                    //        CIUDAD = empleado.EXP1_CIUDAD,
                    //        PAIS = empleado.EXP1_PAIS,
                    //        COD_RAMO = empleado.EXP1_COD_RAMO,
                    //        COD_ACTIVIDAD = empleado.EXP1_COD_ACTIVIDAD,
                    //        COD_RELACION = empleado.EXP1_COD_RELACION,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DEXPERIENCIAS.Add(DExperiencia);
                    //}
                    //if (empleado.EXP2_EMPRESA != null)
                    //{
                    //    DEXPERIENCIA DExperiencia = new DEXPERIENCIA()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        FECHA_INICIO = StringToDateTime(empleado.EXP2_FECHA_INICIO),
                    //        FECHA_FIN = StringToDateTime(empleado.EXP2_FECHA_FIN),
                    //        EMPRESA = empleado.EXP2_EMPRESA,
                    //        CIUDAD = empleado.EXP2_CIUDAD,
                    //        PAIS = empleado.EXP2_PAIS,
                    //        COD_RAMO = empleado.EXP2_COD_RAMO,
                    //        COD_ACTIVIDAD = empleado.EXP2_COD_ACTIVIDAD,
                    //        COD_RELACION = empleado.EXP2_COD_RELACION,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DEXPERIENCIAS.Add(DExperiencia);
                    //}
                    //if (empleado.EXP3_EMPRESA != null)
                    //{
                    //    DEXPERIENCIA DExperiencia = new DEXPERIENCIA()
                    //    {
                    //        CEDULA = empleado.DATOS_PERSONALES.CEDULA,
                    //        FECHA_INICIO = StringToDateTime(empleado.EXP3_FECHA_INICIO),
                    //        FECHA_FIN = StringToDateTime(empleado.EXP3_FECHA_FIN),
                    //        EMPRESA = empleado.EXP3_EMPRESA,
                    //        CIUDAD = empleado.EXP3_CIUDAD,
                    //        PAIS = empleado.EXP3_PAIS,
                    //        COD_RAMO = empleado.EXP3_COD_RAMO,
                    //        COD_ACTIVIDAD = empleado.EXP3_COD_ACTIVIDAD,
                    //        COD_RELACION = empleado.EXP3_COD_RELACION,
                    //        COD_USER_INS = empleado.COD_USER,
                    //        FECHA_INS = System.DateTime.Now,
                    //        COD_USER_UPD = empleado.COD_USER,
                    //        FECHA_UPD = System.DateTime.Now
                    //    };

                    //    db.DEXPERIENCIAS.Add(DExperiencia);
                    //}
                    //#endregion

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
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                return false;
            }

        }

        public bool Update()
        {
            return true;
        }

        #region PRIVATES_METHODS
        private DateTime StringToDateTime( string value )
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            //String format = "dd/MM/yyyy";
            //return DateTime.ParseExact( value, format, provider);        
        
        
            // TO BE FIX
            return DateTime.Parse("12/01/1976");

        }
        #endregion

    }
}