namespace OSM
{
    partial class FormOSM_Purchase_Confirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_Purchase_Confirm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_HWCode = new System.Windows.Forms.Label();
            this.label_HWName = new System.Windows.Forms.Label();
            this.label_HWType = new System.Windows.Forms.Label();
            this.label_PurchaseNumber = new System.Windows.Forms.Label();
            this.label_HWNumber = new System.Windows.Forms.Label();
            this.comboBox_HWType = new System.Windows.Forms.ComboBox();
            this.textBox_HWCode = new System.Windows.Forms.TextBox();
            this.textBox_HWNumber = new System.Windows.Forms.TextBox();
            this.textBox_HWName = new System.Windows.Forms.TextBox();
            this.textBox_PurchaseNumber = new System.Windows.Forms.TextBox();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_PurchaseNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_HWName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_HWNumber, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_HWCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_HWName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_HWType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_PurchaseNumber, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_HWNumber, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_HWType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_HWCode, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 204);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_HWCode
            // 
            this.label_HWCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_HWCode.AutoSize = true;
            this.label_HWCode.Location = new System.Drawing.Point(14, 11);
            this.label_HWCode.Name = "label_HWCode";
            this.label_HWCode.Size = new System.Drawing.Size(56, 17);
            this.label_HWCode.TabIndex = 0;
            this.label_HWCode.Text = "货物代码";
            // 
            // label_HWName
            // 
            this.label_HWName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_HWName.AutoSize = true;
            this.label_HWName.Location = new System.Drawing.Point(14, 51);
            this.label_HWName.Name = "label_HWName";
            this.label_HWName.Size = new System.Drawing.Size(56, 17);
            this.label_HWName.TabIndex = 1;
            this.label_HWName.Text = "货物名称";
            // 
            // label_HWType
            // 
            this.label_HWType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_HWType.AutoSize = true;
            this.label_HWType.Location = new System.Drawing.Point(14, 91);
            this.label_HWType.Name = "label_HWType";
            this.label_HWType.Size = new System.Drawing.Size(56, 17);
            this.label_HWType.TabIndex = 2;
            this.label_HWType.Text = "所属设备";
            // 
            // label_PurchaseNumber
            // 
            this.label_PurchaseNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PurchaseNumber.AutoSize = true;
            this.label_PurchaseNumber.Location = new System.Drawing.Point(8, 131);
            this.label_PurchaseNumber.Name = "label_PurchaseNumber";
            this.label_PurchaseNumber.Size = new System.Drawing.Size(68, 17);
            this.label_PurchaseNumber.TabIndex = 3;
            this.label_PurchaseNumber.Text = "预采购数量";
            // 
            // label_HWNumber
            // 
            this.label_HWNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_HWNumber.AutoSize = true;
            this.label_HWNumber.Location = new System.Drawing.Point(14, 173);
            this.label_HWNumber.Name = "label_HWNumber";
            this.label_HWNumber.Size = new System.Drawing.Size(56, 17);
            this.label_HWNumber.TabIndex = 4;
            this.label_HWNumber.Text = "到货数量";
            // 
            // comboBox_HWType
            // 
            this.comboBox_HWType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_HWType.Enabled = false;
            this.comboBox_HWType.FormattingEnabled = true;
            this.comboBox_HWType.Location = new System.Drawing.Point(99, 90);
            this.comboBox_HWType.Name = "comboBox_HWType";
            this.comboBox_HWType.Size = new System.Drawing.Size(167, 25);
            this.comboBox_HWType.TabIndex = 5;
            // 
            // textBox_HWCode
            // 
            this.textBox_HWCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_HWCode.Location = new System.Drawing.Point(102, 8);
            this.textBox_HWCode.Name = "textBox_HWCode";
            this.textBox_HWCode.ReadOnly = true;
            this.textBox_HWCode.Size = new System.Drawing.Size(161, 23);
            this.textBox_HWCode.TabIndex = 6;
            // 
            // textBox_HWNumber
            // 
            this.textBox_HWNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_HWNumber.Location = new System.Drawing.Point(102, 170);
            this.textBox_HWNumber.Name = "textBox_HWNumber";
            this.textBox_HWNumber.Size = new System.Drawing.Size(161, 23);
            this.textBox_HWNumber.TabIndex = 9;
            this.textBox_HWNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HWNumber_KeyPress);
            // 
            // textBox_HWName
            // 
            this.textBox_HWName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_HWName.Location = new System.Drawing.Point(102, 48);
            this.textBox_HWName.Name = "textBox_HWName";
            this.textBox_HWName.ReadOnly = true;
            this.textBox_HWName.Size = new System.Drawing.Size(161, 23);
            this.textBox_HWName.TabIndex = 10;
            // 
            // textBox_PurchaseNumber
            // 
            this.textBox_PurchaseNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_PurchaseNumber.Location = new System.Drawing.Point(102, 128);
            this.textBox_PurchaseNumber.Name = "textBox_PurchaseNumber";
            this.textBox_PurchaseNumber.ReadOnly = true;
            this.textBox_PurchaseNumber.Size = new System.Drawing.Size(161, 23);
            this.textBox_PurchaseNumber.TabIndex = 11;
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.Location = new System.Drawing.Point(171, 227);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.button_CANCEL.TabIndex = 1;
            this.button_CANCEL.Text = "取消";
            this.button_CANCEL.UseVisualStyleBackColor = true;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(66, 227);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "确认";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // FormOSM_Purchase_Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 261);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOSM_Purchase_Confirm";
            this.Text = "到货确认";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_HWCode;
        private System.Windows.Forms.Label label_HWName;
        private System.Windows.Forms.Label label_HWType;
        private System.Windows.Forms.Label label_PurchaseNumber;
        private System.Windows.Forms.Label label_HWNumber;
        private System.Windows.Forms.TextBox textBox_PurchaseNumber;
        private System.Windows.Forms.TextBox textBox_HWName;
        private System.Windows.Forms.TextBox textBox_HWNumber;
        private System.Windows.Forms.ComboBox comboBox_HWType;
        private System.Windows.Forms.TextBox textBox_HWCode;
        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.Button button_OK;
    }
}