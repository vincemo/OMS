namespace OSM
{
    partial class FormOSM_Offers_Audit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_Offers_Audit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_query = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.dateTimePicker_offersheet_date = new System.Windows.Forms.DateTimePicker();
            this.comboBox_offersheet_type = new System.Windows.Forms.ComboBox();
            this.dataGridView_OfferSheet = new System.Windows.Forms.DataGridView();
            this.OFFERSHEET_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GMF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BJF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_TYPE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFERSHEET_STATE_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.auditBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.OSM_Pager_Offer_Audit = new OSM.OSM_Pager();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OfferSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.button_query, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_reset, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_date, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_type, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_offersheet_date, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_offersheet_type, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(745, 28);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_query
            // 
            this.button_query.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_query.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_query.Location = new System.Drawing.Point(597, 3);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(68, 22);
            this.button_query.TabIndex = 0;
            this.button_query.Text = "查询";
            this.button_query.UseVisualStyleBackColor = true;
            // 
            // button_reset
            // 
            this.button_reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_reset.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_reset.Location = new System.Drawing.Point(671, 3);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(71, 22);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = true;
            // 
            // label_date
            // 
            this.label_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_date.Location = new System.Drawing.Point(21, 5);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(32, 17);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "日期";
            // 
            // label_type
            // 
            this.label_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_type.Location = new System.Drawing.Point(318, 5);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(32, 17);
            this.label_type.TabIndex = 3;
            this.label_type.Text = "类型";
            // 
            // dateTimePicker_offersheet_date
            // 
            this.dateTimePicker_offersheet_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_offersheet_date.Location = new System.Drawing.Point(85, 3);
            this.dateTimePicker_offersheet_date.Name = "dateTimePicker_offersheet_date";
            this.dateTimePicker_offersheet_date.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_offersheet_date.TabIndex = 4;
            // 
            // comboBox_offersheet_type
            // 
            this.comboBox_offersheet_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_offersheet_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_offersheet_type.FormattingEnabled = true;
            this.comboBox_offersheet_type.Location = new System.Drawing.Point(400, 4);
            this.comboBox_offersheet_type.Name = "comboBox_offersheet_type";
            this.comboBox_offersheet_type.Size = new System.Drawing.Size(165, 20);
            this.comboBox_offersheet_type.TabIndex = 5;
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
            this.OFFERSHEET_TYPE_DESC,
            this.OFFERSHEET_DATE,
            this.OFFERSHEET_STATE_DESC,
            this.viewBtn,
            this.auditBtn});
            this.dataGridView_OfferSheet.Location = new System.Drawing.Point(13, 47);
            this.dataGridView_OfferSheet.Name = "dataGridView_OfferSheet";
            this.dataGridView_OfferSheet.RowTemplate.Height = 23;
            this.dataGridView_OfferSheet.Size = new System.Drawing.Size(745, 280);
            this.dataGridView_OfferSheet.TabIndex = 1;
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
            // OFFERSHEET_TYPE_DESC
            // 
            this.OFFERSHEET_TYPE_DESC.DataPropertyName = "OFFERSHEET_TYPE_DESC";
            this.OFFERSHEET_TYPE_DESC.HeaderText = "报价单类型";
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
            this.auditBtn.Width = 50;
            // 
            // OSM_Pager_Offer_Audit
            // 
            this.OSM_Pager_Offer_Audit.Location = new System.Drawing.Point(13, 333);
            this.OSM_Pager_Offer_Audit.Name = "OSM_Pager_Offer_Audit";
            this.OSM_Pager_Offer_Audit.Size = new System.Drawing.Size(745, 30);
            this.OSM_Pager_Offer_Audit.TabIndex = 2;
            // 
            // FormOSM_Offers_Audit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 373);
            this.Controls.Add(this.OSM_Pager_Offer_Audit);
            this.Controls.Add(this.dataGridView_OfferSheet);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOSM_Offers_Audit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报价单审核";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OfferSheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.DateTimePicker dateTimePicker_offersheet_date;
        private System.Windows.Forms.ComboBox comboBox_offersheet_type;
        private System.Windows.Forms.DataGridView dataGridView_OfferSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GMF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BJF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_TYPE_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFERSHEET_STATE_DESC;
        private System.Windows.Forms.DataGridViewLinkColumn viewBtn;
        private System.Windows.Forms.DataGridViewLinkColumn auditBtn;
        private OSM_Pager OSM_Pager_Offer_Audit;
    }
}