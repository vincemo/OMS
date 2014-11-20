namespace OSM
{
    partial class OSM_Order_Delivery_Aduit_Form
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Order_Delivery = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Date = new System.Windows.Forms.Label();
            this.comboBox_OrderState = new System.Windows.Forms.ComboBox();
            this.label_OrderState = new System.Windows.Forms.Label();
            this.dateTimePicker_OrderDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Query = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_PayState = new System.Windows.Forms.Label();
            this.comboBox_PayState = new System.Windows.Forms.ComboBox();
            this.dataGridView_Order = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_STATE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAY_STATE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQUIRE_PAYMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewOrderBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.auditBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.OSM_Pager_Order = new OSM.OSM_Pager();
            this.groupBox_Order_Delivery.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Order_Delivery
            // 
            this.groupBox_Order_Delivery.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_Order_Delivery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_Order_Delivery.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Order_Delivery.Name = "groupBox_Order_Delivery";
            this.groupBox_Order_Delivery.Size = new System.Drawing.Size(262, 493);
            this.groupBox_Order_Delivery.TabIndex = 4;
            this.groupBox_Order_Delivery.TabStop = false;
            this.groupBox_Order_Delivery.Text = "订单查询条件";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label_Date, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_OrderState, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_OrderState, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_OrderDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_PayState, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_PayState, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(249, 171);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label_Date
            // 
            this.label_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(21, 12);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(32, 17);
            this.label_Date.TabIndex = 0;
            this.label_Date.Text = "日期";
            // 
            // comboBox_OrderState
            // 
            this.comboBox_OrderState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_OrderState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OrderState.FormattingEnabled = true;
            this.comboBox_OrderState.Location = new System.Drawing.Point(85, 53);
            this.comboBox_OrderState.Name = "comboBox_OrderState";
            this.comboBox_OrderState.Size = new System.Drawing.Size(152, 25);
            this.comboBox_OrderState.TabIndex = 3;
            // 
            // label_OrderState
            // 
            this.label_OrderState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_OrderState.AutoSize = true;
            this.label_OrderState.Location = new System.Drawing.Point(9, 54);
            this.label_OrderState.Name = "label_OrderState";
            this.label_OrderState.Size = new System.Drawing.Size(56, 17);
            this.label_OrderState.TabIndex = 2;
            this.label_OrderState.Text = "订单状态";
            // 
            // dateTimePicker_OrderDate
            // 
            this.dateTimePicker_OrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_OrderDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_OrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_OrderDate.Location = new System.Drawing.Point(85, 9);
            this.dateTimePicker_OrderDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_OrderDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_OrderDate.Name = "dateTimePicker_OrderDate";
            this.dateTimePicker_OrderDate.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker_OrderDate.TabIndex = 1;
            this.dateTimePicker_OrderDate.Value = new System.DateTime(2014, 10, 8, 0, 0, 0, 0);
            this.dateTimePicker_OrderDate.DropDown += new System.EventHandler(this.dateTimePicker_OrderDate_DropDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_Query, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Reset, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(77, 129);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(169, 37);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // button_Query
            // 
            this.button_Query.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Query.Location = new System.Drawing.Point(7, 7);
            this.button_Query.Name = "button_Query";
            this.button_Query.Size = new System.Drawing.Size(70, 23);
            this.button_Query.TabIndex = 0;
            this.button_Query.Text = "查询";
            this.button_Query.UseVisualStyleBackColor = true;
            this.button_Query.Click += new System.EventHandler(this.button_Query_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Reset.Location = new System.Drawing.Point(91, 7);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(70, 23);
            this.button_Reset.TabIndex = 1;
            this.button_Reset.Text = "重置";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label_PayState
            // 
            this.label_PayState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PayState.AutoSize = true;
            this.label_PayState.Location = new System.Drawing.Point(9, 96);
            this.label_PayState.Name = "label_PayState";
            this.label_PayState.Size = new System.Drawing.Size(56, 17);
            this.label_PayState.TabIndex = 5;
            this.label_PayState.Text = "付款状态";
            // 
            // comboBox_PayState
            // 
            this.comboBox_PayState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_PayState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PayState.FormattingEnabled = true;
            this.comboBox_PayState.Location = new System.Drawing.Point(85, 95);
            this.comboBox_PayState.Name = "comboBox_PayState";
            this.comboBox_PayState.Size = new System.Drawing.Size(152, 25);
            this.comboBox_PayState.TabIndex = 6;
            // 
            // dataGridView_Order
            // 
            this.dataGridView_Order.AllowUserToAddRows = false;
            this.dataGridView_Order.AllowUserToDeleteRows = false;
            this.dataGridView_Order.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.OFFERSHEET_CODE,
            this.ORDER_STATE_DESC,
            this.ORDER_DATE,
            this.PAY_STATE_DESC,
            this.REQUIRE_PAYMENT,
            this.viewOrderBtn,
            this.auditBtn});
            this.dataGridView_Order.Location = new System.Drawing.Point(271, 25);
            this.dataGridView_Order.Name = "dataGridView_Order";
            this.dataGridView_Order.ReadOnly = true;
            this.dataGridView_Order.RowTemplate.Height = 23;
            this.dataGridView_Order.Size = new System.Drawing.Size(750, 443);
            this.dataGridView_Order.TabIndex = 5;
            this.dataGridView_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Order_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // OFFERSHEET_CODE
            // 
            this.OFFERSHEET_CODE.DataPropertyName = "OFFERSHEET_CODE";
            this.OFFERSHEET_CODE.HeaderText = "报价单编号";
            this.OFFERSHEET_CODE.Name = "OFFERSHEET_CODE";
            this.OFFERSHEET_CODE.ReadOnly = true;
            this.OFFERSHEET_CODE.Width = 140;
            // 
            // ORDER_STATE_DESC
            // 
            this.ORDER_STATE_DESC.DataPropertyName = "ORDER_STATE_DESC";
            this.ORDER_STATE_DESC.HeaderText = "订单状态";
            this.ORDER_STATE_DESC.Name = "ORDER_STATE_DESC";
            this.ORDER_STATE_DESC.ReadOnly = true;
            this.ORDER_STATE_DESC.Width = 80;
            // 
            // ORDER_DATE
            // 
            this.ORDER_DATE.DataPropertyName = "ORDER_DATE";
            this.ORDER_DATE.HeaderText = "订单日期";
            this.ORDER_DATE.Name = "ORDER_DATE";
            this.ORDER_DATE.ReadOnly = true;
            this.ORDER_DATE.Width = 80;
            // 
            // PAY_STATE_DESC
            // 
            this.PAY_STATE_DESC.DataPropertyName = "PAY_STATE_DESC";
            this.PAY_STATE_DESC.HeaderText = "付款状态";
            this.PAY_STATE_DESC.Name = "PAY_STATE_DESC";
            this.PAY_STATE_DESC.ReadOnly = true;
            // 
            // REQUIRE_PAYMENT
            // 
            this.REQUIRE_PAYMENT.DataPropertyName = "REQUIRE_PAYMENT";
            this.REQUIRE_PAYMENT.HeaderText = "总价";
            this.REQUIRE_PAYMENT.Name = "REQUIRE_PAYMENT";
            this.REQUIRE_PAYMENT.ReadOnly = true;
            // 
            // viewOrderBtn
            // 
            this.viewOrderBtn.HeaderText = "";
            this.viewOrderBtn.Name = "viewOrderBtn";
            this.viewOrderBtn.ReadOnly = true;
            this.viewOrderBtn.Text = "查看订单";
            this.viewOrderBtn.UseColumnTextForLinkValue = true;
            // 
            // auditBtn
            // 
            this.auditBtn.HeaderText = "";
            this.auditBtn.Name = "auditBtn";
            this.auditBtn.ReadOnly = true;
            this.auditBtn.Text = "订单发货审核";
            this.auditBtn.UseColumnTextForLinkValue = true;
            // 
            // OSM_Pager_Order
            // 
            this.OSM_Pager_Order.Location = new System.Drawing.Point(271, 474);
            this.OSM_Pager_Order.Name = "OSM_Pager_Order";
            this.OSM_Pager_Order.Size = new System.Drawing.Size(750, 30);
            this.OSM_Pager_Order.TabIndex = 6;
            // 
            // OSM_Order_Delivery_Aduit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OSM_Pager_Order);
            this.Controls.Add(this.dataGridView_Order);
            this.Controls.Add(this.groupBox_Order_Delivery);
            this.Name = "OSM_Order_Delivery_Aduit_Form";
            this.Size = new System.Drawing.Size(1024, 510);
            this.groupBox_Order_Delivery.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Order_Delivery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.ComboBox comboBox_OrderState;
        private System.Windows.Forms.Label label_OrderState;
        private System.Windows.Forms.DateTimePicker dateTimePicker_OrderDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Query;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label_PayState;
        private System.Windows.Forms.ComboBox comboBox_PayState;
        private System.Windows.Forms.DataGridView dataGridView_Order;
        private OSM_Pager OSM_Pager_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_STATE_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAY_STATE_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQUIRE_PAYMENT;
        private System.Windows.Forms.DataGridViewLinkColumn viewOrderBtn;
        private System.Windows.Forms.DataGridViewLinkColumn auditBtn;
    }
}
