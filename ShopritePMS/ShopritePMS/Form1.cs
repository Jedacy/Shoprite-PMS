using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopritePMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UnameTb.Texts = "";
            PassTb.Texts = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UnameTb.Texts == "" || PassTb.Texts == "")
            {
                MessageBox.Show("Fill the blanks");
            }
            else
            {
                if (RoleCb.SelectedIndex > -1)
                {
                    if (RoleCb.SelectedItem.ToString() == "ADMIN")
                    {

                        if (UnameTb.Texts == "ADMIN" && PassTb.Texts == "ADMIN")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        } else
                        {
                            MessageBox.Show("If you are the Admin, Enter the correct password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You're in the Attendant Section");
                        ProductForm prod = new ProductForm();
                        prod.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Select a Role");
                }
            }

            
        }

        private void RoleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RoleCb_SelectedIndexChangeCommitted(object sender, EventArgs e)
        {
         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UnameTb.Texts = "";
            PassTb.Texts = "";
        }
    }
}
