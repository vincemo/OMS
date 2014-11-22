namespace OSM
{
    partial class FormOSM_GetPrePayed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_GetPrePayed));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_RequirePayment = new System.Windows.Forms.Label();
            this.label_Pay = new System.Windows.Forms.Label();
            this.label_PrePayment = new System.Windows.Forms.Label();
            this.textBox_RequirePayment = new System.Windows.Forms.TextBox();
            this.textBox_PrePayment = new System.Windows.Forms.TextBox();
            this.textBox_Payment = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.label_Tips = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label_RequirePayment, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_PrePayment, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_RequirePayment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_PrePayment, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Pay, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Payment, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_Tips, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_RequirePayment
            // 
            this.label_RequirePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_RequirePayment.AutoSize = true;
            this.label_RequirePayment.Location = new System.Drawing.Point(5, 9);
            this.label_RequirePayment.Name = "label_RequirePayment";
            this.label_RequirePayment.Size = new System.Drawing.Size(80, 17);
            this.label_RequirePayment.TabIndex = 1;
            this.label_RequirePayment.Text = "需付款总金额";
            // 
            // label_Pay
            // 
            this.label_Pay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Pay.AutoSize = true;
            this.label_Pay.Location = new System.Drawing.Point(11, 114);
            this.label_Pay.Name = "label_Pay";
            this.label_Pay.Size = new System.Drawing.Size(68, 17);
            this.label_Pay.TabIndex = 2;
            this.label_Pay.Text = "预付款金额";
            // 
            // label_PrePayment
            // 
            this.label_PrePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PrePayment.AutoSize = true;
            this.label_PrePayment.Location = new System.Drawing.Point(5, 44);
            this.label_PrePayment.Name = "label_PrePayment";
            this.label_PrePayment.Size = new System.Drawing.Size(80, 17);
            this.label_PrePayment.TabIndex = 3;
            this.label_PrePayment.Text = "需预付款金额";
            // 
            // textBox_RequirePayment
            // 
            this.textBox_RequirePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_RequirePayment.Location = new System.Drawing.Point(105, 6);
            this.textBox_RequirePayment.Name = "textBox_RequirePayment";
            this.textBox_RequirePayment.ReadOnly = true;
            this.textBox_RequirePayment.Size = new System.Drawing.Size(187, 23);
            this.textBox_RequirePayment.TabIndex = 4;
            // 
            // textBox_PrePayment
            // 
            this.textBox_PrePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_PrePayment.Location = new System.Drawing.Point(105, 41);
            this.textBox_PrePayment.Name = "textBox_PrePayment";
            this.textBox_PrePayment.Size = new System.Drawing.Size(187, 23);
            this.textBox_PrePayment.TabIndex = 5;
            this.textBox_PrePayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PrePayment_KeyPress);
            // 
            // textBox_Payment
            // 
            this.textBox_Payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Payment.Location = new System.Drawing.Point(105, 111);
            this.textBox_Payment.Name = "textBox_Payment";
            this.textBox_Payment.Size = new System.Drawing.Size(187, 23);
            this.textBox_Payment.TabIndex = 6;
            this.textBox_Payment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Payment_KeyPress);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(118, 159);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "确认";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.Location = new System.Drawing.Point(230, 159);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.button_CANCEL.TabIndex = 3;
            this.button_CANCEL.Text = "取消";
            this.button_CANCEL.UseVisualStyleBackColor = true;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // label_Tips
            // 
            this.label_Tips.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Tips.AutoSize = true;
            this.label_Tips.Location = new System.Drawing.Point(122, 79);
            this.label_Tips.Name = "label_Tips";
            this.label_Tips.Size = new System.Drawing.Size(153, 17);
            this.label_Tips.TabIndex = 7;
            this.label_Tips.Text = "（默认按照总金额的10%）";
            // 
            // FormOSM_GetPrePayed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 194);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOSM_GetPrePayed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "预付部分款";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_RequirePayment;
        private System.Windows.Forms.Label label_Pay;
        private System.Windows.Forms.Label label_PrePayment;
        private System.Windows.Forms.TextBox textBox_RequirePayment;
        private System.Windows.Forms.TextBox textBox_PrePayment;
        private System.Windows.Forms.TextBox textBox_Payment;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.Label label_Tips;
    }
}