namespace OSM
{
    partial class FormOSM_Login
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_Login));
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.TB_PWD = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(102, 40);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(154, 21);
            this.TB_UserName.TabIndex = 0;
            // 
            // TB_PWD
            // 
            this.TB_PWD.Location = new System.Drawing.Point(102, 100);
            this.TB_PWD.Name = "TB_PWD";
            this.TB_PWD.PasswordChar = '*';
            this.TB_PWD.Size = new System.Drawing.Size(154, 21);
            this.TB_PWD.TabIndex = 1;
            this.TB_PWD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_PWD_KeyDown);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.Location = new System.Drawing.Point(21, 40);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(58, 21);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "用户名";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_pwd.Location = new System.Drawing.Point(37, 100);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(42, 21);
            this.label_pwd.TabIndex = 3;
            this.label_pwd.Text = "密码";
            this.label_pwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_LOGIN.Location = new System.Drawing.Point(41, 157);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(75, 34);
            this.BTN_LOGIN.TabIndex = 4;
            this.BTN_LOGIN.Text = "登录";
            this.BTN_LOGIN.UseVisualStyleBackColor = true;
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_CANCEL.Location = new System.Drawing.Point(162, 157);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(75, 34);
            this.BTN_CANCEL.TabIndex = 5;
            this.BTN_CANCEL.Text = "退出";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // FormOSM_Login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(287, 207);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_LOGIN);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.TB_PWD);
            this.Controls.Add(this.TB_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOSM_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.TextBox TB_PWD;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.Button BTN_LOGIN;
        private System.Windows.Forms.Button BTN_CANCEL;
    }
}

