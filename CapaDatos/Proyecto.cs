using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Proyecto
    {
        private string nombre;
        private decimal diasest;
        private decimal costo;
        private Jefe jefe;
        List<Empleado> listempleados = new List<Empleado>();
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public decimal Diasest 
        {
            get { return diasest; }
            set { diasest = value; }
        }
        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        public Jefe Jefe
        {
            get { return jefe; }
            set { jefe = value; }
        }
        public Proyecto(string nombre, decimal diasest, decimal costo) 
        {

        }
    }
}
