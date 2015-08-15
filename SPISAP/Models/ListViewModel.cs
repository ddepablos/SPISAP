using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPISAP.Models
{

    public static class ListViewModel
    {

        #region DATOS_PERSONALES
        // retornar la lista de género.
        public static List<GenericModel> FillGeneros()
        {

            return new List<GenericModel>
            {
                new GenericModel() { CODIGO="", DESCRIPCION=""  },
                new GenericModel() { CODIGO="F", DESCRIPCION="F" },
                new GenericModel() { CODIGO="M", DESCRIPCION="M" }
            };

        }

        // retornar la lista de países.
        public static List<PAIS> FillPaises()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<PAIS> Lista = new List<PAIS>();

                Lista.Add(new PAIS { COD_PAIS = "", DES_PAIS = "Seleccione un valor" });

                foreach (var record in db.PAISES.OrderBy(p => p.DES_PAIS))
                {
                    PAIS item = new PAIS();
                    item.COD_PAIS = record.COD_PAIS;
                    item.DES_PAIS = record.DES_PAIS;
                    Lista.Add( item );
                }

                return Lista;
            }

        }

        // retornar la lista de nacionalidades.
        public static List<NACIONALIDAD> Nacionalidades()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<NACIONALIDAD> Lista = new List<NACIONALIDAD>();

                Lista.Add(new NACIONALIDAD { COD_NACIONALIDAD = "", DES_NACIONALIDAD = "Seleccione un valor" });

                foreach (var record in db.NACIONALIDADES.OrderBy(p => p.DES_NACIONALIDAD))
                {
                    NACIONALIDAD item = new NACIONALIDAD();
                    item.COD_NACIONALIDAD = record.COD_NACIONALIDAD;
                    item.DES_NACIONALIDAD = record.DES_NACIONALIDAD;
                    Lista.Add(item);
                }

                return Lista;
            }

        }

        // retornar la lista de estados.
        public static List<PAIS_ESTADO> GetPaisEstados()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<PAIS_ESTADO> Lista = new List<PAIS_ESTADO>();

                Lista.Add(new PAIS_ESTADO { COD_ESTADO = "", DES_ESTADO = "Seleccione un valor" });

                foreach (var record in db.PAIS_ESTADO.OrderBy(p => p.DES_ESTADO))
                {
                    PAIS_ESTADO item = new PAIS_ESTADO();
                    item.COD_ESTADO = record.COD_ESTADO;
                    item.DES_ESTADO = record.DES_ESTADO;
                    item.COD_PAIS = record.COD_PAIS;
                    Lista.Add(item);
                }

                return Lista;
            }

        }

        // retornar la lista de estado civil.
        public static List<GenericModel> EstadoCivil()
        {

            return new List<GenericModel>
            {
                new GenericModel() { CODIGO=""     , DESCRIPCION=""              },
                new GenericModel() { CODIGO="Solt." , DESCRIPCION="Soltero(a)"    },
                new GenericModel() { CODIGO="Concu.", DESCRIPCION="Concubino(a)"  },
                new GenericModel() { CODIGO="Cas."  , DESCRIPCION="Casado(a)"     },
                new GenericModel() { CODIGO="Div."  , DESCRIPCION="Divorciado(a)" },
                new GenericModel() { CODIGO="Viu."  , DESCRIPCION="Viudo(a)"      }
            };

        }

        // retornar la lista de area de personal.
        public static List<AREA_PERSONAL> AreaPersonal()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<AREA_PERSONAL> Lista = new List<AREA_PERSONAL>();

                Lista.Add(new AREA_PERSONAL { COD_AREA_PERSONAL = "", DES_AREA_PERSONAL = "" });

                foreach (var record in db.AREA_PERSONAL.OrderBy(p => p.DES_AREA_PERSONAL))
                {
                    AREA_PERSONAL item = new AREA_PERSONAL();
                    item.COD_AREA_PERSONAL = record.COD_AREA_PERSONAL;
                    item.DES_AREA_PERSONAL = record.DES_AREA_PERSONAL;
                    Lista.Add(item);
                }

                return Lista;
            }

        }

        // retornar la lista de sucursales.
        public static List<SUCURSAL> Sucursales()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<SUCURSAL> Lista = new List<SUCURSAL>();

                Lista.Add(new SUCURSAL { COD_SUCURSAL = "", DES_SUCURSAL = "" });

                foreach (var record in db.SUCURSALES.OrderBy(p => p.DES_SUCURSAL))
                {
                    SUCURSAL item = new SUCURSAL();
                    item.COD_SUCURSAL = record.COD_SUCURSAL;
                    item.DES_SUCURSAL = record.DES_SUCURSAL;
                    Lista.Add(item);
                }

                return Lista;
            }

        }

        // retornar la lista de grupos de personal.
        public static List<GRUPO_PERSONAL> GrupoPersonal()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<GRUPO_PERSONAL> Lista = new List<GRUPO_PERSONAL>();

                Lista.Add(new GRUPO_PERSONAL { COD_GRUPO = "", DES_GRUPO_PERSONAL = "" });

                foreach (var record in db.GRUPO_PERSONAL.OrderBy(p => p.DES_GRUPO_PERSONAL))
                {
                    GRUPO_PERSONAL item = new GRUPO_PERSONAL();
                    item.COD_GRUPO = record.COD_GRUPO;
                    item.DES_GRUPO_PERSONAL = record.DES_GRUPO_PERSONAL;
                    Lista.Add(item);
                }

                return Lista;
            }

        }

        // retornar la lista de tratamiento.
        public static List<string> Tratamiento()
        {
            return new List<string> { "Sr.", "Sra.", "Srta." };
        }


        // retornar la lista de tallas de camisa.
        public static List<Generic2Model> GetTallaChemise()
        {
            // CHEMISE_CHECK:
            // (SEXO ='F' AND CHEMISE IN ('S','M','L','XL','XXL','XXXL')) OR (SEXO='M' AND CHEMISE IN ('36','38','40', '42','44','46'))

            return new List<Generic2Model>
            {
                new Generic2Model() { CODIGO="", DESCRIPCION="Seleccione un valor", FOREINGKEY = "" },
                new Generic2Model() { CODIGO="S", DESCRIPCION="S", FOREINGKEY = "F" },
                new Generic2Model() { CODIGO="M", DESCRIPCION="M", FOREINGKEY = "F" },
                new Generic2Model() { CODIGO="L", DESCRIPCION="L", FOREINGKEY = "F" },
                new Generic2Model() { CODIGO="XL", DESCRIPCION="XL", FOREINGKEY = "F" },
                new Generic2Model() { CODIGO="XXL", DESCRIPCION="XXL", FOREINGKEY = "F" },
                new Generic2Model() { CODIGO="XXXL", DESCRIPCION="XXXL", FOREINGKEY = "F" },
                new Generic2Model() { CODIGO="36", DESCRIPCION="36", FOREINGKEY = "M" },
                new Generic2Model() { CODIGO="38", DESCRIPCION="38", FOREINGKEY = "M" },
                new Generic2Model() { CODIGO="40", DESCRIPCION="40", FOREINGKEY = "M" },
                new Generic2Model() { CODIGO="42", DESCRIPCION="42", FOREINGKEY = "M" },
                new Generic2Model() { CODIGO="44", DESCRIPCION="44", FOREINGKEY = "M" },
                new Generic2Model() { CODIGO="46", DESCRIPCION="46", FOREINGKEY = "M" }
            };

        }

        // retornar la lista de tallas de pantalón.
        public static List<Generic2Model> GetTallaPantalon()
        {
            // PANTALON_CHECK
            // (SEXO='F' AND CHEMISE IN ('8','10','12','14','16','18','20','22','24','26'))
            // (SEXO='M' AND CHEMISE IN ('28','30','32','34','36','38','40','42','44','46'))

            return new List<Generic2Model>
            {
                new Generic2Model() { FOREINGKEY="" , CODIGO =  "" , DESCRIPCION="Seleccione un valor" },
                new Generic2Model() { FOREINGKEY="F", CODIGO =  "8", DESCRIPCION="8" },
                new Generic2Model() { FOREINGKEY="F", CODIGO = "10", DESCRIPCION="10"},
                new Generic2Model() { FOREINGKEY="F", CODIGO = "12", DESCRIPCION="12"},
                new Generic2Model() { FOREINGKEY="F", CODIGO = "14", DESCRIPCION="14"},
                new Generic2Model() { FOREINGKEY="F", CODIGO = "16", DESCRIPCION="16"},
                new Generic2Model() { FOREINGKEY="F", CODIGO = "18", DESCRIPCION="18"},
                new Generic2Model() { FOREINGKEY="F", CODIGO = "20", DESCRIPCION="20"},
                new Generic2Model() { FOREINGKEY="F", CODIGO = "22", DESCRIPCION="22"},
                new Generic2Model() { FOREINGKEY="F", CODIGO = "24", DESCRIPCION="24"},
                new Generic2Model() { FOREINGKEY="F", CODIGO = "26", DESCRIPCION="26"},
                new Generic2Model() { FOREINGKEY="M", CODIGO = "28", DESCRIPCION="28"},
                new Generic2Model() { FOREINGKEY="M", CODIGO = "30", DESCRIPCION="30"},
                new Generic2Model() { FOREINGKEY="M", CODIGO = "32", DESCRIPCION="32"},
                new Generic2Model() { FOREINGKEY="M", CODIGO = "34", DESCRIPCION="34"},
                new Generic2Model() { FOREINGKEY="M", CODIGO = "36", DESCRIPCION="36"},
                new Generic2Model() { FOREINGKEY="M", CODIGO = "38", DESCRIPCION="38"},
                new Generic2Model() { FOREINGKEY="M", CODIGO = "40", DESCRIPCION="40"},
                new Generic2Model() { FOREINGKEY="M", CODIGO = "42", DESCRIPCION="42"},
                new Generic2Model() { FOREINGKEY="M", CODIGO = "44", DESCRIPCION="44"},
                new Generic2Model() { FOREINGKEY="M", CODIGO = "46", DESCRIPCION="46"}
            };

        }

        // retornar la lista de tallas de zapato.
        public static List<GenericModel> GetTallaCalzado()
        {
            // CALZADO_CHECK
            // CALZADO BETWEEN '34' AND '46'
            return new List<GenericModel>
            {
                //new GenericModel() { CODIGO="", DESCRIPCION="Seleccione un valor"},
                new GenericModel() { CODIGO="34", DESCRIPCION="34"},
                new GenericModel() { CODIGO="35", DESCRIPCION="35"},
                new GenericModel() { CODIGO="36", DESCRIPCION="36"},
                new GenericModel() { CODIGO="37", DESCRIPCION="37"},
                new GenericModel() { CODIGO="38", DESCRIPCION="38"},
                new GenericModel() { CODIGO="39", DESCRIPCION="39"},
                new GenericModel() { CODIGO="40", DESCRIPCION="40"},
                new GenericModel() { CODIGO="41", DESCRIPCION="41"},
                new GenericModel() { CODIGO="42", DESCRIPCION="42"},
                new GenericModel() { CODIGO="43", DESCRIPCION="43"},
                new GenericModel() { CODIGO="44", DESCRIPCION="44"},
                new GenericModel() { CODIGO="45", DESCRIPCION="45"},
                new GenericModel() { CODIGO="46", DESCRIPCION="46"}
            };

        }
        #endregion

        #region DATOS_DIRECCION

        // retornar la lista de estados.
        public static List<ESTADO_SSO> GetEstadoSSO()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<ESTADO_SSO> Lista = new List<ESTADO_SSO>();

                Lista.Add(new ESTADO_SSO { COD_ESTADO_SSO = "", DES_ESTADO_SSO = "Seleccione un valor" });

                foreach (var record in db.ESTADO_SSO.OrderBy(p => p.DES_ESTADO_SSO))
                {
                    ESTADO_SSO item = new ESTADO_SSO();
                    item.COD_ESTADO_SSO = record.COD_ESTADO_SSO;
                    item.DES_ESTADO_SSO = record.DES_ESTADO_SSO;
                    Lista.Add( item );
                }

                return Lista;
            }

        }

        // retornar la lista de municipios.
        public static List<MUNICIPIO_SSO> GetMunicipioSSO()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<MUNICIPIO_SSO> Lista = new List<MUNICIPIO_SSO>();

                //Lista.Add(new MUNICIPIO_SSO { COD_MUNICIPIO = "", DES_MUNICIPIO = "Seleccione un valor" });

                foreach (var record in db.MUNICIPIO_SSO.OrderBy(p => p.DES_MUNICIPIO))
                {
                    MUNICIPIO_SSO item = new MUNICIPIO_SSO();
                    item.COD_MUNICIPIO = record.COD_MUNICIPIO;
                    item.DES_MUNICIPIO = record.DES_MUNICIPIO;
                    item.COD_ESTADO_SSO = record.COD_ESTADO_SSO;
                    Lista.Add(item);
                }

                return Lista;
            }

        }

        // retornar la lista de parroquias.
        public static List<PARROQUIA_SSO> GetParroquiaSSO()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<PARROQUIA_SSO> Lista = new List<PARROQUIA_SSO>();

                //Lista.Add(new PARROQUIA_SSO { COD_PARROQUIA = "", DES_PARROQUIA = "Seleccione un valor" });

                foreach (var record in db.PARROQUIA_SSO.OrderBy(p => p.DES_PARROQUIA))
                {
                    PARROQUIA_SSO item = new PARROQUIA_SSO();
                    item.COD_PARROQUIA = record.COD_PARROQUIA;
                    item.DES_PARROQUIA = record.DES_PARROQUIA;
                    item.COD_MUNICIPIO = record.COD_MUNICIPIO;
                    Lista.Add(item);
                }

                return Lista;
            }

        }
        #endregion

        #region DATOS_DISCAPACIDAD
        // retornar la lista de parentescos.
        public static List<PARENTESCO> GetParentesco()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<PARENTESCO> Lista = new List<PARENTESCO>();

                Lista.Add(new PARENTESCO { COD_PARENTESCO = "", DES_PARENTESCO = "Seleccione un valor" });

                foreach (var record in db.PARENTESCOS.OrderBy(p => p.DES_PARENTESCO))
                {
                    PARENTESCO item = new PARENTESCO();
                    item.COD_PARENTESCO = record.COD_PARENTESCO;
                    item.DES_PARENTESCO = record.DES_PARENTESCO;
                    Lista.Add(item);
                }

                return Lista;
            }

        }
        #endregion

        #region DATOS_FORMACION
        // retornar la lista de formación.
        public static List<FORMACION> GetFormacion()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<FORMACION> Lista = new List<FORMACION>();

                Lista.Add(new FORMACION { COD_FORMACION = "", DES_FORMACION = "" });

                foreach (var record in db.FORMACIONES.OrderBy(p => p.COD_FORMACION))
                {
                    FORMACION item = new FORMACION();
                    item.COD_FORMACION = record.COD_FORMACION;
                    item.DES_FORMACION = record.DES_FORMACION;
                    Lista.Add(item);
                }

                return Lista;
            }

        }

        // retornar la lista de niveles de estudio.
        public static List<CLASE_INSTITUTO> GetNivelEstudio()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<CLASE_INSTITUTO> Lista = new List<CLASE_INSTITUTO>();

                Lista.Add(new CLASE_INSTITUTO { COD_CLASE = "", DES_CLASE = "Seleccione un valor" });

                foreach (var record in db.CLASE_INSTITUTO.OrderBy(p => p.COD_CLASE))
                {
                    CLASE_INSTITUTO item = new CLASE_INSTITUTO();
                    item.COD_CLASE = record.COD_CLASE;
                    item.DES_CLASE = record.DES_CLASE;
                    Lista.Add(item);
                }

                return Lista;
            }

        }

        // retornar la lista de condiciones/clase de titulos.
        public static List<CLASE_TITULO> GetCondiciones()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<CLASE_TITULO> Lista = new List<CLASE_TITULO>();

                //Lista.Add(new CLASE_TITULO { COD_CLASE = "", DES_TITULO = "Seleccione un valor" });

                foreach (var record in db.CLASE_TITULO.OrderBy(p => p.DES_TITULO))
                {
                    CLASE_TITULO item = new CLASE_TITULO();
                    item.COD_CLASE = record.COD_CLASE;      // CT_COD_CLASE
                    item.COD_TITULO = record.COD_TITULO;    // CT_COD_TITULO
                    item.DES_TITULO = record.DES_TITULO;
                    Lista.Add(item);
                }

                return Lista;
            }

        }
        // retornar la lista de especialidades.
        public static List<CLASE_ESPECIALIDAD> GetEspecialidades()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<CLASE_ESPECIALIDAD> Lista = new List<CLASE_ESPECIALIDAD>();

                //Lista.Add(new CLASE_ESPECIALIDAD { COD_ESPECIALIDAD = "", DES_ESPECIALIDAD = "Seleccione un valor" });

                foreach (var record in db.CLASE_ESPECIALIDAD.OrderBy(p => p.DES_ESPECIALIDAD))
                {
                    CLASE_ESPECIALIDAD item = new CLASE_ESPECIALIDAD();
                    item.COD_ESPECIALIDAD = record.COD_ESPECIALIDAD;
                    item.DES_ESPECIALIDAD = record.DES_ESPECIALIDAD;
                    item.COD_CLASE = record.COD_CLASE;
                    Lista.Add(item);
                }

                return Lista;
            }

        }

        // retornar la lista de Unidades de Tiempo.
        public static List<GenericModel> GetUnidadTiempo()
        {
            // 'Años', 'Clases', 'Dias', 'Meses', 'Semanas', 'Semestres'
            return new List<GenericModel>
            {
                new GenericModel() { CODIGO=""         , DESCRIPCION=""          },
                new GenericModel() { CODIGO="Años"      , DESCRIPCION="Años"      },
                new GenericModel() { CODIGO="Clases"    , DESCRIPCION="Clases"    },
                new GenericModel() { CODIGO="Dias"      , DESCRIPCION="Dias"      },
                new GenericModel() { CODIGO="Meses"     , DESCRIPCION="Meses"     },
                new GenericModel() { CODIGO="Semanas"   , DESCRIPCION="Semanas"   },
                new GenericModel() { CODIGO="Semestres" , DESCRIPCION="Semestres" }
            };

        }

        #endregion

        #region DATOS_EXPERIENCIA_LABORAL

        // retornar la lista de Último Cargo/ACTIVDAD.
        public static List<ACTIVIDAD> GetUltimoCargo()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<ACTIVIDAD> Lista = new List<ACTIVIDAD>();

                Lista.Add(new ACTIVIDAD { COD_ACTIVIDAD = "", DES_ACTIVIDAD = "Seleccione un valor" });

                foreach (var record in db.ACTIVIDADES.OrderBy(p => p.COD_ACTIVIDAD))
                {
                    ACTIVIDAD item = new ACTIVIDAD();
                    item.COD_ACTIVIDAD = record.COD_ACTIVIDAD;
                    item.DES_ACTIVIDAD = record.DES_ACTIVIDAD;
                    Lista.Add(item);
                }

                return Lista;
            }

        }

        // retornar la lista de Area/RAMO.
        public static List<RAMO> GetArea()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<RAMO> Lista = new List<RAMO>();

                Lista.Add(new RAMO { COD_RAMO = "", DES_RAMO = "Seleccione un valor" });

                foreach (var record in db.RAMOS.OrderBy(p => p.DES_RAMO))
                {
                    RAMO item = new RAMO();
                    item.COD_RAMO = record.COD_RAMO;
                    item.DES_RAMO = record.DES_RAMO;
                    Lista.Add(item);
                }

                return Lista;
            }

        }

        // retornar la lista de Tipo de Contratación/RELACION_LABORAL.
        public static List<RELACION_LABORAL> GetTipoContratacion()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<RELACION_LABORAL> Lista = new List<RELACION_LABORAL>();

                Lista.Add(new RELACION_LABORAL { COD_RELACION = "", DES_RELACION = "Seleccione un valor" });

                foreach (var record in db.RELACION_LABORAL.OrderBy(p => p.DES_RELACION))
                {
                    RELACION_LABORAL item = new RELACION_LABORAL();
                    item.COD_RELACION = record.COD_RELACION;
                    item.DES_RELACION = record.DES_RELACION;
                    Lista.Add(item);
                }

                return Lista;
            }

        }


        #endregion

    }

}