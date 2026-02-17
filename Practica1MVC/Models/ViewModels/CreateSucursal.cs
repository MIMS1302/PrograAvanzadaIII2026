using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica1MVC.Models.ViewModels
{
    public class CreateSucursal
    {
        [Required(ErrorMessage ="El nombre de la sucursal es obligatorio")]
        [Display(Name = "Nombre de la sucursal")]
        [StringLength(100, ErrorMessage = "El nombre de la sucursal no puede exceder los 100 caracteres")]
        [MinLength(3, ErrorMessage = "El nombre de la sucursal debe tener al menos 3 caracteres")]
        [RegularExpression(@"^[\p{L}\p{M}\s'-]+$", ErrorMessage = "El nombre solo puede contener letras sin espacios, números ni caracteres especiales")]

        public string Nombre { get; set; }

        [Display(Name = "Direccion de la Sucursal")]
        [MaxLength(200, ErrorMessage = "La direccion de la sucursal no puede exceder los 200 caracteres")]
        public string Direccion { get; set; }

        [Display(Name = "Telefono de la Sucursal")]
        public string Telefono { get; set; }    






    }
}