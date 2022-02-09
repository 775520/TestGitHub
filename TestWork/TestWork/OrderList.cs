using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWork
{
    public partial class OrderList : Form
    {小六啊啊啊 啊啊
        public OrderList()
        {
            InitializeComponent();
        }
        List<OrderExcel> Order = new List<OrderExcel>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Order = UIUtils.SelectOrder();

            GridView1.AutoGenerateColumns = false;

            GridView1.DataSource = Order;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string OrderNo = TfOrderNo.Text;
            string Customer = TfCustomer.Text;
            string DateTime = dateTimePicker1.Value.ToShortDateString();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Order deatils = new Order(GridView1.CurrentRow);
            deatils.Show();      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewWord deatils = new NewWord();
            deatils.Show();
        }
    }
}
