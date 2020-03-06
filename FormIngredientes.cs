using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Pasteleria
{
    public partial class FormIngredientes : Form
    {
        private SQLiteDataAdapter db = new SQLiteDataAdapter();
        public FormIngredientes()
        {
            InitializeComponent();
        }

        private void FormIngredientes_Load(object sender, EventArgs e)
        {
            string cs = @"URI=file:C:\Users\Ale\Source\Repos\alemartin84\PruebasConsola\ale.db"; 

            var con = new SQLiteConnection(cs);
            con.Open();


            string stm = "SELECT * FROM Ingredientes";

           // var cmd = new SQLiteCommand(stm, con);


           db = new SQLiteDataAdapter(stm, con);

            DataSet ds = new DataSet();
            ds.Reset();

             DataTable dt = new DataTable();
             db.Fill(ds);
            

            

             dt = ds.Tables[0];

           dataGridView1.DataSource = dt;
            
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"URI=file:C:\Users\Ale\Source\Repos\alemartin84\PruebasConsola\ale.db";

            var con = new SQLiteConnection(cs);
            con.Open();


            string stm = "SELECT * FROM Ingredientes";

            // var cmd = new SQLiteCommand(stm, con);

            db = new SQLiteDataAdapter(stm, con);


            DataTable dt = new DataTable();

            //Adding the Columns.
            
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }
            
            //Adding the Rows.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            dataGridView2.DataSource = dt;

            //var cmd = new SQLiteCommand("UPDATE * FROM Ingrendientes", con);
            //cmd.ExecuteNonQuery();
            db.Update(dt);
            
        }
    }
    
}
