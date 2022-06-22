using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Area_trabajo
    {
        private string areatra;

        private static List<Area_trabajo> listarea = new List<Area_trabajo>();

        public string Areatra
        {
            get { return areatra; }
            set { areatra = value; }
        }

        public Area_trabajo()
        {
            this.areatra = "n/area";
        }

        public Area_trabajo(string unareatra)
        {
            areatra = unareatra;
        }

        public override string ToString()
        {
            return areatra;
        }

        public void Guardar()
        {
            Area_trabajo.listarea.Add(this);
        }

        public static List<Area_trabajo> Buscar()
        {
            return listarea;
        }
    }
}
