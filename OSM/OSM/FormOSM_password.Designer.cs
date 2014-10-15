namespace OSM
{
    partial class FormOSM_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_password));
            this.label_old_pwd = new System.Windows.Forms.Label();
            this.label_new_pwd = new System.Windows.Forms.Label();
            this.label_pwd_confirm = new System.Windows.Forms.Label();
            this.textBox_old_pwd = new System.Windows.Forms.TextBox();
            this.textBox_new_pwd = new System.Windows.Forms.TextBox();
            this.textBox_pwd_confirm = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Password = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_old_pwd
            // 
            this.label_old_pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_old_pwd.AutoSize = true;
            this.label_old_pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_old_pwd.Location = new System.Drawing.Point(8, 5);
            this.label_old_pwd.Name = "label_old_pwd";
            this.label_old_pwd.Size = new System.Drawing.Size(74, 21);
            this.label_old_pwd.TabIndex = 0;
            this.label_old_pwd.Text = "当前密码";
            // 
            // label_new_pwd
            // 
            this.label_new_pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_new_pwd.AutoSize = true;
            this.label_new_pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_new_pwd.Location = new System.Drawing.Point(8, 37);
            this.label_new_pwd.Name = "label_new_pwd";
            this.label_new_pwd.Size = new System.Drawing.Size(74, 21);
            this.label_new_pwd.TabIndex = 1;
            this.label_new_pwd.Text = "更改密码";
            // 
            // label_pwd_confirm
            // 
            this.label_pwd_confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_pwd_confirm.AutoSize = true;
            this.label_pwd_confirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_pwd_confirm.Location = new System.Drawing.Point(8, 69);
            this.label_pwd_confirm.Name = "label_pwd_confirm";
            this.label_pwd_confirm.Size = new System.Drawing.Size(74, 21);
            this.label_pwd_confirm.TabIndex = 2;
            this.label_pwd_confirm.Text = "确认密码";
            // 
            // textBox_old_pwd
            // 
            this.textBox_old_pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_Password.SetColumnSpan(this.textBox_old_pwd, 2);
            this.textBox_old_pwd.Location = new System.Drawing.Point(100, 5);
            this.textBox_old_pwd.Name = "textBox_old_pwd";
            this.textBox_old_pwd.PasswordChar = '*';
            this.textBox_old_pwd.Size = new System.Drawing.Size(165, 21);
            this.textBox_old_pwd.TabIndex = 3;
            // 
            // textBox_new_pwd
            // 
            this.textBox_new_pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_Password.SetColumnSpan(this.textBox_new_pwd, 2);
            this.textBox_new_pwd.Location = new System.Drawing.Point(100, 37);
            this.textBox_new_pwd.Name = "textBox_new_pwd";
            this.textBox_new_pwd.PasswordChar = '*';
            this.textBox_new_pwd.Size = new System.Drawing.Size(165, 21);
            this.textBox_new_pwd.TabIndex = 4;
            // 
            // textBox_pwd_confirm
            // 
            this.textBox_pwd_confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_Password.SetColumnSpan(this.textBox_pwd_confirm, 2);
            this.textBox_pwd_confirm.Location = new System.Drawing.Point(100, 69);
            this.textBox_pwd_confirm.Name = "textBox_pwd_confirm";
            this.textBox_pwd_confirm.PasswordChar = '*';
            this.textBox_pwd_confirm.Size = new System.Drawing.Size(165, 21);
            this.textBox_pwd_confirm.TabIndex = 5;
            // 
            // button_OK
            // 
            this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OK.Location = new System.Drawing.Point(99, 102);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "确认";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_CANCEL.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_CANCEL.Location = new System.Drawing.Point(190, 102);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.button_CANCEL.TabIndex = 7;
            this.button_CANCEL.Text = "取消";
            this.button_CANCEL.UseVisualStyleBackColor = true;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // tableLayoutPanel_Password
            // 
            this.tableLayoutPanel_Password.ColumnCount = 3;
            this.tableLayoutPanel_Password.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Password.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_Password.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_Password.Controls.Add(this.label_old_pwd, 0, 0);
            this.tableLayoutPanel_Password.Controls.Add(this.button_CANCEL, 2, 3);
            this.tableLayoutPanel_Password.Controls.Add(this.label_new_pwd, 0, 1);
            this.tableLayoutPanel_Password.Controls.Add(this.button_OK, 1, 3);
            this.tableLayoutPanel_Password.Controls.Add(this.label_pwd_confirm, 0, 2);
            this.tableLayoutPanel_Password.Controls.Add(this.textBox_pwd_confirm, 1, 2);
            this.tableLayoutPanel_Password.Controls.Add(this.textBox_old_pwd, 1, 0);
            this.tableLayoutPanel_Password.Controls.Add(this.textBox_new_pwd, 1, 1);
            this.tableLayoutPanel_Password.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel_Password.Name = "tableLayoutPanel_Password";
            this.tableLayoutPanel_Password.RowCount = 4;
            this.tableLayoutPanel_Password.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Password.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Password.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Password.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Password.Size = new System.Drawing.Size(274, 131);
            this.tableLayoutPanel_Password.TabIndex = 8;
            // 
            // FormOSM_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 154);
            this.Controls.Add(this.tableLayoutPanel_Password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOSM_password";
            this.Text = "修改密码";
            this.tableLayoutPanel_Password.ResumeLayout(false);
            this.tableLayoutPanel_Password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_old_pwd;
        private System.Windows.Forms.Label label_new_pwd;
        private System.Windows.Forms.Label label_pwd_confirm;
        private System.Windows.Forms.TextBox textBox_old_pwd;
        private System.Windows.Forms.TextBox textBox_new_pwd;
        private System.Windows.Forms.TextBox textBox_pwd_confirm;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Password;
    }
}