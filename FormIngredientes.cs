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

            //var upd = new SQLiteCommand("UPDATE Costo", con);

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS Ingredientes";
            cmd.ExecuteNonQuery();

            //db = new SQLiteDataAdapter(stm, con);
            cmd.CommandText = @"CREATE TABLE Ingredientes(Ingrediente TEXT, Costo TEXT)";
            cmd.ExecuteNonQuery();

            //DataTable dt = new DataTable();


            //Adding the Columns.
            /*
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }
            */
            //Adding the Rows.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //dt.Rows.Add();
                if (row.Index != dataGridView1.Rows.Count - 1)
                {
                    cmd.CommandText = "INSERT INTO Ingredientes(Ingrediente, Costo) VALUES('" + dataGridView1[0, row.Index].Value.ToString() + "','" + dataGridView1[1, row.Index].Value.ToString() + "')";

                    cmd.ExecuteNonQuery();
                }
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            

            db = new SQLiteDataAdapter(stm, con);

            DataSet ds = new DataSet();
            ds.Reset();

            DataTable dt = new DataTable();
            db.Fill(ds);

            dt = ds.Tables[0];

            dataGridView2.DataSource = dt;

            // DataSet ds = new DataSet();
            //ds.Tables.Add(dt);
            //db.Update(ds,dt.TableName);
            /*
            DataTable tablaale = new DataTable();
                tablaale = (DataTable)dataGridView1.DataSource;
            db.UpdateCommand=upd;
            db.Update(tablaale);
            */
            //db.Fill(dt);
            // db.Update(dt);



        }


    }
    
}
