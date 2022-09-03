using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShopritePMS
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

        private void ProdId__TextChanged(object sender, EventArgs e)
        {

        }

        private void ProdName__TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JED\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select ProdName, ProdQty from ProductTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Texts = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProdPrice.Texts = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString()+ "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void ProdPrice__TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AttendantForm Attend = new AttendantForm();
            Attend.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n = 0, total = Convert.ToInt32(ProdPrice.Texts) * Convert.ToInt32(ProdQty.Texts);
            int GrdTotal = 0;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(OrderDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = ProdName.Texts;
            newRow.Cells[2].Value = ProdPrice.Texts;
            newRow.Cells[3].Value = ProdQty.Texts;
            newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Texts)* Convert.ToInt32(ProdQty.Texts);
            OrderDGV.Rows.Add(newRow);
            GrdTotal = GrdTotal+ total; 
            Amtlbl.Text = "Ghc "+ GrdTotal;
        }

        private void OrderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Amtlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
