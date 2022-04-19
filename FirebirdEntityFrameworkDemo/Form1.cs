using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirebirdEntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        ProductDal productDal;
        public Form1()
        {
            this.productDal = new ProductDal();
            InitializeComponent();
        }

        private void LoadProducts()
        {
            dataGridView1.DataSource = productDal.GetAll();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            productDal.Add(new Product
            {
                Name = textBox_Add_Name.Text,
                StockAmount = Convert.ToInt32(textBox_Add_StockAmount.Text),
                UnitPrice = Convert.ToDecimal(textBox_Add_UnitPrice.Text)
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
            Product product = new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = textBox_Update_Name.Text,
                StockAmount = Convert.ToInt32(textBox_Update_StockAmount.Text),
                UnitPrice = Convert.ToDecimal(textBox_Update_UnitPrice.Text)
            };

            productDal.Update(product);
            LoadProducts();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            productDal.Delete(id);
            LoadProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
