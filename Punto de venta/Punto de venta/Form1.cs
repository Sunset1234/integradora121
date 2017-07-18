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
          
            DialogResult result = MessageBox.Show("¿Imprimir ticket?","Ticket",MessageBoxButtons.YesNoCancel);
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
      
        //List<departamento> Ldepartamento = new List<departamento>();
        //departamento n;
        //public MySqlConnection Cnn = new MySqlConnection();
        //Bdcomun conexión;
        //string nom;
        //string stConsulta = "";
        //string Conexión = "server=127.0.0.1; database=puntodeventa; Uid=root; pwd=;";

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                departamento a = new departamento();
                a.ListaDep();
                cbxdepart.DataSource = a.getLista();
                cbxdepart.DisplayMember = "nombre";
                cbxdepart.ValueMember = "Id";

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                throw;
            }
           
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
            pProducto.Codebar = int.Parse(tbxcode.Text);
            pProducto.Nombre = tbxnombre.Text.ToString();
            pProducto.Descripcion = tbxdesc.Text.ToString();
            pProducto.Cantactual =int.Parse(tbxcanactual.Text);
            pProducto.Precosto = double.Parse(tbxprecost.Text);
            pProducto.Preventa = double.Parse(tbxpreventa.Text);
            pProducto.Departamento = cbxdepart.Text.ToString();

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
            if (e.KeyChar == Convert.ToChar(Keys.V))
            {
                tabControl2.SelectedTab == tabControl2.TabPages[ticket2];
            }
        }
    }
}
