
namespace TestWork
{
    partial class NewWord
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
            this.components = new System.ComponentModel.Container();
            this.OrderdataGridView = new System.Windows.Forms.DataGridView();
            this.RemarkdataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Jan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderReamrkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LocalOrderHeadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderOriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurplusNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocean07A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocean07B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocean07C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocean07D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocean07E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderExcelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrderdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarkdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderReamrkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderExcelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderdataGridView
            // 
            this.OrderdataGridView.AutoGenerateColumns = false;
            this.OrderdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocalOrderHeadId,
            this.OrderNo,
            this.OrderOriNo,
            this.Customer,
            this.ItemNo,
            this.TotalNum,
            this.SendNum,
            this.SurplusNum,
            this.Ocean07A,
            this.Ocean07B,
            this.Ocean07C,
            this.Ocean07D,
            this.Ocean07E});
            this.OrderdataGridView.DataSource = this.orderExcelBindingSource;
            this.OrderdataGridView.Location = new System.Drawing.Point(2, 14);
            this.OrderdataGridView.Name = "OrderdataGridView";
            this.OrderdataGridView.RowHeadersWidth = 43;
            this.OrderdataGridView.RowTemplate.Height = 23;
            this.OrderdataGridView.Size = new System.Drawing.Size(1428, 208);
            this.OrderdataGridView.TabIndex = 1;
            this.OrderdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RemarkdataGridView
            // 
            this.RemarkdataGridView.AutoGenerateColumns = false;
            this.RemarkdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RemarkdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jan,
            this.Remark1,
            this.Feb,
            this.Remark2,
            this.Mar,
            this.Remark3,
            this.Apr,
            this.Remark4,
            this.May,
            this.Remark5,
            this.Jun,
            this.Remark6,
            this.Jul,
            this.Remark7,
            this.Aug,
            this.Remark8,
            this.Sep,
            this.Remark9,
            this.Oct,
            this.Remark10,
            this.Nov,
            this.Remark11,
            this.Dec,
            this.Remark12});
            this.RemarkdataGridView.DataSource = this.orderReamrkBindingSource;
            this.RemarkdataGridView.Location = new System.Drawing.Point(2, 228);
            this.RemarkdataGridView.Name = "RemarkdataGridView";
            this.RemarkdataGridView.RowHeadersWidth = 43;
            this.RemarkdataGridView.RowTemplate.Height = 24;
            this.RemarkdataGridView.Size = new System.Drawing.Size(1473, 173);
            this.RemarkdataGridView.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.25743F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(722, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "保 存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Jan
            // 
            this.Jan.DataPropertyName = "Jan";
            this.Jan.HeaderText = "一月";
            this.Jan.Name = "Jan";
            this.Jan.Width = 105;
            // 
            // Remark1
            // 
            this.Remark1.DataPropertyName = "Remark1";
            this.Remark1.HeaderText = "备注1";
            this.Remark1.Name = "Remark1";
            this.Remark1.Width = 105;
            // 
            // Feb
            // 
            this.Feb.DataPropertyName = "Feb";
            this.Feb.HeaderText = "二月";
            this.Feb.Name = "Feb";
            this.Feb.Width = 105;
            // 
            // Remark2
            // 
            this.Remark2.DataPropertyName = "Remark2";
            this.Remark2.HeaderText = "备注2";
            this.Remark2.Name = "Remark2";
            this.Remark2.Width = 105;
            // 
            // Mar
            // 
            this.Mar.DataPropertyName = "Mar";
            this.Mar.HeaderText = "三月";
            this.Mar.Name = "Mar";
            this.Mar.Width = 105;
            // 
            // Remark3
            // 
            this.Remark3.DataPropertyName = "Remark3";
            this.Remark3.HeaderText = "备注3";
            this.Remark3.Name = "Remark3";
            this.Remark3.Width = 105;
            // 
            // Apr
            // 
            this.Apr.DataPropertyName = "Apr";
            this.Apr.HeaderText = "四月";
            this.Apr.Name = "Apr";
            this.Apr.Width = 105;
            // 
            // Remark4
            // 
            this.Remark4.DataPropertyName = "Remark4";
            this.Remark4.HeaderText = "备注4";
            this.Remark4.Name = "Remark4";
            this.Remark4.Width = 105;
            // 
            // May
            // 
            this.May.DataPropertyName = "May";
            this.May.HeaderText = "五月";
            this.May.Name = "May";
            this.May.Width = 105;
            // 
            // Remark5
            // 
            this.Remark5.DataPropertyName = "Remark5";
            this.Remark5.HeaderText = "备注5";
            this.Remark5.Name = "Remark5";
            this.Remark5.Width = 105;
            // 
            // Jun
            // 
            this.Jun.DataPropertyName = "Jun";
            this.Jun.HeaderText = "六月";
            this.Jun.Name = "Jun";
            this.Jun.Width = 105;
            // 
            // Remark6
            // 
            this.Remark6.DataPropertyName = "Remark6";
            this.Remark6.HeaderText = "备注6";
            this.Remark6.Name = "Remark6";
            this.Remark6.Width = 105;
            // 
            // Jul
            // 
            this.Jul.DataPropertyName = "Jul";
            this.Jul.HeaderText = "七月";
            this.Jul.Name = "Jul";
            this.Jul.Width = 105;
            // 
            // Remark7
            // 
            this.Remark7.DataPropertyName = "Remark7";
            this.Remark7.HeaderText = "备注7";
            this.Remark7.Name = "Remark7";
            this.Remark7.Width = 105;
            // 
            // Aug
            // 
            this.Aug.DataPropertyName = "Aug";
            this.Aug.HeaderText = "八月";
            this.Aug.Name = "Aug";
            this.Aug.Width = 105;
            // 
            // Remark8
            // 
            this.Remark8.DataPropertyName = "Remark8";
            this.Remark8.HeaderText = "备注8";
            this.Remark8.Name = "Remark8";
            this.Remark8.Width = 105;
            // 
            // Sep
            // 
            this.Sep.DataPropertyName = "Sep";
            this.Sep.HeaderText = "九月";
            this.Sep.Name = "Sep";
            this.Sep.Width = 105;
            // 
            // Remark9
            // 
            this.Remark9.DataPropertyName = "Remark9";
            this.Remark9.HeaderText = "备注9";
            this.Remark9.Name = "Remark9";
            this.Remark9.Width = 105;
            // 
            // Oct
            // 
            this.Oct.DataPropertyName = "Oct";
            this.Oct.HeaderText = "十月";
            this.Oct.Name = "Oct";
            this.Oct.Width = 105;
            // 
            // Remark10
            // 
            this.Remark10.DataPropertyName = "Remark10";
            this.Remark10.HeaderText = "备注10";
            this.Remark10.Name = "Remark10";
            this.Remark10.Width = 105;
            // 
            // Nov
            // 
            this.Nov.DataPropertyName = "Nov";
            this.Nov.HeaderText = "十一月";
            this.Nov.Name = "Nov";
            this.Nov.Width = 105;
            // 
            // Remark11
            // 
            this.Remark11.DataPropertyName = "Remark11";
            this.Remark11.HeaderText = "备注11";
            this.Remark11.Name = "Remark11";
            this.Remark11.Width = 105;
            // 
            // Dec
            // 
            this.Dec.DataPropertyName = "Dec";
            this.Dec.HeaderText = "十二月";
            this.Dec.Name = "Dec";
            this.Dec.Width = 105;
            // 
            // Remark12
            // 
            this.Remark12.DataPropertyName = "Remark12";
            this.Remark12.HeaderText = "备注12";
            this.Remark12.Name = "Remark12";
            this.Remark12.Width = 105;
            // 
            // orderReamrkBindingSource
            // 
            this.orderReamrkBindingSource.DataSource = typeof(TestWork.OrderReamrk);
            // 
            // LocalOrderHeadId
            // 
            this.LocalOrderHeadId.DataPropertyName = "LocalOrderHeadId";
            this.LocalOrderHeadId.HeaderText = "LocalOrderHeadId";
            this.LocalOrderHeadId.Name = "LocalOrderHeadId";
            this.LocalOrderHeadId.Visible = false;
            this.LocalOrderHeadId.Width = 105;
            // 
            // OrderNo
            // 
            this.OrderNo.DataPropertyName = "OrderNo";
            this.OrderNo.HeaderText = "订单流水号";
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.Width = 120;
            // 
            // OrderOriNo
            // 
            this.OrderOriNo.DataPropertyName = "OrderOriNo";
            this.OrderOriNo.HeaderText = "客户订单号";
            this.OrderOriNo.Name = "OrderOriNo";
            this.OrderOriNo.Width = 120;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "客户型号";
            this.Customer.Name = "Customer";
            this.Customer.Width = 110;
            // 
            // ItemNo
            // 
            this.ItemNo.DataPropertyName = "ItemNo";
            this.ItemNo.HeaderText = "大谷型号";
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.Width = 110;
            // 
            // TotalNum
            // 
            this.TotalNum.DataPropertyName = "TotalNum";
            this.TotalNum.HeaderText = "总数量";
            this.TotalNum.Name = "TotalNum";
            this.TotalNum.Width = 105;
            // 
            // SendNum
            // 
            this.SendNum.DataPropertyName = "SendNum";
            this.SendNum.HeaderText = "发送数量";
            this.SendNum.Name = "SendNum";
            this.SendNum.Width = 105;
            // 
            // SurplusNum
            // 
            this.SurplusNum.DataPropertyName = "SurplusNum";
            this.SurplusNum.HeaderText = "剩余数量";
            this.SurplusNum.Name = "SurplusNum";
            this.SurplusNum.Width = 105;
            // 
            // Ocean07A
            // 
            this.Ocean07A.DataPropertyName = "Ocean07A";
            this.Ocean07A.HeaderText = "海运A";
            this.Ocean07A.Name = "Ocean07A";
            this.Ocean07A.Width = 120;
            // 
            // Ocean07B
            // 
            this.Ocean07B.DataPropertyName = "Ocean07B";
            this.Ocean07B.HeaderText = "海运B";
            this.Ocean07B.Name = "Ocean07B";
            this.Ocean07B.Width = 120;
            // 
            // Ocean07C
            // 
            this.Ocean07C.DataPropertyName = "Ocean07C";
            this.Ocean07C.HeaderText = "海运C";
            this.Ocean07C.Name = "Ocean07C";
            this.Ocean07C.Width = 120;
            // 
            // Ocean07D
            // 
            this.Ocean07D.DataPropertyName = "Ocean07D";
            this.Ocean07D.HeaderText = "海运D";
            this.Ocean07D.Name = "Ocean07D";
            this.Ocean07D.Width = 120;
            // 
            // Ocean07E
            // 
            this.Ocean07E.DataPropertyName = "Ocean07E";
            this.Ocean07E.HeaderText = "海运E";
            this.Ocean07E.Name = "Ocean07E";
            this.Ocean07E.Width = 120;
            // 
            // orderExcelBindingSource
            // 
            this.orderExcelBindingSource.DataSource = typeof(TestWork.OrderExcel);
            // 
            // NewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemarkdataGridView);
            this.Controls.Add(this.OrderdataGridView);
            this.Font = new System.Drawing.Font("宋体", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "NewWord";
            this.Text = "新增订单";
            this.Load += new System.EventHandler(this.NewWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarkdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderReamrkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderExcelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderdataGridView;
        private System.Windows.Forms.DataGridView RemarkdataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource orderExcelBindingSource;
        private System.Windows.Forms.BindingSource orderReamrkBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalOrderHeadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderOriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurplusNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocean07A;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocean07B;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocean07C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocean07D;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocean07E;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark4;
        private System.Windows.Forms.DataGridViewTextBoxColumn May;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark12;
    }
}