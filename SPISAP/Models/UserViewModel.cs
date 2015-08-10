using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPISAP.Models
{
    public class UserViewModel
    {

        [Required(ErrorMessage = "El campo Usuario es requerido.")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "El campo Usuario debe contener entre 3 y 12 carácteres.")]
        public string username { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es requerido.")]
        [StringLength(8, MinimumLength = 1, ErrorMessage = "El campo Contraseña debe contener 8 carácteres.")]
        public string password { get; set; }

    }
}