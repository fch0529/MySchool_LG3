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
    public partial class FrmStuNews : Form
    {
        public FrmStuNews()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStuNews_Load(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;//取消只读
            WindowJz();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void WindowJz()
        {
            string sql = "SELECT GradeId,GradeName FROM [dbo].[Grade] UNION SELECT '0','请选择'";
            DataTable tab = DBHelper.GetTable(sql);
            cboGrade.DisplayMember = "GradeName";
            cboGrade.ValueMember = "GradeId";
            cboGrade.DataSource = tab;
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBaocun_Click(object sender, EventArgs e)
        {
            if (StudentNo() && Feikong())//判断学号和非空验证
            {
                AddStudent();
            }
        }

        /// <summary>
        /// 新增学生信息
        /// </summary>
        private void AddStudent()
        {
            string stuNo = txtStudentNo.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            string name = txtName.Text.Trim();
            string sex = rbtnSex1.Checked ? "女" : "男";
            int grade = Convert.ToInt32(cboGrade.SelectedValue);
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            DateTime borndate = dtpBornDate.Value;
            string email = txtEmail.Text.Trim();
            string sql = string.Format("INSERT INTO [dbo].[Student] VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",stuNo,pwd,name,sex,grade,phone,address,borndate,email);
            bool b = DBHelper.ExecuteNonQuery(sql);
            if (b)
            {
                MessageBox.Show("注册成功!","注册提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("注册失败!", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        private bool Feikong()
        {
            if (txtPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入密码!","输入提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtPwd.Focus();
                return false;
            }
            else if (txtPwds.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请再次输入密码!", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwds.Focus();
                return false;
            }
            else if (txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入姓名!", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            else if (!txtPwd.Text.Trim().Equals(txtPwds.Text.Trim()))
            {
                MessageBox.Show("两次输入的密码不相同,请重新输入!","输入提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtPwd.Focus();
                return false;
            }
            else if (cboGrade.Text.Trim() == "请选择")
            {
                MessageBox.Show("请选择一个年级!", "选择提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboGrade.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 判断学号
        /// </summary>
        /// <returns></returns>
        private bool StudentNo()
        {
            string sql = string.Format("SELECT COUNT(0) FROM Student WHERE StudentNo = '{0}'",txtStudentNo.Text.Trim());
            int a = Convert.ToInt32(DBHelper.ExecuteScalar(sql));
            if (a>0)
            {
                MessageBox.Show("该学号已存在,请重试!","提示",MessageBoxButtons.OK,MessageBoxIcon.Question);
                txtStudentNo.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            txtStudentNo.Clear();
            txtPwd.Clear();
            txtPwds.Clear();
            txtName.Clear();
            rbtnSex1.Checked = true;
            cboGrade.SelectedValue = 0;
            txtPhone.Clear();
            txtAddress.Clear();
            dtpBornDate.Value = DateTime.Now;
            txtEmail.Clear();
        }
    }
}
