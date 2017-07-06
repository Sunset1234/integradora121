using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Punto_de_venta
{
    class ClienteDAL
    {
        public static int Agregar(cliente pCliente)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into cliente (idcliente,nombre,apaterno,amaterno,direccion,telefono) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
            pCliente.Idcliente,pCliente.Nombre, pCliente.Apaterno,pCliente.Amaterno,pCliente.Dirección,pCliente.Telefono),Bdcomun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
