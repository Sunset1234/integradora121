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
        string Consulta2;
        List<departamento> Ldepartamento = new List<departamento>();
        departamento n;

        public void ListaDep()
        {
            try
            {
                Bdcomun.ObtenerConexion();

                Consulta = "select nombre from departamento";
                Consulta2 = "select iddepartamento from departamento";
                MySqlCommand mycomand = new MySqlCommand();
                mycomand.Connection = Bdcomun.ObtenerConexion();
                mycomand.CommandText = Consulta;
                MySqlDataReader reader = mycomand.ExecuteReader();


                while (reader.Read())
                {
                    //reader.Read();
                    string nom = reader["nombre"].ToString();
                    //reader.Close();
                  //  mycomand.CommandText = Consulta2;
                   // MySqlDataReader read = mycomand.ExecuteReader();
                    //string inte = read["iddepartamento"].ToString();
                    //read.Close();
                    n = new departamento() { Nombre = nom/*,Id=int.Parse(inte)*/};
                    Ldepartamento.Add(n);
                }
                reader.Close();

                

                //while (read.Read())
                //{
                //    mycomand.CommandText = Consulta2;
                //    MySqlDataReader read = mycomand.ExecuteReader();
                //    string inte = read["iddepartamento"].ToString();

                //    string inte = read["iddepartamento"].ToString();
                //    n.Id= int.Parse(inte);
                //}
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

