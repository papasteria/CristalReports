using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CristalReport.model
{
    [Table(name: "Productos")]
   public  class Productos
    {
        [Key]
        public int pkProducto { get; set; }
        [Required(ErrorMessage = "Se requiere el Nombre")]
        public string sNombreCorto { get; set; }

        [Required(ErrorMessage = "Se requiere la descripcion")]
        public string sDescripcion { get; set; }

        [Required(ErrorMessage = "Se requiere el departamento")]
        public double sDepartamemto { get; set; }

        [Required(ErrorMessage = "Se requiere el costo")]
        public double dCosto { get; set; }

        [Required(ErrorMessage = "Se requiere la calificacion")]
        public double dPrecio { get; set; }


        [Required(ErrorMessage = "Se requiere el Estatus")]
        public Boolean iStatus { get; set; }

        [Required(ErrorMessage = "Se requiere el Stock")]
        public int iStock { get; set; }

        public Productos()
        {
            iStatus = true;
        }
    }
}
