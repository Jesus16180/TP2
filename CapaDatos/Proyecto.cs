using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Proyecto
    {
        private string id;
        private string nom;
        private string apellido;
        private string telefono;
        private string proy;
        private decimal cost;
        public Jefe jef;
        private int diasest;
        
        public static List<Proyecto> listproy = new List<Proyecto>();

        public string Nom 
        {
            get { return nom; }
            set { nom = value; }   
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Proy
        {
            get { return proy; }
            set { proy = value; }
        }

        public decimal Cost { 
        get { return cost; }
        set { cost = value; }
        }

        public Jefe Jef 
        {
            get { return jef; }
            set { jef = value; }
        }

        public int Diasest
        {
            get { return diasest; }
            set { diasest = value; }
        }

        public Proyecto() 
        {
            this.Nom = "";
            this.apellido = "";
            this.telefono = "";
            this.proy = "";
            this.cost = 0;
            
            this.diasest = 0;
        }

        public Proyecto(string id, string proy, decimal cost, string jef, int diasest, string nom, string apellido, string telefono)
        { 
          this.nom = nom;
            this.apellido=apellido;
            this.telefono=telefono;
            this.proy=proy;
            this.cost=cost;
            this.jef=buscarj(jef);
            this.diasest = diasest;
        }
        public static Jefe buscarj(string jef)
        {
            Jefe r=new Jefe();
            foreach(Jefe i in Jefe.Buscar())
            {
                if(i.ID==jef)
                {
                    r = i;
                }
            }
            return r;
        }

        public void Guardar() 
        {
            listproy.Add(this);
        }

        public static List<Proyecto> Buscar() 
        {
            return listproy;
        }

        public static List<Proyecto> Buscar(string palabra)
        {
            List<Proyecto> resultado = new List<Proyecto>();
            foreach (Proyecto i in listproy)
            {
                if ((i.nom.Contains(palabra)))
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
