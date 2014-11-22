namespace OSM
{
    partial class FormOSM_GetPayed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_GetPayed));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Payment = new System.Windows.Forms.TextBox();
            this.label_RequirePayment = new System.Windows.Forms.Label();
            this.label_Pay = new System.Windows.Forms.Label();
            this.textBox_RequirePayment = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Payment, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_RequirePayment, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Pay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_RequirePayment, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_Payment
            // 
            this.textBox_Payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Payment.Location = new System.Drawing.Point(105, 44);
            this.textBox_Payment.Name = "textBox_Payment";
            this.textBox_Payment.Size = new System.Drawing.Size(187, 23);
            this.textBox_Payment.TabIndex = 3;
            this.textBox_Payment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Payment_KeyPress);
            // 
            // label_RequirePayment
            // 
            this.label_RequirePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_RequirePayment.AutoSize = true;
            this.label_RequirePayment.Location = new System.Drawing.Point(11, 10);
            this.label_RequirePayment.Name = "label_RequirePayment";
            this.label_RequirePayment.Size = new System.Drawing.Size(68, 17);
            this.label_RequirePayment.TabIndex = 0;
            this.label_RequirePayment.Text = "需付款金额";
            // 
            // label_Pay
            // 
            this.label_Pay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Pay.AutoSize = true;
            this.label_Pay.Location = new System.Drawing.Point(17, 47);
            this.label_Pay.Name = "label_Pay";
            this.label_Pay.Size = new System.Drawing.Size(56, 17);
            this.label_Pay.TabIndex = 1;
            this.label_Pay.Text = "付款金额";
            // 
            // textBox_RequirePayment
            // 
            this.textBox_RequirePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_RequirePayment.Location = new System.Drawing.Point(105, 7);
            this.textBox_RequirePayment.Name = "textBox_RequirePayment";
            this.textBox_RequirePayment.ReadOnly = true;
            this.textBox_RequirePayment.Size = new System.Drawing.Size(187, 23);
            this.textBox_RequirePayment.TabIndex = 2;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(118, 93);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "确认";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.Location = new System.Drawing.Point(230, 93);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.button_CANCEL.TabIndex = 2;
            this.button_CANCEL.Text = "取消";
            this.button_CANCEL.UseVisualStyleBackColor = true;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // FormOSM_GetPayed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 128);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOSM_GetPayed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "全款支付";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_RequirePayment;
        private System.Windows.Forms.Label label_Pay;
        private System.Windows.Forms.TextBox textBox_Payment;
        private System.Windows.Forms.TextBox textBox_RequirePayment;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_CANCEL;
    }
}