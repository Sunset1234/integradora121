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

        }

        private void btnaddproducto_Click(object sender, EventArgs e)
        {
            paneladddepa.Hide();
            tbxcode.Focus();
            panelmodificar.Hide();
            btnmodproduct.Hide();
            button1adp.Show();
            panelfproductos.Show();
        }

        private void btnaddproducto_MouseHover(object sender, EventArgs e)
        {

        }

        int modielim = 0; //Modi es igual a 0 eliminar es igual a 1;
        private void btnmodificarproduc_Click(object sender, EventArgs e)
        {
            modielim = 0;
            tbxmodproduc.Clear();
            panelmodificar.Show();
            paneladddepa.Hide();
            panelfproductos.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (modielim == 0)
            {
                button1adp.Hide();
                btnmodproduct.Visible = true;
                try
                {
                    Bdcomun.ObtenerConexion();

                    string Consulta = "select productos.idproducto,productos.nombre,productos.descripcion,productos.cantidadstock,productos.preciocosto,productos.precioventa,departamento.nombre as 'nombred' from productos inner join departamento on productos.departamento = departamento.iddepartamento where productos.idproducto='" + tbxmodproduc.Text.ToString() + "'";
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
                        MessageBox.Show("!Producto no encontrado¡");
                    }
                    else
                    {
                        panelmodificar.Hide();
                        panelfproductos.Show();

                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else if (modielim == 1)
            {
                button1adp.Hide();
                button2.Show();
                try
                {
                    Bdcomun.ObtenerConexion();

                    string Consulta = "select productos.idproducto,productos.nombre,productos.descripcion,productos.cantidadstock,productos.preciocosto,productos.precioventa,departamento.nombre as 'nombred' from productos inner join departamento on productos.departamento = departamento.iddepartamento where productos.idproducto='" + tbxmodproduc.Text.ToString() + "'";
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
                        tbxcode.Enabled = false; tbxnombre.Enabled = false; tbxdesc.Enabled = false;
                        cbxdepart.Enabled = false;tbxprecost.Enabled = false;tbxpreventa.Enabled = false;
                        tbxcanactual.Enabled = false;
                        button2.Enabled = true;
                        
                    }
                    reader.Close();
                    if (tbxcode.Text == "")
                    {
                        MessageBox.Show("!Producto no encontrado¡");
                    }
                    else
                    {
                        panelmodificar.Hide();
                        panelfproductos.Show();

                    }
                }
                catch (Exception)
                {
                    throw;
                }
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
            producto pProducto = new producto();
            pProducto.Codebar = tbxcode.Text.ToString();
            pProducto.Nombre = tbxnombre.Text.ToString();
            pProducto.Descripcion = tbxdesc.Text.ToString();
            pProducto.Cantactual = int.Parse(tbxcanactual.Text);
            pProducto.Precosto = double.Parse(tbxprecost.Text);
            pProducto.Preventa = double.Parse(tbxpreventa.Text);
            pProducto.Departamento = int.Parse(cbxdepart.SelectedValue.ToString());

            int resultado = Comandos.ActualizarProducto(pProducto);
            if (resultado > 0)
            {
                MessageBox.Show("¡Producto actualizado con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente");
            }

         
        }

        private void form1_Load_1(object sender, EventArgs e) //FORM LOAD
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
            }
        }

        private void btncreadepa_Click(object sender, EventArgs e)
        {
            departamento dDepartamento = new departamento();
            dDepartamento.Nombre=tbxnomdepa.Text.ToString();

            int resultado = Comandos.AgregarDepartamento(dDepartamento);
            if (resultado > 0)
            {
                MessageBox.Show("¡Departamento guardado con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente");
            }

        }

        private void btnaddcliente_Click(object sender, EventArgs e)
        {
            paneladcliente.Show();
            btnguardacambios.Hide();
            btnagregacli.Show();
        }

        private void btnmodcliente_Click(object sender, EventArgs e)
        {
            paneladcliente.Show();
            btnagregacli.Hide();
            btnguardacambios.Show();
        }

        private void btnguardacambios_Click(object sender, EventArgs e)
        {
            cliente Pcliente = new cliente();
            

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
            else
            {
                MessageBox.Show("No se pudo agregar el cliente");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            listBox1.Show();
            paneladddepa.Hide();
            try
            {
                departamento a = new departamento();
                a.ListaDep();
                listBox1.DataSource = a.getLista();
                listBox1.DisplayMember = "nombre";
                listBox1.ValueMember = "id";

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        List<departamento> ldselecc = new List<departamento>();
        private void btnmodificardepartamento_Click(object sender, EventArgs e)
        {
            ldselecc = listBox1.SelectedItems.Cast<departamento>().ToList();

            tbxnomdepa.Text = "holi";
            paneladddepa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Bdcomun.ObtenerConexion();

                string Consulta = "select idproducto ,descripcion,precioventa from productos where idproducto='"+textBox8.Text.ToString()+"'";
                MySqlCommand mycomand = new MySqlCommand();
                mycomand.Connection = Bdcomun.ObtenerConexion();
                mycomand.CommandText = Consulta;
                MySqlDataReader reader = mycomand.ExecuteReader();

                while (reader.Read())
                {
                    string code = reader["idproducto"].ToString();
                    string desc = reader["descripcion"].ToString();
                    string preve = reader["precioventa"].ToString();
                    dataGridView2.Rows.Add(code, desc,"1",preve);
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btneliminarproduc_Click(object sender, EventArgs e)
        {
            panelmodificar.Show();
            modielim = 1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format(
                " DELETE FROM `puntodeventa`.`productos` WHERE `idproducto`= '" + tbxcode.Text.ToString() + "';")
                , Bdcomun.ObtenerConexion());
                 comando.ExecuteNonQuery();
                MessageBox.Show("!Producto Eliminado correctamente¡");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());

            }
          


        }
    }
}
