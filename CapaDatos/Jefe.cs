using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Jefe
    {
        private string id;
        private string nombre;
        private string apellido;
        private string cuil;
        private string telefono;
        Area_trabajo areatra;

        private static List<Jefe> listjefe = new List<Jefe>();

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string CUIL
        {
            get { return cuil; }
            set { cuil = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Area_trabajo AreaTra
        {
            get { return areatra; }
            set { areatra = value; }
        }

        public Jefe()
        {
            this.id = "";
            this.nombre = "";
            this.apellido = "";
            this.cuil = "";
            this.telefono = "";
        }

        public Jefe(string id, string nombre, string apellido, string cuil, string telefono, Area_trabajo areatra)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cuil = cuil;
            this.telefono = telefono;
            this.areatra = areatra;
        }

        public void Guardar()
        {
            listjefe.Add(this);
        }

        public static List<Jefe> Buscar()
        {
            return listjefe;
        }
        public static List<Jefe> Buscar(string palabra)
        {
            List<Jefe> resultado = new List<Jefe>();
            foreach (Jefe i in listjefe)
            {
                if (i.id.Contains(palabra)||i.nombre.Contains(palabra)||i.apellido.Contains(palabra))
                {
                    resultado.Add(i);
                }
                else
                {

                }
            }
            return resultado;
        }
    }
}
