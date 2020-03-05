using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Pasteleria
{
   
    
    [Serializable()]
    public class Receta
    {
        public Dictionary<string, int> ListaIngredientes = new Dictionary<string, int>();

        public Receta()
        {
            //MessageBox.Show("INSTANCIA CREADA!");
        }

        //public Dictionary<string, int> ListaIngredientes { get; set; }

       
        public string NombreReceta { get; set; }

        public string Descripcion { get; set; }

        public string Horneado { get; set; }

       
        public string MostrarIngredientes()
        {
            string ingredientes="";
            string newLine = Environment.NewLine;

            foreach (KeyValuePair<string, int> kvp in ListaIngredientes)
            {
                ingredientes = ingredientes + "INGREDIENTE:" + kvp.Key +"    " + "CANTIDAD:" + kvp.Value + newLine;//(("INGREDIENTE:{0,-20} CANTIDAD:{1}" + "\n"), kvp.Key, kvp.Value);


            }
            return ingredientes;

        }

        public string MostrarCompleta()
        {

            //MessageBox.Show(NombreReceta + '\n' + MostrarIngredientes() + '\n' + Descripcion + '\n' + Horneado + '\n');
            string newLine = Environment.NewLine;

            return (NombreReceta + newLine + MostrarIngredientes() + newLine + Descripcion + newLine + Horneado + newLine);
           
        }


        public void CargarIngredientes(string ingrediente, int cantidad)
        {

             Dictionary<string, int> listaIng = new Dictionary<string, int>();

             listaIng.Add(ingrediente, cantidad);

            ListaIngredientes = listaIng;

            
        }

    }
}
