﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta
{
    class producto
    {
        private int codebar;

        public int Codebar
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

        private string departamento;

        public string Departamento
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

        //private int cantregistro;

        //public int Cantregistro
        //{
        //    get { return cantregistro; }
        //    set { cantregistro = value; }
        //}

        private int cantactual;

        public int Cantactual
        {
            get { return cantactual; }
            set { cantactual = value; }
        }


        public producto() { }

        public producto(int codebar,string nombre, string desc, int cantactual, double precosto, double preventa, string departamento)
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
