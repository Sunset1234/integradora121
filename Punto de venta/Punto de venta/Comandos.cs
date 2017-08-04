using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Punto_de_venta
{
    class Comandos
    {
        public static int AgregarCliente(cliente pCliente)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into cliente (idcliente,nombre,apaterno,amaterno,direccion,telefono) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
            pCliente.Idcliente, pCliente.Nombre, pCliente.Apaterno, pCliente.Amaterno, pCliente.Dirección, pCliente.Telefono), Bdcomun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int AgregarProductos(producto pProducto)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into productos (idproducto,nombre,descripcion,cantidadstock,preciocosto,precioventa,departamento) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
            pProducto.Codebar,pProducto.Nombre,pProducto.Descripcion,pProducto.Cantactual,pProducto.Precosto,pProducto.Preventa,pProducto.Departamento), Bdcomun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }

        public static int AgregarDepartamento(departamento dDepartamento)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into departamento(nombre) values ('{0}')",
            dDepartamento.Nombre), Bdcomun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ActualizarProducto(producto pProducto)
        {
            int retorno=0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `puntodeventa`.`productos` SET `idproducto`='" + pProducto.Codebar +
                "', `nombre`='" + pProducto.Nombre + "', `descripcion`='" + pProducto.Descripcion +
                "', `cantidadstock`='" + pProducto.Cantactual + "', `preciocosto`='" + pProducto.Precosto +
                "', `precioventa`='" + pProducto.Preventa + "', `departamento`='" + pProducto.Departamento +
                "' WHERE `idproducto`='" + pProducto.Codebar + "';"),
                Bdcomun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ActualizarCliente(cliente cCliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `puntodeventa`.`cliente` SET `idcliente`='" + cCliente.Idcliente +
                "', `nombre`='" + cCliente.Nombre + "', `apaterno`='" + cCliente.Apaterno + "', `amaterno`='" + cCliente.Amaterno +
                "', `direccion`='" + cCliente.Dirección + "', `telefono`='" + cCliente.Telefono + "', `saldo`='" + cCliente.Saldo +
                "' WHERE `idcliente`='" + cCliente.Idcliente + "';"), Bdcomun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ActualizarDepartamento(departamento dDepartamento)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `puntodeventa`.`departamento` SET `iddepartamento`= '" + dDepartamento.Id +
                "', `nombre`= '" + dDepartamento.Nombre + "' WHERE `iddepartamento`= '" + dDepartamento.Id + "'"), Bdcomun.ObtenerConexion());
            comando.ExecuteNonQuery();
            return retorno;
        }



    }
}
