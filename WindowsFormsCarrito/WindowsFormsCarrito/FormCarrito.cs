using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsCarrito
{
    public partial class FormCarrito : Form
    {
        List<Carrito> carrito = new List<Carrito>();
        
        public FormCarrito()
        {
            InitializeComponent();

        }

        #region Eventos
        private void btn1_Click(object sender, EventArgs e)
        {
            Carrito newcarrito = new Carrito(prod1.Text, Convert.ToInt32(precio1.Text));

            if (dgv1.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow && row.Cells["Producto"].Value?.ToString().ToLower() == "pantalones"))
            {
                 MessageBox.Show("Ya ingreso este producto" , "Error");
         

            }
            else
            {
                newcarrito.p_Cantidad = newcarrito.p_Cantidad + 1;

                carrito.Add(newcarrito);
                newcarrito.p_total = newcarrito.p_Precio * newcarrito.p_Cantidad;
                dgv1.Rows.Add(newcarrito.p_Producto, newcarrito.p_Precio, newcarrito.p_Cantidad, newcarrito.p_total);
                CalcularTotal();

            }

        
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Carrito newcarrito = new Carrito(Prod2.Text, Convert.ToInt32(precio2.Text));

            if (dgv1.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow && row.Cells["Producto"].Value?.ToString().ToLower() ==   "remeras"))
            {
                MessageBox.Show("Ya ingreso este producto", "Error");
            }
            else
            {
                newcarrito.p_Cantidad = newcarrito.p_Cantidad + 1;

                carrito.Add(newcarrito);
                newcarrito.p_total = newcarrito.p_Precio * newcarrito.p_Cantidad;
                dgv1.Rows.Add(newcarrito.p_Producto, newcarrito.p_Precio, newcarrito.p_Cantidad, newcarrito.p_total);
                CalcularTotal();

            }
    }

        private void btn3_Click(object sender, EventArgs e)
        {
            Carrito newcarrito = new Carrito(prod3.Text, Convert.ToInt32(precio3.Text));

            if (dgv1.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow && row.Cells["Producto"].Value?.ToString().ToLower() == "camperas"))
            {
                MessageBox.Show("Ya ingreso este producto", "Error");
            }
            else
            {
                newcarrito.p_Cantidad = newcarrito.p_Cantidad + 1;

                carrito.Add(newcarrito);
                newcarrito.p_total = newcarrito.p_Precio * newcarrito.p_Cantidad;
                dgv1.Rows.Add(newcarrito.p_Producto, newcarrito.p_Precio, newcarrito.p_Cantidad, newcarrito.p_total);
                CalcularTotal();

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Carrito newcarrito = new Carrito(prod4.Text, Convert.ToInt32(precio4.Text));

            if (dgv1.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow && row.Cells["Producto"].Value?.ToString().ToLower() == "gorras"))
            {
                MessageBox.Show("Ya ingreso este producto", "Error");
            }
            else
            {
                newcarrito.p_Cantidad = newcarrito.p_Cantidad + 1;

                carrito.Add(newcarrito);

                newcarrito.p_total = newcarrito.p_Precio * newcarrito.p_Cantidad;
                dgv1.Rows.Add(newcarrito.p_Producto, newcarrito.p_Precio, newcarrito.p_Cantidad, newcarrito.p_total);
                CalcularTotal();
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "Total")

            {
                MessageBox.Show("No ha seleccionado ningun producto", "Error");
            }
            else
            {
                dgv1.Rows.Clear();
                MessageBox.Show("Compra Realizada", "Operacion Exitosa");
                lblTotal.Text = "Total";
            }

        }

        #endregion

        private void CalcularTotal()
        {
            int total = 0;

            foreach (DataGridViewRow row in dgv1.Rows)
            {
                if (!row.IsNewRow && row.Cells[3].Value != null)
                {
                    int precio;
                    if (int.TryParse(row.Cells[3].Value.ToString(), out precio))
                    {
                        total += precio;
                    }
                }
            }

            lblTotal.Text = $"Total: ${total:F2}";
        }

       
    }
}



