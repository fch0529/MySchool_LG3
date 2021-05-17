
namespace MySchool
{
    partial class FrmStuList
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("男", 0, 0);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("女", 1, 1);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("S1", 3, 2, new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("男", 0, 0);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("女", 1, 1);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("S2", 3, 2, new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Y2", 3, 2, new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("全部", 3, 2, new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode16,
            treeNode19});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStuList));
            this.splStuList = new System.Windows.Forms.SplitContainer();
            this.tvStuList = new System.Windows.Forms.TreeView();
            this.imglStuList = new System.Windows.Forms.ImageList(this.components);
            this.dgvStuList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splStuList)).BeginInit();
            this.splStuList.Panel1.SuspendLayout();
            this.splStuList.Panel2.SuspendLayout();
            this.splStuList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).BeginInit();
            this.SuspendLayout();
            // 
            // splStuList
            // 
            this.splStuList.Location = new System.Drawing.Point(3, 4);
            this.splStuList.Name = "splStuList";
            // 
            // splStuList.Panel1
            // 
            this.splStuList.Panel1.Controls.Add(this.tvStuList);
            // 
            // splStuList.Panel2
            // 
            this.splStuList.Panel2.Controls.Add(this.dgvStuList);
            this.splStuList.Size = new System.Drawing.Size(699, 445);
            this.splStuList.SplitterDistance = 143;
            this.splStuList.TabIndex = 1;
            // 
            // tvStuList
            // 
            this.tvStuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvStuList.ImageIndex = 0;
            this.tvStuList.ImageList = this.imglStuList;
            this.tvStuList.Location = new System.Drawing.Point(0, 0);
            this.tvStuList.Name = "tvStuList";
            treeNode11.ImageIndex = 0;
            treeNode11.Name = "节点4";
            treeNode11.SelectedImageIndex = 0;
            treeNode11.Tag = "男";
            treeNode11.Text = "男";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "节点5";
            treeNode12.SelectedImageIndex = 1;
            treeNode12.Tag = "女";
            treeNode12.Text = "女";
            treeNode13.ImageIndex = 3;
            treeNode13.Name = "节点1";
            treeNode13.SelectedImageIndex = 2;
            treeNode13.Tag = "1";
            treeNode13.Text = "S1";
            treeNode14.ImageIndex = 0;
            treeNode14.Name = "节点6";
            treeNode14.SelectedImageIndex = 0;
            treeNode14.Tag = "男";
            treeNode14.Text = "男";
            treeNode15.ImageIndex = 1;
            treeNode15.Name = "节点7";
            treeNode15.SelectedImageIndex = 1;
            treeNode15.Tag = "女";
            treeNode15.Text = "女";
            treeNode16.ImageIndex = 3;
            treeNode16.Name = "节点2";
            treeNode16.SelectedImageIndex = 2;
            treeNode16.Tag = "2";
            treeNode16.Text = "S2";
            treeNode17.Name = "节点8";
            treeNode17.Tag = "男";
            treeNode17.Text = "男";
            treeNode18.Name = "节点9";
            treeNode18.Tag = "女";
            treeNode18.Text = "女";
            treeNode19.ImageIndex = 3;
            treeNode19.Name = "节点3";
            treeNode19.SelectedImageIndex = 2;
            treeNode19.Tag = "3";
            treeNode19.Text = "Y2";
            treeNode20.ImageIndex = 3;
            treeNode20.Name = "节点0";
            treeNode20.SelectedImageIndex = 2;
            treeNode20.Tag = "0";
            treeNode20.Text = "全部";
            this.tvStuList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.tvStuList.SelectedImageIndex = 0;
            this.tvStuList.Size = new System.Drawing.Size(143, 445);
            this.tvStuList.TabIndex = 0;
            this.tvStuList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStuList_AfterSelect);
            // 
            // imglStuList
            // 
            this.imglStuList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStuList.ImageStream")));
            this.imglStuList.TransparentColor = System.Drawing.Color.Transparent;
            this.imglStuList.Images.SetKeyName(0, "男职2.png");
            this.imglStuList.Images.SetKeyName(1, "女职.png");
            this.imglStuList.Images.SetKeyName(2, "文件夹 (1).png");
            this.imglStuList.Images.SetKeyName(3, "文件夹.png");
            // 
            // dgvStuList
            // 
            this.dgvStuList.AllowUserToAddRows = false;
            this.dgvStuList.AllowUserToDeleteRows = false;
            this.dgvStuList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStuList.Location = new System.Drawing.Point(0, 0);
            this.dgvStuList.Name = "dgvStuList";
            this.dgvStuList.ReadOnly = true;
            this.dgvStuList.RowHeadersVisible = false;
            this.dgvStuList.RowTemplate.Height = 23;
            this.dgvStuList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStuList.Size = new System.Drawing.Size(552, 445);
            this.dgvStuList.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StudentNo";
            this.Column1.HeaderText = "学号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StudentName";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Sex";
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GradeName";
            this.Column4.HeaderText = "年级";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Phone";
            this.Column5.HeaderText = "联系电话";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FrmStuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.splStuList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmStuList";
            this.Text = "学生信息列表";
            this.Load += new System.EventHandler(this.FrmStuList_Load);
            this.splStuList.Panel1.ResumeLayout(false);
            this.splStuList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splStuList)).EndInit();
            this.splStuList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splStuList;
        private System.Windows.Forms.TreeView tvStuList;
        private System.Windows.Forms.DataGridView dgvStuList;
        private System.Windows.Forms.ImageList imglStuList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}