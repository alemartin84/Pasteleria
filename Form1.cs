using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasteleria
{
    public partial class Form1 : Form
    {

        private Receta recet = new Receta();
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void CargarListBoxRecetas()
        {
            List<string> listaRecetas = new List<string>();

            listBoxRecetas.Items.Clear();

            listaRecetas = EntradaSalida.LeerRecetasDb();
            foreach (string item in listaRecetas)
            {
                listBoxRecetas.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarListBoxRecetas();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string nombreReceta;
            nombreReceta = listBoxRecetas.Text;
         
            EntradaSalida.DeserealizeFromSqlite(nombreReceta, ref recet); //SI EXISTE PONE EL RESULTADO DEL BLOB DE SQLITE EN EL OBJETO recet
            txtRecetaDB.Text = recet.MostrarCompleta();
            recet.Reset();       
              
           
           


        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            listBoxRecetas.Items.Add(txtBoxReceta.Text);
            txtRecetaDB.Text = "";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recet.NombreReceta = listBoxRecetas.Text; //SI NO EXISTE CARGO LOS DATOS DEL OBJETO DE LA CLASE RECETA
            
            recet.Descripcion=txtDescRcp.Text;
            recet.TempHorneado=txtTempRcp.Text;
            recet.TiempoHorneado = txtTiempoRcp.Text;

            EntradaSalida.SerializeToSqlite(recet); //POR AHORA LA RECETA TIENE QUE TENER INGREDIENTES
            MessageBox.Show("SE CARGO LA RECETA");
            recet.Reset();

            txtDescRcp.Text = "";
            txtTempRcp.Text = "";
            txtTiempoRcp.Text = "";
            txtIngRcp.Text = "";
            txtCantRcp.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            recet.CargarIngredientes(txtIngRcp.Text, int.Parse(txtCantRcp.Text));
            
            MessageBox.Show("SE AGREGO UN ITEM, VAN: " + recet.CantidadIngredientes());
            
        }

        private void buttonBorrarDB_Click(object sender, EventArgs e)
        {
            EntradaSalida.BorrarRecetaDB(listBoxRecetas.Text);
            CargarListBoxRecetas();
            txtRecetaDB.Text = "";
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngredientes formIngredientes = new FormIngredientes();

            formIngredientes.Show();

           
        }
    }
}
