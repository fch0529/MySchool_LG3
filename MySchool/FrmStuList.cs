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
    public partial class FrmStuList : Form
    {
        public FrmStuList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStuList_Load(object sender, EventArgs e)
        {
            //让TreeView控件默认展开所有节点
            tvStuList.ExpandAll();
            //加载学员数据
            JzStudent();
        }
        /// <summary>
        /// 加载学员数据
        /// </summary>
        private void JzStudent()
        {
            string sql = @"SELECT S.StudentNo,S.StudentName,S.Sex,G.GradeName,S.Phone FROM Student S INNER JOIN Grade G ON S.GradeId = G.GradeId WHERE 1=1";
            if (tvStuList.SelectedNode != null)
            {
                int level = tvStuList.SelectedNode.Level;
                if (level ==1)
                {
                    int git = Convert.ToInt32(tvStuList.SelectedNode.Tag);
                    sql += $"  AND G.GradeId = {git}";
                }
                else if (level == 2)
                {
                    string sex = Convert.ToString(tvStuList.SelectedNode.Tag);
                    int git = Convert.ToInt32(tvStuList.SelectedNode.Parent.Tag);
                    sql += $"  AND G.GradeId = {git} AND S.Sex = '{sex}'";
                }
            }
            DataTable table = DBHelper.GetTable(sql);
            dgvStuList.AutoGenerateColumns = false;
            dgvStuList.DataSource = table;
        }

        /// <summary>
        /// 选中某个节点查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvStuList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            JzStudent();
        }
    }
}
