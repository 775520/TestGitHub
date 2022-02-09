
namespace TestWork
{
    partial class OrderList
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TfOrderNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TfCustomer = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.localOrderHeadIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderOriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surplusNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocean07ADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocean07BDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocean07CDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocean07DDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocean07EDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderExcelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderExcelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单流水号：";
            // 
            // TfOrderNo
            // 
            this.TfOrderNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TfOrderNo.Location = new System.Drawing.Point(167, 28);
            this.TfOrderNo.Name = "TfOrderNo";
            this.TfOrderNo.Size = new System.Drawing.Size(212, 27);
            this.TfOrderNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(387, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "客户订单号：";
            // 
            // TfCustomer
            // 
            this.TfCustomer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TfCustomer.Location = new System.Drawing.Point(553, 28);
            this.TfCustomer.Name = "TfCustomer";
            this.TfCustomer.Size = new System.Drawing.Size(235, 27);
            this.TfCustomer.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Location = new System.Drawing.Point(944, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(798, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "下单时间：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1350, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "查 询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridView1
            // 
            this.GridView1.AllowUserToAddRows = false;
            this.GridView1.AutoGenerateColumns = false;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.localOrderHeadIdDataGridViewTextBoxColumn,
            this.orderDataDataGridViewTextBoxColumn,
            this.orderNoDataGridViewTextBoxColumn,
            this.orderOriNoDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.itemNoDataGridViewTextBoxColumn,
            this.totalNumDataGridViewTextBoxColumn,
            this.sendNumDataGridViewTextBoxColumn,
            this.surplusNumDataGridViewTextBoxColumn,
            this.ocean07ADataGridViewTextBoxColumn,
            this.ocean07BDataGridViewTextBoxColumn,
            this.ocean07CDataGridViewTextBoxColumn,
            this.ocean07DDataGridViewTextBoxColumn,
            this.ocean07EDataGridViewTextBoxColumn});
            this.GridView1.DataSource = this.orderExcelBindingSource1;
            this.GridView1.Location = new System.Drawing.Point(20, 76);
            this.GridView1.Name = "GridView1";
            this.GridView1.RowHeadersWidth = 43;
            this.GridView1.RowTemplate.Height = 23;
            this.GridView1.Size = new System.Drawing.Size(1609, 665);
            this.GridView1.TabIndex = 7;
            this.GridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(1539, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "新 增";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // localOrderHeadIdDataGridViewTextBoxColumn
            // 
            this.localOrderHeadIdDataGridViewTextBoxColumn.DataPropertyName = "LocalOrderHeadId";
            this.localOrderHeadIdDataGridViewTextBoxColumn.HeaderText = "LocalOrderHeadId";
            this.localOrderHeadIdDataGridViewTextBoxColumn.Name = "localOrderHeadIdDataGridViewTextBoxColumn";
            this.localOrderHeadIdDataGridViewTextBoxColumn.Visible = false;
            this.localOrderHeadIdDataGridViewTextBoxColumn.Width = 105;
            // 
            // orderDataDataGridViewTextBoxColumn
            // 
            this.orderDataDataGridViewTextBoxColumn.DataPropertyName = "OrderData";
            this.orderDataDataGridViewTextBoxColumn.HeaderText = "下单时间";
            this.orderDataDataGridViewTextBoxColumn.Name = "orderDataDataGridViewTextBoxColumn";
            this.orderDataDataGridViewTextBoxColumn.Width = 105;
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "订单流水号";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.Width = 120;
            // 
            // orderOriNoDataGridViewTextBoxColumn
            // 
            this.orderOriNoDataGridViewTextBoxColumn.DataPropertyName = "OrderOriNo";
            this.orderOriNoDataGridViewTextBoxColumn.HeaderText = "客户订单号";
            this.orderOriNoDataGridViewTextBoxColumn.Name = "orderOriNoDataGridViewTextBoxColumn";
            this.orderOriNoDataGridViewTextBoxColumn.Width = 120;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "客户型号";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 120;
            // 
            // itemNoDataGridViewTextBoxColumn
            // 
            this.itemNoDataGridViewTextBoxColumn.DataPropertyName = "ItemNo";
            this.itemNoDataGridViewTextBoxColumn.HeaderText = "大谷型号";
            this.itemNoDataGridViewTextBoxColumn.Name = "itemNoDataGridViewTextBoxColumn";
            this.itemNoDataGridViewTextBoxColumn.Width = 105;
            // 
            // totalNumDataGridViewTextBoxColumn
            // 
            this.totalNumDataGridViewTextBoxColumn.DataPropertyName = "TotalNum";
            this.totalNumDataGridViewTextBoxColumn.HeaderText = "总件数";
            this.totalNumDataGridViewTextBoxColumn.Name = "totalNumDataGridViewTextBoxColumn";
            this.totalNumDataGridViewTextBoxColumn.Width = 105;
            // 
            // sendNumDataGridViewTextBoxColumn
            // 
            this.sendNumDataGridViewTextBoxColumn.DataPropertyName = "SendNum";
            this.sendNumDataGridViewTextBoxColumn.HeaderText = "已发送数";
            this.sendNumDataGridViewTextBoxColumn.Name = "sendNumDataGridViewTextBoxColumn";
            this.sendNumDataGridViewTextBoxColumn.Width = 105;
            // 
            // surplusNumDataGridViewTextBoxColumn
            // 
            this.surplusNumDataGridViewTextBoxColumn.DataPropertyName = "SurplusNum";
            this.surplusNumDataGridViewTextBoxColumn.HeaderText = "剩余数量";
            this.surplusNumDataGridViewTextBoxColumn.Name = "surplusNumDataGridViewTextBoxColumn";
            this.surplusNumDataGridViewTextBoxColumn.Width = 105;
            // 
            // ocean07ADataGridViewTextBoxColumn
            // 
            this.ocean07ADataGridViewTextBoxColumn.DataPropertyName = "Ocean07A";
            this.ocean07ADataGridViewTextBoxColumn.HeaderText = "海运A";
            this.ocean07ADataGridViewTextBoxColumn.Name = "ocean07ADataGridViewTextBoxColumn";
            this.ocean07ADataGridViewTextBoxColumn.Width = 120;
            // 
            // ocean07BDataGridViewTextBoxColumn
            // 
            this.ocean07BDataGridViewTextBoxColumn.DataPropertyName = "Ocean07B";
            this.ocean07BDataGridViewTextBoxColumn.HeaderText = "海运B";
            this.ocean07BDataGridViewTextBoxColumn.Name = "ocean07BDataGridViewTextBoxColumn";
            this.ocean07BDataGridViewTextBoxColumn.Width = 120;
            // 
            // ocean07CDataGridViewTextBoxColumn
            // 
            this.ocean07CDataGridViewTextBoxColumn.DataPropertyName = "Ocean07C";
            this.ocean07CDataGridViewTextBoxColumn.HeaderText = "海运C";
            this.ocean07CDataGridViewTextBoxColumn.Name = "ocean07CDataGridViewTextBoxColumn";
            this.ocean07CDataGridViewTextBoxColumn.Width = 120;
            // 
            // ocean07DDataGridViewTextBoxColumn
            // 
            this.ocean07DDataGridViewTextBoxColumn.DataPropertyName = "Ocean07D";
            this.ocean07DDataGridViewTextBoxColumn.HeaderText = "海运D";
            this.ocean07DDataGridViewTextBoxColumn.Name = "ocean07DDataGridViewTextBoxColumn";
            this.ocean07DDataGridViewTextBoxColumn.Width = 120;
            // 
            // ocean07EDataGridViewTextBoxColumn
            // 
            this.ocean07EDataGridViewTextBoxColumn.DataPropertyName = "Ocean07E";
            this.ocean07EDataGridViewTextBoxColumn.HeaderText = "海运E";
            this.ocean07EDataGridViewTextBoxColumn.Name = "ocean07EDataGridViewTextBoxColumn";
            this.ocean07EDataGridViewTextBoxColumn.Width = 120;
            // 
            // orderExcelBindingSource1
            // 
            this.orderExcelBindingSource1.DataSource = typeof(TestWork.OrderExcel);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 762);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TfCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TfOrderNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "OrderList";
            this.Text = "订单列表";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderExcelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TfOrderNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TfCustomer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource orderExcelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn localOrderHeadIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderOriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surplusNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocean07ADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocean07BDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocean07CDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocean07DDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocean07EDataGridViewTextBoxColumn;
    }
}

