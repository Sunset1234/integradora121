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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioefectivo.Checked)
            {
                DialogResult result = MessageBox.Show("¿Imprimir ticket?", "Ticket", MessageBoxButtons.YesNoCancel);
            }
            else
            {
                MessageBox.Show("CLIENTE REGISTRADO");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bdcomun.ObtenerConexion();
            MessageBox.Show("conectado");
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            cliente Pcliente = new cliente();
            Pcliente.Idcliente = int.Parse(tbxid.Text);
            Pcliente.Nombre = tbxname.Text;
            Pcliente.Apaterno = tbxamaterno.Text;
            Pcliente.Amaterno = tbxapaterno.Text;
            Pcliente.Dirección = tbxdir.Text;
            Pcliente.Telefono = int.Parse(tbxtel.Text);

            
            int resultado = Comandos.AgregarCliente(Pcliente);
            if (resultado > 0)
            {
                MessageBox.Show("¡Cliente guardado con exito!");
            }
            else {
                MessageBox.Show("No se pudo agregar el cliente");
            }

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lblprecosto_Click(object sender, EventArgs e)
        {

        }

        private void btnaddprod_Click(object sender, EventArgs e)
        {
          
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                producto pProducto = new producto();
                pProducto.Codebar = tbxcode.Text.ToString();
                pProducto.Nombre = tbxnombre.Text.ToString();
                pProducto.Descripcion = tbxdesc.Text.ToString();
                pProducto.Cantactual = int.Parse(tbxcanactual.Text);
                pProducto.Precosto = double.Parse(tbxprecost.Text);
                pProducto.Preventa = double.Parse(tbxpreventa.Text);
                pProducto.Departamento = int.Parse(cbxdepart.SelectedValue.ToString());

                int resultado = Comandos.AgregarProductos(pProducto);
                if (resultado > 0)
                {
                    MessageBox.Show("¡Producto guardado con exito!");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente");
                }
        }

        private void cbxdepart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblcantregistro_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    if (e.KeyChar == Convert.ToChar(Keys.V))
        //    {
        //        tabControl2.SelectedTab == tabControl2.TabPages[ticket2];
        //    }
        }

        private void btnaddproducto_Click(object sender, EventArgs e)
        {
            panelmodificar.Hide();
            panelfproductos.Show();
        }

        private void btnaddproducto_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnmodificarproduc_Click(object sender, EventArgs e)
        {
            tbxmodproduc.Clear();
            panelmodificar.Show();
            paneladddepa.Hide();
            panelfproductos.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            btnmodproduct.Visible = true;
            try
            {
                Bdcomun.ObtenerConexion();

                string Consulta = "select productos.idproducto,productos.nombre,productos.descripcion,productos.cantidadstock,productos.preciocosto,productos.precioventa,departamento.nombre as 'nombred' from productos inner join departamento on productos.departamento = departamento.iddepartamento where productos.idproducto='"+tbxmodproduc.Text.ToString()+"'";
                MySqlCommand mycomand = new MySqlCommand();
                mycomand.Connection = Bdcomun.ObtenerConexion();
                mycomand.CommandText = Consulta;
                MySqlDataReader reader = mycomand.ExecuteReader();

                while (reader.Read())
                {                      
                        tbxcode.Text = reader["idproducto"].ToString();
                        tbxnombre.Text = reader["nombre"].ToString();
                        tbxdesc.Text = reader["descripcion"].ToString();
                        cbxdepart.Text = reader["nombred"].ToString();
                        tbxprecost.Text = reader["preciocosto"].ToString();
                        tbxpreventa.Text = reader["precioventa"].ToString();
                        tbxcanactual.Text = reader["cantidadstock"].ToString();
                }
                reader.Close();
                if (tbxcode.Text == "")
                {
                    MessageBox.Show("Producto no encontrado");
                }
                else {
                    panelmodificar.Hide();
                    panelfproductos.Show();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void panelfproductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadddepa_Click(object sender, EventArgs e)
        {
            paneladddepa.Show();
            panelfproductos.Hide();
            panelmodificar.Hide();
        }

        private void btnmodproduct_Click(object sender, EventArgs e)
        {

            try
            {
                Bdcomun.ObtenerConexion();

                string Consulta = "UPDATE `puntodeventa`.`productos` SET `idproducto`= '"+tbxcode.Text.ToString()+ "', `nombre`= '"+tbxnombre.Text.ToString()+"', `descripcion`= '"+tbxdesc.Text.ToString()+"', `cantidadstock`= '"+int.Parse(tbxcanactual.Text)+"', `preciocosto`= '"+int.Parse(tbxprecost.Text)+"', `precioventa`= '"+int.Parse(tbxpreventa.Text)+"', `departamento`= '"+cbxdepart.ValueMember+"' WHERE `idproducto`= '"+tbxcode.Text.ToString()+"';";
                MySqlCommand mycomand = new MySqlCommand();
                mycomand.Connection = Bdcomun.ObtenerConexion();
                mycomand.CommandText = Consulta;
                MySqlDataReader reader = mycomand.ExecuteReader();
                MessageBox.Show("Producto Modificado con exito!");
                while (reader.Read())
                {
                    
                }
                reader.Close();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void form1_Load_1(object sender, EventArgs e)
        {

            try
            {
                departamento a = new departamento();
                a.ListaDep();
                cbxdepart.DataSource = a.getLista();
                cbxdepart.DisplayMember = "nombre";
                cbxdepart.ValueMember = "id";

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                throw;
            }
        }
    }
}
