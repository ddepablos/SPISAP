using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPISAP.Models
{

    public static class ListViewModel
    {

        // estructura de registro de item dummy.
        public class GENERIC_ITEM
        {
            public string CODIGO { get; set; }
            public string DESCRIPCION { get; set; }
        }


        // retornar la lista de países.
        public static List<PAIS> FillPaises()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<PAIS> Lista = new List<PAIS>();

                foreach (var record in db.PAISES.OrderBy(p => p.DES_PAIS))
                {
                    PAIS pais = new PAIS();
                    pais.COD_PAIS = record.COD_PAIS;
                    pais.DES_PAIS = record.DES_PAIS;
                    Lista.Add(pais);
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

                foreach (var record in db.PAIS_ESTADO.OrderBy(p => p.COD_PAIS))
                {
                    PAIS_ESTADO item = new PAIS_ESTADO();
                    item.COD_ESTADO = record.COD_ESTADO;
                    item.DES_ESTADO = record.COD_ESTADO;
                    Lista.Add(item);
                }

                return Lista;
            }

        }

        // retornar la lista de estado civil.
        public static List<string> EstadoCivil()
        {
            return new List<string> { "Cas.", "Concu.", "Div.", "Solt.", "Viu." };
        }

        // retornar la lista de area de personal.
        public static List<AREA_PERSONAL> AreaPersonal()
        {

            using (SPISAPEntities db = new SPISAPEntities())
            {
                List<AREA_PERSONAL> Lista = new List<AREA_PERSONAL>();

                foreach (var record in db.AREA_PERSONAL.OrderBy(p => p.COD_AREA_PERSONAL))
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

                foreach ( var record in db.SUCURSALES.OrderBy(p => p.DES_SUCURSAL) )
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
        public static List<GENERIC_ITEM> FillTallaCamisa()
        {
            // CHEMISE_CHECK:
            // (SEXO ='F' AND CHEMISE IN ('S','M','L','XL','XXL','XXXL')) OR (SEXO='M' AND CHEMISE IN ('36','38','40', '42','44','46'))

            var lista = new List<GENERIC_ITEM>
            {
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="S" },
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="M"},
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="L"},
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="XL"},
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="XXL"},
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="XXXL"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="36"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="38"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="40"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="42"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="44"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="46"}
            };

            return lista;

        }

        // retornar la lista de tallas de pantalón.
        public static List<GENERIC_ITEM> FillTallaPantalon()
        {
            // PANTALON_CHECK
            // (SEXO='F' AND CHEMISE IN ('8','10','12','14','16','18','20','22','24','26'))
            // (SEXO='M' AND CHEMISE IN ('28','30','32','34','36','38','40','42','44','46'))

            var lista = new List<GENERIC_ITEM>
            {
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="8" },
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="10"},
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="12"},
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="14"},
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="16"},
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="18"},
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="20"},
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="22"},
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="24"},
                new GENERIC_ITEM() { CODIGO="F", DESCRIPCION="26"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="28"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="30"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="32"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="34"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="36"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="38"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="40"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="42"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="44"},
                new GENERIC_ITEM() { CODIGO="M", DESCRIPCION="46"}
            };

            return lista;

        }

        // retornar la lista de tallas de zapato.
        public static List<string> FillTallaZapato()
        {
            // CALZADO_CHECK
	        // CALZADO BETWEEN '34' AND '46'

            return new List<string> { "34", "36", "38", "40", "42", "44", "46" };

        }


    }

}