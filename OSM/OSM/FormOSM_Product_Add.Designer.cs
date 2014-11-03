namespace OSM
{
    partial class FormOSM_Product_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_Product_Add));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.label_type = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Code = new System.Windows.Forms.Label();
            this.label_Comment = new System.Windows.Forms.Label();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.textBox_Comment, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Code, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_type, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Code, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Comment, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Type, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Name, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 201);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Comment.Location = new System.Drawing.Point(108, 123);
            this.textBox_Comment.Multiline = true;
            this.textBox_Comment.Name = "textBox_Comment";
            this.tableLayoutPanel1.SetRowSpan(this.textBox_Comment, 2);
            this.textBox_Comment.Size = new System.Drawing.Size(183, 75);
            this.textBox_Comment.TabIndex = 7;
            // 
            // textBox_Code
            // 
            this.textBox_Code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Code.Location = new System.Drawing.Point(108, 88);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(183, 23);
            this.textBox_Code.TabIndex = 6;
            // 
            // label_type
            // 
            this.label_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(18, 11);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(56, 17);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "所属设备";
            // 
            // label_Name
            // 
            this.label_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(18, 51);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(56, 17);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "产品名称";
            // 
            // label_Code
            // 
            this.label_Code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Code.AutoSize = true;
            this.label_Code.Location = new System.Drawing.Point(18, 91);
            this.label_Code.Name = "label_Code";
            this.label_Code.Size = new System.Drawing.Size(56, 17);
            this.label_Code.TabIndex = 2;
            this.label_Code.Text = "产品代码";
            // 
            // label_Comment
            // 
            this.label_Comment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Comment.AutoSize = true;
            this.label_Comment.Location = new System.Drawing.Point(30, 131);
            this.label_Comment.Name = "label_Comment";
            this.label_Comment.Size = new System.Drawing.Size(32, 17);
            this.label_Comment.TabIndex = 3;
            this.label_Comment.Text = "备注";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(109, 10);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(180, 25);
            this.comboBox_Type.TabIndex = 4;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Name.Location = new System.Drawing.Point(108, 48);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(183, 23);
            this.textBox_Name.TabIndex = 5;
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.Location = new System.Drawing.Point(244, 220);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.button_CANCEL.TabIndex = 1;
            this.button_CANCEL.Text = "取消";
            this.button_CANCEL.UseVisualStyleBackColor = true;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(154, 220);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "确认";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // FormOSM_Product_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 255);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOSM_Product_Add";
            this.Text = "新增产品";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Code;
        private System.Windows.Forms.Label label_Comment;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.Button button_OK;
    }
}