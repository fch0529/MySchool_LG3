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
    public partial class FrmDemo : Form
    {
        public FrmDemo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 显示大图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiLargeImageList_Click(object sender, EventArgs e)
        {
            this.lvCp.View = View.LargeIcon;
        }

        /// <summary>
        /// 显示小图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSmallImageList_Click(object sender, EventArgs e)
        {
            this.lvCp.View = View.SmallIcon;
        }

        /// <summary>
        /// 显示详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiNews_Click(object sender, EventArgs e)
        {
            this.lvCp.View = View.Details;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Yanzheng())
            {
                string name = txtName.Text.Trim();
                string type = txtType.Text.Trim();
                string alldx = txtAlldx.Text.Trim();
                string kykj = txtKykj.Text.Trim();
                //创建一个List View的项
                ListViewItem lvi = new ListViewItem();
                //指定关联文本
                lvi.Text = name;
                //指定显示图片下标
                lvi.ImageIndex = new Random().Next(0, 6);
                //添加子项
                lvi.SubItems.AddRange(new[] {type,alldx,kykj});
                lvCp.Items.Add(lvi);
                MessageBox.Show("添加成功", "添加提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("添加失败","添加提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        private bool Yanzheng()
        {
            //名称为空
            if (txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入名称","输入提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            //类型为空
            else if (txtType.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入类型", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtType.Focus();
                return false;
            }
            //总大小为空
            else if (txtAlldx.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入总大小", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAlldx.Focus();
                return false;
            }
            //可用空间为空
            else if (txtKykj.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入可用空间", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKykj.Focus();
                return false;
            }
            else
            {
                return true;
            } 
        }

    }
}
