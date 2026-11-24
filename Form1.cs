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
            lvCatalogo.Items.Add("Cafe Expreso");
            lvCatalogo.Items.Add("Bolon de Queso");
            lvCatalogo.Items.Add("Bolon de Chicharon");
            lvCatalogo.Items.Add("Empanada de viento");
            lvCatalogo.Items.Add("Encebollado");
            lvCatalogo.Items.Add("Sanduche simple");
            lvCatalogo.Items.Add("Cafe con leche");
            lvCatalogo.Items.Add("Ceviche de camaron");
            lvCatalogo.Items.Add("Majado");
            lvCatalogo.Items.Add("Batido de mora");

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
    }
}
