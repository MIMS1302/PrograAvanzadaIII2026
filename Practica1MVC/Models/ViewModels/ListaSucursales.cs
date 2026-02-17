using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica1MVC.Models.ViewModels
{
    public class ListaSucursales
    {
        public int SucursalId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}