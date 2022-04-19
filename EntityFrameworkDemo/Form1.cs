using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        ProductDal productDal = new ProductDal();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dataGridView1.DataSource = this.productDal.GetAll();
        }
        private void SearchProducts(string key)
        {
            //dataGridView1.DataSource = this.productDal.GetAll().Where(p => p.Name.Contains(key)).ToList();
            dataGridView1.DataSource = this.productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();
            //dataGridView1.DataSource = this.productDal.GetByName(key);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            this.productDal.Add(new Product
            {
                Name = textBox_Add_Name.Text,
                UnitPrice = Convert.ToDecimal(textBox_Add_UnitPrice.Text),
                StockAmount = Convert.ToInt32(textBox_Add_StockAmount.Text)
            });

            LoadProducts();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Update_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_Update_UnitPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_Update_StockAmount.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            this.productDal.Update(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = textBox_Update_Name.Text,
                StockAmount = Convert.ToInt32(textBox_Update_StockAmount.Text),
                UnitPrice = Convert.ToDecimal(textBox_Update_UnitPrice.Text)
            });

            LoadProducts();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            this.productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                //Name = textBox_Update_Name.Text,
                //StockAmount = Convert.ToInt32(textBox_Update_StockAmount.Text),
                //UnitPrice = Convert.ToDecimal(textBox_Update_UnitPrice.Text)
            });

            LoadProducts();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(textBox_Search.Text);
            //if (textBox_Search.Text == "")
            //{
            //    LoadProducts();
            //}
            //else
            //{
            //    SearchProducts(textBox_Search.Text);
            //}
        }
    }
}
