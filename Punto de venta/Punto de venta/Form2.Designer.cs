namespace Punto_de_venta
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button5 = new System.Windows.Forms.Button();
            this.tbxmodproduc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(117, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 48);
            this.button5.TabIndex = 5;
            this.button5.Text = "Modificar Producto";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tbxmodproduc
            // 
            this.tbxmodproduc.Location = new System.Drawing.Point(178, 24);
            this.tbxmodproduc.Name = "tbxmodproduc";
            this.tbxmodproduc.Size = new System.Drawing.Size(204, 20);
            this.tbxmodproduc.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Código del producto";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 119);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tbxmodproduc);
            this.Controls.Add(this.label7);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbxmodproduc;
        private System.Windows.Forms.Label label7;
    }
}