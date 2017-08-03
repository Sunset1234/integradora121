using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta
{
    class producto
    {
        private string codebar;

        public string Codebar
        {
            get { return codebar; }
            set { codebar = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private int departamento;

        public int Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        private double precosto;

        public double Precosto
        {
            get { return precosto; }
            set { precosto = value; }
        }

        private double preventa;

        public double Preventa
        {
            get { return preventa; }
            set { preventa = value; }
        }

        private int cantactual;

        public int Cantactual
        {
            get { return cantactual; }
            set { cantactual = value; }
        }

        public producto() { }

        public producto(string codebar,string nombre, string desc, int cantactual, double precosto, double preventa, int departamento)
        {
            this.codebar = codebar;
            this.nombre = nombre;
            this.descripcion = desc;
            this.cantactual = cantactual;
            this.precosto = precosto;
            this.preventa = preventa;
            this.departamento = departamento;
        }

    }
}
