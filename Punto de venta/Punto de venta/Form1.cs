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
using System.Diagnostics;

namespace Punto_de_venta
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load_1(object sender, EventArgs e) //FORM LOAD
        {
            Timer t = new Timer();
            t.Start();
            t.Tick += T_Tick;
            textBox8.Focus();
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

            try
            {
                Bdcomun.ObtenerConexion();
                string Consulta = "select nombre as 'Nombre',apaterno as 'Apellido Paterno'," +
                    "amaterno as 'Apellido Materno',direccion as 'Direccion',telefono as 'Telefono', saldo as " +
                    "'Saldo' from cliente";
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(Consulta, Bdcomun.ObtenerConexion());
                ad.Fill(dt);
                dgvclientes.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void btnaddproducto_Click(object sender, EventArgs e) //BTN PRINCIPAL AGREGAR PRODUCTO
        {
            tbxcode.Enabled = true; tbxnombre.Enabled = true; tbxdesc.Enabled = true;
            cbxdepart.Enabled = true; tbxprecost.Enabled = true; tbxpreventa.Enabled = true;
            tbxcanactual.Enabled = true; button1adp.Enabled = true;
            tbxcode.Clear(); tbxnombre.Clear(); tbxdesc.Clear(); tbxprecost.Clear(); tbxpreventa.Clear();
            tbxcanactual.Clear(); 

            panelfproductos.Show();
            paneladddepa.Hide();
            panelmodificar.Hide();
            tbxcode.Focus();         
            btnmodproduct.Hide();
            button2.Hide();
            button1adp.Show();
        }

        int modielim = 0; //Modi es igual a 0 eliminar es igual a 1;
        private void btnmodificarproduc_Click(object sender, EventArgs e)//BTN PRINCIPAL MODIFCAR PRODUCTO
        {
            tbxmodproduc.Clear();
            Form2 f = new Form2();
            f.Show();
            f.Location = new Point(590,300);
            modielim = 0;
            tbxmodproduc.Clear();
            paneladddepa.Hide();
            panelfproductos.Hide();
            panelmodificar.Show();
        }

        private void btneliminarproduc_Click(object sender, EventArgs e) // BTN PRINCIPAL ELIMINAR PRODUCTO 
        {
            Form2 f = new Form2();
            f.Show();
            f.Location = new Point(590, 300);
            tbxmodproduc.Clear();
            panelmodificar.Show();
            panelfproductos.Hide();
            paneladddepa.Hide();
            modielim = 1;
        }

        private void btnadddepa_Click(object sender, EventArgs e) //AGREGAR DEPARTAMENTO
        {
            tbxidepa.Text = "Auto Incremento";
            tbxnomdepa.Clear();
            tbxnomdepa.Focus();
            try
            {
                paneladddepa.Show();
                panelfproductos.Hide();
                panelmodificar.Hide();

                Bdcomun.ObtenerConexion();
                string Consulta = "select nombre,iddepartamento from departamento";
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(Consulta, Bdcomun.ObtenerConexion());
                ad.Fill(dt);
                dgvdepartamentos.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

      
        private void button1_Click_1(object sender, EventArgs e) //INSERTAR PRODUCTO EN BD
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

        private void btnmodproduct_Click(object sender, EventArgs e) //MODIFICAR PRODUCTO EN BD
        {
            button2.Hide();
            button1adp.Hide();
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

        private void button2_Click_1(object sender, EventArgs e) //ELIMINAR PRODUCTO EN BD
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

        private void btncreadepa_Click(object sender, EventArgs e) // CREAR DEPARTAMENTO EN BD
        {
            departamento dDepartamento = new departamento();
            dDepartamento.Nombre = tbxnomdepa.Text.ToString();

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

        private void button1_Click_2(object sender, EventArgs e) //MODIFICAR DEPARTAMENTO EN LA BD
        {

            departamento dDepartamento = new departamento();

            dDepartamento.Id = int.Parse(tbxidepa.Text);
            dDepartamento.Nombre = tbxnomdepa.Text.ToString();


            int resultado = Comandos.ActualizarDepartamento(dDepartamento);
            if (resultado > 0)
            {
                MessageBox.Show("¡Cliente guardado con exito!");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el cliente");
            }
        }

        private void btneliminardepa_Click(object sender, EventArgs e)//ELIMINAR DEPARTAMENTO EN LA BD
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format(
                " DELETE FROM `puntodeventa`.`departamento` WHERE `iddepartamento`= '" + tbxidepa.Text.ToString() + "';")
                , Bdcomun.ObtenerConexion());
                comando.ExecuteNonQuery();
                MessageBox.Show("!Departamento Eliminado correctamente¡");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e) //BUSCAR PRODUCTO EN BD PARA MODIFICAR Y O ELIMINAR
        {
            if (modielim == 0)
            {
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
                        tbxcode.Clear(); tbxnombre.Clear(); tbxdesc.Clear(); tbxprecost.Clear(); tbxpreventa.Clear();
                        tbxcanactual.Clear();
                        tbxcode.Enabled = true; tbxnombre.Enabled = true; tbxdesc.Enabled = true;
                        cbxdepart.Enabled = true; tbxprecost.Enabled = true; tbxpreventa.Enabled = true;
                        tbxcanactual.Enabled = true; btnmodproduct.Enabled = true;
                        tbxcode.Clear(); tbxnombre.Clear(); tbxdesc.Clear(); tbxprecost.Clear(); tbxpreventa.Clear();
                        tbxcanactual.Clear();

                        button1adp.Hide();
                        button2.Hide();
                        panelmodificar.Hide();
                        panelfproductos.Show();
                        btnmodproduct.Show();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else if (modielim == 1)
            {
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
                        cbxdepart.Enabled = false; tbxprecost.Enabled = false; tbxpreventa.Enabled = false;
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
                        paneladddepa.Hide();
                        button1adp.Hide();
                        btnmodproduct.Hide();
                        button2.Show();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void T_Tick(object sender, EventArgs e) //EVENTO TICK DEL TIMER PARA LA HORA
        {
            lbltime.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e) //COBRAR EFECTIVO
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

        private void button2_Click(object sender, EventArgs e) //BTN GUARDAR CLIENTES EN BD
        {
            cliente Pcliente = new cliente();

            Pcliente.Nombre = tbxname.Text;
            Pcliente.Apaterno = tbxamaterno.Text;
            Pcliente.Amaterno = tbxapaterno.Text;
            Pcliente.Dirección = tbxdir.Text;
            Pcliente.Telefono = tbxtel.Text;


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

        private void btnaddcliente_Click(object sender, EventArgs e) //BTN PRINCIPAL AGREGAR CLIENTE
        {
            paneladcliente.Show();
            btnguardacambios.Hide();
            btnagregacli.Show();
        }

        private void btnmodcliente_Click(object sender, EventArgs e) //BTN PRINCIPAL MODIFICAR CLIENTE
        {
            paneladcliente.Show();
            btnagregacli.Hide();
            btnguardacambios.Show();
        }

        private void btnguardacambios_Click(object sender, EventArgs e) //BTN UPDATE BD MODIFICAR CLIENTE
        {
            cliente Pcliente = new cliente();
            

            Pcliente.Nombre = tbxname.Text;
            Pcliente.Apaterno = tbxamaterno.Text;
            Pcliente.Amaterno = tbxapaterno.Text;
            Pcliente.Dirección = tbxdir.Text;
            Pcliente.Telefono = tbxtel.Text;


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


        string code, desc, preve; double stotal = 0;
        private void btnbuscar_Click(object sender, EventArgs e) //BUSCAR PRODUCTOS EN BD PARA COBRARLOS
        {        
            try
            {
                Bdcomun.ObtenerConexion();

                string Consulta = "select idproducto ,descripcion, precioventa from productos where idproducto='"+textBox8.Text.ToString()+"'";
                MySqlCommand mycomand = new MySqlCommand();
                mycomand.Connection = Bdcomun.ObtenerConexion();
                mycomand.CommandText = Consulta;
                MySqlDataReader reader = mycomand.ExecuteReader();

                while (reader.Read())
                {
                    code = reader["idproducto"].ToString();
                    desc = reader["descripcion"].ToString();
                    preve = reader["precioventa"].ToString();
                    dataGridView2.Rows.Add(code, desc,"1",preve);
                    stotal += double.Parse(preve);
                    lblcostotot.Text = stotal.ToString();
                }
                reader.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
            textBox8.Clear();
            
        }

        private void button4_Click(object sender, EventArgs e) //Actualizar DGV con la lista de Departamentos
        {
            Bdcomun.ObtenerConexion();
            string Consulta = "select nombre,iddepartamento from departamento";
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(Consulta, Bdcomun.ObtenerConexion());
            ad.Fill(dt);
            dgvdepartamentos.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bnteliminarclientedb_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format(
                " DELETE FROM `puntodeventa`.`cliente` WHERE `idproducto`= '" + tbxcode.Text.ToString() + "';")
                , Bdcomun.ObtenerConexion());
                comando.ExecuteNonQuery();
                MessageBox.Show("!Producto Eliminado correctamente¡");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());

            }
        }

        private void dgvclientes_MouseClick(object sender, MouseEventArgs e) //DGV CLIENTE SELECCIONAR CELDA 
        {
            tbxname.Text = dgvclientes.CurrentRow.Cells[0].Value.ToString();
            tbxapaterno.Text = dgvclientes.CurrentRow.Cells[1].Value.ToString();
            tbxamaterno.Text = dgvclientes.CurrentRow.Cells[2].Value.ToString();
            tbxdir.Text = dgvclientes.CurrentRow.Cells[3].Value.ToString();
            tbxtel.Text = dgvclientes.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvdepartamentos_MouseClick(object sender, MouseEventArgs e) //DGV PRODUCTOS SELECCIONAR CELDA
        {
            tbxidepa.Text = dgvdepartamentos.CurrentRow.Cells[1].Value.ToString();
            tbxnomdepa.Text = dgvdepartamentos.CurrentRow.Cells[0].Value.ToString();
        }

    }
}
