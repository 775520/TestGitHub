
namespace TestWork
{
    partial class Order
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.janDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.febDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.junDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.julDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.augDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.octDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderReamrkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localOrderHeadIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocean07DDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocean07EDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderExcelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderReamrkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderExcelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.localOrderHeadIdDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.ocean07DDataGridViewTextBoxColumn,
            this.ocean07EDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderExcelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 43;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1477, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OrderData";
            this.Column1.HeaderText = "下单时间";
            this.Column1.Name = "Column1";
            this.Column1.Width = 105;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "OrderNo";
            this.Column2.HeaderText = "订单流水号";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "OrderOriNo";
            this.Column3.HeaderText = "客户订单号";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Customer";
            this.Column4.HeaderText = "客户型号";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ItemNo";
            this.Column5.HeaderText = "大谷型号";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TotalNum";
            this.Column6.HeaderText = "总件数";
            this.Column6.Name = "Column6";
            this.Column6.Width = 105;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SendNum";
            this.Column7.HeaderText = "已发数量";
            this.Column7.Name = "Column7";
            this.Column7.Width = 105;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "SurplusNum";
            this.Column8.HeaderText = "剩余数量";
            this.Column8.Name = "Column8";
            this.Column8.Width = 105;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Ocean07A";
            this.Column9.HeaderText = "海运A";
            this.Column9.Name = "Column9";
            this.Column9.Width = 105;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Ocean07B";
            this.Column10.HeaderText = "海运B";
            this.Column10.Name = "Column10";
            this.Column10.Width = 105;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Ocean07C";
            this.Column11.HeaderText = "海运C";
            this.Column11.Name = "Column11";
            this.Column11.Width = 105;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.janDataGridViewTextBoxColumn,
            this.remark1DataGridViewTextBoxColumn,
            this.febDataGridViewTextBoxColumn,
            this.remark2DataGridViewTextBoxColumn,
            this.marDataGridViewTextBoxColumn,
            this.remark3DataGridViewTextBoxColumn,
            this.aprDataGridViewTextBoxColumn,
            this.remark4DataGridViewTextBoxColumn,
            this.mayDataGridViewTextBoxColumn,
            this.remark5DataGridViewTextBoxColumn,
            this.junDataGridViewTextBoxColumn,
            this.remark6DataGridViewTextBoxColumn,
            this.julDataGridViewTextBoxColumn,
            this.remark7DataGridViewTextBoxColumn,
            this.augDataGridViewTextBoxColumn,
            this.remark8DataGridViewTextBoxColumn,
            this.sepDataGridViewTextBoxColumn,
            this.remark9DataGridViewTextBoxColumn,
            this.octDataGridViewTextBoxColumn,
            this.remark10DataGridViewTextBoxColumn,
            this.novDataGridViewTextBoxColumn,
            this.remark11DataGridViewTextBoxColumn,
            this.decDataGridViewTextBoxColumn,
            this.remark12DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderReamrkBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(2, 197);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 43;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1534, 212);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "保  存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // janDataGridViewTextBoxColumn
            // 
            this.janDataGridViewTextBoxColumn.DataPropertyName = "Jan";
            this.janDataGridViewTextBoxColumn.HeaderText = "一月";
            this.janDataGridViewTextBoxColumn.Name = "janDataGridViewTextBoxColumn";
            this.janDataGridViewTextBoxColumn.Width = 105;
            // 
            // remark1DataGridViewTextBoxColumn
            // 
            this.remark1DataGridViewTextBoxColumn.DataPropertyName = "Remark1";
            this.remark1DataGridViewTextBoxColumn.HeaderText = "备注1";
            this.remark1DataGridViewTextBoxColumn.Name = "remark1DataGridViewTextBoxColumn";
            this.remark1DataGridViewTextBoxColumn.Width = 105;
            // 
            // febDataGridViewTextBoxColumn
            // 
            this.febDataGridViewTextBoxColumn.DataPropertyName = "Feb";
            this.febDataGridViewTextBoxColumn.HeaderText = "二月";
            this.febDataGridViewTextBoxColumn.Name = "febDataGridViewTextBoxColumn";
            this.febDataGridViewTextBoxColumn.Width = 105;
            // 
            // remark2DataGridViewTextBoxColumn
            // 
            this.remark2DataGridViewTextBoxColumn.DataPropertyName = "Remark2";
            this.remark2DataGridViewTextBoxColumn.HeaderText = "备注2";
            this.remark2DataGridViewTextBoxColumn.Name = "remark2DataGridViewTextBoxColumn";
            this.remark2DataGridViewTextBoxColumn.Width = 105;
            // 
            // marDataGridViewTextBoxColumn
            // 
            this.marDataGridViewTextBoxColumn.DataPropertyName = "Mar";
            this.marDataGridViewTextBoxColumn.HeaderText = "三月";
            this.marDataGridViewTextBoxColumn.Name = "marDataGridViewTextBoxColumn";
            this.marDataGridViewTextBoxColumn.Width = 105;
            // 
            // remark3DataGridViewTextBoxColumn
            // 
            this.remark3DataGridViewTextBoxColumn.DataPropertyName = "Remark3";
            this.remark3DataGridViewTextBoxColumn.HeaderText = "备注3";
            this.remark3DataGridViewTextBoxColumn.Name = "remark3DataGridViewTextBoxColumn";
            this.remark3DataGridViewTextBoxColumn.Width = 105;
            // 
            // aprDataGridViewTextBoxColumn
            // 
            this.aprDataGridViewTextBoxColumn.DataPropertyName = "Apr";
            this.aprDataGridViewTextBoxColumn.HeaderText = "四月";
            this.aprDataGridViewTextBoxColumn.Name = "aprDataGridViewTextBoxColumn";
            this.aprDataGridViewTextBoxColumn.Width = 105;
            // 
            // remark4DataGridViewTextBoxColumn
            // 
            this.remark4DataGridViewTextBoxColumn.DataPropertyName = "Remark4";
            this.remark4DataGridViewTextBoxColumn.HeaderText = "备注4";
            this.remark4DataGridViewTextBoxColumn.Name = "remark4DataGridViewTextBoxColumn";
            this.remark4DataGridViewTextBoxColumn.Width = 105;
            // 
            // mayDataGridViewTextBoxColumn
            // 
            this.mayDataGridViewTextBoxColumn.DataPropertyName = "May";
            this.mayDataGridViewTextBoxColumn.HeaderText = "五月";
            this.mayDataGridViewTextBoxColumn.Name = "mayDataGridViewTextBoxColumn";
            this.mayDataGridViewTextBoxColumn.Width = 105;
            // 
            // remark5DataGridViewTextBoxColumn
            // 
            this.remark5DataGridViewTextBoxColumn.DataPropertyName = "Remark5";
            this.remark5DataGridViewTextBoxColumn.HeaderText = "备注5";
            this.remark5DataGridViewTextBoxColumn.Name = "remark5DataGridViewTextBoxColumn";
            this.remark5DataGridViewTextBoxColumn.Width = 105;
            // 
            // junDataGridViewTextBoxColumn
            // 
            this.junDataGridViewTextBoxColumn.DataPropertyName = "Jun";
            this.junDataGridViewTextBoxColumn.HeaderText = "六月";
            this.junDataGridViewTextBoxColumn.Name = "junDataGridViewTextBoxColumn";
            this.junDataGridViewTextBoxColumn.Width = 105;
            // 
            // remark6DataGridViewTextBoxColumn
            // 
            this.remark6DataGridViewTextBoxColumn.DataPropertyName = "Remark6";
            this.remark6DataGridViewTextBoxColumn.HeaderText = "备注6";
            this.remark6DataGridViewTextBoxColumn.Name = "remark6DataGridViewTextBoxColumn";
            this.remark6DataGridViewTextBoxColumn.Width = 105;
            // 
            // julDataGridViewTextBoxColumn
            // 
            this.julDataGridViewTextBoxColumn.DataPropertyName = "Jul";
            this.julDataGridViewTextBoxColumn.HeaderText = "七月";
            this.julDataGridViewTextBoxColumn.Name = "julDataGridViewTextBoxColumn";
            this.julDataGridViewTextBoxColumn.Width = 105;
            // 
            // remark7DataGridViewTextBoxColumn
            // 
            this.remark7DataGridViewTextBoxColumn.DataPropertyName = "Remark7";
            this.remark7DataGridViewTextBoxColumn.HeaderText = "备注7";
            this.remark7DataGridViewTextBoxColumn.Name = "remark7DataGridViewTextBoxColumn";
            this.remark7DataGridViewTextBoxColumn.Width = 105;
            // 
            // augDataGridViewTextBoxColumn
            // 
            this.augDataGridViewTextBoxColumn.DataPropertyName = "Aug";
            this.augDataGridViewTextBoxColumn.HeaderText = "八月";
            this.augDataGridViewTextBoxColumn.Name = "augDataGridViewTextBoxColumn";
            this.augDataGridViewTextBoxColumn.Width = 105;
            // 
            // remark8DataGridViewTextBoxColumn
            // 
            this.remark8DataGridViewTextBoxColumn.DataPropertyName = "Remark8";
            this.remark8DataGridViewTextBoxColumn.HeaderText = "备注8";
            this.remark8DataGridViewTextBoxColumn.Name = "remark8DataGridViewTextBoxColumn";
            this.remark8DataGridViewTextBoxColumn.Width = 105;
            // 
            // sepDataGridViewTextBoxColumn
            // 
            this.sepDataGridViewTextBoxColumn.DataPropertyName = "Sep";
            this.sepDataGridViewTextBoxColumn.HeaderText = "九月";
            this.sepDataGridViewTextBoxColumn.Name = "sepDataGridViewTextBoxColumn";
            this.sepDataGridViewTextBoxColumn.Width = 105;
            // 
            // remark9DataGridViewTextBoxColumn
            // 
            this.remark9DataGridViewTextBoxColumn.DataPropertyName = "Remark9";
            this.remark9DataGridViewTextBoxColumn.HeaderText = "备注9";
            this.remark9DataGridViewTextBoxColumn.Name = "remark9DataGridViewTextBoxColumn";
            this.remark9DataGridViewTextBoxColumn.Width = 105;
            // 
            // octDataGridViewTextBoxColumn
            // 
            this.octDataGridViewTextBoxColumn.DataPropertyName = "Oct";
            this.octDataGridViewTextBoxColumn.HeaderText = "十月";
            this.octDataGridViewTextBoxColumn.Name = "octDataGridViewTextBoxColumn";
            this.octDataGridViewTextBoxColumn.Width = 105;
            // 
            // remark10DataGridViewTextBoxColumn
            // 
            this.remark10DataGridViewTextBoxColumn.DataPropertyName = "Remark10";
            this.remark10DataGridViewTextBoxColumn.HeaderText = "备注10";
            this.remark10DataGridViewTextBoxColumn.Name = "remark10DataGridViewTextBoxColumn";
            this.remark10DataGridViewTextBoxColumn.Width = 105;
            // 
            // novDataGridViewTextBoxColumn
            // 
            this.novDataGridViewTextBoxColumn.DataPropertyName = "Nov";
            this.novDataGridViewTextBoxColumn.HeaderText = "十一月";
            this.novDataGridViewTextBoxColumn.Name = "novDataGridViewTextBoxColumn";
            this.novDataGridViewTextBoxColumn.Width = 105;
            // 
            // remark11DataGridViewTextBoxColumn
            // 
            this.remark11DataGridViewTextBoxColumn.DataPropertyName = "Remark11";
            this.remark11DataGridViewTextBoxColumn.HeaderText = "备注11";
            this.remark11DataGridViewTextBoxColumn.Name = "remark11DataGridViewTextBoxColumn";
            this.remark11DataGridViewTextBoxColumn.Width = 105;
            // 
            // decDataGridViewTextBoxColumn
            // 
            this.decDataGridViewTextBoxColumn.DataPropertyName = "Dec";
            this.decDataGridViewTextBoxColumn.HeaderText = "十二月";
            this.decDataGridViewTextBoxColumn.Name = "decDataGridViewTextBoxColumn";
            this.decDataGridViewTextBoxColumn.Width = 105;
            // 
            // remark12DataGridViewTextBoxColumn
            // 
            this.remark12DataGridViewTextBoxColumn.DataPropertyName = "Remark12";
            this.remark12DataGridViewTextBoxColumn.HeaderText = "备注12";
            this.remark12DataGridViewTextBoxColumn.Name = "remark12DataGridViewTextBoxColumn";
            this.remark12DataGridViewTextBoxColumn.Width = 105;
            // 
            // orderReamrkBindingSource
            // 
            this.orderReamrkBindingSource.DataSource = typeof(TestWork.OrderReamrk);
            // 
            // localOrderHeadIdDataGridViewTextBoxColumn
            // 
            this.localOrderHeadIdDataGridViewTextBoxColumn.DataPropertyName = "LocalOrderHeadId";
            this.localOrderHeadIdDataGridViewTextBoxColumn.HeaderText = "LocalOrderHeadId";
            this.localOrderHeadIdDataGridViewTextBoxColumn.Name = "localOrderHeadIdDataGridViewTextBoxColumn";
            this.localOrderHeadIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.localOrderHeadIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.localOrderHeadIdDataGridViewTextBoxColumn.Visible = false;
            this.localOrderHeadIdDataGridViewTextBoxColumn.Width = 105;
            // 
            // ocean07DDataGridViewTextBoxColumn
            // 
            this.ocean07DDataGridViewTextBoxColumn.DataPropertyName = "Ocean07D";
            this.ocean07DDataGridViewTextBoxColumn.HeaderText = "海运D";
            this.ocean07DDataGridViewTextBoxColumn.Name = "ocean07DDataGridViewTextBoxColumn";
            this.ocean07DDataGridViewTextBoxColumn.Width = 105;
            // 
            // ocean07EDataGridViewTextBoxColumn
            // 
            this.ocean07EDataGridViewTextBoxColumn.DataPropertyName = "Ocean07E";
            this.ocean07EDataGridViewTextBoxColumn.HeaderText = "海运E";
            this.ocean07EDataGridViewTextBoxColumn.Name = "ocean07EDataGridViewTextBoxColumn";
            this.ocean07EDataGridViewTextBoxColumn.Width = 105;
            // 
            // orderExcelBindingSource
            // 
            this.orderExcelBindingSource.DataSource = typeof(TestWork.OrderExcel);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("宋体", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Order";
            this.Text = "详情界面";
            this.Load += new System.EventHandler(this.OrderDeatils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderReamrkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderExcelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderExcelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn localOrderHeadIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocean07DDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocean07EDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn janDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn febDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn junDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn julDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn augDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn octDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn novDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark12DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderReamrkBindingSource;
        private System.Windows.Forms.Button button1;
    }
}