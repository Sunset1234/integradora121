namespace Punto_de_venta
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
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
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tbxcantregistro = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tbxcantactual = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblcantregistro = new System.Windows.Forms.Label();
            this.lblcantactual = new System.Windows.Forms.Label();
            this.lblpreventa = new System.Windows.Forms.Label();
            this.lblprecosto = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.tbxpreventa = new System.Windows.Forms.TextBox();
            this.tbxprecosto = new System.Windows.Forms.TextBox();
            this.tbxdesc = new System.Windows.Forms.TextBox();
            this.tbxcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbxid = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbltel = new System.Windows.Forms.Label();
            this.lbldir = new System.Windows.Forms.Label();
            this.lblamaterno = new System.Windows.Forms.Label();
            this.lblapaterno = new System.Windows.Forms.Label();
            this.tbxtel = new System.Windows.Forms.TextBox();
            this.tbxdir = new System.Windows.Forms.TextBox();
            this.tbxapaterno = new System.Windows.Forms.TextBox();
            this.tbxamaterno = new System.Windows.Forms.TextBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tbxcantregistro.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbxcantregistro);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1094, 526);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(140)))));
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1086, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(979, 483);
            this.tabControl2.TabIndex = 20;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(140)))));
            this.tabPage6.Controls.Add(this.radioButton2);
            this.tabPage6.Controls.Add(this.radioButton1);
            this.tabPage6.Controls.Add(this.button4);
            this.tabPage6.Controls.Add(this.button3);
            this.tabPage6.Controls.Add(this.textBox5);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.textBox8);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.textBox6);
            this.tabPage6.Controls.Add(this.dataGridView2);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.textBox7);
            this.tabPage6.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(971, 457);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Ticket 1";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(775, 259);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "AGREGAR A CUENTA";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(680, 259);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
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
            this.button3.Location = new System.Drawing.Point(760, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 48);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cobrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(760, 192);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(133, 20);
            this.textBox5.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cambio";
            // 
            // textBox8
            // 
            this.textBox8.AccessibleDescription = "Ingrese código o palabra a consultar";
            this.textBox8.AccessibleName = "Ingrese código o palabra a consultar";
            this.textBox8.Location = new System.Drawing.Point(25, 30);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(560, 20);
            this.textBox8.TabIndex = 12;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(684, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Recibo";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(760, 151);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(133, 20);
            this.textBox6.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.cantidad,
            this.precio});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(25, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(644, 346);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 200;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 120;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.Width = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Costo Total";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(760, 114);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(133, 20);
            this.textBox7.TabIndex = 14;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(971, 457);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Ticket 2";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tbxcantregistro
            // 
            this.tbxcantregistro.BackColor = System.Drawing.Color.PeachPuff;
            this.tbxcantregistro.Controls.Add(this.button1);
            this.tbxcantregistro.Controls.Add(this.textBox10);
            this.tbxcantregistro.Controls.Add(this.tbxcantactual);
            this.tbxcantregistro.Controls.Add(this.label11);
            this.tbxcantregistro.Controls.Add(this.label10);
            this.tbxcantregistro.Controls.Add(this.lblcantregistro);
            this.tbxcantregistro.Controls.Add(this.lblcantactual);
            this.tbxcantregistro.Controls.Add(this.lblpreventa);
            this.tbxcantregistro.Controls.Add(this.lblprecosto);
            this.tbxcantregistro.Controls.Add(this.lbldesc);
            this.tbxcantregistro.Controls.Add(this.tbxpreventa);
            this.tbxcantregistro.Controls.Add(this.tbxprecosto);
            this.tbxcantregistro.Controls.Add(this.tbxdesc);
            this.tbxcantregistro.Controls.Add(this.tbxcode);
            this.tbxcantregistro.Controls.Add(this.label1);
            this.tbxcantregistro.Location = new System.Drawing.Point(4, 25);
            this.tbxcantregistro.Name = "tbxcantregistro";
            this.tbxcantregistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbxcantregistro.Size = new System.Drawing.Size(1086, 497);
            this.tbxcantregistro.TabIndex = 1;
            this.tbxcantregistro.Text = "Productos";
            this.tbxcantregistro.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Punto_de_venta.Properties.Resources.flecha;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(123, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agregar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(158, 372);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(181, 20);
            this.textBox10.TabIndex = 14;
            // 
            // tbxcantactual
            // 
            this.tbxcantactual.Enabled = false;
            this.tbxcantactual.Location = new System.Drawing.Point(158, 309);
            this.tbxcantactual.Name = "tbxcantactual";
            this.tbxcantactual.Size = new System.Drawing.Size(181, 20);
            this.tbxcantactual.TabIndex = 13;
            this.tbxcantactual.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(340, 44);
            this.label11.TabIndex = 12;
            this.label11.Text = "Agregar Producto";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(558, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "NO OLVIDAR LA ALERTA DE MINIMOS";
            // 
            // lblcantregistro
            // 
            this.lblcantregistro.AutoSize = true;
            this.lblcantregistro.Location = new System.Drawing.Point(45, 375);
            this.lblcantregistro.Name = "lblcantregistro";
            this.lblcantregistro.Size = new System.Drawing.Size(98, 13);
            this.lblcantregistro.TabIndex = 10;
            this.lblcantregistro.Text = "Cantidad a registrar";
            // 
            // lblcantactual
            // 
            this.lblcantactual.AutoSize = true;
            this.lblcantactual.Location = new System.Drawing.Point(45, 316);
            this.lblcantactual.Name = "lblcantactual";
            this.lblcantactual.Size = new System.Drawing.Size(82, 13);
            this.lblcantactual.TabIndex = 9;
            this.lblcantactual.Text = "Cantidad Actual";
            // 
            // lblpreventa
            // 
            this.lblpreventa.AutoSize = true;
            this.lblpreventa.Location = new System.Drawing.Point(45, 264);
            this.lblpreventa.Name = "lblpreventa";
            this.lblpreventa.Size = new System.Drawing.Size(68, 13);
            this.lblpreventa.TabIndex = 8;
            this.lblpreventa.Text = "Precio Venta";
            // 
            // lblprecosto
            // 
            this.lblprecosto.AutoSize = true;
            this.lblprecosto.Location = new System.Drawing.Point(45, 215);
            this.lblprecosto.Name = "lblprecosto";
            this.lblprecosto.Size = new System.Drawing.Size(67, 13);
            this.lblprecosto.TabIndex = 7;
            this.lblprecosto.Text = "Precio Costo";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(49, 151);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(63, 13);
            this.lbldesc.TabIndex = 6;
            this.lbldesc.Text = "Descripción";
            // 
            // tbxpreventa
            // 
            this.tbxpreventa.Location = new System.Drawing.Point(158, 257);
            this.tbxpreventa.Name = "tbxpreventa";
            this.tbxpreventa.Size = new System.Drawing.Size(181, 20);
            this.tbxpreventa.TabIndex = 5;
            // 
            // tbxprecosto
            // 
            this.tbxprecosto.Location = new System.Drawing.Point(158, 208);
            this.tbxprecosto.Name = "tbxprecosto";
            this.tbxprecosto.Size = new System.Drawing.Size(181, 20);
            this.tbxprecosto.TabIndex = 4;
            // 
            // tbxdesc
            // 
            this.tbxdesc.Location = new System.Drawing.Point(158, 151);
            this.tbxdesc.Name = "tbxdesc";
            this.tbxdesc.Size = new System.Drawing.Size(181, 20);
            this.tbxdesc.TabIndex = 3;
            // 
            // tbxcode
            // 
            this.tbxcode.Location = new System.Drawing.Point(158, 90);
            this.tbxcode.Name = "tbxcode";
            this.tbxcode.Size = new System.Drawing.Size(181, 20);
            this.tbxcode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.textBox13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.textBox12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.textBox11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1086, 497);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inventario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(526, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Inventario";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(206, 145);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(215, 20);
            this.textBox13.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(98, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
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
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Descripción";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(206, 61);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(215, 20);
            this.textBox11.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(98, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Código";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1086, 497);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Corte de caja";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbxid);
            this.tabPage5.Controls.Add(this.lblcliente);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.lbltel);
            this.tabPage5.Controls.Add(this.lbldir);
            this.tabPage5.Controls.Add(this.lblamaterno);
            this.tabPage5.Controls.Add(this.lblapaterno);
            this.tabPage5.Controls.Add(this.tbxtel);
            this.tabPage5.Controls.Add(this.tbxdir);
            this.tabPage5.Controls.Add(this.tbxapaterno);
            this.tabPage5.Controls.Add(this.tbxamaterno);
            this.tabPage5.Controls.Add(this.tbxname);
            this.tabPage5.Controls.Add(this.lblname);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1086, 497);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Clientes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbxid
            // 
            this.tbxid.Location = new System.Drawing.Point(166, 32);
            this.tbxid.Name = "tbxid";
            this.tbxid.Size = new System.Drawing.Size(185, 20);
            this.tbxid.TabIndex = 12;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(53, 35);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(50, 13);
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
            this.lbltel.Size = new System.Drawing.Size(49, 13);
            this.lbltel.TabIndex = 9;
            this.lbltel.Text = "Teléfono";
            // 
            // lbldir
            // 
            this.lbldir.AutoSize = true;
            this.lbldir.Location = new System.Drawing.Point(53, 212);
            this.lbldir.Name = "lbldir";
            this.lbldir.Size = new System.Drawing.Size(52, 13);
            this.lbldir.TabIndex = 8;
            this.lbldir.Text = "Dirección";
            // 
            // lblamaterno
            // 
            this.lblamaterno.AutoSize = true;
            this.lblamaterno.Location = new System.Drawing.Point(53, 166);
            this.lblamaterno.Name = "lblamaterno";
            this.lblamaterno.Size = new System.Drawing.Size(86, 13);
            this.lblamaterno.TabIndex = 7;
            this.lblamaterno.Text = "Apellido Materno";
            // 
            // lblapaterno
            // 
            this.lblapaterno.AutoSize = true;
            this.lblapaterno.Location = new System.Drawing.Point(53, 119);
            this.lblapaterno.Name = "lblapaterno";
            this.lblapaterno.Size = new System.Drawing.Size(84, 13);
            this.lblapaterno.TabIndex = 6;
            this.lblapaterno.Text = "Apellido Paterno";
            // 
            // tbxtel
            // 
            this.tbxtel.Location = new System.Drawing.Point(166, 255);
            this.tbxtel.Name = "tbxtel";
            this.tbxtel.Size = new System.Drawing.Size(185, 20);
            this.tbxtel.TabIndex = 5;
            // 
            // tbxdir
            // 
            this.tbxdir.Location = new System.Drawing.Point(166, 209);
            this.tbxdir.Name = "tbxdir";
            this.tbxdir.Size = new System.Drawing.Size(185, 20);
            this.tbxdir.TabIndex = 4;
            // 
            // tbxapaterno
            // 
            this.tbxapaterno.Location = new System.Drawing.Point(166, 116);
            this.tbxapaterno.Name = "tbxapaterno";
            this.tbxapaterno.Size = new System.Drawing.Size(185, 20);
            this.tbxapaterno.TabIndex = 3;
            // 
            // tbxamaterno
            // 
            this.tbxamaterno.Location = new System.Drawing.Point(166, 163);
            this.tbxamaterno.Name = "tbxamaterno";
            this.tbxamaterno.Size = new System.Drawing.Size(185, 20);
            this.tbxamaterno.TabIndex = 2;
            this.tbxamaterno.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(166, 70);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(185, 20);
            this.tbxname.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(53, 73);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(978, 570);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSOMEDICS";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tbxcantregistro.ResumeLayout(false);
            this.tbxcantregistro.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.TabPage tbxcantregistro;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblcantregistro;
        private System.Windows.Forms.Label lblcantactual;
        private System.Windows.Forms.Label lblpreventa;
        private System.Windows.Forms.Label lblprecosto;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox tbxpreventa;
        private System.Windows.Forms.TextBox tbxprecosto;
        private System.Windows.Forms.TextBox tbxdesc;
        private System.Windows.Forms.TextBox tbxcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxcantactual;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxtel;
        private System.Windows.Forms.TextBox tbxdir;
        private System.Windows.Forms.TextBox tbxapaterno;
        private System.Windows.Forms.TextBox tbxamaterno;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lbldir;
        private System.Windows.Forms.Label lblamaterno;
        private System.Windows.Forms.Label lblapaterno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TextBox tbxid;
    }
}

