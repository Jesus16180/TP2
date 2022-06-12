using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Empleado
    {
        private string id;
        private string nombre;
        private string apellido;
        private string cuil;
        private string telefono;
        private string areatra;
        private string idjefe;
       
        private static List<Empleado> listempleados = new List<Empleado>();

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
        public string AreaTra
        {
            get { return areatra; }
            set { areatra = value; }
        }
        public string IDjefe
        {
            get { return idjefe; }
            set { idjefe = value; }
        }

        public Empleado()
        {
            this.id = "";
            this.nombre = "";
            this.apellido = "";
            this.cuil = "";
            this.telefono = "";
            this.areatra = "";
            this.idjefe = "";
        }

        public Empleado(string id, string nombre, string apellido, string cuil, string telefono, string areatra, string idjefe)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cuil = cuil;
            this.telefono = telefono;
            this.areatra = areatra;
            this.idjefe = idjefe;
        }

        public void Guardar()
        {
            listempleados.Add(this);
        }

        public static List<Empleado> Buscar()
        {
            return listempleados;
        }

        public string ExactData()
        {
            return string.Format("{0},{1},{2},Empleado,{3}",ID,Apellido,Nombre,AreaTra);
        }
    }
}
