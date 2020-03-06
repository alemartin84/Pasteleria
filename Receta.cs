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
        private Dictionary<string, int> ListaIngredientes = new Dictionary<string, int>();

       // private List<KeyValuePair<string, int>> ListaIngredientes = new List<KeyValuePair<string, int>>(); VER SI ME CONVIENE HACER UNA LISTA DE PARES

        public Receta()
        {
            //MessageBox.Show("INSTANCIA CREADA!");
        }

               
        public string NombreReceta { get; set; }

        public string Descripcion { get; set; }

        public string TiempoHorneado { get; set; }

        public string TempHorneado { get; set; }


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

            return (NombreReceta + newLine + MostrarIngredientes() + newLine + Descripcion + newLine + TempHorneado + newLine + TiempoHorneado + newLine);
           
        }


        public void CargarIngredientes(string ingrediente, int cantidad) //ES UN SETTER "ESPECIAL"
        {
           ListaIngredientes.Add(ingrediente, cantidad);
           
        }

        public int CantidadIngredientes()
        {
            return ListaIngredientes.Count();
        }

        public void Reset()
        {
            NombreReceta = "";
            Descripcion = "";
            ListaIngredientes.Clear();
            TempHorneado = "";
            TiempoHorneado = "";

        }


    }
}
