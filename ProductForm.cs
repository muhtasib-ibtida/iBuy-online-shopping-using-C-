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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RKKKG23;Initial Catalog=iBuyDB;Integrated Security=True");

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDVG.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CatagoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            CatCB.ValueMember = "CatName";
            CatCB.DataSource = dt;
            SearchCb.ValueMember = "CatName";
            SearchCb.DataSource = dt;
            Con.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatagoryForm cat = new CatagoryForm();
            cat.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ProductTbl values(" + ProdIdtb.Text + ",'" + ProdNametb.Text + "'," + ProdQtytb.Text + "," + ProdPricetb.Text + ",'" + CatCB.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added!");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdIdtb.Text == " ")
                {
                    MessageBox.Show("Type the info of the product you want to delete.");
                }
                else
                {
                    Con.Open();
                    string query = "delete from ProductTbl where ProdId=" + ProdIdtb.Text + " ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deletion successful!");
                    Con.Close();
                    populate();
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
                if (ProdIdtb.Text == "" || ProdNametb.Text == "" || ProdPricetb.Text == ""|| ProdQtytb.Text == "")
                {
                    MessageBox.Show("Informations missing in the text box.");
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE ProductTbl SET ProdName='" + ProdNametb.Text + "', ProdQty='" + ProdQtytb.Text + "', ProdPrice=" + ProdPricetb.Text + ", ProdCat='" + CatCB.SelectedValue.ToString() + "' WHERE ProdId=" + ProdIdtb.Text + ";";
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

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from ProductTbl where ProdCat='" + SearchCb.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDVG.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellingForm selling = new SellingForm();
            selling.Show();
        }
    }
}
