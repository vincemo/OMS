namespace OSM
{
    partial class OSM_Pager
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_first_page = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_last_page = new System.Windows.Forms.Button();
            this.textBox_page_index = new System.Windows.Forms.TextBox();
            this.button_goToPage = new System.Windows.Forms.Button();
            this.label_currentPage = new System.Windows.Forms.Label();
            this.label_current_page = new System.Windows.Forms.Label();
            this.label_recordSum = new System.Windows.Forms.Label();
            this.label_record_sum = new System.Windows.Forms.Label();
            this.comboBox_recordsPerPage = new System.Windows.Forms.ComboBox();
            this.label_recordsPerPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_first_page
            // 
            this.button_first_page.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_first_page.Location = new System.Drawing.Point(3, 2);
            this.button_first_page.Name = "button_first_page";
            this.button_first_page.Size = new System.Drawing.Size(56, 23);
            this.button_first_page.TabIndex = 0;
            this.button_first_page.Text = "首页";
            this.button_first_page.UseVisualStyleBackColor = true;
            this.button_first_page.Click += new System.EventHandler(this.button_first_page_Click);
            // 
            // button_previous
            // 
            this.button_previous.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_previous.Location = new System.Drawing.Point(65, 2);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(56, 23);
            this.button_previous.TabIndex = 1;
            this.button_previous.Text = "上一页";
            this.button_previous.UseVisualStyleBackColor = true;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // button_next
            // 
            this.button_next.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_next.Location = new System.Drawing.Point(127, 2);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(56, 23);
            this.button_next.TabIndex = 2;
            this.button_next.Text = "下一页";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_last_page
            // 
            this.button_last_page.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_last_page.Location = new System.Drawing.Point(189, 2);
            this.button_last_page.Name = "button_last_page";
            this.button_last_page.Size = new System.Drawing.Size(56, 23);
            this.button_last_page.TabIndex = 3;
            this.button_last_page.Text = "尾页";
            this.button_last_page.UseVisualStyleBackColor = true;
            this.button_last_page.Click += new System.EventHandler(this.button_last_page_Click);
            // 
            // textBox_page_index
            // 
            this.textBox_page_index.Location = new System.Drawing.Point(269, 4);
            this.textBox_page_index.Name = "textBox_page_index";
            this.textBox_page_index.Size = new System.Drawing.Size(23, 21);
            this.textBox_page_index.TabIndex = 4;
            this.textBox_page_index.Text = "1";
            // 
            // button_goToPage
            // 
            this.button_goToPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_goToPage.Location = new System.Drawing.Point(298, 2);
            this.button_goToPage.Name = "button_goToPage";
            this.button_goToPage.Size = new System.Drawing.Size(40, 23);
            this.button_goToPage.TabIndex = 5;
            this.button_goToPage.Text = "跳转";
            this.button_goToPage.UseVisualStyleBackColor = true;
            this.button_goToPage.Click += new System.EventHandler(this.button_goToPage_Click);
            // 
            // label_currentPage
            // 
            this.label_currentPage.AutoSize = true;
            this.label_currentPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_currentPage.Location = new System.Drawing.Point(516, 6);
            this.label_currentPage.Name = "label_currentPage";
            this.label_currentPage.Size = new System.Drawing.Size(47, 17);
            this.label_currentPage.TabIndex = 9;
            this.label_currentPage.Text = "当前页:";
            // 
            // label_current_page
            // 
            this.label_current_page.AutoSize = true;
            this.label_current_page.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_current_page.Location = new System.Drawing.Point(560, 6);
            this.label_current_page.Name = "label_current_page";
            this.label_current_page.Size = new System.Drawing.Size(51, 17);
            this.label_current_page.TabIndex = 8;
            this.label_current_page.Text = "Current";
            // 
            // label_recordSum
            // 
            this.label_recordSum.AutoSize = true;
            this.label_recordSum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_recordSum.Location = new System.Drawing.Point(612, 6);
            this.label_recordSum.Name = "label_recordSum";
            this.label_recordSum.Size = new System.Drawing.Size(59, 17);
            this.label_recordSum.TabIndex = 11;
            this.label_recordSum.Text = "总记录数:";
            // 
            // label_record_sum
            // 
            this.label_record_sum.AutoSize = true;
            this.label_record_sum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_record_sum.Location = new System.Drawing.Point(671, 6);
            this.label_record_sum.Name = "label_record_sum";
            this.label_record_sum.Size = new System.Drawing.Size(72, 17);
            this.label_record_sum.TabIndex = 10;
            this.label_record_sum.Text = "recordSum";
            // 
            // comboBox_recordsPerPage
            // 
            this.comboBox_recordsPerPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_recordsPerPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_recordsPerPage.FormattingEnabled = true;
            this.comboBox_recordsPerPage.Items.AddRange(new object[] {
            "10",
            "20",
            "50"});
            this.comboBox_recordsPerPage.Location = new System.Drawing.Point(432, 0);
            this.comboBox_recordsPerPage.Name = "comboBox_recordsPerPage";
            this.comboBox_recordsPerPage.Size = new System.Drawing.Size(47, 25);
            this.comboBox_recordsPerPage.TabIndex = 12;
            this.comboBox_recordsPerPage.SelectedIndexChanged += new System.EventHandler(this.comboBox_recordsPerPage_SelectedIndexChanged);
            // 
            // label_recordsPerPage
            // 
            this.label_recordsPerPage.AutoSize = true;
            this.label_recordsPerPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_recordsPerPage.Location = new System.Drawing.Point(357, 6);
            this.label_recordsPerPage.Name = "label_recordsPerPage";
            this.label_recordsPerPage.Size = new System.Drawing.Size(71, 17);
            this.label_recordsPerPage.TabIndex = 13;
            this.label_recordsPerPage.Text = "每页记录数:";
            // 
            // OSM_Pager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_recordsPerPage);
            this.Controls.Add(this.comboBox_recordsPerPage);
            this.Controls.Add(this.label_recordSum);
            this.Controls.Add(this.label_record_sum);
            this.Controls.Add(this.label_currentPage);
            this.Controls.Add(this.label_current_page);
            this.Controls.Add(this.button_goToPage);
            this.Controls.Add(this.textBox_page_index);
            this.Controls.Add(this.button_last_page);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_previous);
            this.Controls.Add(this.button_first_page);
            this.Name = "OSM_Pager";
            this.Size = new System.Drawing.Size(750, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_first_page;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_last_page;
        private System.Windows.Forms.TextBox textBox_page_index;
        private System.Windows.Forms.Button button_goToPage;
        private System.Windows.Forms.Label label_currentPage;
        private System.Windows.Forms.Label label_current_page;
        private System.Windows.Forms.Label label_recordSum;
        private System.Windows.Forms.Label label_record_sum;
        private System.Windows.Forms.ComboBox comboBox_recordsPerPage;
        private System.Windows.Forms.Label label_recordsPerPage;
    }
}
