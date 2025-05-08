namespace WindowsFormsCarrito
{
    partial class FormCarrito
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
            this.prod1 = new System.Windows.Forms.Label();
            this.Prod2 = new System.Windows.Forms.Label();
            this.prod3 = new System.Windows.Forms.Label();
            this.prod4 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.descr1 = new System.Windows.Forms.Label();
            this.descr2 = new System.Windows.Forms.Label();
            this.descr3 = new System.Windows.Forms.Label();
            this.descr4 = new System.Windows.Forms.Label();
            this.precio1 = new System.Windows.Forms.Label();
            this.precio2 = new System.Windows.Forms.Label();
            this.precio3 = new System.Windows.Forms.Label();
            this.precio4 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // prod1
            // 
            this.prod1.AutoSize = true;
            this.prod1.Location = new System.Drawing.Point(79, 58);
            this.prod1.Name = "prod1";
            this.prod1.Size = new System.Drawing.Size(60, 13);
            this.prod1.TabIndex = 0;
            this.prod1.Text = "Pantalones";
            // 
            // Prod2
            // 
            this.Prod2.AutoSize = true;
            this.Prod2.Location = new System.Drawing.Point(269, 58);
            this.Prod2.Name = "Prod2";
            this.Prod2.Size = new System.Drawing.Size(49, 13);
            this.Prod2.TabIndex = 1;
            this.Prod2.Text = "Remeras";
            // 
            // prod3
            // 
            this.prod3.AutoSize = true;
            this.prod3.Location = new System.Drawing.Point(476, 58);
            this.prod3.Name = "prod3";
            this.prod3.Size = new System.Drawing.Size(54, 13);
            this.prod3.TabIndex = 2;
            this.prod3.Text = "Camperas";
            // 
            // prod4
            // 
            this.prod4.AutoSize = true;
            this.prod4.Location = new System.Drawing.Point(658, 58);
            this.prod4.Name = "prod4";
            this.prod4.Size = new System.Drawing.Size(38, 13);
            this.prod4.TabIndex = 3;
            this.prod4.Text = "Gorras";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(52, 247);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Agregar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(253, 247);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Agregar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(455, 247);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "Agregar";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(650, 247);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "Agregar";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // descr1
            // 
            this.descr1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descr1.AutoSize = true;
            this.descr1.Location = new System.Drawing.Point(12, 96);
            this.descr1.Name = "descr1";
            this.descr1.Size = new System.Drawing.Size(169, 52);
            this.descr1.TabIndex = 9;
            this.descr1.Text = "Lorem ipsum dolor sit amet,\r\n consectetur adipiscing elit. \r\nSed do eiusmod tempo" +
    "r incididunt \r\nut labore et dolore magna aliqua.\r\n";
            // 
            // descr2
            // 
            this.descr2.AutoSize = true;
            this.descr2.Location = new System.Drawing.Point(214, 96);
            this.descr2.Name = "descr2";
            this.descr2.Size = new System.Drawing.Size(169, 52);
            this.descr2.TabIndex = 10;
            this.descr2.Text = "Lorem ipsum dolor sit amet,\r\n consectetur adipiscing elit. \r\nSed do eiusmod tempo" +
    "r incididunt \r\nut labore et dolore magna aliqua.";
            // 
            // descr3
            // 
            this.descr3.AutoSize = true;
            this.descr3.Location = new System.Drawing.Point(413, 96);
            this.descr3.Name = "descr3";
            this.descr3.Size = new System.Drawing.Size(169, 52);
            this.descr3.TabIndex = 11;
            this.descr3.Text = "Lorem ipsum dolor sit amet,\r\n consectetur adipiscing elit. \r\nSed do eiusmod tempo" +
    "r incididunt \r\nut labore et dolore magna aliqua.";
            // 
            // descr4
            // 
            this.descr4.AutoSize = true;
            this.descr4.Location = new System.Drawing.Point(606, 96);
            this.descr4.Name = "descr4";
            this.descr4.Size = new System.Drawing.Size(169, 52);
            this.descr4.TabIndex = 12;
            this.descr4.Text = "Lorem ipsum dolor sit amet,\r\n consectetur adipiscing elit. \r\nSed do eiusmod tempo" +
    "r incididunt \r\nut labore et dolore magna aliqua.\r\n";
            // 
            // precio1
            // 
            this.precio1.AutoSize = true;
            this.precio1.Location = new System.Drawing.Point(67, 187);
            this.precio1.Name = "precio1";
            this.precio1.Size = new System.Drawing.Size(37, 13);
            this.precio1.TabIndex = 13;
            this.precio1.Text = "20000";
            // 
            // precio2
            // 
            this.precio2.AutoSize = true;
            this.precio2.Location = new System.Drawing.Point(269, 187);
            this.precio2.Name = "precio2";
            this.precio2.Size = new System.Drawing.Size(37, 13);
            this.precio2.TabIndex = 14;
            this.precio2.Text = "15000";
            // 
            // precio3
            // 
            this.precio3.AutoSize = true;
            this.precio3.Location = new System.Drawing.Point(476, 187);
            this.precio3.Name = "precio3";
            this.precio3.Size = new System.Drawing.Size(37, 13);
            this.precio3.TabIndex = 15;
            this.precio3.Text = "40000";
            // 
            // precio4
            // 
            this.precio4.AutoSize = true;
            this.precio4.Location = new System.Drawing.Point(661, 187);
            this.precio4.Name = "precio4";
            this.precio4.Size = new System.Drawing.Size(37, 13);
            this.precio4.TabIndex = 16;
            this.precio4.Text = "12000";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Total});
            this.dgv1.Location = new System.Drawing.Point(31, 288);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(443, 150);
            this.dgv1.TabIndex = 17;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(547, 352);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(650, 352);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 19;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // FormCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.precio4);
            this.Controls.Add(this.precio3);
            this.Controls.Add(this.precio2);
            this.Controls.Add(this.precio1);
            this.Controls.Add(this.descr4);
            this.Controls.Add(this.descr3);
            this.Controls.Add(this.descr2);
            this.Controls.Add(this.descr1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.prod4);
            this.Controls.Add(this.prod3);
            this.Controls.Add(this.Prod2);
            this.Controls.Add(this.prod1);
            this.Name = "FormCarrito";
            this.Text = "FormCarrito";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prod1;
        private System.Windows.Forms.Label Prod2;
        private System.Windows.Forms.Label prod3;
        private System.Windows.Forms.Label prod4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label descr1;
        private System.Windows.Forms.Label descr2;
        private System.Windows.Forms.Label descr3;
        private System.Windows.Forms.Label descr4;
        private System.Windows.Forms.Label precio1;
        private System.Windows.Forms.Label precio2;
        private System.Windows.Forms.Label precio3;
        private System.Windows.Forms.Label precio4;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnComprar;
    }
}