using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Examen2.Models
{
    public class Estudiante
    {
        public int estudiante_id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string estado { get; set; }
        public List<Materia> materias { get; set; }
    }
}
