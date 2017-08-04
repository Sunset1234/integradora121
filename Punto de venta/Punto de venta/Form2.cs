using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Punto_de_venta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            try
            {
                Bdcomun.ObtenerConexion();
                string Consulta = "select idproducto,nombre,descripcion from productos";
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(Consulta, Bdcomun.ObtenerConexion());
                ad.Fill(dt);
                dgvproducts.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
