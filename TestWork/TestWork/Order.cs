using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWork
{
    public partial class Order : Form
    {
        public DataGridViewRow dgvr;
        public Order(DataGridViewRow dgvr1)
        {
            InitializeComponent();
            if (dgvr1 != null)
            {
                dgvr = dgvr1;
                getValue();
            }
        }
        OrderExcel order = new OrderExcel();
        private void OrderDeatils_Load(object sender, EventArgs e)
        {
            if (OrderHeaId != null)
            {
                order = UIUtils.SelectCondition("OrderHeadId", OrderHeaId);
                dataGridView1.DataSource = order;
            }
        }

        string OrderHeaId = null;

        public void getValue()
        {
            OrderHeaId = dgvr.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
