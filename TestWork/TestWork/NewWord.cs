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
    public partial class NewWord : Form
    {
        public NewWord()
        {
            InitializeComponent();
        }

        private void NewWord_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<OrderExcel> ExcleList = new List<OrderExcel>();
            List<OrderReamrk> OrderList = new List<OrderReamrk>();
            int Count = 0;
            for (int i = 0; i < OrderdataGridView.Rows.Count; i++)
            {
                if (OrderdataGridView.Rows[i].Cells["OrderNo"].Value != null)
                {
                    Count += i;
                }
            }

            for (int i = 0; i < Count; i++)
            {
                
            }



            Guid guid = new Guid();
            OrderExcel excel = new OrderExcel();
            excel.LocalOrderHeadId = guid.ToString();
            excel.OrderData = DateTime.Now.ToString("yyyy-MM-dd");
            if (OrderdataGridView.Rows[0].Cells["Customer"].Value != null)
            {
                excel.Customer = OrderdataGridView.Rows[0].Cells["Customer"].Value.ToString();
            }
            if (OrderdataGridView.Rows[0].Cells["ItemNo"].Value != null)
            {
                excel.ItemNo = OrderdataGridView.Rows[0].Cells["ItemNo"].Value.ToString();
            }
            
            excel.OrderNo = OrderdataGridView.Rows[0].Cells["OrderNo"].Value.ToString();
            excel.OrderOriNo = OrderdataGridView.Rows[0].Cells["OrderOriNo"].Value.ToString();
            excel.SendNum = OrderdataGridView.Rows[0].Cells["SendNum"].Value.ToString();
            excel.SurplusNum = OrderdataGridView.Rows[0].Cells["SurplusNum"].Value.ToString();
            excel.TotalNum = OrderdataGridView.Rows[0].Cells["TotalNum"].Value.ToString();
            excel.Ocean07A = OrderdataGridView.Rows[0].Cells["Ocean07A"].Value.ToString();
            excel.Ocean07B = OrderdataGridView.Rows[0].Cells["Ocean07B"].Value.ToString();
            excel.Ocean07C = OrderdataGridView.Rows[0].Cells["Ocean07C"].Value.ToString();
            excel.Ocean07D = OrderdataGridView.Rows[0].Cells["Ocean07D"].Value.ToString();
            excel.Ocean07E = OrderdataGridView.Rows[0].Cells["Ocean07E"].Value.ToString();



            OrderReamrk reamrk = new OrderReamrk();               
            reamrk.Jan = RemarkdataGridView.Rows[0].Cells["Jan"].Value.ToString();//1
            reamrk.Feb = RemarkdataGridView.Rows[0].Cells["Feb"].Value.ToString();//2
            reamrk.Mar = RemarkdataGridView.Rows[0].Cells["Mar"].Value.ToString();
            reamrk.Apr = RemarkdataGridView.Rows[0].Cells["Apr"].Value.ToString();
            reamrk.May = RemarkdataGridView.Rows[0].Cells["May"].Value.ToString();
            reamrk.Jun = RemarkdataGridView.Rows[0].Cells["Jun"].Value.ToString();
            reamrk.Jul = RemarkdataGridView.Rows[0].Cells["Jul"].Value.ToString();
            reamrk.Aug = RemarkdataGridView.Rows[0].Cells["Aug"].Value.ToString();
            reamrk.Sep = RemarkdataGridView.Rows[0].Cells["Sep"].Value.ToString();
            reamrk.Oct = RemarkdataGridView.Rows[0].Cells["Oct"].Value.ToString();
            reamrk.Nov = RemarkdataGridView.Rows[0].Cells["Nov"].Value.ToString();
            reamrk.Dec = RemarkdataGridView.Rows[0].Cells["Dec"].Value.ToString();
            reamrk.Remark1 = RemarkdataGridView.Rows[0].Cells["Remark1"].Value.ToString();          
            reamrk.Remark2 = RemarkdataGridView.Rows[0].Cells["Remark2"].Value.ToString();
            reamrk.Remark3 = RemarkdataGridView.Rows[0].Cells["Remark3"].Value.ToString();
            reamrk.Remark4 = RemarkdataGridView.Rows[0].Cells["Remark4"].Value.ToString();
            reamrk.Remark5 = RemarkdataGridView.Rows[0].Cells["Remark5"].Value.ToString();
            reamrk.Remark6 = RemarkdataGridView.Rows[0].Cells["Remark6"].Value.ToString();
            reamrk.Remark7 = RemarkdataGridView.Rows[0].Cells["Remark7"].Value.ToString();
            reamrk.Remark8 = RemarkdataGridView.Rows[0].Cells["Remark8"].Value.ToString();
            reamrk.Remark9 = RemarkdataGridView.Rows[0].Cells["Remark9"].Value.ToString();
            reamrk.Remark10 = RemarkdataGridView.Rows[0].Cells["Remark10"].Value.ToString();
            reamrk.Remark11 = RemarkdataGridView.Rows[0].Cells["Remark11"].Value.ToString();
            reamrk.Remark12 = RemarkdataGridView.Rows[0].Cells["Remark12"].Value.ToString();
            reamrk.LocalheadId = guid.ToString();
            excel.reamrk = reamrk;

            string Result = UIUtils.InsertOrder(excel);

            MessageBox.Show("成功");

        }
    }
}
