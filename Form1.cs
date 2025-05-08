using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iBuy
{
    public partial class FLP : Form
    {
        public FLP()
        {
            InitializeComponent();
        }

        int startPointOfLoading = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPointOfLoading += 1;
            LoadingProgressBar.Value = startPointOfLoading;

            if (LoadingProgressBar.Value == 100)
            {
                LoadingProgressBar.Value = 0;
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void FLP_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
