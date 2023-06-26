using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_crud.Models
{
    internal class Cliente
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set;}
        public string direccion { get; set;}
        public int telefono { get; set;}
        public DateTime fechaNacimiento { get; set;}
        public string estado { get; set;}
    }
}
