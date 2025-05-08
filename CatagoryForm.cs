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
    public partial class CatagoryForm : Form
    {
        public CatagoryForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RKKKG23;Initial Catalog=iBuyDB;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CatagoryTbl values(" + CatIdtb.Text + ",'" + CatNametb.Text + "','" + CatDesctb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Catagory Successfully Added!");
                Con.Close();
                populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate() 
        {
            Con.Open();
            string query = "select * from CatagoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatagoryDVG.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void CatagoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatagoryDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CatIdtb.Text = CatagoryDVG.SelectedRows[0].Cells[0].Value.ToString();
            //CatNametb.Text = CatagoryDVG.SelectedRows[0].Cells[1].Value.ToString();
            //CatDesctb.Text = CatagoryDVG.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdtb.Text == " ")
                {
                    MessageBox.Show("Type the info of the catagory you want to delete.");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CatagoryTbl where CatId=" + CatIdtb.Text + " ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Catagory deletion successful!");
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
                if (CatIdtb.Text == "" || CatNametb.Text == "" || CatDesctb.Text == "")
                {
                    MessageBox.Show("Informations missing in the text box.");
                }
                else
                {
                    Con.Open();
                    string query = "update CatagoryTbl set CatName='" + CatNametb.Text + "',CatDesc='" + CatDesctb.Text + "'where CatId=" + CatIdtb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Catagory Update successful!");
                    Con.Close();
                    populate();
                } 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
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
