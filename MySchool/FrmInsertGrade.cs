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
    public partial class FrmInsertGrade : Form
    {
        public string studentNo = string.Empty;
        public FrmInsertGrade()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInsertGrade_Load(object sender, EventArgs e)
        {
            WindowsJz();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        private void WindowsJz()
        {
            string sql = "SELECT SubjectId,SubjectName FROM Subject UNION SELECT '0','请选择'";
            DataTable table = DBHelper.GetTable(sql);
            cboSubject.DisplayMember = "SubjectName";
            cboSubject.ValueMember = "SubjectId";
            cboSubject.DataSource = table;
            SearchResultByStuNo();//通过学号查找学生成绩记录
        }
        /// <summary>
        /// 通过学号查找学生成绩记录
        /// </summary>
        public void SearchResultByStuNo()
        {
            string sql = string.Format(@"SELECT S.StudentName,U.SubjectName,R.StudentResult,R.ExamDate FROM [dbo].[Student] S INNER JOIN [dbo].[Result]
              R ON S.StudentNo = R.StudentNo  INNER JOIN [dbo].[Subject] U ON U.SubjectId = R.SubjectId WHERE S.StudentNo = '{0}'", studentNo);
            //int gid = Convert.ToInt32(cboExamDate.SelectedValue);
            DataTable table = DBHelper.GetTable(sql);
            dgvSelectResult.DataSource = table;
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 添加学员考试成绩信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //非空验证
            if (cboSubject.Text.Trim() == "请选择")
            {
                MessageBox.Show("请选择科目","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cboSubject.Focus();
            }
            else if (txtResult.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("学员成绩不能为空","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtResult.Focus();
            }
            else
            {
                AddResult();
            }
        }
        /// <summary>
        /// 添加成绩信息
        /// </summary>
        private void AddResult()
        {
            int subjectId = Convert.ToInt32(cboSubject.SelectedValue);
            int result = Convert.ToInt32(txtResult.Text);
            string examDate = dtpExamTime.Value.ToString("yyyy-MM-dd");
            string sql = string.Format("INSERT INTO Result(StudentNo, SubjectId, StudentResult, ExamDate) SELECT '{0}','{1}','{2}','{3}'",studentNo,subjectId,result,examDate);
            bool b = DBHelper.ExecuteNonQuery(sql);
            if (b)
            {
                MessageBox.Show("新增学员考试成绩成功!","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                SearchResultByStuNo();
            }
            else
            {
                MessageBox.Show("新增学员考试成绩失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
