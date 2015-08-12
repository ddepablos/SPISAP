using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPISAP.Models
{
    public class FilterModelView
    {

        //[Required(ErrorMessage = "El campo Ficha es requerido.")]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Ficha permite únicamente números.")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "El campo Ficha debe contener entre 6 y 12 dígitos.")]
        public string FICHA { get; set; }

        //[Required(ErrorMessage = "El campo Cédula es requerido.")]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "El campo Cédula permite únicamente números.")]
        [StringLength(8, MinimumLength = 6, ErrorMessage = "El campo Cédula debe contener entre 6 y 8 dígitos.")]
        public string CEDULA { get; set; }

        //[Required(ErrorMessage = "El campo Primer Apellido es requerido.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "El campo Primer Apellido debe contener entre 3 y 40 carácteres.")]
        public string PRIMER_APELLIDO { get; set; }


    }
}