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
    }
}
