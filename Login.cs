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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string SellerName = "";
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RKKKG23;Initial Catalog=iBuyDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Unametb.Text = "";
            Passtb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Unametb.Text == ""||Passtb.Text == "")
            {
                MessageBox.Show("Enter the username and Password.");
            }
            else
            {
                if (RoleCB.SelectedIndex > -1)
                {
                    if (RoleCB.SelectedItem.ToString() == "Admin")
                    {
                        if (Unametb.Text == "Admin" && Passtb.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the admin , insert login info correctly!");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("You're in the seller section.");

                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from SellerTbl where SellerName='" + Unametb.Text + "'and SellerPass='" + Passtb.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            SellerName = Unametb.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong user or Pass. Try again !");
                        }
                        Con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select who you are.");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
