namespace OSM
{
    partial class FormOSM_PayMode_Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_PayMode_Select));
            this.radioButton_lastPay = new System.Windows.Forms.RadioButton();
            this.radioButton_prePay = new System.Windows.Forms.RadioButton();
            this.radioButton_firstPay = new System.Windows.Forms.RadioButton();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_lastPay
            // 
            this.radioButton_lastPay.AutoSize = true;
            this.radioButton_lastPay.Location = new System.Drawing.Point(13, 13);
            this.radioButton_lastPay.Name = "radioButton_lastPay";
            this.radioButton_lastPay.Size = new System.Drawing.Size(74, 21);
            this.radioButton_lastPay.TabIndex = 0;
            this.radioButton_lastPay.TabStop = true;
            this.radioButton_lastPay.Text = "货到付款";
            this.radioButton_lastPay.UseVisualStyleBackColor = true;
            // 
            // radioButton_prePay
            // 
            this.radioButton_prePay.AutoSize = true;
            this.radioButton_prePay.Location = new System.Drawing.Point(123, 13);
            this.radioButton_prePay.Name = "radioButton_prePay";
            this.radioButton_prePay.Size = new System.Drawing.Size(86, 21);
            this.radioButton_prePay.TabIndex = 1;
            this.radioButton_prePay.TabStop = true;
            this.radioButton_prePay.Text = "预付部分款";
            this.radioButton_prePay.UseVisualStyleBackColor = true;
            // 
            // radioButton_firstPay
            // 
            this.radioButton_firstPay.AutoSize = true;
            this.radioButton_firstPay.Location = new System.Drawing.Point(245, 13);
            this.radioButton_firstPay.Name = "radioButton_firstPay";
            this.radioButton_firstPay.Size = new System.Drawing.Size(74, 21);
            this.radioButton_firstPay.TabIndex = 2;
            this.radioButton_firstPay.TabStop = true;
            this.radioButton_firstPay.Text = "全款发货";
            this.radioButton_firstPay.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(129, 45);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 3;
            this.button_OK.Text = "确认";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // FormOSM_PayMode_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 80);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.radioButton_firstPay);
            this.Controls.Add(this.radioButton_prePay);
            this.Controls.Add(this.radioButton_lastPay);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOSM_PayMode_Select";
            this.Text = "请选择付款方式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_lastPay;
        private System.Windows.Forms.RadioButton radioButton_prePay;
        private System.Windows.Forms.RadioButton radioButton_firstPay;
        private System.Windows.Forms.Button button_OK;
    }
}