
namespace MySchool
{
    partial class FrmStuNews
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
            this.gboUserZe = new System.Windows.Forms.GroupBox();
            this.lblPwds = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.txtPwds = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.gboUserNews = new System.Windows.Forms.GroupBox();
            this.dtpBornDate = new System.Windows.Forms.DateTimePicker();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.plSex = new System.Windows.Forms.Panel();
            this.rbtnSex1 = new System.Windows.Forms.RadioButton();
            this.rbtnSex2 = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBeondate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBaocun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gboUserZe.SuspendLayout();
            this.gboUserNews.SuspendLayout();
            this.plSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboUserZe
            // 
            this.gboUserZe.Controls.Add(this.lblPwds);
            this.gboUserZe.Controls.Add(this.lblPwd);
            this.gboUserZe.Controls.Add(this.lblStudentNo);
            this.gboUserZe.Controls.Add(this.txtPwds);
            this.gboUserZe.Controls.Add(this.txtPwd);
            this.gboUserZe.Controls.Add(this.txtStudentNo);
            this.gboUserZe.Location = new System.Drawing.Point(12, 13);
            this.gboUserZe.Name = "gboUserZe";
            this.gboUserZe.Size = new System.Drawing.Size(306, 120);
            this.gboUserZe.TabIndex = 0;
            this.gboUserZe.TabStop = false;
            this.gboUserZe.Text = "用户注册信息";
            // 
            // lblPwds
            // 
            this.lblPwds.AutoSize = true;
            this.lblPwds.Location = new System.Drawing.Point(15, 91);
            this.lblPwds.Name = "lblPwds";
            this.lblPwds.Size = new System.Drawing.Size(53, 12);
            this.lblPwds.TabIndex = 1;
            this.lblPwds.Text = "确认密码";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(15, 63);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(29, 12);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "密码";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(15, 30);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(29, 12);
            this.lblStudentNo.TabIndex = 1;
            this.lblStudentNo.Text = "学号";
            // 
            // txtPwds
            // 
            this.txtPwds.Location = new System.Drawing.Point(85, 88);
            this.txtPwds.Name = "txtPwds";
            this.txtPwds.Size = new System.Drawing.Size(200, 21);
            this.txtPwds.TabIndex = 2;
            this.txtPwds.UseSystemPasswordChar = true;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(85, 60);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(200, 21);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.TabStop = false;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(85, 30);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(200, 21);
            this.txtStudentNo.TabIndex = 0;
            // 
            // gboUserNews
            // 
            this.gboUserNews.Controls.Add(this.dtpBornDate);
            this.gboUserNews.Controls.Add(this.cboGrade);
            this.gboUserNews.Controls.Add(this.plSex);
            this.gboUserNews.Controls.Add(this.lblEmail);
            this.gboUserNews.Controls.Add(this.lblBeondate);
            this.gboUserNews.Controls.Add(this.lblAddress);
            this.gboUserNews.Controls.Add(this.lblGrade);
            this.gboUserNews.Controls.Add(this.lblPhone);
            this.gboUserNews.Controls.Add(this.txtEmail);
            this.gboUserNews.Controls.Add(this.txtAddress);
            this.gboUserNews.Controls.Add(this.txtPhone);
            this.gboUserNews.Controls.Add(this.txtName);
            this.gboUserNews.Controls.Add(this.lblSex);
            this.gboUserNews.Controls.Add(this.lblName);
            this.gboUserNews.Location = new System.Drawing.Point(12, 151);
            this.gboUserNews.Name = "gboUserNews";
            this.gboUserNews.Size = new System.Drawing.Size(306, 277);
            this.gboUserNews.TabIndex = 1;
            this.gboUserNews.TabStop = false;
            this.gboUserNews.Text = "用户基本信息";
            // 
            // dtpBornDate
            // 
            this.dtpBornDate.Location = new System.Drawing.Point(85, 210);
            this.dtpBornDate.Name = "dtpBornDate";
            this.dtpBornDate.Size = new System.Drawing.Size(200, 21);
            this.dtpBornDate.TabIndex = 4;
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(85, 90);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(200, 20);
            this.cboGrade.TabIndex = 1;
            // 
            // plSex
            // 
            this.plSex.Controls.Add(this.rbtnSex1);
            this.plSex.Controls.Add(this.rbtnSex2);
            this.plSex.Location = new System.Drawing.Point(85, 56);
            this.plSex.Name = "plSex";
            this.plSex.Size = new System.Drawing.Size(200, 30);
            this.plSex.TabIndex = 3;
            // 
            // rbtnSex1
            // 
            this.rbtnSex1.AutoSize = true;
            this.rbtnSex1.Checked = true;
            this.rbtnSex1.Location = new System.Drawing.Point(23, 7);
            this.rbtnSex1.Name = "rbtnSex1";
            this.rbtnSex1.Size = new System.Drawing.Size(35, 16);
            this.rbtnSex1.TabIndex = 0;
            this.rbtnSex1.TabStop = true;
            this.rbtnSex1.Text = "女";
            this.rbtnSex1.UseVisualStyleBackColor = true;
            // 
            // rbtnSex2
            // 
            this.rbtnSex2.AutoSize = true;
            this.rbtnSex2.Location = new System.Drawing.Point(95, 9);
            this.rbtnSex2.Name = "rbtnSex2";
            this.rbtnSex2.Size = new System.Drawing.Size(35, 16);
            this.rbtnSex2.TabIndex = 1;
            this.rbtnSex2.Text = "男";
            this.rbtnSex2.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 240);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 12);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblBeondate
            // 
            this.lblBeondate.AutoSize = true;
            this.lblBeondate.Location = new System.Drawing.Point(15, 210);
            this.lblBeondate.Name = "lblBeondate";
            this.lblBeondate.Size = new System.Drawing.Size(53, 12);
            this.lblBeondate.TabIndex = 1;
            this.lblBeondate.Text = "出生日期";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 152);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(29, 12);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "地址";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(15, 93);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(29, 12);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "年级";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 125);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(29, 12);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "电话";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 237);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 21);
            this.txtEmail.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Location = new System.Drawing.Point(85, 149);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 45);
            this.txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(85, 122);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 21);
            this.txtPhone.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 21);
            this.txtName.TabIndex = 0;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(15, 65);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "性别";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名";
            // 
            // btnBaocun
            // 
            this.btnBaocun.Location = new System.Drawing.Point(141, 448);
            this.btnBaocun.Name = "btnBaocun";
            this.btnBaocun.Size = new System.Drawing.Size(75, 23);
            this.btnBaocun.TabIndex = 0;
            this.btnBaocun.Text = "保存";
            this.btnBaocun.UseVisualStyleBackColor = true;
            this.btnBaocun.Click += new System.EventHandler(this.btnBaocun_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(222, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "清空";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmStuNews
            // 
            this.AcceptButton = this.btnBaocun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(330, 485);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBaocun);
            this.Controls.Add(this.gboUserNews);
            this.Controls.Add(this.gboUserZe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmStuNews";
            this.Text = "编辑学生信息";
            this.Load += new System.EventHandler(this.FrmStuNews_Load);
            this.gboUserZe.ResumeLayout(false);
            this.gboUserZe.PerformLayout();
            this.gboUserNews.ResumeLayout(false);
            this.gboUserNews.PerformLayout();
            this.plSex.ResumeLayout(false);
            this.plSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboUserZe;
        private System.Windows.Forms.Label lblPwds;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TextBox txtPwds;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.GroupBox gboUserNews;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBeondate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel plSex;
        private System.Windows.Forms.RadioButton rbtnSex1;
        private System.Windows.Forms.RadioButton rbtnSex2;
        private System.Windows.Forms.DateTimePicker dtpBornDate;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Button btnBaocun;
        private System.Windows.Forms.Button btnClose;
    }
}