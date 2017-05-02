using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeInventarios
{
    public partial class Form1 : Form
    {
        Producto miProducto;
        Inventario miInventario = new Inventario();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miInventario.eliminarProducto(Convert.ToInt16(txtEliminar.Text));
            txtReporte.Text = miInventario.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            miProducto = new Producto(Convert.ToInt16(txtCodigo.Text), txtNombre.Text, Convert.ToInt16(txtCantidad.Text), Convert.ToInt16(txtCosto.Text));
            miInventario.insertarProducto(miProducto, Convert.ToInt16(txtPosicion.Text));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            miProducto = new Producto(Convert.ToInt16(txtCodigo.Text), txtNombre.Text, Convert.ToInt16(txtCantidad.Text), Convert.ToInt16(txtCosto.Text));
            bool inventario = miInventario.agregarProducto(miProducto);

            if(inventario == true)
            {
                miInventario.agregarProducto(miProducto);
            }
            else
            {
                MessageBox.Show("Ya existe un producto con el código: " + txtCodigo.Text);
            }

            txtCodigo.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
            txtCosto.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtReporte.Text = miInventario.ToString();
        }

        private void btnBuscarPorCodigo_Click(object sender, EventArgs e)
        {
            txtReporte.Text = (miInventario.buscarProducto(Convert.ToInt16(txtBuscarPorCodigo.Text))).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            miProducto = new Producto(Convert.ToInt16(txtCodigo.Text), txtNombre.Text, Convert.ToInt16(txtCantidad.Text), Convert.ToInt16(txtCosto.Text));
            miInventario.agregarInicio(miProducto);
        }
    }
}
