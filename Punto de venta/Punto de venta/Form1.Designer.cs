namespace Punto_de_venta
{
    partial class form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.tabprincipal = new System.Windows.Forms.TabControl();
            this.tabventas = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.ticket1 = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.ticket2 = new System.Windows.Forms.TabPage();
            this.tabproductos = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnaddproducto = new System.Windows.Forms.Button();
            this.panelfproductos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxcode = new System.Windows.Forms.TextBox();
            this.tbxcanactual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxcanreg = new System.Windows.Forms.TextBox();
            this.tbxnombre = new System.Windows.Forms.TextBox();
            this.lblcantactual = new System.Windows.Forms.Label();
            this.tbxpreventa = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblcantregistro = new System.Windows.Forms.Label();
            this.tbxprecost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpreventa = new System.Windows.Forms.Label();
            this.cbxdepart = new System.Windows.Forms.ComboBox();
            this.tbxdesc = new System.Windows.Forms.TextBox();
            this.lblprecosto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabiventario = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabcortecaja = new System.Windows.Forms.TabPage();
            this.tabcliente = new System.Windows.Forms.TabPage();
            this.tbxid = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbltel = new System.Windows.Forms.Label();
            this.lbldir = new System.Windows.Forms.Label();
            this.lblamaterno = new System.Windows.Forms.Label();
            this.lblapaterno = new System.Windows.Forms.Label();
            this.tbxtel = new System.Windows.Forms.TextBox();
            this.tbxdir = new System.Windows.Forms.TextBox();
            this.tbxamaterno = new System.Windows.Forms.TextBox();
            this.tbxapaterno = new System.Windows.Forms.TextBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnmodificarproduc = new System.Windows.Forms.Button();
            this.panelmodificar = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxmodproduc = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tabprincipal.SuspendLayout();
            this.tabventas.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.ticket1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabproductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelfproductos.SuspendLayout();
            this.tabiventario.SuspendLayout();
            this.tabcliente.SuspendLayout();
            this.panelmodificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabprincipal
            // 
            this.tabprincipal.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabprincipal.Controls.Add(this.tabventas);
            this.tabprincipal.Controls.Add(this.tabproductos);
            this.tabprincipal.Controls.Add(this.tabiventario);
            this.tabprincipal.Controls.Add(this.tabcortecaja);
            this.tabprincipal.Controls.Add(this.tabcliente);
            this.tabprincipal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabprincipal.HotTrack = true;
            this.tabprincipal.ImageList = this.imageList1;
            this.tabprincipal.ItemSize = new System.Drawing.Size(51, 56);
            this.tabprincipal.Location = new System.Drawing.Point(0, 0);
            this.tabprincipal.Multiline = true;
            this.tabprincipal.Name = "tabprincipal";
            this.tabprincipal.SelectedIndex = 0;
            this.tabprincipal.Size = new System.Drawing.Size(1367, 719);
            this.tabprincipal.TabIndex = 0;
            // 
            // tabventas
            // 
            this.tabventas.BackColor = System.Drawing.Color.Transparent;
            this.tabventas.Controls.Add(this.tabControl2);
            this.tabventas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabventas.ForeColor = System.Drawing.Color.Black;
            this.tabventas.ImageIndex = 0;
            this.tabventas.Location = new System.Drawing.Point(4, 60);
            this.tabventas.Name = "tabventas";
            this.tabventas.Padding = new System.Windows.Forms.Padding(3);
            this.tabventas.Size = new System.Drawing.Size(1359, 655);
            this.tabventas.TabIndex = 0;
            this.tabventas.Text = "Ventas";
            this.tabventas.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.ticket1);
            this.tabControl2.Controls.Add(this.ticket2);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1359, 651);
            this.tabControl2.TabIndex = 20;
            this.tabControl2.TabStop = false;
            this.tabControl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl2_KeyPress);
            // 
            // ticket1
            // 
            this.ticket1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ticket1.Controls.Add(this.radioButton2);
            this.ticket1.Controls.Add(this.radioButton1);
            this.ticket1.Controls.Add(this.button4);
            this.ticket1.Controls.Add(this.button3);
            this.ticket1.Controls.Add(this.textBox5);
            this.ticket1.Controls.Add(this.label4);
            this.ticket1.Controls.Add(this.textBox8);
            this.ticket1.Controls.Add(this.label5);
            this.ticket1.Controls.Add(this.textBox6);
            this.ticket1.Controls.Add(this.dataGridView2);
            this.ticket1.Controls.Add(this.label6);
            this.ticket1.Controls.Add(this.textBox7);
            this.ticket1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket1.ForeColor = System.Drawing.Color.Black;
            this.ticket1.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.ticket1.Location = new System.Drawing.Point(4, 29);
            this.ticket1.Name = "ticket1";
            this.ticket1.Padding = new System.Windows.Forms.Padding(3);
            this.ticket1.Size = new System.Drawing.Size(1351, 618);
            this.ticket1.TabIndex = 0;
            this.ticket1.Text = "Ticket 1";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton2.Location = new System.Drawing.Point(1131, 291);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(161, 24);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "AGREGAR A CUENTA";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1015, 273);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 24);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "EFECTIVO";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CadetBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button4.FlatAppearance.BorderSize = 7;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(600, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 39);
            this.button4.TabIndex = 11;
            this.button4.Text = "BUSCAR";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1171, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 48);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cobrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1044, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(133, 26);
            this.textBox5.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(915, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cambio";
            // 
            // textBox8
            // 
            this.textBox8.AccessibleDescription = "Ingrese código o palabra a consultar";
            this.textBox8.AccessibleName = "Ingrese código o palabra a consultar";
            this.textBox8.Location = new System.Drawing.Point(25, 30);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(560, 26);
            this.textBox8.TabIndex = 12;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(918, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Recibo";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1060, 173);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(133, 26);
            this.textBox6.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.cantidad,
            this.precio});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.Location = new System.Drawing.Point(25, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(837, 519);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 260;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 240;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 170;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 165;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(930, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Costo Total";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1028, 117);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(133, 26);
            this.textBox7.TabIndex = 14;
            // 
            // ticket2
            // 
            this.ticket2.Location = new System.Drawing.Point(4, 29);
            this.ticket2.Name = "ticket2";
            this.ticket2.Padding = new System.Windows.Forms.Padding(3);
            this.ticket2.Size = new System.Drawing.Size(1351, 618);
            this.ticket2.TabIndex = 1;
            this.ticket2.Text = "Ticket 2";
            this.ticket2.UseVisualStyleBackColor = true;
            // 
            // tabproductos
            // 
            this.tabproductos.BackColor = System.Drawing.Color.Khaki;
            this.tabproductos.Controls.Add(this.panelmodificar);
            this.tabproductos.Controls.Add(this.btnmodificarproduc);
            this.tabproductos.Controls.Add(this.pictureBox1);
            this.tabproductos.Controls.Add(this.btnaddproducto);
            this.tabproductos.Controls.Add(this.panelfproductos);
            this.tabproductos.Controls.Add(this.label10);
            this.tabproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabproductos.ForeColor = System.Drawing.Color.Black;
            this.tabproductos.ImageIndex = 1;
            this.tabproductos.Location = new System.Drawing.Point(4, 60);
            this.tabproductos.Name = "tabproductos";
            this.tabproductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabproductos.Size = new System.Drawing.Size(1359, 655);
            this.tabproductos.TabIndex = 1;
            this.tabproductos.Text = "Productos";
            this.tabproductos.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Punto_de_venta.Properties.Resources.seccionproduc3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(426, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnaddproducto
            // 
            this.btnaddproducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnaddproducto.BackColor = System.Drawing.Color.Transparent;
            this.btnaddproducto.BackgroundImage = global::Punto_de_venta.Properties.Resources.addp21;
            this.btnaddproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddproducto.FlatAppearance.BorderSize = 0;
            this.btnaddproducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnaddproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnaddproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddproducto.ForeColor = System.Drawing.Color.Transparent;
            this.btnaddproducto.Location = new System.Drawing.Point(31, 112);
            this.btnaddproducto.Name = "btnaddproducto";
            this.btnaddproducto.Size = new System.Drawing.Size(218, 52);
            this.btnaddproducto.TabIndex = 19;
            this.btnaddproducto.UseVisualStyleBackColor = false;
            this.btnaddproducto.Click += new System.EventHandler(this.btnaddproducto_Click);
            this.btnaddproducto.MouseHover += new System.EventHandler(this.btnaddproducto_MouseHover);
            // 
            // panelfproductos
            // 
            this.panelfproductos.Controls.Add(this.label1);
            this.panelfproductos.Controls.Add(this.button1);
            this.panelfproductos.Controls.Add(this.tbxcode);
            this.panelfproductos.Controls.Add(this.tbxcanactual);
            this.panelfproductos.Controls.Add(this.label3);
            this.panelfproductos.Controls.Add(this.tbxcanreg);
            this.panelfproductos.Controls.Add(this.tbxnombre);
            this.panelfproductos.Controls.Add(this.lblcantactual);
            this.panelfproductos.Controls.Add(this.tbxpreventa);
            this.panelfproductos.Controls.Add(this.lbldesc);
            this.panelfproductos.Controls.Add(this.lblcantregistro);
            this.panelfproductos.Controls.Add(this.tbxprecost);
            this.panelfproductos.Controls.Add(this.label2);
            this.panelfproductos.Controls.Add(this.lblpreventa);
            this.panelfproductos.Controls.Add(this.cbxdepart);
            this.panelfproductos.Controls.Add(this.tbxdesc);
            this.panelfproductos.Controls.Add(this.lblprecosto);
            this.panelfproductos.ForeColor = System.Drawing.Color.Black;
            this.panelfproductos.Location = new System.Drawing.Point(19, 183);
            this.panelfproductos.Name = "panelfproductos";
            this.panelfproductos.Size = new System.Drawing.Size(548, 440);
            this.panelfproductos.TabIndex = 18;
            this.panelfproductos.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "Guardar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbxcode
            // 
            this.tbxcode.Location = new System.Drawing.Point(191, 26);
            this.tbxcode.Name = "tbxcode";
            this.tbxcode.Size = new System.Drawing.Size(218, 22);
            this.tbxcode.TabIndex = 9;
            // 
            // tbxcanactual
            // 
            this.tbxcanactual.Location = new System.Drawing.Point(191, 340);
            this.tbxcanactual.Name = "tbxcanactual";
            this.tbxcanactual.Size = new System.Drawing.Size(209, 22);
            this.tbxcanactual.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // tbxcanreg
            // 
            this.tbxcanreg.Location = new System.Drawing.Point(191, 303);
            this.tbxcanreg.Name = "tbxcanreg";
            this.tbxcanreg.Size = new System.Drawing.Size(209, 22);
            this.tbxcanreg.TabIndex = 15;
            // 
            // tbxnombre
            // 
            this.tbxnombre.Location = new System.Drawing.Point(191, 63);
            this.tbxnombre.Name = "tbxnombre";
            this.tbxnombre.Size = new System.Drawing.Size(218, 22);
            this.tbxnombre.TabIndex = 10;
            // 
            // lblcantactual
            // 
            this.lblcantactual.AutoSize = true;
            this.lblcantactual.Location = new System.Drawing.Point(24, 343);
            this.lblcantactual.Name = "lblcantactual";
            this.lblcantactual.Size = new System.Drawing.Size(102, 16);
            this.lblcantactual.TabIndex = 8;
            this.lblcantactual.Text = "Cantidad Actual";
            // 
            // tbxpreventa
            // 
            this.tbxpreventa.Location = new System.Drawing.Point(191, 266);
            this.tbxpreventa.Name = "tbxpreventa";
            this.tbxpreventa.Size = new System.Drawing.Size(209, 22);
            this.tbxpreventa.TabIndex = 14;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(21, 126);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(80, 16);
            this.lbldesc.TabIndex = 3;
            this.lbldesc.Text = "Descripción";
            // 
            // lblcantregistro
            // 
            this.lblcantregistro.AutoSize = true;
            this.lblcantregistro.Location = new System.Drawing.Point(24, 306);
            this.lblcantregistro.Name = "lblcantregistro";
            this.lblcantregistro.Size = new System.Drawing.Size(125, 16);
            this.lblcantregistro.TabIndex = 7;
            this.lblcantregistro.Text = "Cantidad a registrar";
            this.lblcantregistro.Click += new System.EventHandler(this.lblcantregistro_Click);
            // 
            // tbxprecost
            // 
            this.tbxprecost.Location = new System.Drawing.Point(191, 229);
            this.tbxprecost.Name = "tbxprecost";
            this.tbxprecost.Size = new System.Drawing.Size(218, 22);
            this.tbxprecost.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departamento";
            // 
            // lblpreventa
            // 
            this.lblpreventa.AutoSize = true;
            this.lblpreventa.Location = new System.Drawing.Point(24, 269);
            this.lblpreventa.Name = "lblpreventa";
            this.lblpreventa.Size = new System.Drawing.Size(85, 16);
            this.lblpreventa.TabIndex = 6;
            this.lblpreventa.Text = "Precio Venta";
            // 
            // cbxdepart
            // 
            this.cbxdepart.FormattingEnabled = true;
            this.cbxdepart.Location = new System.Drawing.Point(191, 192);
            this.cbxdepart.Name = "cbxdepart";
            this.cbxdepart.Size = new System.Drawing.Size(218, 24);
            this.cbxdepart.TabIndex = 12;
            this.cbxdepart.SelectedIndexChanged += new System.EventHandler(this.cbxdepart_SelectedIndexChanged);
            // 
            // tbxdesc
            // 
            this.tbxdesc.Location = new System.Drawing.Point(191, 100);
            this.tbxdesc.Multiline = true;
            this.tbxdesc.Name = "tbxdesc";
            this.tbxdesc.Size = new System.Drawing.Size(352, 73);
            this.tbxdesc.TabIndex = 11;
            // 
            // lblprecosto
            // 
            this.lblprecosto.AutoSize = true;
            this.lblprecosto.Location = new System.Drawing.Point(24, 232);
            this.lblprecosto.Name = "lblprecosto";
            this.lblprecosto.Size = new System.Drawing.Size(85, 16);
            this.lblprecosto.TabIndex = 5;
            this.lblprecosto.Text = "Precio Costo";
            this.lblprecosto.Click += new System.EventHandler(this.lblprecosto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "NO OLVIDAR LA ALERTA DE MINIMOS";
            // 
            // tabiventario
            // 
            this.tabiventario.Controls.Add(this.label15);
            this.tabiventario.Controls.Add(this.textBox13);
            this.tabiventario.Controls.Add(this.label14);
            this.tabiventario.Controls.Add(this.textBox12);
            this.tabiventario.Controls.Add(this.label13);
            this.tabiventario.Controls.Add(this.textBox11);
            this.tabiventario.Controls.Add(this.label12);
            this.tabiventario.ForeColor = System.Drawing.Color.Black;
            this.tabiventario.ImageIndex = 2;
            this.tabiventario.Location = new System.Drawing.Point(4, 60);
            this.tabiventario.Name = "tabiventario";
            this.tabiventario.Size = new System.Drawing.Size(1359, 655);
            this.tabiventario.TabIndex = 2;
            this.tabiventario.Text = "Inventario";
            this.tabiventario.UseVisualStyleBackColor = true;
            this.tabiventario.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(526, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Inventario";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(206, 145);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(215, 27);
            this.textBox13.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(98, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Nombre";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(206, 100);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(215, 20);
            this.textBox12.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(98, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Descripción";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(206, 61);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(215, 27);
            this.textBox11.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(98, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Código";
            // 
            // tabcortecaja
            // 
            this.tabcortecaja.ImageIndex = 3;
            this.tabcortecaja.Location = new System.Drawing.Point(4, 60);
            this.tabcortecaja.Name = "tabcortecaja";
            this.tabcortecaja.Size = new System.Drawing.Size(1359, 655);
            this.tabcortecaja.TabIndex = 3;
            this.tabcortecaja.Text = "Corte de caja";
            this.tabcortecaja.UseVisualStyleBackColor = true;
            // 
            // tabcliente
            // 
            this.tabcliente.Controls.Add(this.tbxid);
            this.tabcliente.Controls.Add(this.lblcliente);
            this.tabcliente.Controls.Add(this.button2);
            this.tabcliente.Controls.Add(this.lbltel);
            this.tabcliente.Controls.Add(this.lbldir);
            this.tabcliente.Controls.Add(this.lblamaterno);
            this.tabcliente.Controls.Add(this.lblapaterno);
            this.tabcliente.Controls.Add(this.tbxtel);
            this.tabcliente.Controls.Add(this.tbxdir);
            this.tabcliente.Controls.Add(this.tbxamaterno);
            this.tabcliente.Controls.Add(this.tbxapaterno);
            this.tabcliente.Controls.Add(this.tbxname);
            this.tabcliente.Controls.Add(this.lblname);
            this.tabcliente.ForeColor = System.Drawing.Color.Black;
            this.tabcliente.ImageIndex = 4;
            this.tabcliente.Location = new System.Drawing.Point(4, 60);
            this.tabcliente.Name = "tabcliente";
            this.tabcliente.Size = new System.Drawing.Size(1359, 655);
            this.tabcliente.TabIndex = 4;
            this.tabcliente.Text = "Clientes";
            this.tabcliente.UseVisualStyleBackColor = true;
            // 
            // tbxid
            // 
            this.tbxid.Location = new System.Drawing.Point(216, 32);
            this.tbxid.Name = "tbxid";
            this.tbxid.Size = new System.Drawing.Size(185, 27);
            this.tbxid.TabIndex = 12;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(53, 35);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(80, 19);
            this.lblcliente.TabIndex = 11;
            this.lblcliente.Text = "Id cliente";
            this.lblcliente.Click += new System.EventHandler(this.label16_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 64);
            this.button2.TabIndex = 10;
            this.button2.Text = "Agregar Clientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(56, 255);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(74, 19);
            this.lbltel.TabIndex = 9;
            this.lbltel.Text = "Teléfono";
            // 
            // lbldir
            // 
            this.lbldir.AutoSize = true;
            this.lbldir.Location = new System.Drawing.Point(53, 212);
            this.lbldir.Name = "lbldir";
            this.lbldir.Size = new System.Drawing.Size(83, 19);
            this.lbldir.TabIndex = 8;
            this.lbldir.Text = "Dirección";
            // 
            // lblamaterno
            // 
            this.lblamaterno.AutoSize = true;
            this.lblamaterno.Location = new System.Drawing.Point(53, 166);
            this.lblamaterno.Name = "lblamaterno";
            this.lblamaterno.Size = new System.Drawing.Size(143, 19);
            this.lblamaterno.TabIndex = 7;
            this.lblamaterno.Text = "Apellido Materno";
            // 
            // lblapaterno
            // 
            this.lblapaterno.AutoSize = true;
            this.lblapaterno.Location = new System.Drawing.Point(53, 119);
            this.lblapaterno.Name = "lblapaterno";
            this.lblapaterno.Size = new System.Drawing.Size(138, 19);
            this.lblapaterno.TabIndex = 6;
            this.lblapaterno.Text = "Apellido Paterno";
            // 
            // tbxtel
            // 
            this.tbxtel.Location = new System.Drawing.Point(216, 252);
            this.tbxtel.Name = "tbxtel";
            this.tbxtel.Size = new System.Drawing.Size(185, 27);
            this.tbxtel.TabIndex = 5;
            // 
            // tbxdir
            // 
            this.tbxdir.Location = new System.Drawing.Point(216, 209);
            this.tbxdir.Name = "tbxdir";
            this.tbxdir.Size = new System.Drawing.Size(185, 27);
            this.tbxdir.TabIndex = 4;
            // 
            // tbxamaterno
            // 
            this.tbxamaterno.Location = new System.Drawing.Point(216, 163);
            this.tbxamaterno.Name = "tbxamaterno";
            this.tbxamaterno.Size = new System.Drawing.Size(185, 27);
            this.tbxamaterno.TabIndex = 3;
            // 
            // tbxapaterno
            // 
            this.tbxapaterno.Location = new System.Drawing.Point(216, 116);
            this.tbxapaterno.Name = "tbxapaterno";
            this.tbxapaterno.Size = new System.Drawing.Size(185, 27);
            this.tbxapaterno.TabIndex = 2;
            this.tbxapaterno.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(216, 70);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(185, 27);
            this.tbxname.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(53, 73);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(73, 19);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Nombre";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ventas.png");
            this.imageList1.Images.SetKeyName(1, "productos.png");
            this.imageList1.Images.SetKeyName(2, "inventario.png");
            this.imageList1.Images.SetKeyName(3, "ccaja.png");
            this.imageList1.Images.SetKeyName(4, "cliente.png");
            // 
            // btnmodificarproduc
            // 
            this.btnmodificarproduc.Location = new System.Drawing.Point(295, 112);
            this.btnmodificarproduc.Name = "btnmodificarproduc";
            this.btnmodificarproduc.Size = new System.Drawing.Size(178, 52);
            this.btnmodificarproduc.TabIndex = 21;
            this.btnmodificarproduc.Text = "Modificar Producto";
            this.btnmodificarproduc.UseVisualStyleBackColor = true;
            this.btnmodificarproduc.Click += new System.EventHandler(this.btnmodificarproduc_Click);
            // 
            // panelmodificar
            // 
            this.panelmodificar.Controls.Add(this.button5);
            this.panelmodificar.Controls.Add(this.tbxmodproduc);
            this.panelmodificar.Controls.Add(this.label7);
            this.panelmodificar.Location = new System.Drawing.Point(594, 183);
            this.panelmodificar.Name = "panelmodificar";
            this.panelmodificar.Size = new System.Drawing.Size(508, 305);
            this.panelmodificar.TabIndex = 22;
            this.panelmodificar.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código del producto";
            // 
            // tbxmodproduc
            // 
            this.tbxmodproduc.Location = new System.Drawing.Point(182, 97);
            this.tbxmodproduc.Name = "tbxmodproduc";
            this.tbxmodproduc.Size = new System.Drawing.Size(162, 22);
            this.tbxmodproduc.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(220, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Modificar Producto";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1358, 731);
            this.Controls.Add(this.tabprincipal);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.TransparencyKey = System.Drawing.Color.Goldenrod;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form1_KeyPress);
            this.tabprincipal.ResumeLayout(false);
            this.tabventas.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ticket1.ResumeLayout(false);
            this.ticket1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabproductos.ResumeLayout(false);
            this.tabproductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelfproductos.ResumeLayout(false);
            this.panelfproductos.PerformLayout();
            this.tabiventario.ResumeLayout(false);
            this.tabiventario.PerformLayout();
            this.tabcliente.ResumeLayout(false);
            this.tabcliente.PerformLayout();
            this.panelmodificar.ResumeLayout(false);
            this.panelmodificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabprincipal;
        private System.Windows.Forms.TabPage tabventas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabproductos;
        private System.Windows.Forms.TabPage tabiventario;
        private System.Windows.Forms.TabPage tabcortecaja;
        private System.Windows.Forms.TabPage tabcliente;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage ticket1;
        private System.Windows.Forms.TabPage ticket2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblcantregistro;
        private System.Windows.Forms.Label lblcantactual;
        private System.Windows.Forms.Label lblpreventa;
        private System.Windows.Forms.Label lblprecosto;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxtel;
        private System.Windows.Forms.TextBox tbxdir;
        private System.Windows.Forms.TextBox tbxamaterno;
        private System.Windows.Forms.TextBox tbxapaterno;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lbldir;
        private System.Windows.Forms.Label lblamaterno;
        private System.Windows.Forms.Label lblapaterno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TextBox tbxid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxcanreg;
        private System.Windows.Forms.TextBox tbxpreventa;
        private System.Windows.Forms.TextBox tbxprecost;
        private System.Windows.Forms.TextBox tbxdesc;
        private System.Windows.Forms.ComboBox cbxdepart;
        private System.Windows.Forms.TextBox tbxnombre;
        private System.Windows.Forms.TextBox tbxcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxcanactual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelfproductos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Button btnaddproducto;
        protected internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelmodificar;
        private System.Windows.Forms.TextBox tbxmodproduc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnmodificarproduc;
        private System.Windows.Forms.Button button5;
    }
}

