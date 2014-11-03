namespace OSM
{
    partial class OSM_Purchase_Form
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
            this.groupBox_Purchase = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Date = new System.Windows.Forms.Label();
            this.comboBox_PurchaseState = new System.Windows.Forms.ComboBox();
            this.label_PurchaseState = new System.Windows.Forms.Label();
            this.dateTimePicker_InitDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Query = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_HWType = new System.Windows.Forms.Label();
            this.comboBox_HWType = new System.Windows.Forms.ComboBox();
            this.dataGridView_Purchase = new System.Windows.Forms.DataGridView();
            this.OSM_Pager_Purchase = new OSM.OSM_Pager();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HW_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HW_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HW_TYPE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PURCHASE_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PURCHASE_STATE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INIT_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewOrderBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox_Purchase.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Purchase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Purchase
            // 
            this.groupBox_Purchase.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_Purchase.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_Purchase.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Purchase.Name = "groupBox_Purchase";
            this.groupBox_Purchase.Size = new System.Drawing.Size(262, 493);
            this.groupBox_Purchase.TabIndex = 4;
            this.groupBox_Purchase.TabStop = false;
            this.groupBox_Purchase.Text = "采购单查询条件";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label_Date, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_PurchaseState, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_PurchaseState, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_InitDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_HWType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_HWType, 1, 2);
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
            // comboBox_PurchaseState
            // 
            this.comboBox_PurchaseState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_PurchaseState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PurchaseState.FormattingEnabled = true;
            this.comboBox_PurchaseState.Location = new System.Drawing.Point(85, 50);
            this.comboBox_PurchaseState.Name = "comboBox_PurchaseState";
            this.comboBox_PurchaseState.Size = new System.Drawing.Size(152, 25);
            this.comboBox_PurchaseState.TabIndex = 3;
            // 
            // label_PurchaseState
            // 
            this.label_PurchaseState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PurchaseState.AutoSize = true;
            this.label_PurchaseState.Location = new System.Drawing.Point(9, 54);
            this.label_PurchaseState.Name = "label_PurchaseState";
            this.label_PurchaseState.Size = new System.Drawing.Size(56, 17);
            this.label_PurchaseState.TabIndex = 2;
            this.label_PurchaseState.Text = "采购状态";
            // 
            // dateTimePicker_InitDate
            // 
            this.dateTimePicker_InitDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_InitDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_InitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_InitDate.Location = new System.Drawing.Point(85, 9);
            this.dateTimePicker_InitDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_InitDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_InitDate.Name = "dateTimePicker_InitDate";
            this.dateTimePicker_InitDate.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker_InitDate.TabIndex = 1;
            this.dateTimePicker_InitDate.Value = new System.DateTime(2014, 10, 8, 0, 0, 0, 0);
            this.dateTimePicker_InitDate.DropDown += new System.EventHandler(this.dateTimePicker_InitDate_DropDown);
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
            // label_HWType
            // 
            this.label_HWType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_HWType.AutoSize = true;
            this.label_HWType.Location = new System.Drawing.Point(9, 96);
            this.label_HWType.Name = "label_HWType";
            this.label_HWType.Size = new System.Drawing.Size(56, 17);
            this.label_HWType.TabIndex = 5;
            this.label_HWType.Text = "所属设备";
            // 
            // comboBox_HWType
            // 
            this.comboBox_HWType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_HWType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HWType.FormattingEnabled = true;
            this.comboBox_HWType.Location = new System.Drawing.Point(85, 92);
            this.comboBox_HWType.Name = "comboBox_HWType";
            this.comboBox_HWType.Size = new System.Drawing.Size(152, 25);
            this.comboBox_HWType.TabIndex = 6;
            // 
            // dataGridView_Purchase
            // 
            this.dataGridView_Purchase.AllowUserToAddRows = false;
            this.dataGridView_Purchase.AllowUserToDeleteRows = false;
            this.dataGridView_Purchase.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Purchase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_Purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Purchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ORDER_ID,
            this.HW_NAME,
            this.HW_CODE,
            this.HW_TYPE_DESC,
            this.PURCHASE_NUMBER,
            this.PURCHASE_STATE_DESC,
            this.INIT_DATE,
            this.viewOrderBtn});
            this.dataGridView_Purchase.Location = new System.Drawing.Point(271, 25);
            this.dataGridView_Purchase.Name = "dataGridView_Purchase";
            this.dataGridView_Purchase.ReadOnly = true;
            this.dataGridView_Purchase.RowTemplate.Height = 23;
            this.dataGridView_Purchase.Size = new System.Drawing.Size(750, 443);
            this.dataGridView_Purchase.TabIndex = 5;
            this.dataGridView_Purchase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Purchase_CellContentClick);
            // 
            // OSM_Pager_Purchase
            // 
            this.OSM_Pager_Purchase.Location = new System.Drawing.Point(271, 474);
            this.OSM_Pager_Purchase.Name = "OSM_Pager_Purchase";
            this.OSM_Pager_Purchase.Size = new System.Drawing.Size(750, 30);
            this.OSM_Pager_Purchase.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ORDER_ID
            // 
            this.ORDER_ID.DataPropertyName = "ORDER_ID";
            this.ORDER_ID.HeaderText = "ORDER_ID";
            this.ORDER_ID.Name = "ORDER_ID";
            this.ORDER_ID.ReadOnly = true;
            this.ORDER_ID.Visible = false;
            // 
            // HW_NAME
            // 
            this.HW_NAME.DataPropertyName = "HW_NAME";
            this.HW_NAME.HeaderText = "货物名称";
            this.HW_NAME.Name = "HW_NAME";
            this.HW_NAME.ReadOnly = true;
            // 
            // HW_CODE
            // 
            this.HW_CODE.DataPropertyName = "HW_CODE";
            this.HW_CODE.HeaderText = "货物代码";
            this.HW_CODE.Name = "HW_CODE";
            this.HW_CODE.ReadOnly = true;
            // 
            // HW_TYPE_DESC
            // 
            this.HW_TYPE_DESC.DataPropertyName = "HW_TYPE_DESC";
            this.HW_TYPE_DESC.HeaderText = "所属设备";
            this.HW_TYPE_DESC.Name = "HW_TYPE_DESC";
            this.HW_TYPE_DESC.ReadOnly = true;
            // 
            // PURCHASE_NUMBER
            // 
            this.PURCHASE_NUMBER.DataPropertyName = "PURCHASE_NUMBER";
            this.PURCHASE_NUMBER.HeaderText = "采购数量";
            this.PURCHASE_NUMBER.Name = "PURCHASE_NUMBER";
            this.PURCHASE_NUMBER.ReadOnly = true;
            // 
            // PURCHASE_STATE_DESC
            // 
            this.PURCHASE_STATE_DESC.DataPropertyName = "PURCHASE_STATE_DESC";
            this.PURCHASE_STATE_DESC.HeaderText = "采购状态";
            this.PURCHASE_STATE_DESC.Name = "PURCHASE_STATE_DESC";
            this.PURCHASE_STATE_DESC.ReadOnly = true;
            // 
            // INIT_DATE
            // 
            this.INIT_DATE.DataPropertyName = "INIT_DATE";
            this.INIT_DATE.HeaderText = "产生日期";
            this.INIT_DATE.Name = "INIT_DATE";
            this.INIT_DATE.ReadOnly = true;
            // 
            // viewOrderBtn
            // 
            this.viewOrderBtn.HeaderText = "";
            this.viewOrderBtn.Name = "viewOrderBtn";
            this.viewOrderBtn.ReadOnly = true;
            this.viewOrderBtn.Text = "对应订单";
            this.viewOrderBtn.UseColumnTextForLinkValue = true;
            // 
            // OSM_Purchase_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OSM_Pager_Purchase);
            this.Controls.Add(this.dataGridView_Purchase);
            this.Controls.Add(this.groupBox_Purchase);
            this.Name = "OSM_Purchase_Form";
            this.Size = new System.Drawing.Size(1024, 510);
            this.groupBox_Purchase.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Purchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Purchase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.ComboBox comboBox_PurchaseState;
        private System.Windows.Forms.Label label_PurchaseState;
        private System.Windows.Forms.DateTimePicker dateTimePicker_InitDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Query;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label_HWType;
        private System.Windows.Forms.ComboBox comboBox_HWType;
        private System.Windows.Forms.DataGridView dataGridView_Purchase;
        private OSM_Pager OSM_Pager_Purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HW_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn HW_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HW_TYPE_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PURCHASE_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PURCHASE_STATE_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn INIT_DATE;
        private System.Windows.Forms.DataGridViewLinkColumn viewOrderBtn;
    }
}
