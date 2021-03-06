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

    public partial class FrmStudent : Form
    {
        public static FrmStudent frmStudent;
        public FrmStudent()
        {
            InitializeComponent();
            frmStudent = this;
        }

        /// <summary>
        /// 查询学员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectStudentNews();
        }
        /// <summary>
        /// 查询学员信息
        /// </summary>
        public void SelectStudentNews()
        {
            string name = txtName.Text.Trim();
            lvStudent.Items.Clear();
            string sql = string.Format("SELECT S.StudentNo,S.StudentName,S.Sex,G.GradeName,S.Phone,S.Address FROM [dbo].[Student] S INNER JOIN Grade G ON G.GradeId = S.GradeId WHERE S.StudentName LIKE '%{0}%'", name);
            SqlDataReader r = DBHelper.ExecuteReader(sql);
            if (r != null && !r.HasRows)
            {
                MessageBox.Show("您查询的学员信息不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                while (r != null && r.HasRows && r.Read())
                {
                    string sNo = r["StudentNo"].ToString();
                    string sName = r["StudentName"].ToString();
                    string sex = r["Sex"].ToString();
                    string gName = r["GradeName"].ToString();
                    string phone = r["Phone"].ToString();
                    string address = r["Address"].ToString();
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = sNo;
                    lvi.ImageIndex = new Random().Next(0, 6);
                    lvi.SubItems.AddRange(new[] { sName, sex, gName, phone, address });
                    lvStudent.Items.Add(lvi);
                }
            }
        }
        /// <summary>
        /// 默认显示所有学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            ShowAllstudent();
        }
        /// <summary>
        /// 默认显示所有学生信息
        /// </summary>
        public void ShowAllstudent()
        {
            //接收数据
            string sql = "SELECT S.StudentNo,S.StudentName,S.Sex,G.GradeName,S.Phone,S.Address FROM [dbo].[Student] S INNER JOIN Grade G ON G.GradeId = S.GradeId";
            SqlDataReader r = DBHelper.ExecuteReader(sql);
            if (r != null && !r.HasRows)
            {
                MessageBox.Show("您要查询的学员信息不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                while (r != null && r.HasRows && r.Read())
                {
                    string sNo = r["StudentNo"].ToString();
                    string sName = r["StudentName"].ToString();
                    string sex = r["Sex"].ToString();
                    string gName = r["GradeName"].ToString();
                    string phone = r["Phone"].ToString();
                    string address = r["Address"].ToString();
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = sNo;
                    lvi.ImageIndex = new Random().Next(0, 6);
                    lvi.SubItems.AddRange(new[] { sName, sex, gName, phone, address });
                    lvStudent.Items.Add(lvi);
                }
            }
        }
        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            if (this.lvStudent.SelectedItems.Count > 0)
            {
                FrmStuNews frm = new FrmStuNews();
                //将选中的学号传递到"编辑学生信息"窗体
                frm.studentNo = (this.lvStudent.SelectedItems[0].Text);
                frm.Show();
            }
            else
            {
                MessageBox.Show("请选择一名学生", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelect_Click(object sender, EventArgs e)
        {
            string stuNo = lvStudent.SelectedItems[0].Text;
            string sql = string.Format("DELETE FROM Result WHERE StudentNo = '{0}'", stuNo);
            bool b = DBHelper.ExecuteNonQuery(sql);
            string sql_1 = string.Format("DELETE FROM Student WHERE StudentNo = '{0}'", stuNo);
            bool bo = DBHelper.ExecuteNonQuery(sql_1);
            if (bo)
            {
                MessageBox.Show("删除学员信息成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SelectStudentNews();
            }
            else
            {
                MessageBox.Show("删除学员信息失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
