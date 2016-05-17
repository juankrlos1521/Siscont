using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SisCont.Models.Models
{
    public class Persona
    {
        [Key]
        public Int32 Id { get; set; }
        public String Nombres { get; set; }
        public String Direccion { get; set; }
        public Int32 Telefono { get; set; }

        //Clave sol

        public String Usuario { get; set; }
        public String ClaveSol { get; set; }
    }
}
