﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Punto_de_venta
{
     public class Bdcomun
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=puntodeventa; Uid=root; pwd=;");
            conectar.Open();
            return conectar;
        }

     }
}
