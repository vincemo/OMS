namespace OSM
{
    partial class FormOSM_OfferSheet_AuditBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_OfferSheet_AuditBox));
            this.label_audit = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_pass = new System.Windows.Forms.Button();
            this.button_unpass = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_audit
            // 
            this.label_audit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.label_audit, 3);
            this.label_audit.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label_audit.Location = new System.Drawing.Point(87, 5);
            this.label_audit.Name = "label_audit";
            this.label_audit.Size = new System.Drawing.Size(132, 30);
            this.label_audit.TabIndex = 0;
            this.label_audit.Text = "是否审核通过";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.button_Cancel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_unpass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_audit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_pass, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 82);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button_pass
            // 
            this.button_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_pass.Location = new System.Drawing.Point(13, 50);
            this.button_pass.Name = "button_pass";
            this.button_pass.Size = new System.Drawing.Size(75, 23);
            this.button_pass.TabIndex = 1;
            this.button_pass.Text = "通过";
            this.button_pass.UseVisualStyleBackColor = true;
            this.button_pass.Click += new System.EventHandler(this.button_pass_Click);
            // 
            // button_unpass
            // 
            this.button_unpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_unpass.Location = new System.Drawing.Point(115, 50);
            this.button_unpass.Name = "button_unpass";
            this.button_unpass.Size = new System.Drawing.Size(75, 23);
            this.button_unpass.TabIndex = 2;
            this.button_unpass.Text = "不通过";
            this.button_unpass.UseVisualStyleBackColor = true;
            this.button_unpass.Click += new System.EventHandler(this.button_unpass_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Cancel.Location = new System.Drawing.Point(218, 50);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // FormOSM_OfferSheet_AuditBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 106);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOSM_OfferSheet_AuditBox";
            this.Text = "报价单审核";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_audit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_unpass;
        private System.Windows.Forms.Button button_pass;
    }
}