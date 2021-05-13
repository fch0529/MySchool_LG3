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
    public partial class FrmAbout : Form
    {
       
        public FrmAbout()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 按下OK键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plOK_Click(object sender, EventArgs e)
        {
            Close();
        }
        int i = 0;//图片框中图片的索引
        /// <summary>
        /// 计时器的Tick事件处理方法,定时变换图片框中的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBook_Tick(object sender, EventArgs e)
        {
            //如果当前显示的图片索引没有到最大值就继续增加
            if (i < this.imglBook.Images.Count-1)
            {
                i++;
            }
            else  //否则从第一个图片开始显示,索引从0开始
            {
                i = 0;
            }
            //设置图片框显示的图片
            this.picAbout.Image = imglBook.Images[i];
        }
    }
}
