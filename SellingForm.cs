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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RKKKG23;Initial Catalog=iBuyDB;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select ProdName,ProdQty from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populateBills()
        {
            Con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillDGV.DataSource = ds.Tables[0];
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
            //CatCB.ValueMember = "CatName";
            //CatCB.DataSource = dt;
            SearchCB.ValueMember = "CatName";
            SearchCB.DataSource = dt;
            Con.Close();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populateBills();
            fillcombo();
            SellerNamelbl.Text = Login.SellerName;
        }
        int flag = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        private int n = 0;
        int GrdTotal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
 
            if (ProdNametb.Text == "" || ProdQtytb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(ProdPricetb.Text) * Convert.ToInt32(ProdQtytb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdNametb.Text;
                newRow.Cells[2].Value = ProdPricetb.Text;
                newRow.Cells[3].Value = ProdQtytb.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPricetb.Text) * Convert.ToInt32(ProdQtytb.Text);
                OrderDGV.Rows.Add(newRow);
                n++;
                GrdTotal = GrdTotal + total;
                Amtlbl.Text =" "+GrdTotal;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Billidtb.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillTbl values(" + Billidtb.Text + ",'" + SellerNamelbl.Text + "','" + Datelbl.Text + "'," + Amtlbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Successfully Added!");
                    Con.Close();
                    populateBills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BillDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("iBuy", new Font("Jokerman", 25, FontStyle.Bold), Brushes.Red, new Point(230));
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select ProdName,ProdPrice from ProductTbl where ProdCat='" + SearchCB.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatagoryForm cat = new CatagoryForm();
            cat.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }
    }
}
