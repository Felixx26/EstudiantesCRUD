using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Examen2.Models
{
    public class Materia
    {
        public int materia_id { get; set; }
        public string codigo { get; set; }
        public string nombre_materia { get; set; }
        public int creditos { get; set; }
    }
}
