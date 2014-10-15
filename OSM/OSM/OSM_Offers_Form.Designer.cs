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
            this.groupBox__OfferSheet = new System.Windows.Forms.GroupBox();
            this.comboBox_OfferSheet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_OfferSheet = new System.Windows.Forms.DateTimePicker();
            this.label_Date = new System.Windows.Forms.Label();
            this.OFFERSHEET_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GMF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BJF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_STATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OfferSheet)).BeginInit();
            this.groupBox__OfferSheet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_OfferSheet
            // 
            this.dataGridView_OfferSheet.AllowUserToAddRows = false;
            this.dataGridView_OfferSheet.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_OfferSheet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_OfferSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OfferSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OFFERSHEET_CODE,
            this.GMF_NAME,
            this.BJF_NAME,
            this.OFFERSHEET_TYPE,
            this.OFFERSHEET_DATE,
            this.OFFERSHEET_STATE,
            this.viewBtn,
            this.editBtn});
            this.dataGridView_OfferSheet.Location = new System.Drawing.Point(272, 0);
            this.dataGridView_OfferSheet.Name = "dataGridView_OfferSheet";
            this.dataGridView_OfferSheet.RowTemplate.Height = 23;
            this.dataGridView_OfferSheet.Size = new System.Drawing.Size(749, 474);
            this.dataGridView_OfferSheet.TabIndex = 0;
            // 
            // groupBox__OfferSheet
            // 
            this.groupBox__OfferSheet.Controls.Add(this.comboBox_OfferSheet);
            this.groupBox__OfferSheet.Controls.Add(this.label1);
            this.groupBox__OfferSheet.Controls.Add(this.dateTimePicker_OfferSheet);
            this.groupBox__OfferSheet.Controls.Add(this.label_Date);
            this.groupBox__OfferSheet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox__OfferSheet.Location = new System.Drawing.Point(4, 4);
            this.groupBox__OfferSheet.Name = "groupBox__OfferSheet";
            this.groupBox__OfferSheet.Size = new System.Drawing.Size(262, 470);
            this.groupBox__OfferSheet.TabIndex = 1;
            this.groupBox__OfferSheet.TabStop = false;
            this.groupBox__OfferSheet.Text = "报价单查询条件";
            // 
            // comboBox_OfferSheet
            // 
            this.comboBox_OfferSheet.FormattingEnabled = true;
            this.comboBox_OfferSheet.Location = new System.Drawing.Point(77, 97);
            this.comboBox_OfferSheet.Name = "comboBox_OfferSheet";
            this.comboBox_OfferSheet.Size = new System.Drawing.Size(152, 25);
            this.comboBox_OfferSheet.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "状态";
            // 
            // dateTimePicker_OfferSheet
            // 
            this.dateTimePicker_OfferSheet.Location = new System.Drawing.Point(77, 39);
            this.dateTimePicker_OfferSheet.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_OfferSheet.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_OfferSheet.Name = "dateTimePicker_OfferSheet";
            this.dateTimePicker_OfferSheet.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker_OfferSheet.TabIndex = 1;
            this.dateTimePicker_OfferSheet.Value = new System.DateTime(2014, 10, 8, 0, 0, 0, 0);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(28, 43);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(32, 17);
            this.label_Date.TabIndex = 0;
            this.label_Date.Text = "日期";
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
            // OFFERSHEET_TYPE
            // 
            this.OFFERSHEET_TYPE.DataPropertyName = "OFFERSHEET_TYPE";
            this.OFFERSHEET_TYPE.HeaderText = "报价单类型";
            this.OFFERSHEET_TYPE.Name = "OFFERSHEET_TYPE";
            this.OFFERSHEET_TYPE.ReadOnly = true;
            // 
            // OFFERSHEET_DATE
            // 
            this.OFFERSHEET_DATE.DataPropertyName = "OFFERSHEET_DATE";
            this.OFFERSHEET_DATE.HeaderText = "报价单日期";
            this.OFFERSHEET_DATE.Name = "OFFERSHEET_DATE";
            this.OFFERSHEET_DATE.ReadOnly = true;
            // 
            // OFFERSHEET_STATE
            // 
            this.OFFERSHEET_STATE.DataPropertyName = "OFFERSHEET_STATE";
            this.OFFERSHEET_STATE.HeaderText = "报价单状态";
            this.OFFERSHEET_STATE.Name = "OFFERSHEET_STATE";
            this.OFFERSHEET_STATE.ReadOnly = true;
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
            // editBtn
            // 
            this.editBtn.HeaderText = "";
            this.editBtn.Name = "editBtn";
            this.editBtn.Text = "编辑";
            this.editBtn.UseColumnTextForLinkValue = true;
            this.editBtn.Width = 50;
            // 
            // OSM_Offers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox__OfferSheet);
            this.Controls.Add(this.dataGridView_OfferSheet);
            this.Name = "OSM_Offers_Form";
            this.Size = new System.Drawing.Size(1024, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OfferSheet)).EndInit();
            this.groupBox__OfferSheet.ResumeLayout(false);
            this.groupBox__OfferSheet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_OfferSheet;
        private System.Windows.Forms.GroupBox groupBox__OfferSheet;
        private System.Windows.Forms.ComboBox comboBox_OfferSheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_OfferSheet;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GMF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BJF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_STATE;
        private System.Windows.Forms.DataGridViewLinkColumn viewBtn;
        private System.Windows.Forms.DataGridViewLinkColumn editBtn;
    }
}
