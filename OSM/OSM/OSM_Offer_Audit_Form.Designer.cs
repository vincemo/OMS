namespace OSM
{
    partial class OSM_Offer_Audit_Form
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
            this.groupBox__OfferSheet = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Date = new System.Windows.Forms.Label();
            this.comboBox_OfferSheet_Audit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_OfferSheet_Audit = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Query = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.dataGridView_OfferSheet_Audit = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GMF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BJF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_REGION_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_TYPE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_STATE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.auditBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.passBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.failBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.OSM_Pager_OfferSheet_Audit = new OSM.OSM_Pager();
            this.groupBox__OfferSheet.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OfferSheet_Audit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox__OfferSheet
            // 
            this.groupBox__OfferSheet.Controls.Add(this.tableLayoutPanel1);
            this.groupBox__OfferSheet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox__OfferSheet.Location = new System.Drawing.Point(6, 3);
            this.groupBox__OfferSheet.Name = "groupBox__OfferSheet";
            this.groupBox__OfferSheet.Size = new System.Drawing.Size(262, 493);
            this.groupBox__OfferSheet.TabIndex = 2;
            this.groupBox__OfferSheet.TabStop = false;
            this.groupBox__OfferSheet.Text = "报价单查询条件";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label_Date, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_OfferSheet_Audit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_OfferSheet_Audit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(249, 127);
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
            // comboBox_OfferSheet_Audit
            // 
            this.comboBox_OfferSheet_Audit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_OfferSheet_Audit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OfferSheet_Audit.FormattingEnabled = true;
            this.comboBox_OfferSheet_Audit.Location = new System.Drawing.Point(85, 53);
            this.comboBox_OfferSheet_Audit.Name = "comboBox_OfferSheet_Audit";
            this.comboBox_OfferSheet_Audit.Size = new System.Drawing.Size(152, 25);
            this.comboBox_OfferSheet_Audit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "状态";
            // 
            // dateTimePicker_OfferSheet_Audit
            // 
            this.dateTimePicker_OfferSheet_Audit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_OfferSheet_Audit.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_OfferSheet_Audit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_OfferSheet_Audit.Location = new System.Drawing.Point(85, 9);
            this.dateTimePicker_OfferSheet_Audit.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_OfferSheet_Audit.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_OfferSheet_Audit.Name = "dateTimePicker_OfferSheet_Audit";
            this.dateTimePicker_OfferSheet_Audit.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker_OfferSheet_Audit.TabIndex = 1;
            this.dateTimePicker_OfferSheet_Audit.Value = new System.DateTime(2014, 10, 22, 0, 0, 0, 0);
            this.dateTimePicker_OfferSheet_Audit.DropDown += new System.EventHandler(this.dateTimePicker_OfferSheet_Audit_DropDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_Query, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Reset, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(77, 87);
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
            // dataGridView_OfferSheet_Audit
            // 
            this.dataGridView_OfferSheet_Audit.AllowUserToAddRows = false;
            this.dataGridView_OfferSheet_Audit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_OfferSheet_Audit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_OfferSheet_Audit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OfferSheet_Audit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.OFFERSHEET_CODE,
            this.GMF_NAME,
            this.BJF_NAME,
            this.OFFERSHEET_REGION_DESC,
            this.OFFERSHEET_TYPE_DESC,
            this.OFFERSHEET_DATE,
            this.OFFERSHEET_STATE_DESC,
            this.viewBtn,
            this.auditBtn,
            this.passBtn,
            this.failBtn});
            this.dataGridView_OfferSheet_Audit.Location = new System.Drawing.Point(274, 3);
            this.dataGridView_OfferSheet_Audit.Name = "dataGridView_OfferSheet_Audit";
            this.dataGridView_OfferSheet_Audit.RowTemplate.Height = 23;
            this.dataGridView_OfferSheet_Audit.Size = new System.Drawing.Size(750, 465);
            this.dataGridView_OfferSheet_Audit.TabIndex = 3;
            this.dataGridView_OfferSheet_Audit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OfferSheet_Audit_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // OFFERSHEET_CODE
            // 
            this.OFFERSHEET_CODE.DataPropertyName = "OFFERSHEET_CODE";
            this.OFFERSHEET_CODE.HeaderText = "报价单编号";
            this.OFFERSHEET_CODE.Name = "OFFERSHEET_CODE";
            this.OFFERSHEET_CODE.ReadOnly = true;
            // 
            // GMF_NAME
            // 
            this.GMF_NAME.DataPropertyName = "GMF_NAME";
            this.GMF_NAME.HeaderText = "购买方";
            this.GMF_NAME.Name = "GMF_NAME";
            this.GMF_NAME.ReadOnly = true;
            // 
            // BJF_NAME
            // 
            this.BJF_NAME.DataPropertyName = "BJF_NAME";
            this.BJF_NAME.HeaderText = "报价方";
            this.BJF_NAME.Name = "BJF_NAME";
            this.BJF_NAME.ReadOnly = true;
            // 
            // OFFERSHEET_REGION_DESC
            // 
            this.OFFERSHEET_REGION_DESC.DataPropertyName = "OFFERSHEET_REGION_DESC";
            this.OFFERSHEET_REGION_DESC.HeaderText = "所属区域";
            this.OFFERSHEET_REGION_DESC.Name = "OFFERSHEET_REGION_DESC";
            // 
            // OFFERSHEET_TYPE_DESC
            // 
            this.OFFERSHEET_TYPE_DESC.DataPropertyName = "OFFERSHEET_TYPE_DESC";
            this.OFFERSHEET_TYPE_DESC.HeaderText = "所属行业";
            this.OFFERSHEET_TYPE_DESC.Name = "OFFERSHEET_TYPE_DESC";
            this.OFFERSHEET_TYPE_DESC.ReadOnly = true;
            // 
            // OFFERSHEET_DATE
            // 
            this.OFFERSHEET_DATE.DataPropertyName = "OFFERSHEET_DATE";
            this.OFFERSHEET_DATE.HeaderText = "报价单日期";
            this.OFFERSHEET_DATE.Name = "OFFERSHEET_DATE";
            this.OFFERSHEET_DATE.ReadOnly = true;
            // 
            // OFFERSHEET_STATE_DESC
            // 
            this.OFFERSHEET_STATE_DESC.DataPropertyName = "OFFERSHEET_STATE_DESC";
            this.OFFERSHEET_STATE_DESC.HeaderText = "报价单状态";
            this.OFFERSHEET_STATE_DESC.Name = "OFFERSHEET_STATE_DESC";
            this.OFFERSHEET_STATE_DESC.ReadOnly = true;
            // 
            // viewBtn
            // 
            this.viewBtn.HeaderText = "";
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.viewBtn.Text = "查看";
            this.viewBtn.UseColumnTextForLinkValue = true;
            this.viewBtn.Width = 50;
            // 
            // auditBtn
            // 
            this.auditBtn.HeaderText = "";
            this.auditBtn.Name = "auditBtn";
            this.auditBtn.Text = "审核";
            this.auditBtn.UseColumnTextForLinkValue = true;
            this.auditBtn.Visible = false;
            this.auditBtn.Width = 50;
            // 
            // passBtn
            // 
            this.passBtn.HeaderText = "";
            this.passBtn.Name = "passBtn";
            this.passBtn.Text = "通过";
            this.passBtn.UseColumnTextForLinkValue = true;
            this.passBtn.Width = 50;
            // 
            // failBtn
            // 
            this.failBtn.HeaderText = "";
            this.failBtn.Name = "failBtn";
            this.failBtn.Text = "不通过";
            this.failBtn.UseColumnTextForLinkValue = true;
            this.failBtn.Width = 50;
            // 
            // OSM_Pager_OfferSheet_Audit
            // 
            this.OSM_Pager_OfferSheet_Audit.Location = new System.Drawing.Point(274, 474);
            this.OSM_Pager_OfferSheet_Audit.Name = "OSM_Pager_OfferSheet_Audit";
            this.OSM_Pager_OfferSheet_Audit.Size = new System.Drawing.Size(750, 30);
            this.OSM_Pager_OfferSheet_Audit.TabIndex = 4;
            // 
            // OSM_Offer_Audit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OSM_Pager_OfferSheet_Audit);
            this.Controls.Add(this.dataGridView_OfferSheet_Audit);
            this.Controls.Add(this.groupBox__OfferSheet);
            this.Name = "OSM_Offer_Audit_Form";
            this.Size = new System.Drawing.Size(1024, 510);
            this.groupBox__OfferSheet.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OfferSheet_Audit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox__OfferSheet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.ComboBox comboBox_OfferSheet_Audit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_OfferSheet_Audit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Query;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.DataGridView dataGridView_OfferSheet_Audit;
        private OSM_Pager OSM_Pager_OfferSheet_Audit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GMF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BJF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_REGION_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_TYPE_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_STATE_DESC;
        private System.Windows.Forms.DataGridViewLinkColumn viewBtn;
        private System.Windows.Forms.DataGridViewLinkColumn auditBtn;
        private System.Windows.Forms.DataGridViewLinkColumn passBtn;
        private System.Windows.Forms.DataGridViewLinkColumn failBtn;
    }
}
