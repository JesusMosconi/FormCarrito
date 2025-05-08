using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        #region Atributos
        private string Producto;
        private int Precio;
        private int cantidad; 
        private int total;

        #endregion

        #region Propiedades

        public string p_Producto 
        { 
            set { Producto = value; }
            get { return Producto; }    
        }

        public int p_Precio 
        {
            set { Precio = value; }
            get { return Precio; }
        }
        public int p_Cantidad
        {
           set { cantidad = value; }    
            get { return cantidad; }
        }

        public int p_total 
        {
            set {  total = value; }
            get { return total; }
        }

        #endregion

        #region Constructores
        public Carrito() 
        { }

        public Carrito (string prod, int precio)
        {
            Producto = prod;
            Precio = precio;
        }

        #endregion

    }
}
