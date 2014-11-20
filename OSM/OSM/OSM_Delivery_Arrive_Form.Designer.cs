namespace OSM
{
    partial class OSM_Delivery_Arrive_Form
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
            this.groupBox__Delivery = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Date = new System.Windows.Forms.Label();
            this.dateTimePicker_DeliverDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Query = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_DeliveryState = new System.Windows.Forms.Label();
            this.comboBox_DeliveryState = new System.Windows.Forms.ComboBox();
            this.label_ArrDate = new System.Windows.Forms.Label();
            this.dateTimePicker_ArrDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_Delivery = new System.Windows.Forms.DataGridView();
            this.OSM_Pager_Delivery = new OSM.OSM_Pager();
            this.ORDER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DILIVERY_STATE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DILIVERY_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARRIVE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewOrderBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.auditBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox__Delivery.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Delivery)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox__Delivery
            // 
            this.groupBox__Delivery.Controls.Add(this.tableLayoutPanel1);
            this.groupBox__Delivery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox__Delivery.Location = new System.Drawing.Point(3, 3);
            this.groupBox__Delivery.Name = "groupBox__Delivery";
            this.groupBox__Delivery.Size = new System.Drawing.Size(262, 493);
            this.groupBox__Delivery.TabIndex = 6;
            this.groupBox__Delivery.TabStop = false;
            this.groupBox__Delivery.Text = "发货单查询条件";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label_Date, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_DeliverDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_DeliveryState, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_DeliveryState, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_ArrDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_ArrDate, 1, 1);
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
            this.label_Date.Text = "发货日期";
            // 
            // dateTimePicker_DeliverDate
            // 
            this.dateTimePicker_DeliverDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_DeliverDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_DeliverDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DeliverDate.Location = new System.Drawing.Point(85, 9);
            this.dateTimePicker_DeliverDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_DeliverDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_DeliverDate.Name = "dateTimePicker_DeliverDate";
            this.dateTimePicker_DeliverDate.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker_DeliverDate.TabIndex = 1;
            this.dateTimePicker_DeliverDate.Value = new System.DateTime(2014, 10, 8, 0, 0, 0, 0);
            this.dateTimePicker_DeliverDate.DropDown += new System.EventHandler(this.dateTimePicker_DeliverDate_DropDown);
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
            // label_DeliveryState
            // 
            this.label_DeliveryState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_DeliveryState.AutoSize = true;
            this.label_DeliveryState.Location = new System.Drawing.Point(3, 96);
            this.label_DeliveryState.Name = "label_DeliveryState";
            this.label_DeliveryState.Size = new System.Drawing.Size(68, 17);
            this.label_DeliveryState.TabIndex = 2;
            this.label_DeliveryState.Text = "发货单状态";
            // 
            // comboBox_DeliveryState
            // 
            this.comboBox_DeliveryState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_DeliveryState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DeliveryState.FormattingEnabled = true;
            this.comboBox_DeliveryState.Location = new System.Drawing.Point(85, 95);
            this.comboBox_DeliveryState.Name = "comboBox_DeliveryState";
            this.comboBox_DeliveryState.Size = new System.Drawing.Size(152, 25);
            this.comboBox_DeliveryState.TabIndex = 3;
            // 
            // label_ArrDate
            // 
            this.label_ArrDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ArrDate.AutoSize = true;
            this.label_ArrDate.Location = new System.Drawing.Point(9, 54);
            this.label_ArrDate.Name = "label_ArrDate";
            this.label_ArrDate.Size = new System.Drawing.Size(56, 17);
            this.label_ArrDate.TabIndex = 5;
            this.label_ArrDate.Text = "到货日期";
            // 
            // dateTimePicker_ArrDate
            // 
            this.dateTimePicker_ArrDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_ArrDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_ArrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ArrDate.Location = new System.Drawing.Point(85, 51);
            this.dateTimePicker_ArrDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_ArrDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_ArrDate.Name = "dateTimePicker_ArrDate";
            this.dateTimePicker_ArrDate.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker_ArrDate.TabIndex = 6;
            this.dateTimePicker_ArrDate.Value = new System.DateTime(2014, 10, 8, 0, 0, 0, 0);
            this.dateTimePicker_ArrDate.DropDown += new System.EventHandler(this.dateTimePicker_ArrDate_DropDown);
            // 
            // dataGridView_Delivery
            // 
            this.dataGridView_Delivery.AllowUserToAddRows = false;
            this.dataGridView_Delivery.AllowUserToDeleteRows = false;
            this.dataGridView_Delivery.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Delivery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_Delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Delivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORDER_ID,
            this.ID,
            this.DILIVERY_STATE_DESC,
            this.DILIVERY_DATE,
            this.ARRIVE_DATE,
            this.COMMENT,
            this.viewOrderBtn,
            this.auditBtn});
            this.dataGridView_Delivery.Location = new System.Drawing.Point(271, 25);
            this.dataGridView_Delivery.Name = "dataGridView_Delivery";
            this.dataGridView_Delivery.ReadOnly = true;
            this.dataGridView_Delivery.RowTemplate.Height = 23;
            this.dataGridView_Delivery.Size = new System.Drawing.Size(750, 443);
            this.dataGridView_Delivery.TabIndex = 7;
            this.dataGridView_Delivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Delivery_CellContentClick);
            // 
            // OSM_Pager_Delivery
            // 
            this.OSM_Pager_Delivery.Location = new System.Drawing.Point(271, 474);
            this.OSM_Pager_Delivery.Name = "OSM_Pager_Delivery";
            this.OSM_Pager_Delivery.Size = new System.Drawing.Size(750, 30);
            this.OSM_Pager_Delivery.TabIndex = 8;
            // 
            // ORDER_ID
            // 
            this.ORDER_ID.DataPropertyName = "ORDER_ID";
            this.ORDER_ID.HeaderText = "ORDER_ID";
            this.ORDER_ID.Name = "ORDER_ID";
            this.ORDER_ID.ReadOnly = true;
            this.ORDER_ID.Visible = false;
            this.ORDER_ID.Width = 140;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "发货单号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DILIVERY_STATE_DESC
            // 
            this.DILIVERY_STATE_DESC.DataPropertyName = "DILIVERY_STATE_DESC";
            this.DILIVERY_STATE_DESC.HeaderText = "发货单状态";
            this.DILIVERY_STATE_DESC.Name = "DILIVERY_STATE_DESC";
            this.DILIVERY_STATE_DESC.ReadOnly = true;
            // 
            // DILIVERY_DATE
            // 
            this.DILIVERY_DATE.DataPropertyName = "DILIVERY_DATE";
            this.DILIVERY_DATE.HeaderText = "发货日期";
            this.DILIVERY_DATE.Name = "DILIVERY_DATE";
            this.DILIVERY_DATE.ReadOnly = true;
            // 
            // ARRIVE_DATE
            // 
            this.ARRIVE_DATE.DataPropertyName = "ARRIVE_DATE";
            this.ARRIVE_DATE.HeaderText = "到货日期";
            this.ARRIVE_DATE.Name = "ARRIVE_DATE";
            this.ARRIVE_DATE.ReadOnly = true;
            // 
            // COMMENT
            // 
            this.COMMENT.DataPropertyName = "COMMENT";
            this.COMMENT.HeaderText = "备注";
            this.COMMENT.Name = "COMMENT";
            this.COMMENT.ReadOnly = true;
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
            this.auditBtn.Text = "到货确认";
            this.auditBtn.UseColumnTextForLinkValue = true;
            // 
            // OSM_Delivery_Arrive_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OSM_Pager_Delivery);
            this.Controls.Add(this.dataGridView_Delivery);
            this.Controls.Add(this.groupBox__Delivery);
            this.Name = "OSM_Delivery_Arrive_Form";
            this.Size = new System.Drawing.Size(1024, 510);
            this.groupBox__Delivery.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Delivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox__Delivery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DeliverDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Query;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label_DeliveryState;
        private System.Windows.Forms.ComboBox comboBox_DeliveryState;
        private System.Windows.Forms.Label label_ArrDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ArrDate;
        private System.Windows.Forms.DataGridView dataGridView_Delivery;
        private OSM_Pager OSM_Pager_Delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DILIVERY_STATE_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DILIVERY_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRIVE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMMENT;
        private System.Windows.Forms.DataGridViewLinkColumn viewOrderBtn;
        private System.Windows.Forms.DataGridViewLinkColumn auditBtn;
    }
}
