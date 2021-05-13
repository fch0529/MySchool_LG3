
namespace MySchool
{
    partial class FrmDemo
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "SSD(C:)",
            "本地磁盘",
            "99.9 GB",
            "22.1 GB"}, 2);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Data(D:)",
            "本地磁盘",
            "375 GB",
            "345 GB"}, 4);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemo));
            this.lvCp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsYou = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLargeImageList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSmallImageList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLiebiao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNews = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPp = new System.Windows.Forms.ToolStripMenuItem();
            this.imglMax = new System.Windows.Forms.ImageList(this.components);
            this.imglMin = new System.Windows.Forms.ImageList(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAlldx = new System.Windows.Forms.Label();
            this.lblKykj = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAlldx = new System.Windows.Forms.TextBox();
            this.txtKykj = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmsYou.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCp
            // 
            this.lvCp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvCp.ContextMenuStrip = this.cmsYou;
            this.lvCp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvCp.HideSelection = false;
            this.lvCp.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvCp.LargeImageList = this.imglMax;
            this.lvCp.Location = new System.Drawing.Point(0, 0);
            this.lvCp.Name = "lvCp";
            this.lvCp.Size = new System.Drawing.Size(800, 355);
            this.lvCp.SmallImageList = this.imglMin;
            this.lvCp.TabIndex = 0;
            this.lvCp.UseCompatibleStateImageBehavior = false;
            this.lvCp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类型";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "总大小";
            this.columnHeader3.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "可用空间";
            this.columnHeader4.Width = 202;
            // 
            // cmsYou
            // 
            this.cmsYou.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLargeImageList,
            this.tsmiSmallImageList,
            this.tsmiLiebiao,
            this.tsmiNews,
            this.tsmiPp});
            this.cmsYou.Name = "cmsYou";
            this.cmsYou.Size = new System.Drawing.Size(125, 114);
            // 
            // tsmiLargeImageList
            // 
            this.tsmiLargeImageList.Name = "tsmiLargeImageList";
            this.tsmiLargeImageList.Size = new System.Drawing.Size(124, 22);
            this.tsmiLargeImageList.Text = "大图标";
            this.tsmiLargeImageList.Click += new System.EventHandler(this.tsmiLargeImageList_Click);
            // 
            // tsmiSmallImageList
            // 
            this.tsmiSmallImageList.Name = "tsmiSmallImageList";
            this.tsmiSmallImageList.Size = new System.Drawing.Size(124, 22);
            this.tsmiSmallImageList.Text = "小图标";
            this.tsmiSmallImageList.Click += new System.EventHandler(this.tsmiSmallImageList_Click);
            // 
            // tsmiLiebiao
            // 
            this.tsmiLiebiao.Name = "tsmiLiebiao";
            this.tsmiLiebiao.Size = new System.Drawing.Size(124, 22);
            this.tsmiLiebiao.Text = "列表";
            // 
            // tsmiNews
            // 
            this.tsmiNews.Name = "tsmiNews";
            this.tsmiNews.Size = new System.Drawing.Size(124, 22);
            this.tsmiNews.Text = "详细信息";
            this.tsmiNews.Click += new System.EventHandler(this.tsmiNews_Click);
            // 
            // tsmiPp
            // 
            this.tsmiPp.Name = "tsmiPp";
            this.tsmiPp.Size = new System.Drawing.Size(124, 22);
            this.tsmiPp.Text = "平铺";
            // 
            // imglMax
            // 
            this.imglMax.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglMax.ImageStream")));
            this.imglMax.TransparentColor = System.Drawing.Color.Transparent;
            this.imglMax.Images.SetKeyName(0, "yp-1.png");
            this.imglMax.Images.SetKeyName(1, "yp-2.png");
            this.imglMax.Images.SetKeyName(2, "yp-3.png");
            this.imglMax.Images.SetKeyName(3, "yp-4.png");
            this.imglMax.Images.SetKeyName(4, "yp-5.png");
            this.imglMax.Images.SetKeyName(5, "yp-6.png");
            // 
            // imglMin
            // 
            this.imglMin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglMin.ImageStream")));
            this.imglMin.TransparentColor = System.Drawing.Color.Transparent;
            this.imglMin.Images.SetKeyName(0, "yp-1.png");
            this.imglMin.Images.SetKeyName(1, "yp-2.png");
            this.imglMin.Images.SetKeyName(2, "yp-3.png");
            this.imglMin.Images.SetKeyName(3, "yp-4.png");
            this.imglMin.Images.SetKeyName(4, "yp-5.png");
            this.imglMin.Images.SetKeyName(5, "yp-6.png");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(89, 373);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "名称";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(89, 406);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(29, 12);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "类型";
            // 
            // lblAlldx
            // 
            this.lblAlldx.AutoSize = true;
            this.lblAlldx.Location = new System.Drawing.Point(408, 373);
            this.lblAlldx.Name = "lblAlldx";
            this.lblAlldx.Size = new System.Drawing.Size(41, 12);
            this.lblAlldx.TabIndex = 2;
            this.lblAlldx.Text = "总大小";
            // 
            // lblKykj
            // 
            this.lblKykj.AutoSize = true;
            this.lblKykj.Location = new System.Drawing.Point(408, 409);
            this.lblKykj.Name = "lblKykj";
            this.lblKykj.Size = new System.Drawing.Size(53, 12);
            this.lblKykj.TabIndex = 2;
            this.lblKykj.Text = "可用空间";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 364);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(148, 406);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(138, 21);
            this.txtType.TabIndex = 3;
            // 
            // txtAlldx
            // 
            this.txtAlldx.Location = new System.Drawing.Point(487, 370);
            this.txtAlldx.Name = "txtAlldx";
            this.txtAlldx.Size = new System.Drawing.Size(137, 21);
            this.txtAlldx.TabIndex = 3;
            // 
            // txtKykj
            // 
            this.txtKykj.Location = new System.Drawing.Point(487, 406);
            this.txtKykj.Name = "txtKykj";
            this.txtKykj.Size = new System.Drawing.Size(137, 21);
            this.txtKykj.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(657, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtKykj);
            this.Controls.Add(this.txtAlldx);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblKykj);
            this.Controls.Add(this.lblAlldx);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lvCp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDemo";
            this.cmsYou.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCp;
        private System.Windows.Forms.ImageList imglMax;
        private System.Windows.Forms.ImageList imglMin;
        private System.Windows.Forms.ContextMenuStrip cmsYou;
        private System.Windows.Forms.ToolStripMenuItem tsmiLargeImageList;
        private System.Windows.Forms.ToolStripMenuItem tsmiSmallImageList;
        private System.Windows.Forms.ToolStripMenuItem tsmiLiebiao;
        private System.Windows.Forms.ToolStripMenuItem tsmiNews;
        private System.Windows.Forms.ToolStripMenuItem tsmiPp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAlldx;
        private System.Windows.Forms.Label lblKykj;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAlldx;
        private System.Windows.Forms.TextBox txtKykj;
        private System.Windows.Forms.Button btnAdd;
    }
}