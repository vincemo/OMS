namespace OSM
{
    partial class FormOSM_GetRestPayed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_GetRestPayed));
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_RequirePayment = new System.Windows.Forms.Label();
            this.label_PrePayment = new System.Windows.Forms.Label();
            this.textBox_RequirePayment = new System.Windows.Forms.TextBox();
            this.textBox_PrePayment = new System.Windows.Forms.TextBox();
            this.label_Pay = new System.Windows.Forms.Label();
            this.textBox_Payment = new System.Windows.Forms.TextBox();
            this.textBox_RestPayment = new System.Windows.Forms.TextBox();
            this.label_RestPay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.Location = new System.Drawing.Point(229, 158);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.button_CANCEL.TabIndex = 6;
            this.button_CANCEL.Text = "取消";
            this.button_CANCEL.UseVisualStyleBackColor = true;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(117, 158);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "确认";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label_RestPay, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_RequirePayment, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_PrePayment, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_RequirePayment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_PrePayment, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Pay, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Payment, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_RestPayment, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 140);
            this.tableLayoutPanel1.TabIndex = 4;
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
            // label_PrePayment
            // 
            this.label_PrePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PrePayment.AutoSize = true;
            this.label_PrePayment.Location = new System.Drawing.Point(17, 44);
            this.label_PrePayment.Name = "label_PrePayment";
            this.label_PrePayment.Size = new System.Drawing.Size(56, 17);
            this.label_PrePayment.TabIndex = 3;
            this.label_PrePayment.Text = "需预付款";
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
            this.textBox_PrePayment.ReadOnly = true;
            this.textBox_PrePayment.Size = new System.Drawing.Size(187, 23);
            this.textBox_PrePayment.TabIndex = 5;
            // 
            // label_Pay
            // 
            this.label_Pay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Pay.AutoSize = true;
            this.label_Pay.Location = new System.Drawing.Point(17, 114);
            this.label_Pay.Name = "label_Pay";
            this.label_Pay.Size = new System.Drawing.Size(56, 17);
            this.label_Pay.TabIndex = 2;
            this.label_Pay.Text = "付款金额";
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
            // textBox_RestPayment
            // 
            this.textBox_RestPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_RestPayment.Location = new System.Drawing.Point(105, 76);
            this.textBox_RestPayment.Name = "textBox_RestPayment";
            this.textBox_RestPayment.ReadOnly = true;
            this.textBox_RestPayment.Size = new System.Drawing.Size(187, 23);
            this.textBox_RestPayment.TabIndex = 7;
            // 
            // label_RestPay
            // 
            this.label_RestPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_RestPay.AutoSize = true;
            this.label_RestPay.Location = new System.Drawing.Point(11, 79);
            this.label_RestPay.Name = "label_RestPay";
            this.label_RestPay.Size = new System.Drawing.Size(68, 17);
            this.label_RestPay.TabIndex = 8;
            this.label_RestPay.Text = "需付剩余款";
            // 
            // FormOSM_GetRestPayed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 190);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOSM_GetRestPayed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "付剩余款";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_RestPay;
        private System.Windows.Forms.Label label_RequirePayment;
        private System.Windows.Forms.Label label_PrePayment;
        private System.Windows.Forms.TextBox textBox_RequirePayment;
        private System.Windows.Forms.TextBox textBox_PrePayment;
        private System.Windows.Forms.Label label_Pay;
        private System.Windows.Forms.TextBox textBox_Payment;
        private System.Windows.Forms.TextBox textBox_RestPayment;
    }
}