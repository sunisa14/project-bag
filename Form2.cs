using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectbag
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=bag";
                string Query = "select * from detall;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;

                // MyConn2.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=bag";

                string Query = "delete from brand where id_detall ='" + this.txtid_detall.Text + "';";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Deleted");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=bag";
                string Query = "update detall set type_detall ='" + this.txttype_detall.Text + "',price_detall='" + this.txtprice_detall.Text + "',color_detall ='" + this.txtcolor_detall.Text + "',pattern_detall ='" + this.txtpattern_detall.Text + "',adjunct_detall = '"+ this.txtadjunct_detall.Text +  "' where id_detall='" + this.txtid_detall.Text + "';";
                

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Updated");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();//Connection closed here 

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=bag";

                string Query = "insert into detall (id_detall,type_detall,price_detall,color_detall,pattern_detall,adjunct_detall,species_detall,genuineleather_detall,artificialleather_detall) "
                    +  "values('" + this.txtid_detall.Text + "','" + this.txttype_detall.Text + "','" + this.txtprice_detall.Text + "','" + this.txtcolor_detall.Text + "','" + this.txtpattern_detall.Text + "','" + this.txtadjunct_detall.Text + "','"+this.genuineleather_detall.Checked+"','"+this.artificialleather_detall.Checked+"','"+this.species_detall.Text+"');";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {
                }

                MyConn2.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
    }
 
    

        
    
    
