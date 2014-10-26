namespace OSM
{
    partial class OSM_Offers_Form
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
            this.dataGridView_OfferSheet = new System.Windows.Forms.DataGridView();
            this.ORDERSHEET_GEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GMF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BJF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_TYPE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_STATE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.delBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox__OfferSheet = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Date = new System.Windows.Forms.Label();
            this.comboBox_OfferSheet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_OfferSheet = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Query = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.OSM_Pager_offerSheet = new OSM.OSM_Pager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OfferSheet)).BeginInit();
            this.groupBox__OfferSheet.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_OfferSheet
            // 
            this.dataGridView_OfferSheet.AllowUserToAddRows = false;
            this.dataGridView_OfferSheet.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_OfferSheet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_OfferSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OfferSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORDERSHEET_GEN,
            this.OFFERSHEET_CODE,
            this.GMF_NAME,
            this.BJF_NAME,
            this.OFFERSHEET_TYPE_DESC,
            this.OFFERSHEET_DATE,
            this.OFFERSHEET_STATE_DESC,
            this.viewBtn,
            this.editBtn,
            this.delBtn});
            this.dataGridView_OfferSheet.Location = new System.Drawing.Point(271, 3);
            this.dataGridView_OfferSheet.Name = "dataGridView_OfferSheet";
            this.dataGridView_OfferSheet.RowTemplate.Height = 23;
            this.dataGridView_OfferSheet.Size = new System.Drawing.Size(750, 465);
            this.dataGridView_OfferSheet.TabIndex = 0;
            this.dataGridView_OfferSheet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OfferSheet_CellContentClick);
            // 
            // ORDERSHEET_GEN
            // 
            this.ORDERSHEET_GEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ORDERSHEET_GEN.DataPropertyName = "ORDERSHEET_GEN";
            this.ORDERSHEET_GEN.HeaderText = "生成订单";
            this.ORDERSHEET_GEN.Name = "ORDERSHEET_GEN";
            this.ORDERSHEET_GEN.Width = 78;
            // 
            // OFFERSHEET_CODE
            // 
            this.OFFERSHEET_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OFFERSHEET_CODE.DataPropertyName = "OFFERSHEET_CODE";
            this.OFFERSHEET_CODE.HeaderText = "报价单编号";
            this.OFFERSHEET_CODE.Name = "OFFERSHEET_CODE";
            this.OFFERSHEET_CODE.ReadOnly = true;
            this.OFFERSHEET_CODE.Width = 140;
            // 
            // GMF_NAME
            // 
            this.GMF_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GMF_NAME.DataPropertyName = "GMF_NAME";
            this.GMF_NAME.HeaderText = "购买方";
            this.GMF_NAME.Name = "GMF_NAME";
            this.GMF_NAME.ReadOnly = true;
            // 
            // BJF_NAME
            // 
            this.BJF_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BJF_NAME.DataPropertyName = "BJF_NAME";
            this.BJF_NAME.HeaderText = "报价方";
            this.BJF_NAME.Name = "BJF_NAME";
            this.BJF_NAME.ReadOnly = true;
            // 
            // OFFERSHEET_TYPE_DESC
            // 
            this.OFFERSHEET_TYPE_DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OFFERSHEET_TYPE_DESC.DataPropertyName = "OFFERSHEET_TYPE_DESC";
            this.OFFERSHEET_TYPE_DESC.HeaderText = "报价单类型";
            this.OFFERSHEET_TYPE_DESC.Name = "OFFERSHEET_TYPE_DESC";
            this.OFFERSHEET_TYPE_DESC.ReadOnly = true;
            this.OFFERSHEET_TYPE_DESC.Width = 90;
            // 
            // OFFERSHEET_DATE
            // 
            this.OFFERSHEET_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OFFERSHEET_DATE.DataPropertyName = "OFFERSHEET_DATE";
            this.OFFERSHEET_DATE.HeaderText = "报价单日期";
            this.OFFERSHEET_DATE.Name = "OFFERSHEET_DATE";
            this.OFFERSHEET_DATE.ReadOnly = true;
            this.OFFERSHEET_DATE.Width = 90;
            // 
            // OFFERSHEET_STATE_DESC
            // 
            this.OFFERSHEET_STATE_DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OFFERSHEET_STATE_DESC.DataPropertyName = "OFFERSHEET_STATE_DESC";
            this.OFFERSHEET_STATE_DESC.HeaderText = "报价单状态";
            this.OFFERSHEET_STATE_DESC.Name = "OFFERSHEET_STATE_DESC";
            this.OFFERSHEET_STATE_DESC.ReadOnly = true;
            this.OFFERSHEET_STATE_DESC.Width = 90;
            // 
            // viewBtn
            // 
            this.viewBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.viewBtn.HeaderText = "";
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.viewBtn.Text = "查看";
            this.viewBtn.UseColumnTextForLinkValue = true;
            this.viewBtn.Width = 50;
            // 
            // editBtn
            // 
            this.editBtn.HeaderText = "";
            this.editBtn.Name = "editBtn";
            this.editBtn.Text = "编辑";
            this.editBtn.UseColumnTextForLinkValue = true;
            this.editBtn.Width = 50;
            // 
            // delBtn
            // 
            this.delBtn.HeaderText = "";
            this.delBtn.Name = "delBtn";
            this.delBtn.Text = "删除";
            this.delBtn.UseColumnTextForLinkValue = true;
            this.delBtn.Width = 50;
            // 
            // groupBox__OfferSheet
            // 
            this.groupBox__OfferSheet.Controls.Add(this.tableLayoutPanel1);
            this.groupBox__OfferSheet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox__OfferSheet.Location = new System.Drawing.Point(3, 3);
            this.groupBox__OfferSheet.Name = "groupBox__OfferSheet";
            this.groupBox__OfferSheet.Size = new System.Drawing.Size(262, 493);
            this.groupBox__OfferSheet.TabIndex = 1;
            this.groupBox__OfferSheet.TabStop = false;
            this.groupBox__OfferSheet.Text = "报价单查询条件";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label_Date, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_OfferSheet, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_OfferSheet, 1, 0);
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
            // comboBox_OfferSheet
            // 
            this.comboBox_OfferSheet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_OfferSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OfferSheet.FormattingEnabled = true;
            this.comboBox_OfferSheet.Location = new System.Drawing.Point(85, 53);
            this.comboBox_OfferSheet.Name = "comboBox_OfferSheet";
            this.comboBox_OfferSheet.Size = new System.Drawing.Size(152, 25);
            this.comboBox_OfferSheet.TabIndex = 3;
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
            // dateTimePicker_OfferSheet
            // 
            this.dateTimePicker_OfferSheet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_OfferSheet.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_OfferSheet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_OfferSheet.Location = new System.Drawing.Point(85, 9);
            this.dateTimePicker_OfferSheet.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_OfferSheet.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_OfferSheet.Name = "dateTimePicker_OfferSheet";
            this.dateTimePicker_OfferSheet.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker_OfferSheet.TabIndex = 1;
            this.dateTimePicker_OfferSheet.Value = new System.DateTime(2014, 10, 8, 0, 0, 0, 0);
            this.dateTimePicker_OfferSheet.DropDown += new System.EventHandler(this.dateTimePicker_OfferSheet_DropDown);
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
            // OSM_Pager_offerSheet
            // 
            this.OSM_Pager_offerSheet.Location = new System.Drawing.Point(271, 474);
            this.OSM_Pager_offerSheet.Name = "OSM_Pager_offerSheet";
            this.OSM_Pager_offerSheet.Size = new System.Drawing.Size(750, 30);
            this.OSM_Pager_offerSheet.TabIndex = 2;
            // 
            // OSM_Offers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OSM_Pager_offerSheet);
            this.Controls.Add(this.groupBox__OfferSheet);
            this.Controls.Add(this.dataGridView_OfferSheet);
            this.Name = "OSM_Offers_Form";
            this.Size = new System.Drawing.Size(1024, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OfferSheet)).EndInit();
            this.groupBox__OfferSheet.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_OfferSheet;
        private System.Windows.Forms.GroupBox groupBox__OfferSheet;
        private System.Windows.Forms.ComboBox comboBox_OfferSheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_OfferSheet;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Query;
        private System.Windows.Forms.Button button_Reset;
        private OSM_Pager OSM_Pager_offerSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDERSHEET_GEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GMF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BJF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_TYPE_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_STATE_DESC;
        private System.Windows.Forms.DataGridViewLinkColumn viewBtn;
        private System.Windows.Forms.DataGridViewLinkColumn editBtn;
        private System.Windows.Forms.DataGridViewLinkColumn delBtn;
    }
}
