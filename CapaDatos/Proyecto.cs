using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Proyecto
    {
        private string nom;
        private string apellido;
        private string telefono;
        private string proy;
        private float cost;
        public string jef;
        private decimal diasest;
        
        public static List<Proyecto> listclint = new List<Proyecto>();

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

        public float Cost { 
        get { return cost; }
        set { cost = value; }
        }

        public string Jef 
        {
            get { return jef; }
            set { jef = value; }
        }

        public decimal Diasest
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
            this.jef = "";
            this.diasest = 0;
        }

        public Proyecto(string nom, string apellido, string telefono, string proy, float cost, string jef, decimal diasest)
        { 
          this.nom = nom;
            this.apellido=apellido;
            this.telefono=telefono;
            this.proy=proy;
            this.cost=cost;
            this.jef=jef;
            this.diasest = diasest;
        }

        public void Guardar() 
        {
            listclint.Add(this);
        }

        public List<Proyecto> Buscar() 
        {
            return listclint;
        }

        public static List<Proyecto> Buscar(string palabra)
        {
            List<Proyecto> resultado = new List<Proyecto>();
            foreach (Proyecto i in listclint)
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
