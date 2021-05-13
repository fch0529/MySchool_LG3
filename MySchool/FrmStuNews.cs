using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool
{
    public partial class FrmStuNews : Form
    {
        public string studentNo = string.Empty;
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
            WindowJz();
            if (!string.IsNullOrEmpty(studentNo))
            {
                txtStudentNo.ReadOnly = true;
                UpdateStudent();
            }
        }

        /// <summary>
        /// 修改学员信息
        /// </summary>
        private void UpdateStudent()
        {
            txtStudentNo.ReadOnly = true;
            txtStudentNo.Text = studentNo;
            string sql = string.Format("SELECT LoginPwd,StudentName,Sex,GradeId,Phone,Address,BornDate,Email FROM Student WHERE StudentNo = '{0}'",studentNo);
            SqlDataReader r = DBHelper.ExecuteReader(sql);
            if (r != null && r.HasRows && r.Read())
            {
                txtPwd.Text = r["LoginPwd"].ToString();
                txtPwds.Text = r["LoginPwd"].ToString();
                txtName.Text = r["StudentName"].ToString();
                if (r["Sex"].ToString().Equals("女"))
                {
                    rbtnSex1.Checked = true;
                }
                else
                {
                    rbtnSex2.Checked = true;
                }
                int gid = Convert.ToInt32(r["GradeId"].ToString());
                cboGrade.SelectedValue = gid;
                txtPhone.Text = r["Phone"].ToString();
                txtAddress.Text = r["Address"].ToString();
                txtEmail.Text = r["Email"].ToString();
                dtpBornDate.Value = Convert.ToDateTime(r["BornDate"]);
            }
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
            if (string.IsNullOrEmpty(studentNo))
            {
                txtStudentNo.ReadOnly = false;
                AddStudent();
            }
            else
            {
                string stuNo = txtStudentNo.Text;
                string pwd = txtPwd.Text;
                string name = txtName.Text;
                string sex = rbtnSex1.Checked ? "女" : "男";
                int grade = Convert.ToInt32(cboGrade.SelectedValue);
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                string borndate = dtpBornDate.Value.ToString("yyyy-MM-dd");
                string email = txtEmail.Text;
                string sql = string.Format(@"UPDATE Student SET LoginPwd = '{0}',StudentName = '{1}',Sex = '{2}',GradeId = '{3}',Phone = '{4}',Address = '{5}',
                BornDate = '{6}',Email = '{7}'WHERE StudentNo = '{8}'",pwd,name,sex,grade,phone,address,borndate,email,stuNo);
                bool b = DBHelper.ExecuteNonQuery(sql);
                if (b)
                {
                    MessageBox.Show("修改学生信息成功!","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (FrmStudent.frmStudent != null)
                    {
                        FrmStudent.frmStudent.ShowAllstudent();
                    }
                }
                else
                {
                    MessageBox.Show("修改学生信息失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        /// <summary>
        /// 新增学生信息(保存学生信息)
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
            if (txtStudentNo.ReadOnly == true)
            {
                UpdateStudent();
            }
            else
            {
                Clear();
            }
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        private void Clear()
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
