
namespace MySchool
{
    partial class FrmLogin
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.btnDl = new System.Windows.Forms.Button();
            this.btnQx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.Location = new System.Drawing.Point(180, 190);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 17);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "用户名:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(180, 227);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(43, 17);
            this.lblPwd.TabIndex = 0;
            this.lblPwd.Text = "密  码:";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStyle.Location = new System.Drawing.Point(180, 270);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(59, 17);
            this.lblStyle.TabIndex = 0;
            this.lblStyle.Text = "登录类型:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(255, 227);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(152, 21);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(255, 186);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(152, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // cboStyle
            // 
            this.cboStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Items.AddRange(new object[] {
            "系统管理员",
            "普通用户"});
            this.cboStyle.Location = new System.Drawing.Point(255, 270);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(152, 20);
            this.cboStyle.TabIndex = 2;
            // 
            // btnDl
            // 
            this.btnDl.BackgroundImage = global::MySchool.Properties.Resources.button;
            this.btnDl.FlatAppearance.BorderSize = 0;
            this.btnDl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDl.Location = new System.Drawing.Point(183, 308);
            this.btnDl.Name = "btnDl";
            this.btnDl.Size = new System.Drawing.Size(84, 21);
            this.btnDl.TabIndex = 3;
            this.btnDl.Text = "登  录";
            this.btnDl.UseVisualStyleBackColor = true;
            this.btnDl.Click += new System.EventHandler(this.btnDl_Click);
            // 
            // btnQx
            // 
            this.btnQx.BackgroundImage = global::MySchool.Properties.Resources.button;
            this.btnQx.FlatAppearance.BorderSize = 0;
            this.btnQx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQx.Location = new System.Drawing.Point(298, 308);
            this.btnQx.Name = "btnQx";
            this.btnQx.Size = new System.Drawing.Size(84, 21);
            this.btnQx.TabIndex = 4;
            this.btnQx.Text = "取  消";
            this.btnQx.UseVisualStyleBackColor = true;
            this.btnQx.Click += new System.EventHandler(this.btnQx_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MySchool.Properties.Resources.login_bj;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(504, 373);
            this.Controls.Add(this.btnQx);
            this.Controls.Add(this.btnDl);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理系统-登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.Button btnDl;
        private System.Windows.Forms.Button btnQx;
    }
}

