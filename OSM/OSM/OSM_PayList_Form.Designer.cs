namespace OSM
{
    partial class OSM_PayList_Form
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
            this.groupBox_PayList = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Date = new System.Windows.Forms.Label();
            this.comboBox_PayMode = new System.Windows.Forms.ComboBox();
            this.label_OrderState = new System.Windows.Forms.Label();
            this.dateTimePicker_GenDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Query = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_PayState = new System.Windows.Forms.Label();
            this.comboBox_PayState = new System.Windows.Forms.ComboBox();
            this.dataGridView_PayList = new System.Windows.Forms.DataGridView();
            this.OSM_Pager_PayList = new OSM.OSM_Pager();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GEN_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACHIEVE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAY_MODE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAY_STATE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALREADY_PAYMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRE_PAYMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQUIRE_PAYMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewOrderBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox_PayList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PayList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_PayList
            // 
            this.groupBox_PayList.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_PayList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_PayList.Location = new System.Drawing.Point(3, 3);
            this.groupBox_PayList.Name = "groupBox_PayList";
            this.groupBox_PayList.Size = new System.Drawing.Size(262, 493);
            this.groupBox_PayList.TabIndex = 5;
            this.groupBox_PayList.TabStop = false;
            this.groupBox_PayList.Text = "收款单查询条件";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label_Date, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_PayMode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_OrderState, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_GenDate, 1, 0);
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
            this.label_Date.Location = new System.Drawing.Point(9, 12);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(56, 17);
            this.label_Date.TabIndex = 0;
            this.label_Date.Text = "创建日期";
            // 
            // comboBox_PayMode
            // 
            this.comboBox_PayMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_PayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PayMode.FormattingEnabled = true;
            this.comboBox_PayMode.Location = new System.Drawing.Point(85, 50);
            this.comboBox_PayMode.Name = "comboBox_PayMode";
            this.comboBox_PayMode.Size = new System.Drawing.Size(152, 25);
            this.comboBox_PayMode.TabIndex = 3;
            // 
            // label_OrderState
            // 
            this.label_OrderState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_OrderState.AutoSize = true;
            this.label_OrderState.Location = new System.Drawing.Point(9, 54);
            this.label_OrderState.Name = "label_OrderState";
            this.label_OrderState.Size = new System.Drawing.Size(56, 17);
            this.label_OrderState.TabIndex = 2;
            this.label_OrderState.Text = "付款方式";
            // 
            // dateTimePicker_GenDate
            // 
            this.dateTimePicker_GenDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_GenDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_GenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_GenDate.Location = new System.Drawing.Point(85, 9);
            this.dateTimePicker_GenDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_GenDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_GenDate.Name = "dateTimePicker_GenDate";
            this.dateTimePicker_GenDate.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker_GenDate.TabIndex = 1;
            this.dateTimePicker_GenDate.Value = new System.DateTime(2014, 10, 8, 0, 0, 0, 0);
            this.dateTimePicker_GenDate.DropDown += new System.EventHandler(this.dateTimePicker_GenDate_DropDown);
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
            this.comboBox_PayState.Location = new System.Drawing.Point(85, 92);
            this.comboBox_PayState.Name = "comboBox_PayState";
            this.comboBox_PayState.Size = new System.Drawing.Size(152, 25);
            this.comboBox_PayState.TabIndex = 6;
            // 
            // dataGridView_PayList
            // 
            this.dataGridView_PayList.AllowUserToAddRows = false;
            this.dataGridView_PayList.AllowUserToDeleteRows = false;
            this.dataGridView_PayList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_PayList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_PayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PayList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ORDER_ID,
            this.GEN_DATE,
            this.ACHIEVE_DATE,
            this.PAY_MODE_DESC,
            this.PAY_STATE_DESC,
            this.ALREADY_PAYMENT,
            this.PRE_PAYMENT,
            this.REQUIRE_PAYMENT,
            this.viewOrderBtn});
            this.dataGridView_PayList.Location = new System.Drawing.Point(271, 25);
            this.dataGridView_PayList.Name = "dataGridView_PayList";
            this.dataGridView_PayList.ReadOnly = true;
            this.dataGridView_PayList.RowTemplate.Height = 23;
            this.dataGridView_PayList.Size = new System.Drawing.Size(750, 443);
            this.dataGridView_PayList.TabIndex = 6;
            this.dataGridView_PayList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PayList_CellContentClick);
            // 
            // OSM_Pager_PayList
            // 
            this.OSM_Pager_PayList.Location = new System.Drawing.Point(271, 474);
            this.OSM_Pager_PayList.Name = "OSM_Pager_PayList";
            this.OSM_Pager_PayList.Size = new System.Drawing.Size(750, 30);
            this.OSM_Pager_PayList.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // ORDER_ID
            // 
            this.ORDER_ID.DataPropertyName = "ORDER_ID";
            this.ORDER_ID.HeaderText = "订单ID";
            this.ORDER_ID.Name = "ORDER_ID";
            this.ORDER_ID.ReadOnly = true;
            this.ORDER_ID.Visible = false;
            // 
            // GEN_DATE
            // 
            this.GEN_DATE.DataPropertyName = "GEN_DATE";
            this.GEN_DATE.HeaderText = "创建日期";
            this.GEN_DATE.Name = "GEN_DATE";
            this.GEN_DATE.ReadOnly = true;
            this.GEN_DATE.Width = 80;
            // 
            // ACHIEVE_DATE
            // 
            this.ACHIEVE_DATE.DataPropertyName = "ACHIEVE_DATE";
            this.ACHIEVE_DATE.HeaderText = "付款日期";
            this.ACHIEVE_DATE.Name = "ACHIEVE_DATE";
            this.ACHIEVE_DATE.ReadOnly = true;
            this.ACHIEVE_DATE.Width = 80;
            // 
            // PAY_MODE_DESC
            // 
            this.PAY_MODE_DESC.DataPropertyName = "PAY_MODE_DESC";
            this.PAY_MODE_DESC.HeaderText = "付款方式";
            this.PAY_MODE_DESC.Name = "PAY_MODE_DESC";
            this.PAY_MODE_DESC.ReadOnly = true;
            this.PAY_MODE_DESC.Width = 80;
            // 
            // PAY_STATE_DESC
            // 
            this.PAY_STATE_DESC.DataPropertyName = "PAY_STATE_DESC";
            this.PAY_STATE_DESC.HeaderText = "付款状态";
            this.PAY_STATE_DESC.Name = "PAY_STATE_DESC";
            this.PAY_STATE_DESC.ReadOnly = true;
            this.PAY_STATE_DESC.Width = 80;
            // 
            // ALREADY_PAYMENT
            // 
            this.ALREADY_PAYMENT.DataPropertyName = "ALREADY_PAYMENT";
            this.ALREADY_PAYMENT.HeaderText = "已付款";
            this.ALREADY_PAYMENT.Name = "ALREADY_PAYMENT";
            this.ALREADY_PAYMENT.ReadOnly = true;
            this.ALREADY_PAYMENT.Width = 80;
            // 
            // PRE_PAYMENT
            // 
            this.PRE_PAYMENT.DataPropertyName = "PRE_PAYMENT";
            this.PRE_PAYMENT.HeaderText = "需预付款";
            this.PRE_PAYMENT.Name = "PRE_PAYMENT";
            this.PRE_PAYMENT.ReadOnly = true;
            this.PRE_PAYMENT.Width = 80;
            // 
            // REQUIRE_PAYMENT
            // 
            this.REQUIRE_PAYMENT.DataPropertyName = "REQUIRE_PAYMENT";
            this.REQUIRE_PAYMENT.HeaderText = "付款总价";
            this.REQUIRE_PAYMENT.Name = "REQUIRE_PAYMENT";
            this.REQUIRE_PAYMENT.ReadOnly = true;
            this.REQUIRE_PAYMENT.Width = 80;
            // 
            // viewOrderBtn
            // 
            this.viewOrderBtn.HeaderText = "";
            this.viewOrderBtn.Name = "viewOrderBtn";
            this.viewOrderBtn.ReadOnly = true;
            this.viewOrderBtn.Text = "查看订单";
            this.viewOrderBtn.UseColumnTextForLinkValue = true;
            // 
            // OSM_PayList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OSM_Pager_PayList);
            this.Controls.Add(this.dataGridView_PayList);
            this.Controls.Add(this.groupBox_PayList);
            this.Name = "OSM_PayList_Form";
            this.Size = new System.Drawing.Size(1024, 510);
            this.groupBox_PayList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PayList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_PayList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.ComboBox comboBox_PayMode;
        private System.Windows.Forms.Label label_OrderState;
        private System.Windows.Forms.DateTimePicker dateTimePicker_GenDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Query;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label_PayState;
        private System.Windows.Forms.ComboBox comboBox_PayState;
        private System.Windows.Forms.DataGridView dataGridView_PayList;
        private OSM_Pager OSM_Pager_PayList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GEN_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACHIEVE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAY_MODE_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAY_STATE_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALREADY_PAYMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRE_PAYMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQUIRE_PAYMENT;
        private System.Windows.Forms.DataGridViewLinkColumn viewOrderBtn;
    }
}
