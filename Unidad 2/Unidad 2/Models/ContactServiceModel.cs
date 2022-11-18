using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad_2.Models
{
    internal class ContactServiceModel
    {
     
            public string mensaje { get; set; }
            public Contacto response { get; set; }
    }

        public class Contacto
        {
            public int idContacto { get; set; }
            public string nombre { get; set; }
            public string descripcion { get; set; }
            public string telefono { get; set; }
            public int idTipo { get; set; }
            public Objtipo objTipo { get; set; }
        }

        public class Objtipo
        {
            public string descripcion { get; set; }
        }

    }

