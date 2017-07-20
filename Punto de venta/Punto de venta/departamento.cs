using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Punto_de_venta
{
    class departamento
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string Consulta;
        List<departamento> Ldepartamento = new List<departamento>();
        departamento n;

        public void ListaDep()
        {
            try
            {
                Bdcomun.ObtenerConexion();

                Consulta = "select nombre,iddepartamento from departamento";
                MySqlCommand mycomand = new MySqlCommand();
                mycomand.Connection = Bdcomun.ObtenerConexion();
                mycomand.CommandText = Consulta;
                MySqlDataReader reader = mycomand.ExecuteReader();


                while (reader.Read())
                { 
                    string nom = reader["nombre"].ToString();
                    string iddeps = reader["iddepartamento"].ToString();
                    n = new departamento() { Nombre = nom,Id=int.Parse(iddeps)};
                    Ldepartamento.Add(n);
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<departamento> getLista()
        {
            return Ldepartamento;
        }
    }

}

