using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        public string message { get; set; }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("欢迎您,{0}", message);
        }

        /// <summary>
        /// 编辑学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsXjStudent_Click(object sender, EventArgs e)
        {
            FrmStuNews few = new FrmStuNews();
            few.MdiParent = this;//设置父窗体容器=当前窗体
            few.Show();
        }
        /// <summary>
        /// 按姓名查询学员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsSelectByname_Click(object sender, EventArgs e)
        {
            FrmStudent frm = new FrmStudent();
            frm.MdiParent = this;
            frm.Show();
        }
        /// <summary>
        /// 关于我们
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msHelp_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// 按年级查询(调用窗体)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiBygrade_Click(object sender, EventArgs e)
        {
            FrmSearchStudentByGrade frm = new FrmSearchStudentByGrade();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// 学生列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsStudentList_Click(object sender, EventArgs e)
        {
            FrmStuList frm = new FrmStuList();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// 科目列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsSubjectList_Click(object sender, EventArgs e)
        {
            FrmSubList frm = new FrmSubList();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
