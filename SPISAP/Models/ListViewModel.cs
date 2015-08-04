﻿using System;
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
                new GenericModel() { CODIGO=" ", DESCRIPCION=""  },
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

                Lista.Add(new PAIS { COD_PAIS = " ", DES_PAIS = "" });

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
        public static List<PAIS_ESTADO> Estados()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<PAIS_ESTADO> Lista = new List<PAIS_ESTADO>();

                Lista.Add(new PAIS_ESTADO { COD_ESTADO = "", DES_ESTADO = "" });

                foreach (var record in db.PAIS_ESTADO.Where(p => p.COD_PAIS == "VE").OrderBy(p => p.DES_ESTADO))
                {
                    PAIS_ESTADO item = new PAIS_ESTADO();
                    item.COD_ESTADO = record.COD_ESTADO;
                    item.DES_ESTADO = record.DES_ESTADO;
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
                new GenericModel() { CODIGO=" "     , DESCRIPCION=""            },
                new GenericModel() { CODIGO="Solt." , DESCRIPCION="Soltero"     },
                new GenericModel() { CODIGO="Concu.", DESCRIPCION="Concubino"   },
                new GenericModel() { CODIGO="Cas."  , DESCRIPCION="Casado"      },
                new GenericModel() { CODIGO="Div."  , DESCRIPCION="Divorciado"  },
                new GenericModel() { CODIGO="Viu."  , DESCRIPCION="Viudo"       }
            };

        }

        // retornar la lista de area de personal.
        public static List<AREA_PERSONAL> AreaPersonal()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<AREA_PERSONAL> Lista = new List<AREA_PERSONAL>();

                Lista.Add(new AREA_PERSONAL { COD_AREA_PERSONAL = " ", DES_AREA_PERSONAL = "" });

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

                Lista.Add(new SUCURSAL { COD_SUCURSAL = " ", DES_SUCURSAL = "" });

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

                Lista.Add(new GRUPO_PERSONAL { COD_GRUPO = " ", DES_GRUPO_PERSONAL = "" });

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
        public static List<GenericModel> FillTallaChemise()
        {
            // CHEMISE_CHECK:
            // (SEXO ='F' AND CHEMISE IN ('S','M','L','XL','XXL','XXXL')) OR (SEXO='M' AND CHEMISE IN ('36','38','40', '42','44','46'))

            return new List<GenericModel>
            {
                new GenericModel() { CODIGO=" ", DESCRIPCION="" },
                new GenericModel() { CODIGO="F", DESCRIPCION="S" },
                new GenericModel() { CODIGO="F", DESCRIPCION="M"},
                new GenericModel() { CODIGO="F", DESCRIPCION="L"},
                new GenericModel() { CODIGO="F", DESCRIPCION="XL"},
                new GenericModel() { CODIGO="F", DESCRIPCION="XXL"},
                new GenericModel() { CODIGO="F", DESCRIPCION="XXXL"},
                new GenericModel() { CODIGO="M", DESCRIPCION="36"},
                new GenericModel() { CODIGO="M", DESCRIPCION="38"},
                new GenericModel() { CODIGO="M", DESCRIPCION="40"},
                new GenericModel() { CODIGO="M", DESCRIPCION="42"},
                new GenericModel() { CODIGO="M", DESCRIPCION="44"},
                new GenericModel() { CODIGO="M", DESCRIPCION="46"}
            };

        }

        // retornar la lista de tallas de pantalón.
        public static List<GenericModel> FillTallaPantalon()
        {
            // PANTALON_CHECK
            // (SEXO='F' AND CHEMISE IN ('8','10','12','14','16','18','20','22','24','26'))
            // (SEXO='M' AND CHEMISE IN ('28','30','32','34','36','38','40','42','44','46'))

            return new List<GenericModel>
            {
                new GenericModel() { CODIGO=" ", DESCRIPCION="" },
                new GenericModel() { CODIGO="F", DESCRIPCION="8" },
                new GenericModel() { CODIGO="F", DESCRIPCION="10"},
                new GenericModel() { CODIGO="F", DESCRIPCION="12"},
                new GenericModel() { CODIGO="F", DESCRIPCION="14"},
                new GenericModel() { CODIGO="F", DESCRIPCION="16"},
                new GenericModel() { CODIGO="F", DESCRIPCION="18"},
                new GenericModel() { CODIGO="F", DESCRIPCION="20"},
                new GenericModel() { CODIGO="F", DESCRIPCION="22"},
                new GenericModel() { CODIGO="F", DESCRIPCION="24"},
                new GenericModel() { CODIGO="F", DESCRIPCION="26"},
                new GenericModel() { CODIGO="M", DESCRIPCION="28"},
                new GenericModel() { CODIGO="M", DESCRIPCION="30"},
                new GenericModel() { CODIGO="M", DESCRIPCION="32"},
                new GenericModel() { CODIGO="M", DESCRIPCION="34"},
                new GenericModel() { CODIGO="M", DESCRIPCION="36"},
                new GenericModel() { CODIGO="M", DESCRIPCION="38"},
                new GenericModel() { CODIGO="M", DESCRIPCION="40"},
                new GenericModel() { CODIGO="M", DESCRIPCION="42"},
                new GenericModel() { CODIGO="M", DESCRIPCION="44"},
                new GenericModel() { CODIGO="M", DESCRIPCION="46"}
            };

        }

        // retornar la lista de tallas de zapato.
        public static List<GenericModel> FillTallaCalzado()
        {
            // CALZADO_CHECK
            // CALZADO BETWEEN '34' AND '46'
            return new List<GenericModel>
            {
                new GenericModel() { CODIGO=" ", DESCRIPCION="" },
                new GenericModel() { CODIGO="34", DESCRIPCION="34" },
                new GenericModel() { CODIGO="36", DESCRIPCION="36"},
                new GenericModel() { CODIGO="38", DESCRIPCION="38"},
                new GenericModel() { CODIGO="40", DESCRIPCION="40"},
                new GenericModel() { CODIGO="42", DESCRIPCION="42"},
                new GenericModel() { CODIGO="44", DESCRIPCION="44"},
                new GenericModel() { CODIGO="46", DESCRIPCION="46"}
            };

        }
        #endregion

        #region DIRECCION

        // retornar la lista de estados.
        public static List<ESTADO_SSO> GetEstadoSSO()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<ESTADO_SSO> Lista = new List<ESTADO_SSO>();

                Lista.Add(new ESTADO_SSO { COD_ESTADO_SSO = " ", DES_ESTADO_SSO = "" });

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

                Lista.Add(new MUNICIPIO_SSO { COD_MUNICIPIO = " ", DES_MUNICIPIO = "" });

                foreach (var record in db.MUNICIPIO_SSO.OrderBy(p => p.DES_MUNICIPIO))
                {
                    MUNICIPIO_SSO item = new MUNICIPIO_SSO();
                    item.COD_MUNICIPIO = record.COD_MUNICIPIO;
                    item.DES_MUNICIPIO = record.DES_MUNICIPIO;
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

                Lista.Add(new PARROQUIA_SSO { COD_PARROQUIA = " ", DES_PARROQUIA = "" });

                foreach (var record in db.PARROQUIA_SSO.OrderBy(p => p.DES_PARROQUIA))
                {
                    PARROQUIA_SSO item = new PARROQUIA_SSO();
                    item.COD_PARROQUIA = record.COD_PARROQUIA;
                    item.DES_PARROQUIA = record.DES_PARROQUIA;
                    Lista.Add(item);
                }

                return Lista;
            }

        }


        #endregion

    }

}