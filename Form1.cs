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

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string nombreReceta;


            
            
            
                nombreReceta = listBoxRecetas.Text;
            if (EntradaSalida.CheckIfRecordExists(nombreReceta))
            {
                EntradaSalida.DeserealizeFromSqlite(nombreReceta, ref recet); //SI EXISTE PONE EL RESULTADO DEL BLOB DE SQLITE EN EL OBJETO recet
                txtRecetaDB.Text = recet.MostrarCompleta();
            }
                      
              
            else
                
                {
                MessageBox.Show("no existe, carguela abajo");
                }
           
               
                //Console.WriteLine("\n\nDESEA INGRESAR OTRA RECETA? Y/N:");

           


        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            listBoxRecetas.Items.Add(txtBoxReceta.Text);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recet.NombreReceta = listBoxRecetas.Text; //SI NO EXISTE CARGO LOS DATOS DEL OBJETO DE LA CLASE RECETA
            
            recet.Descripcion=txtDescRcp.Text;
            recet.Horneado=txtHornoRcp.Text;
            EntradaSalida.SerializeToSqlite(recet); //POR AHORA LA RECETA TIENE QUE TENER INGREDIENTES
            MessageBox.Show("SE CARGO LA RECETA");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //recet.CargarIngredientes(txtIngRcp.Text, int.Parse(txtCantRcp.Text));
            recet.ListaIngredientes.Add(txtIngRcp.Text, int.Parse(txtCantRcp.Text));
            MessageBox.Show("SE AGREGO UN ITEM, VAN: " + recet.ListaIngredientes.Count());
            
        }
    }
}
