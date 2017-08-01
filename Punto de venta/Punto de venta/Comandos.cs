﻿using System;
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
        public static int ActualizarProductos(producto pProducto)
        {
            int retorno = 0;
            //    MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `puntodeventa`.`productos` SET `idproducto`=" + pProducto.Codebar + ", `nombre`=" + pProducto.Nombre + ", `descripcion`=" + pProducto.Descripcion + ", `cantidadstock`=" + pProducto.Cantactual + ", `preciocosto`=" + pProducto.Precosto + ", `precioventa`=" + pProducto.Preventa + ", `departamento`=" + pProducto.Departamento + " WHERE `idproducto`=" + pProducto.Codebar
            //    ), Bdcomun.ObtenerConexion());
            //    retorno = comando.ExecuteNonQuery();
            return retorno;

        }
    }
}
