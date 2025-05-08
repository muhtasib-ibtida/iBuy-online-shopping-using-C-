
namespace iBuy
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.SearchCb = new System.Windows.Forms.ComboBox();
            this.ProductDVG = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CatCB = new System.Windows.Forms.ComboBox();
            this.ProdQtytb = new System.Windows.Forms.TextBox();
            this.ProdPricetb = new System.Windows.Forms.TextBox();
            this.ProdIdtb = new System.Windows.Forms.TextBox();
            this.ProdNametb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.SearchCb);
            this.panel1.Controls.Add(this.ProductDVG);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.CatCB);
            this.panel1.Controls.Add(this.ProdQtytb);
            this.panel1.Controls.Add(this.ProdPricetb);
            this.panel1.Controls.Add(this.ProdIdtb);
            this.panel1.Controls.Add(this.ProdNametb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(175, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 789);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Jokerman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Coral;
            this.button8.Location = new System.Drawing.Point(372, 69);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 33);
            this.button8.TabIndex = 21;
            this.button8.Text = "REFRESH";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // SearchCb
            // 
            this.SearchCb.BackColor = System.Drawing.Color.MistyRose;
            this.SearchCb.Font = new System.Drawing.Font("Jokerman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCb.ForeColor = System.Drawing.Color.Coral;
            this.SearchCb.FormattingEnabled = true;
            this.SearchCb.Location = new System.Drawing.Point(168, 69);
            this.SearchCb.Name = "SearchCb";
            this.SearchCb.Size = new System.Drawing.Size(198, 33);
            this.SearchCb.TabIndex = 20;
            this.SearchCb.Text = "Select Catagory";
            this.SearchCb.SelectedIndexChanged += new System.EventHandler(this.SearchCb_SelectedIndexChanged);
            this.SearchCb.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // ProductDVG
            // 
            this.ProductDVG.BackgroundColor = System.Drawing.Color.MistyRose;
            this.ProductDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDVG.Location = new System.Drawing.Point(3, 108);
            this.ProductDVG.Name = "ProductDVG";
            this.ProductDVG.RowHeadersWidth = 51;
            this.ProductDVG.RowTemplate.Height = 24;
            this.ProductDVG.Size = new System.Drawing.Size(693, 678);
            this.ProductDVG.TabIndex = 19;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Jokerman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Coral;
            this.button7.Location = new System.Drawing.Point(930, 350);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 53);
            this.button7.TabIndex = 18;
            this.button7.Text = "DELETE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Jokerman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Coral;
            this.button6.Location = new System.Drawing.Point(824, 350);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 53);
            this.button6.TabIndex = 17;
            this.button6.Text = "UPDATE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Jokerman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Coral;
            this.button4.Location = new System.Drawing.Point(709, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 53);
            this.button4.TabIndex = 16;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CatCB
            // 
            this.CatCB.BackColor = System.Drawing.Color.MistyRose;
            this.CatCB.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCB.ForeColor = System.Drawing.Color.Coral;
            this.CatCB.FormattingEnabled = true;
            this.CatCB.Location = new System.Drawing.Point(826, 288);
            this.CatCB.Name = "CatCB";
            this.CatCB.Size = new System.Drawing.Size(198, 37);
            this.CatCB.TabIndex = 15;
            this.CatCB.Text = "Select Catagory";
            // 
            // ProdQtytb
            // 
            this.ProdQtytb.BackColor = System.Drawing.Color.MistyRose;
            this.ProdQtytb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQtytb.Location = new System.Drawing.Point(825, 239);
            this.ProdQtytb.Name = "ProdQtytb";
            this.ProdQtytb.Size = new System.Drawing.Size(199, 30);
            this.ProdQtytb.TabIndex = 14;
            // 
            // ProdPricetb
            // 
            this.ProdPricetb.BackColor = System.Drawing.Color.MistyRose;
            this.ProdPricetb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPricetb.Location = new System.Drawing.Point(825, 197);
            this.ProdPricetb.Name = "ProdPricetb";
            this.ProdPricetb.Size = new System.Drawing.Size(199, 30);
            this.ProdPricetb.TabIndex = 13;
            // 
            // ProdIdtb
            // 
            this.ProdIdtb.BackColor = System.Drawing.Color.MistyRose;
            this.ProdIdtb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIdtb.Location = new System.Drawing.Point(825, 153);
            this.ProdIdtb.Name = "ProdIdtb";
            this.ProdIdtb.Size = new System.Drawing.Size(199, 30);
            this.ProdIdtb.TabIndex = 12;
            // 
            // ProdNametb
            // 
            this.ProdNametb.BackColor = System.Drawing.Color.MistyRose;
            this.ProdNametb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNametb.Location = new System.Drawing.Point(825, 107);
            this.ProdNametb.Name = "ProdNametb";
            this.ProdNametb.Size = new System.Drawing.Size(199, 30);
            this.ProdNametb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(704, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Catagory :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(703, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(702, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price         :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(703, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID               :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(703, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name        :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Products Management";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Tomato;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(980, 12);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 42);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Jokerman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(12, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Jokerman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(12, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Catagory";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Jokerman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Coral;
            this.button3.Location = new System.Drawing.Point(12, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Selling";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Jokerman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Coral;
            this.button9.Location = new System.Drawing.Point(12, 726);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(114, 33);
            this.button9.TabIndex = 24;
            this.button9.Text = "LOG OUT";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(736, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1210, 785);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ProdQtytb;
        private System.Windows.Forms.TextBox ProdPricetb;
        private System.Windows.Forms.TextBox ProdIdtb;
        private System.Windows.Forms.TextBox ProdNametb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductDVG;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox CatCB;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox SearchCb;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}