using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            texboxpcodigo.Text = "WEY";
            //WindowState = MaximumSize;
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
            Pcliente.Apaterno = tbxapaterno.Text;
            Pcliente.Amaterno = tbxamaterno.Text;
            Pcliente.Dirección = tbxdir.Text;
            Pcliente.Telefono = int.Parse(tbxtel.Text);
            
            int resultado = ClienteDAL.Agregar(Pcliente);
            if (resultado > 0)
            {
                MessageBox.Show("¡Clientre guardado con exito!");
            }
            else {
                MessageBox.Show("No se pudo agregar el cliente");
            }

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
