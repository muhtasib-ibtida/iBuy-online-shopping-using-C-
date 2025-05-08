using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace iBuy
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RKKKG23;Initial Catalog=iBuyDB;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDVG.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into SellerTbl values(" + SIdtb.Text + ",'" + SNametb.Text + "'," + SAgetb.Text + "," + SPhonetb.Text + ",'" + SPasstb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Successfully Added!");
                Con.Close();
                populate();
                Con.Close();
                populate();
                SIdtb.Text = "";
                SNametb.Text = "";
                SPhonetb.Text = "";
                SPasstb.Text = "";
                SAgetb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (SIdtb.Text == " ")
                {
                    MessageBox.Show("Type the info of the Seller you want to delete.");
                }
                else
                {
                    Con.Open();
                    string query = "delete from SellerTbl where SellerId=" + SIdtb.Text + " ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller info deletion successful!");
                    Con.Close();
                    populate();
                    SIdtb.Text = "";
                    SNametb.Text = "";
                    SPhonetb.Text = "";
                    SPasstb.Text = "";
                    SAgetb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (SIdtb.Text == "" || SNametb.Text == "" || SAgetb.Text == "" || SPhonetb.Text == "" || SPasstb.Text == "")
                {
                    MessageBox.Show("Informations missing in the text box.");
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE SellerTbl SET SellerName='" + SNametb.Text + "', SellerAge='" + SAgetb.Text + "', SellerPhone=" + SPhonetb.Text + ", SellerPass='" + SPasstb.Text + "' WHERE SellerId=" + SIdtb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Update successful!");
                    Con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatagoryForm cat = new CatagoryForm();
            cat.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellingForm selling = new SellingForm();
            selling.Show();
        }
    }
}
