using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Nombre: Cesar Angos 
//Paralelo: GR2
//Codigo: EAPPP
namespace cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Selecionar Productos del Catalogo
            if (lvCatalogo.SelectedItems.Count > 0)
            {
                // Obtener el producto seleccionado
                ListViewItem item = lvCatalogo.SelectedItems[0];

                string producto = item.SubItems[0].Text;
                string precio = item.SubItems[1].Text;

                // Mostrar producto en el TextBox
                txtProducto.Text = producto;

                // Mostrar producto y precio en el estado
                lblEstado.Text = "Producto seleccionado: " +
                                 producto + " - Precio: " + precio;

                // Habilitar boton si la cantidad es >= 1
                int cantidad;

                if (int.TryParse(txtCantidad.Text, out cantidad))
                {
                    btnAgregar.Enabled = cantidad >= 1;
                }
                else
                {
                    btnAgregar.Enabled = false;
                }
            }
            else
            {
                txtProducto.Clear();
                btnAgregar.Enabled = false;
                lblEstado.Text = "Seleccione un producto";
            }
        }
        //Inicialiar y Cargar Formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;
            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "Estado: Seleccione un producto";
            txtCantidad.Text = "1";
            rbtnMostrador.Checked = true;
            //Creacion de items del Catalogo
            lvCatalogo.View = View.Details;
            lvCatalogo.FullRowSelect = true;
            lvCatalogo.GridLines = true;

            lvCatalogo.Columns.Clear();
            lvCatalogo.Columns.Add("Producto", 110);
            lvCatalogo.Columns.Add("Precio", 60);

            // Productos y precios
            string[,] productos =
            {
                 {"Cafe Expreso", "1.50"},
                 {"Bolon de Queso", "2.00"},
                 {"Bolon de Chicharron", "2.50"},
                 {"Empanada de Viento", "1.00"},
                 {"Encebollado", "3.50"},
                 {"Sanduche Simple", "2.00"},
                 {"Cafe con Leche", "1.75"},
                 {"Ceviche de Camaron", "4.50"},
                 {"Majado", "3.00"},
                 {"Batido de Mora", "1.50"}
              };
            //Agregar productos me diante un lazo for
            lvCatalogo.Items.Clear();

            for (int i = 0; i < productos.GetLength(0); i++)
            {
                ListViewItem item = new ListViewItem(productos[i, 0]);
                item.SubItems.Add("$" + productos[i, 1]);
                lvCatalogo.Items.Add(item);
            }
            
        }
        
        //Programacion de Eventos de Boton Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvPedido.Clear();
            txtCliente.Clear();
            txtProducto.Clear();
            txtCantidad.Text = "1";
            rbtnMostrador.Checked = true;
            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "Estado: Seleccione un producto";
            chkPostre.Checked = false;
            chkServilletas.Checked = false;




        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad;

            btnAgregar.Enabled =
                lvCatalogo.SelectedItems.Count > 0 &&
                int.TryParse(txtCantidad.Text, out cantidad) &&
                cantidad >= 1;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lvPedido.SelectedItems.Count > 0){
                btnQuitar.Enabled = true;
            }
            else{
                btnQuitar.Enabled = false;
                }
        }
    }
}
