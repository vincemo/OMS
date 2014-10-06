namespace OSM
{
    partial class AboutBox_OSM
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox_OSM));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProductName_OSM = new System.Windows.Forms.Label();
            this.labelVersion_OSM = new System.Windows.Forms.Label();
            this.labelCopyright_OSM = new System.Windows.Forms.Label();
            this.labelCompanyName_OSM = new System.Windows.Forms.Label();
            this.textBoxDescription_OSM = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProductName_OSM, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion_OSM, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright_OSM, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCompanyName_OSM, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription_OSM, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 8);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.375F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.625F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(288, 160);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(89, 154);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // labelProductName_OSM
            // 
            this.labelProductName_OSM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName_OSM.Location = new System.Drawing.Point(101, 0);
            this.labelProductName_OSM.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName_OSM.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelProductName_OSM.Name = "labelProductName_OSM";
            this.labelProductName_OSM.Size = new System.Drawing.Size(184, 16);
            this.labelProductName_OSM.TabIndex = 19;
            this.labelProductName_OSM.Text = "订单信息管理系统";
            this.labelProductName_OSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion_OSM
            // 
            this.labelVersion_OSM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion_OSM.Location = new System.Drawing.Point(101, 16);
            this.labelVersion_OSM.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion_OSM.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelVersion_OSM.Name = "labelVersion_OSM";
            this.labelVersion_OSM.Size = new System.Drawing.Size(184, 16);
            this.labelVersion_OSM.TabIndex = 0;
            this.labelVersion_OSM.Text = "版本 v0.1";
            this.labelVersion_OSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright_OSM
            // 
            this.labelCopyright_OSM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright_OSM.Location = new System.Drawing.Point(101, 32);
            this.labelCopyright_OSM.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCopyright_OSM.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelCopyright_OSM.Name = "labelCopyright_OSM";
            this.labelCopyright_OSM.Size = new System.Drawing.Size(184, 16);
            this.labelCopyright_OSM.TabIndex = 21;
            this.labelCopyright_OSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName_OSM
            // 
            this.labelCompanyName_OSM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCompanyName_OSM.Location = new System.Drawing.Point(101, 48);
            this.labelCompanyName_OSM.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCompanyName_OSM.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelCompanyName_OSM.Name = "labelCompanyName_OSM";
            this.labelCompanyName_OSM.Size = new System.Drawing.Size(184, 16);
            this.labelCompanyName_OSM.TabIndex = 22;
            this.labelCompanyName_OSM.Text = "OSM Com.Inc";
            this.labelCompanyName_OSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription_OSM
            // 
            this.textBoxDescription_OSM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription_OSM.Location = new System.Drawing.Point(101, 67);
            this.textBoxDescription_OSM.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription_OSM.Multiline = true;
            this.textBoxDescription_OSM.Name = "textBoxDescription_OSM";
            this.textBoxDescription_OSM.ReadOnly = true;
            this.textBoxDescription_OSM.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription_OSM.Size = new System.Drawing.Size(184, 57);
            this.textBoxDescription_OSM.TabIndex = 23;
            this.textBoxDescription_OSM.TabStop = false;
            this.textBoxDescription_OSM.Text = "试用版";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(210, 136);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 21);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "确定(&O)";
            // 
            // AboutBox_OSM
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 176);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox_OSM";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName_OSM;
        private System.Windows.Forms.Label labelVersion_OSM;
        private System.Windows.Forms.Label labelCopyright_OSM;
        private System.Windows.Forms.Label labelCompanyName_OSM;
        private System.Windows.Forms.TextBox textBoxDescription_OSM;
        private System.Windows.Forms.Button okButton;
    }
}
