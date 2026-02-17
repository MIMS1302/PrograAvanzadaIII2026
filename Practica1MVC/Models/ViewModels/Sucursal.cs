using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica1MVC.Models.ViewModels
{
    public class Sucursal : ListaSucursales
    {
        [Display (Name = "ID de la Sucursal")]

        public int SucursalId { get; set; }

        [Display(Name = "Direccion")]

        public string Direccion { get; set; }


    }
}