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
    public partial class FrmSearchStudentByGrade : Form
    {
        public static FrmSearchStudentByGrade frmSearchStudentByGrade;
        public FrmSearchStudentByGrade()
        {
            InitializeComponent();
            frmSearchStudentByGrade = this;
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSearchStudentByGrade_Load(object sender, EventArgs e)
        {
            BdStudent();//绑定学生
            BdGrade();//绑定年级
        }

        /// <summary>
        /// 绑定年级
        /// </summary>
        private void BdGrade()
        {
            string sql = @"SELECT * FROM Grade UNION SELECT '0','查询所有信息'";
            DataTable table = DBHelper.GetTable(sql);
            //显示
            cboGrade.DisplayMember = "GradeName";
            //隐藏
            cboGrade.ValueMember = "GradeId";
            //绑定数据源
            cboGrade.DataSource = table;
        }

        /// <summary>
        /// 绑定学生
        /// </summary>
        private void BdStudent()
        {
            string sql = @"SELECT S.StudentNo,S.StudentName,S.Sex,G.GradeName,S.Phone,S.Address,S.Email FROM Student S INNER JOIN Grade G ON S.GradeId = G.GradeId";
            DataTable table = DBHelper.GetTable(sql);
            dgvSearch.AutoGenerateColumns = false;//不允许控件自动创建列
            dgvSearch.DataSource = table;//绑定数据源

        }

        /// <summary>
        /// 查询按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchButton();
        }
        /// <summary>
        /// 查询按钮(根据年级)
        /// </summary>
        private void SearchButton()
        {
            string sql = string.Format(@"SELECT S.StudentNo,S.StudentName,S.Sex,G.GradeName,S.Phone,S.Address,S.Email FROM Student S INNER JOIN 
                Grade G ON S.GradeId = G.GradeId WHERE 1 = 1");
            int gid = Convert.ToInt32(cboGrade.SelectedValue);
            if (gid > 0)
            {
                sql += $"  AND G.GradeId ={gid}";
                DataTable table = DBHelper.GetTable(sql);
                dgvSearch.DataSource = table;
            }
        }

        /// <summary>
        /// 编辑学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiBjStudent_Click(object sender, EventArgs e)
        {
            FrmStuNews frm = new FrmStuNews();
            if (dgvSearch.SelectedRows.Count>0)
            {
                string studentno = dgvSearch.SelectedRows[0].Cells[0].Value.ToString();
                frm.studentNo = studentno;
                //执行修改
                frm.UpdateStudent();
                frm.ShowDialog();
                SearchButton();//刷新
            }
        }

        /// <summary>
        /// 添加学生成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiInsertStudent_Click(object sender, EventArgs e)
        {
            FrmInsertGrade frm = new FrmInsertGrade();
            frm.studentNo = (this.dgvSearch.SelectedCells[0].Value.ToString());
            frm.ShowDialog();
        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDeleteStudent_Click(object sender, EventArgs e)
        {
            string studentno = dgvSearch.SelectedRows[0].Cells[0].Value.ToString();
            string sql = string.Format("DELETE FROM Result WHERE StudentNo = '{0}'", studentno);
            bool b = DBHelper.ExecuteNonQuery(sql);
            string sql_1 = string.Format("DELETE FROM Student WHERE StudentNo = '{0}'", studentno);
            bool bl = DBHelper.ExecuteNonQuery(sql_1);
            if (bl)
            {
                MessageBox.Show("删除学员信息成功!","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                SearchButton();
            }
            else
            {
                MessageBox.Show("删除学员信息失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
