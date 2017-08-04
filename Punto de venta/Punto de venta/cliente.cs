using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Punto_de_venta
{
    class cliente
    {
        private int idcliente;

        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apaterno;

        public string Apaterno
        {
            get { return apaterno; }
            set { apaterno = value; }
        }

        private string amaterno;

        public string Amaterno
        {
            get { return amaterno; }
            set { amaterno = value; }
        }

        private string dirección;

        public string Dirección
        {
            get { return dirección; }
            set { dirección = value; }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }


        public cliente() { }

        public cliente(int Pid,string Pnombre, string Papaterno, string Pamaterno, string Pdir, string tel)
        {
            this.idcliente = Pid;
            this.nombre = Pnombre;
            this.apaterno = Papaterno;
            this.amaterno = Pamaterno;
            this.dirección = Pdir;
            this.telefono = tel;
        }

    }
}
