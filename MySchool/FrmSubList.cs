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
    public partial class FrmSubList : Form
    {
        public FrmSubList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSubList_Load(object sender, EventArgs e)
        {
            tvSubList.ExpandAll();//默认展开所有节点
            JzSubList();//加载科目信息
        }
        /// <summary>
        /// 加载科目信息
        /// </summary>
        private void JzSubList()
        {
            string sql = @"SELECT S.SubjectName,S.ClassHour,G.GradeName FROM Subject S INNER JOIN Grade G ON S.GradeId = G.GradeId";
            if (tvSubList.SelectedNode != null)
            {
                int level = tvSubList.SelectedNode.Level;
                if (level == 1)
                {
                    int git = Convert.ToInt32(tvSubList.SelectedNode.Tag);
                    sql += $"  AND G.GradeId = {git}";
                }
                DataTable table = DBHelper.GetTable(sql);
                dgvSubList.AutoGenerateColumns = false;
                dgvSubList.DataSource = table;
            }
        }

        private void tvSubList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            JzSubList();
        }
    }
}
