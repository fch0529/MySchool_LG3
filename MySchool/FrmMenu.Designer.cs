
namespace MySchool
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.msAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXgpwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTuichu = new System.Windows.Forms.ToolStripMenuItem();
            this.msStudentgl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiByname = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBygrade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudentList = new System.Windows.Forms.ToolStripMenuItem();
            this.msSubjectgl = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsXjStudent = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSelectByname = new System.Windows.Forms.ToolStripButton();
            this.tsSelectByAge = new System.Windows.Forms.ToolStripButton();
            this.tsStudentList = new System.Windows.Forms.ToolStripButton();
            this.tsSubjectList = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsXjStudent,
            this.tsSelectByname,
            this.tsSelectByAge,
            this.tsStudentList,
            this.tsSubjectList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // msAccount
            // 
            this.msAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXgpwd,
            this.toolStripSeparator1,
            this.tsmiTuichu});
            this.msAccount.Name = "msAccount";
            this.msAccount.Size = new System.Drawing.Size(85, 21);
            this.msAccount.Text = "账户管理(&U)";
            // 
            // tsmiXgpwd
            // 
            this.tsmiXgpwd.Name = "tsmiXgpwd";
            this.tsmiXgpwd.Size = new System.Drawing.Size(140, 22);
            this.tsmiXgpwd.Text = "修改密码(&X)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiTuichu
            // 
            this.tsmiTuichu.Name = "tsmiTuichu";
            this.tsmiTuichu.Size = new System.Drawing.Size(140, 22);
            this.tsmiTuichu.Text = "退出(&T)";
            // 
            // msStudentgl
            // 
            this.msStudentgl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStudent,
            this.tsmiByname,
            this.tsmiBygrade,
            this.tsmiStudentList});
            this.msStudentgl.Name = "msStudentgl";
            this.msStudentgl.Size = new System.Drawing.Size(107, 21);
            this.msStudentgl.Text = "学生用户管理(&S)";
            // 
            // tsmiAddStudent
            // 
            this.tsmiAddStudent.Name = "tsmiAddStudent";
            this.tsmiAddStudent.Size = new System.Drawing.Size(156, 22);
            this.tsmiAddStudent.Text = "新增学生(&N)";
            this.tsmiAddStudent.Click += new System.EventHandler(this.tsXjStudent_Click);
            // 
            // tsmiByname
            // 
            this.tsmiByname.Name = "tsmiByname";
            this.tsmiByname.Size = new System.Drawing.Size(156, 22);
            this.tsmiByname.Text = "按姓名查询(&M)";
            // 
            // tsmiBygrade
            // 
            this.tsmiBygrade.Name = "tsmiBygrade";
            this.tsmiBygrade.Size = new System.Drawing.Size(156, 22);
            this.tsmiBygrade.Text = "按年级查询(&G)";
            this.tsmiBygrade.Click += new System.EventHandler(this.tsmiBygrade_Click);
            // 
            // tsmiStudentList
            // 
            this.tsmiStudentList.Name = "tsmiStudentList";
            this.tsmiStudentList.Size = new System.Drawing.Size(156, 22);
            this.tsmiStudentList.Text = "学生列表(&L)";
            this.tsmiStudentList.Click += new System.EventHandler(this.tsStudentList_Click);
            // 
            // msSubjectgl
            // 
            this.msSubjectgl.Name = "msSubjectgl";
            this.msSubjectgl.Size = new System.Drawing.Size(84, 21);
            this.msSubjectgl.Text = "科目管理(&C)";
            // 
            // msWindows
            // 
            this.msWindows.Name = "msWindows";
            this.msWindows.Size = new System.Drawing.Size(64, 21);
            this.msWindows.Text = "窗口(&W)";
            // 
            // msHelp
            // 
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(61, 21);
            this.msHelp.Text = "帮助(&H)";
            this.msHelp.Click += new System.EventHandler(this.msHelp_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAccount,
            this.msStudentgl,
            this.msSubjectgl,
            this.msWindows,
            this.msHelp});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 25);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsXjStudent
            // 
            this.tsXjStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsXjStudent.Image")));
            this.tsXjStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsXjStudent.Name = "tsXjStudent";
            this.tsXjStudent.Size = new System.Drawing.Size(109, 22);
            this.tsXjStudent.Text = "新建学生用户";
            this.tsXjStudent.Click += new System.EventHandler(this.tsXjStudent_Click);
            // 
            // tsSelectByname
            // 
            this.tsSelectByname.Image = ((System.Drawing.Image)(resources.GetObject("tsSelectByname.Image")));
            this.tsSelectByname.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSelectByname.Name = "tsSelectByname";
            this.tsSelectByname.Size = new System.Drawing.Size(136, 22);
            this.tsSelectByname.Text = "按姓名查询学生信息";
            this.tsSelectByname.Click += new System.EventHandler(this.tsSelectByname_Click);
            // 
            // tsSelectByAge
            // 
            this.tsSelectByAge.Image = global::MySchool.Properties.Resources.tsbtn1;
            this.tsSelectByAge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSelectByAge.Name = "tsSelectByAge";
            this.tsSelectByAge.Size = new System.Drawing.Size(136, 22);
            this.tsSelectByAge.Text = "按年龄查询学生信息";
            // 
            // tsStudentList
            // 
            this.tsStudentList.Image = global::MySchool.Properties.Resources.tsbtn4;
            this.tsStudentList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStudentList.Name = "tsStudentList";
            this.tsStudentList.Size = new System.Drawing.Size(76, 22);
            this.tsStudentList.Text = "学生列表";
            this.tsStudentList.Click += new System.EventHandler(this.tsStudentList_Click);
            // 
            // tsSubjectList
            // 
            this.tsSubjectList.Image = global::MySchool.Properties.Resources.tsbtn3;
            this.tsSubjectList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSubjectList.Name = "tsSubjectList";
            this.tsSubjectList.Size = new System.Drawing.Size(76, 22);
            this.tsSubjectList.Text = "科目列表";
            this.tsSubjectList.Click += new System.EventHandler(this.tsSubjectList_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton tsXjStudent;
        private System.Windows.Forms.ToolStripButton tsSelectByname;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem msAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmiXgpwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTuichu;
        private System.Windows.Forms.ToolStripMenuItem msStudentgl;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiByname;
        private System.Windows.Forms.ToolStripMenuItem tsmiBygrade;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentList;
        private System.Windows.Forms.ToolStripMenuItem msSubjectgl;
        private System.Windows.Forms.ToolStripMenuItem msWindows;
        private System.Windows.Forms.ToolStripMenuItem msHelp;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripButton tsSelectByAge;
        private System.Windows.Forms.ToolStripButton tsStudentList;
        private System.Windows.Forms.ToolStripButton tsSubjectList;
    }
}