
namespace MySchool
{
    partial class FrmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.imglBook = new System.Windows.Forms.ImageList(this.components);
            this.tBook = new System.Windows.Forms.Timer(this.components);
            this.lblBanquan = new System.Windows.Forms.Label();
            this.lblCopy = new System.Windows.Forms.Label();
            this.lblJIshu = new System.Windows.Forms.Label();
            this.lblBeida = new System.Windows.Forms.Label();
            this.lblCopyS = new System.Windows.Forms.Label();
            this.lblJSRight = new System.Windows.Forms.Label();
            this.plOK = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // picAbout
            // 
            this.picAbout.Image = global::MySchool.Properties.Resources.girl_1;
            this.picAbout.Location = new System.Drawing.Point(32, 70);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(160, 178);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAbout.TabIndex = 0;
            this.picAbout.TabStop = false;
            // 
            // imglBook
            // 
            this.imglBook.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglBook.ImageStream")));
            this.imglBook.TransparentColor = System.Drawing.Color.Transparent;
            this.imglBook.Images.SetKeyName(0, "girl_1.gif");
            this.imglBook.Images.SetKeyName(1, "girl_2.gif");
            this.imglBook.Images.SetKeyName(2, "girl_3.gif");
            this.imglBook.Images.SetKeyName(3, "girl_4.gif");
            // 
            // tBook
            // 
            this.tBook.Enabled = true;
            this.tBook.Tick += new System.EventHandler(this.tBook_Tick);
            // 
            // lblBanquan
            // 
            this.lblBanquan.AutoSize = true;
            this.lblBanquan.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBanquan.Location = new System.Drawing.Point(232, 124);
            this.lblBanquan.Name = "lblBanquan";
            this.lblBanquan.Size = new System.Drawing.Size(63, 17);
            this.lblBanquan.TabIndex = 1;
            this.lblBanquan.Text = "版权所有 :";
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCopy.Location = new System.Drawing.Point(232, 160);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(76, 17);
            this.lblCopy.TabIndex = 1;
            this.lblCopy.Text = "Copyright :";
            // 
            // lblJIshu
            // 
            this.lblJIshu.AutoSize = true;
            this.lblJIshu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJIshu.Location = new System.Drawing.Point(232, 201);
            this.lblJIshu.Name = "lblJIshu";
            this.lblJIshu.Size = new System.Drawing.Size(63, 17);
            this.lblJIshu.TabIndex = 1;
            this.lblJIshu.Text = "技术支持 :";
            // 
            // lblBeida
            // 
            this.lblBeida.AutoSize = true;
            this.lblBeida.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBeida.Location = new System.Drawing.Point(308, 124);
            this.lblBeida.Name = "lblBeida";
            this.lblBeida.Size = new System.Drawing.Size(56, 17);
            this.lblBeida.TabIndex = 1;
            this.lblBeida.Text = "北大青鸟";
            // 
            // lblCopyS
            // 
            this.lblCopyS.AutoSize = true;
            this.lblCopyS.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCopyS.Location = new System.Drawing.Point(321, 160);
            this.lblCopyS.Name = "lblCopyS";
            this.lblCopyS.Size = new System.Drawing.Size(69, 17);
            this.lblCopyS.TabIndex = 1;
            this.lblCopyS.Text = "2013-2016";
            // 
            // lblJSRight
            // 
            this.lblJSRight.AutoSize = true;
            this.lblJSRight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJSRight.Location = new System.Drawing.Point(308, 201);
            this.lblJSRight.Name = "lblJSRight";
            this.lblJSRight.Size = new System.Drawing.Size(172, 17);
            this.lblJSRight.TabIndex = 1;
            this.lblJSRight.Text = "StudentMis@JadeBird.com";
            // 
            // plOK
            // 
            this.plOK.BackColor = System.Drawing.Color.Transparent;
            this.plOK.Location = new System.Drawing.Point(379, 245);
            this.plOK.Name = "plOK";
            this.plOK.Size = new System.Drawing.Size(101, 30);
            this.plOK.TabIndex = 2;
            this.plOK.Click += new System.EventHandler(this.plOK_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MySchool.Properties.Resources.aboug_bj;
            this.ClientSize = new System.Drawing.Size(550, 339);
            this.Controls.Add(this.plOK);
            this.Controls.Add(this.lblJSRight);
            this.Controls.Add(this.lblJIshu);
            this.Controls.Add(this.lblBeida);
            this.Controls.Add(this.lblCopyS);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.lblBanquan);
            this.Controls.Add(this.picAbout);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAbout";
            this.Text = "关于我们";
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.ImageList imglBook;
        private System.Windows.Forms.Timer tBook;
        private System.Windows.Forms.Label lblBanquan;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label lblJIshu;
        private System.Windows.Forms.Label lblBeida;
        private System.Windows.Forms.Label lblCopyS;
        private System.Windows.Forms.Label lblJSRight;
        private System.Windows.Forms.Panel plOK;
    }
}