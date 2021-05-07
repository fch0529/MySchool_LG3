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
    public partial class FrmLogin : Form
    {
        public FrmLogin frmLogin;
        public string userName = "";
        public FrmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQx_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定取消登录吗?","操作提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDl_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string pwd = txtPwd.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请输入用户名","输入提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.txtUserName.Focus();//文本框聚焦
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();//文本框聚焦
                return;
            }
            string sql = string.Format("SELECT COUNT(0) FROM [User] WHERE zhanghao = '{0}' AND password = '{1}'",name,pwd);
            int a = Convert.ToInt32(DBHelper.ExecuteScalar(sql));
            if (a>0)
            {
                FrmMenu frmMenu = new FrmMenu();
                MessageBox.Show("登录成功!","登录提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                frmMenu.message = name;
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("您输入的用户名或密码错误,登录失败!","登录提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

    }
}
