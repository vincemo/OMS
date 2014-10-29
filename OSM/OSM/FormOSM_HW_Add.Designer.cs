namespace OSM
{
    partial class FormOSM_HW_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_HW_Add));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.label_comment_hw = new System.Windows.Forms.Label();
            this.textBox_HW_COMMENT = new System.Windows.Forms.TextBox();
            this.textBox_HW_NUMBER = new System.Windows.Forms.TextBox();
            this.textBox_HW_PRICE = new System.Windows.Forms.TextBox();
            this.label_number_hw = new System.Windows.Forms.Label();
            this.label_price_hw = new System.Windows.Forms.Label();
            this.comboBox_HW_TYPE = new System.Windows.Forms.ComboBox();
            this.label_type_hw = new System.Windows.Forms.Label();
            this.label_code_hw = new System.Windows.Forms.Label();
            this.textBox_HW_CODE = new System.Windows.Forms.TextBox();
            this.label_name_hw = new System.Windows.Forms.Label();
            this.textBox_HW_NAME = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button_OK, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.button_CANCEL, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label_comment_hw, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_HW_COMMENT, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_HW_NUMBER, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_HW_PRICE, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_number_hw, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_price_hw, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_HW_TYPE, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_type_hw, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_code_hw, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_HW_CODE, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_name_hw, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_HW_NAME, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 210);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_OK
            // 
            this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_OK.Location = new System.Drawing.Point(232, 180);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 14;
            this.button_OK.Text = "确认添加";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_CANCEL.Location = new System.Drawing.Point(342, 180);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.button_CANCEL.TabIndex = 15;
            this.button_CANCEL.Text = "取消添加";
            this.button_CANCEL.UseVisualStyleBackColor = true;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // label_comment_hw
            // 
            this.label_comment_hw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_comment_hw.AutoSize = true;
            this.label_comment_hw.Location = new System.Drawing.Point(38, 122);
            this.label_comment_hw.Name = "label_comment_hw";
            this.label_comment_hw.Size = new System.Drawing.Size(32, 17);
            this.label_comment_hw.TabIndex = 7;
            this.label_comment_hw.Text = "备注";
            // 
            // textBox_HW_COMMENT
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_HW_COMMENT, 3);
            this.textBox_HW_COMMENT.Location = new System.Drawing.Point(111, 119);
            this.textBox_HW_COMMENT.Multiline = true;
            this.textBox_HW_COMMENT.Name = "textBox_HW_COMMENT";
            this.tableLayoutPanel1.SetRowSpan(this.textBox_HW_COMMENT, 2);
            this.textBox_HW_COMMENT.Size = new System.Drawing.Size(321, 52);
            this.textBox_HW_COMMENT.TabIndex = 13;
            // 
            // textBox_HW_NUMBER
            // 
            this.textBox_HW_NUMBER.Location = new System.Drawing.Point(111, 90);
            this.textBox_HW_NUMBER.Name = "textBox_HW_NUMBER";
            this.textBox_HW_NUMBER.Size = new System.Drawing.Size(100, 23);
            this.textBox_HW_NUMBER.TabIndex = 11;
            this.textBox_HW_NUMBER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HW_NUMBER_KeyPress);
            // 
            // textBox_HW_PRICE
            // 
            this.textBox_HW_PRICE.Location = new System.Drawing.Point(327, 90);
            this.textBox_HW_PRICE.Name = "textBox_HW_PRICE";
            this.textBox_HW_PRICE.Size = new System.Drawing.Size(100, 23);
            this.textBox_HW_PRICE.TabIndex = 12;
            this.textBox_HW_PRICE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HW_PRICE_KeyPress);
            // 
            // label_number_hw
            // 
            this.label_number_hw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_number_hw.AutoSize = true;
            this.label_number_hw.Location = new System.Drawing.Point(38, 93);
            this.label_number_hw.Name = "label_number_hw";
            this.label_number_hw.Size = new System.Drawing.Size(32, 17);
            this.label_number_hw.TabIndex = 5;
            this.label_number_hw.Text = "数量";
            // 
            // label_price_hw
            // 
            this.label_price_hw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_price_hw.AutoSize = true;
            this.label_price_hw.Location = new System.Drawing.Point(254, 93);
            this.label_price_hw.Name = "label_price_hw";
            this.label_price_hw.Size = new System.Drawing.Size(32, 17);
            this.label_price_hw.TabIndex = 6;
            this.label_price_hw.Text = "单价";
            // 
            // comboBox_HW_TYPE
            // 
            this.comboBox_HW_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HW_TYPE.FormattingEnabled = true;
            this.comboBox_HW_TYPE.Location = new System.Drawing.Point(327, 61);
            this.comboBox_HW_TYPE.Name = "comboBox_HW_TYPE";
            this.comboBox_HW_TYPE.Size = new System.Drawing.Size(100, 25);
            this.comboBox_HW_TYPE.TabIndex = 10;
            this.comboBox_HW_TYPE.SelectedIndexChanged += new System.EventHandler(this.comboBox_HW_TYPE_SelectedIndexChanged);
            // 
            // label_type_hw
            // 
            this.label_type_hw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_type_hw.AutoSize = true;
            this.label_type_hw.Location = new System.Drawing.Point(230, 64);
            this.label_type_hw.Name = "label_type_hw";
            this.label_type_hw.Size = new System.Drawing.Size(80, 17);
            this.label_type_hw.TabIndex = 4;
            this.label_type_hw.Text = "产品所属设备";
            // 
            // label_code_hw
            // 
            this.label_code_hw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_code_hw.AutoSize = true;
            this.label_code_hw.Location = new System.Drawing.Point(38, 64);
            this.label_code_hw.Name = "label_code_hw";
            this.label_code_hw.Size = new System.Drawing.Size(32, 17);
            this.label_code_hw.TabIndex = 3;
            this.label_code_hw.Text = "代码";
            // 
            // textBox_HW_CODE
            // 
            this.textBox_HW_CODE.Location = new System.Drawing.Point(111, 61);
            this.textBox_HW_CODE.Name = "textBox_HW_CODE";
            this.textBox_HW_CODE.Size = new System.Drawing.Size(100, 23);
            this.textBox_HW_CODE.TabIndex = 9;
            // 
            // label_name_hw
            // 
            this.label_name_hw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_name_hw.AutoSize = true;
            this.label_name_hw.Location = new System.Drawing.Point(38, 35);
            this.label_name_hw.Name = "label_name_hw";
            this.label_name_hw.Size = new System.Drawing.Size(32, 17);
            this.label_name_hw.TabIndex = 2;
            this.label_name_hw.Text = "名称";
            // 
            // textBox_HW_NAME
            // 
            this.textBox_HW_NAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_HW_NAME, 2);
            this.textBox_HW_NAME.Location = new System.Drawing.Point(111, 32);
            this.textBox_HW_NAME.Name = "textBox_HW_NAME";
            this.textBox_HW_NAME.Size = new System.Drawing.Size(210, 23);
            this.textBox_HW_NAME.TabIndex = 8;
            // 
            // FormOSM_HW_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOSM_HW_Add";
            this.Text = "新增货物";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_name_hw;
        private System.Windows.Forms.Label label_code_hw;
        private System.Windows.Forms.TextBox textBox_HW_NAME;
        private System.Windows.Forms.Label label_type_hw;
        private System.Windows.Forms.Label label_number_hw;
        private System.Windows.Forms.Label label_price_hw;
        private System.Windows.Forms.TextBox textBox_HW_CODE;
        private System.Windows.Forms.ComboBox comboBox_HW_TYPE;
        private System.Windows.Forms.TextBox textBox_HW_NUMBER;
        private System.Windows.Forms.TextBox textBox_HW_PRICE;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.Label label_comment_hw;
        private System.Windows.Forms.TextBox textBox_HW_COMMENT;
    }
}