namespace OSM
{
    partial class FormOSM_Order_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_Order_View));
            this.groupBox_OrderInfo = new System.Windows.Forms.GroupBox();
            this.groupBox_HW = new System.Windows.Forms.GroupBox();
            this.dataGridView_HW = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_OfferSheetCode = new System.Windows.Forms.Label();
            this.textBox_OfferSheetCode = new System.Windows.Forms.TextBox();
            this.label_OrderState = new System.Windows.Forms.Label();
            this.comboBox_OrderState = new System.Windows.Forms.ComboBox();
            this.label_OrderDate = new System.Windows.Forms.Label();
            this.dateTimePicker_OrderDate = new System.Windows.Forms.DateTimePicker();
            this.label_PayMode = new System.Windows.Forms.Label();
            this.comboBox_PayMode = new System.Windows.Forms.ComboBox();
            this.label_PayState = new System.Windows.Forms.Label();
            this.comboBox_PayState = new System.Windows.Forms.ComboBox();
            this.label_AlreadyPay = new System.Windows.Forms.Label();
            this.label_RequirePayment = new System.Windows.Forms.Label();
            this.textBox_AlreadyPayment = new System.Windows.Forms.TextBox();
            this.textBox_RequirePayment = new System.Windows.Forms.TextBox();
            this.label_PrePayment = new System.Windows.Forms.Label();
            this.textBox_PrePayment = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.HW_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HW_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HW_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HW_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HW_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_OrderInfo.SuspendLayout();
            this.groupBox_HW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HW)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_OrderInfo
            // 
            this.groupBox_OrderInfo.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_OrderInfo.Location = new System.Drawing.Point(13, 13);
            this.groupBox_OrderInfo.Name = "groupBox_OrderInfo";
            this.groupBox_OrderInfo.Size = new System.Drawing.Size(464, 187);
            this.groupBox_OrderInfo.TabIndex = 0;
            this.groupBox_OrderInfo.TabStop = false;
            this.groupBox_OrderInfo.Text = "订单信息";
            // 
            // groupBox_HW
            // 
            this.groupBox_HW.Controls.Add(this.dataGridView_HW);
            this.groupBox_HW.Location = new System.Drawing.Point(13, 216);
            this.groupBox_HW.Name = "groupBox_HW";
            this.groupBox_HW.Size = new System.Drawing.Size(464, 182);
            this.groupBox_HW.TabIndex = 1;
            this.groupBox_HW.TabStop = false;
            this.groupBox_HW.Text = "订单货物记录";
            // 
            // dataGridView_HW
            // 
            this.dataGridView_HW.AllowUserToAddRows = false;
            this.dataGridView_HW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HW_NAME,
            this.HW_TYPE,
            this.HW_CODE,
            this.HW_NUMBER,
            this.HW_PRICE});
            this.dataGridView_HW.Location = new System.Drawing.Point(7, 23);
            this.dataGridView_HW.Name = "dataGridView_HW";
            this.dataGridView_HW.RowTemplate.Height = 23;
            this.dataGridView_HW.Size = new System.Drawing.Size(451, 150);
            this.dataGridView_HW.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label_OfferSheetCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_OfferSheetCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_OrderState, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_OrderState, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_OrderDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_OrderDate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_PayMode, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_PayMode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_PayState, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_PayState, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_AlreadyPay, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_AlreadyPayment, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_PrePayment, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_PrePayment, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_RequirePayment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_RequirePayment, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 158);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_OfferSheetCode
            // 
            this.label_OfferSheetCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_OfferSheetCode.AutoSize = true;
            this.label_OfferSheetCode.Location = new System.Drawing.Point(22, 7);
            this.label_OfferSheetCode.Name = "label_OfferSheetCode";
            this.label_OfferSheetCode.Size = new System.Drawing.Size(68, 17);
            this.label_OfferSheetCode.TabIndex = 0;
            this.label_OfferSheetCode.Text = "报价单编号";
            // 
            // textBox_OfferSheetCode
            // 
            this.textBox_OfferSheetCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_OfferSheetCode, 2);
            this.textBox_OfferSheetCode.Location = new System.Drawing.Point(115, 4);
            this.textBox_OfferSheetCode.Name = "textBox_OfferSheetCode";
            this.textBox_OfferSheetCode.Size = new System.Drawing.Size(218, 23);
            this.textBox_OfferSheetCode.TabIndex = 1;
            // 
            // label_OrderState
            // 
            this.label_OrderState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_OrderState.AutoSize = true;
            this.label_OrderState.Location = new System.Drawing.Point(28, 38);
            this.label_OrderState.Name = "label_OrderState";
            this.label_OrderState.Size = new System.Drawing.Size(56, 17);
            this.label_OrderState.TabIndex = 2;
            this.label_OrderState.Text = "订单状态";
            // 
            // comboBox_OrderState
            // 
            this.comboBox_OrderState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_OrderState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OrderState.FormattingEnabled = true;
            this.comboBox_OrderState.Location = new System.Drawing.Point(115, 36);
            this.comboBox_OrderState.Name = "comboBox_OrderState";
            this.comboBox_OrderState.Size = new System.Drawing.Size(106, 25);
            this.comboBox_OrderState.TabIndex = 3;
            // 
            // label_OrderDate
            // 
            this.label_OrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_OrderDate.AutoSize = true;
            this.label_OrderDate.Location = new System.Drawing.Point(252, 38);
            this.label_OrderDate.Name = "label_OrderDate";
            this.label_OrderDate.Size = new System.Drawing.Size(56, 17);
            this.label_OrderDate.TabIndex = 4;
            this.label_OrderDate.Text = "订单日期";
            // 
            // dateTimePicker_OrderDate
            // 
            this.dateTimePicker_OrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_OrderDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_OrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_OrderDate.Location = new System.Drawing.Point(339, 36);
            this.dateTimePicker_OrderDate.Name = "dateTimePicker_OrderDate";
            this.dateTimePicker_OrderDate.Size = new System.Drawing.Size(109, 23);
            this.dateTimePicker_OrderDate.TabIndex = 5;
            // 
            // label_PayMode
            // 
            this.label_PayMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PayMode.AutoSize = true;
            this.label_PayMode.Location = new System.Drawing.Point(28, 69);
            this.label_PayMode.Name = "label_PayMode";
            this.label_PayMode.Size = new System.Drawing.Size(56, 17);
            this.label_PayMode.TabIndex = 6;
            this.label_PayMode.Text = "付款方式";
            // 
            // comboBox_PayMode
            // 
            this.comboBox_PayMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_PayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PayMode.FormattingEnabled = true;
            this.comboBox_PayMode.Location = new System.Drawing.Point(115, 65);
            this.comboBox_PayMode.Name = "comboBox_PayMode";
            this.comboBox_PayMode.Size = new System.Drawing.Size(106, 25);
            this.comboBox_PayMode.TabIndex = 7;
            this.comboBox_PayMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_PayMode_SelectedIndexChanged);
            // 
            // label_PayState
            // 
            this.label_PayState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PayState.AutoSize = true;
            this.label_PayState.Location = new System.Drawing.Point(252, 69);
            this.label_PayState.Name = "label_PayState";
            this.label_PayState.Size = new System.Drawing.Size(56, 17);
            this.label_PayState.TabIndex = 8;
            this.label_PayState.Text = "付款状态";
            // 
            // comboBox_PayState
            // 
            this.comboBox_PayState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_PayState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PayState.FormattingEnabled = true;
            this.comboBox_PayState.Location = new System.Drawing.Point(340, 65);
            this.comboBox_PayState.Name = "comboBox_PayState";
            this.comboBox_PayState.Size = new System.Drawing.Size(106, 25);
            this.comboBox_PayState.TabIndex = 9;
            // 
            // label_AlreadyPay
            // 
            this.label_AlreadyPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_AlreadyPay.AutoSize = true;
            this.label_AlreadyPay.Location = new System.Drawing.Point(34, 100);
            this.label_AlreadyPay.Name = "label_AlreadyPay";
            this.label_AlreadyPay.Size = new System.Drawing.Size(44, 17);
            this.label_AlreadyPay.TabIndex = 10;
            this.label_AlreadyPay.Text = "已付款";
            // 
            // label_RequirePayment
            // 
            this.label_RequirePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_RequirePayment.AutoSize = true;
            this.label_RequirePayment.Location = new System.Drawing.Point(34, 132);
            this.label_RequirePayment.Name = "label_RequirePayment";
            this.label_RequirePayment.Size = new System.Drawing.Size(44, 17);
            this.label_RequirePayment.TabIndex = 11;
            this.label_RequirePayment.Text = "应付款";
            // 
            // textBox_AlreadyPayment
            // 
            this.textBox_AlreadyPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_AlreadyPayment.Location = new System.Drawing.Point(118, 97);
            this.textBox_AlreadyPayment.Name = "textBox_AlreadyPayment";
            this.textBox_AlreadyPayment.Size = new System.Drawing.Size(100, 23);
            this.textBox_AlreadyPayment.TabIndex = 12;
            // 
            // textBox_RequirePayment
            // 
            this.textBox_RequirePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_RequirePayment.Location = new System.Drawing.Point(118, 129);
            this.textBox_RequirePayment.Name = "textBox_RequirePayment";
            this.textBox_RequirePayment.Size = new System.Drawing.Size(100, 23);
            this.textBox_RequirePayment.TabIndex = 13;
            // 
            // label_PrePayment
            // 
            this.label_PrePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PrePayment.AutoSize = true;
            this.label_PrePayment.Location = new System.Drawing.Point(258, 100);
            this.label_PrePayment.Name = "label_PrePayment";
            this.label_PrePayment.Size = new System.Drawing.Size(44, 17);
            this.label_PrePayment.TabIndex = 14;
            this.label_PrePayment.Text = "预付款";
            // 
            // textBox_PrePayment
            // 
            this.textBox_PrePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_PrePayment.Location = new System.Drawing.Point(343, 97);
            this.textBox_PrePayment.Name = "textBox_PrePayment";
            this.textBox_PrePayment.Size = new System.Drawing.Size(100, 23);
            this.textBox_PrePayment.TabIndex = 15;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(281, 404);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "确认";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.Location = new System.Drawing.Point(388, 404);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.button_CANCEL.TabIndex = 3;
            this.button_CANCEL.Text = "关闭";
            this.button_CANCEL.UseVisualStyleBackColor = true;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // HW_NAME
            // 
            this.HW_NAME.DataPropertyName = "HW_NAME";
            this.HW_NAME.HeaderText = "名称";
            this.HW_NAME.Name = "HW_NAME";
            // 
            // HW_TYPE
            // 
            this.HW_TYPE.DataPropertyName = "HW_TYPE";
            this.HW_TYPE.HeaderText = "种类";
            this.HW_TYPE.Name = "HW_TYPE";
            // 
            // HW_CODE
            // 
            this.HW_CODE.DataPropertyName = "HW_CODE";
            this.HW_CODE.HeaderText = "代码";
            this.HW_CODE.Name = "HW_CODE";
            // 
            // HW_NUMBER
            // 
            this.HW_NUMBER.DataPropertyName = "HW_NUMBER";
            this.HW_NUMBER.HeaderText = "数量";
            this.HW_NUMBER.Name = "HW_NUMBER";
            // 
            // HW_PRICE
            // 
            this.HW_PRICE.DataPropertyName = "HW_PRICE";
            this.HW_PRICE.HeaderText = "单价";
            this.HW_PRICE.Name = "HW_PRICE";
            // 
            // FormOSM_Order_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 435);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox_HW);
            this.Controls.Add(this.groupBox_OrderInfo);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOSM_Order_View";
            this.Text = "订单查看";
            this.groupBox_OrderInfo.ResumeLayout(false);
            this.groupBox_HW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HW)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_OrderInfo;
        private System.Windows.Forms.GroupBox groupBox_HW;
        private System.Windows.Forms.DataGridView dataGridView_HW;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_OfferSheetCode;
        private System.Windows.Forms.TextBox textBox_OfferSheetCode;
        private System.Windows.Forms.Label label_OrderState;
        private System.Windows.Forms.ComboBox comboBox_OrderState;
        private System.Windows.Forms.Label label_OrderDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_OrderDate;
        private System.Windows.Forms.Label label_PayMode;
        private System.Windows.Forms.ComboBox comboBox_PayMode;
        private System.Windows.Forms.Label label_PayState;
        private System.Windows.Forms.ComboBox comboBox_PayState;
        private System.Windows.Forms.Label label_AlreadyPay;
        private System.Windows.Forms.Label label_RequirePayment;
        private System.Windows.Forms.TextBox textBox_AlreadyPayment;
        private System.Windows.Forms.TextBox textBox_RequirePayment;
        private System.Windows.Forms.Label label_PrePayment;
        private System.Windows.Forms.TextBox textBox_PrePayment;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn HW_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn HW_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HW_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HW_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn HW_PRICE;
    }
}