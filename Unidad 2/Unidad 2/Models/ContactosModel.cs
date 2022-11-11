using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad_2.Models
{
    public class ContactosModel
    {
        [PrimaryKey , AutoIncrement]
        public int ContactID { get; set; }

        [MaxLength (40)]
        public string Nombre { get; set; }

        [MaxLength(12)]
        public string Telefono { get; set; }

        [MaxLength(200)]
        public string Imagen { get; set; }
    }
}
