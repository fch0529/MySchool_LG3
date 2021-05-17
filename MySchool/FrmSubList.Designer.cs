
namespace MySchool
{
    partial class FrmSubList
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("S1", 1, 0);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("S2", 1, 0);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Y2", 1, 0);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("全部", 1, 0, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubList));
            this.splSubList = new System.Windows.Forms.SplitContainer();
            this.tvSubList = new System.Windows.Forms.TreeView();
            this.dgvSubList = new System.Windows.Forms.DataGridView();
            this.imglSubList = new System.Windows.Forms.ImageList(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splSubList)).BeginInit();
            this.splSubList.Panel1.SuspendLayout();
            this.splSubList.Panel2.SuspendLayout();
            this.splSubList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubList)).BeginInit();
            this.SuspendLayout();
            // 
            // splSubList
            // 
            this.splSubList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splSubList.Location = new System.Drawing.Point(0, 0);
            this.splSubList.Name = "splSubList";
            // 
            // splSubList.Panel1
            // 
            this.splSubList.Panel1.Controls.Add(this.tvSubList);
            // 
            // splSubList.Panel2
            // 
            this.splSubList.Panel2.Controls.Add(this.dgvSubList);
            this.splSubList.Size = new System.Drawing.Size(488, 403);
            this.splSubList.SplitterDistance = 127;
            this.splSubList.TabIndex = 0;
            // 
            // tvSubList
            // 
            this.tvSubList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSubList.ImageIndex = 0;
            this.tvSubList.ImageList = this.imglSubList;
            this.tvSubList.Location = new System.Drawing.Point(0, 0);
            this.tvSubList.Name = "tvSubList";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "节点1";
            treeNode5.SelectedImageIndex = 0;
            treeNode5.Tag = "1";
            treeNode5.Text = "S1";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "节点2";
            treeNode6.SelectedImageIndex = 0;
            treeNode6.Tag = "2";
            treeNode6.Text = "S2";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "节点3";
            treeNode7.SelectedImageIndex = 0;
            treeNode7.Tag = "3";
            treeNode7.Text = "Y2";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "节点0";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Tag = "0";
            treeNode8.Text = "全部";
            this.tvSubList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.tvSubList.SelectedImageIndex = 0;
            this.tvSubList.Size = new System.Drawing.Size(127, 403);
            this.tvSubList.TabIndex = 0;
            this.tvSubList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSubList_AfterSelect);
            // 
            // dgvSubList
            // 
            this.dgvSubList.AllowUserToAddRows = false;
            this.dgvSubList.AllowUserToDeleteRows = false;
            this.dgvSubList.AllowUserToResizeRows = false;
            this.dgvSubList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSubList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvSubList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubList.Location = new System.Drawing.Point(0, 0);
            this.dgvSubList.Name = "dgvSubList";
            this.dgvSubList.ReadOnly = true;
            this.dgvSubList.RowHeadersVisible = false;
            this.dgvSubList.RowTemplate.Height = 23;
            this.dgvSubList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubList.Size = new System.Drawing.Size(357, 403);
            this.dgvSubList.TabIndex = 0;
            // 
            // imglSubList
            // 
            this.imglSubList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglSubList.ImageStream")));
            this.imglSubList.TransparentColor = System.Drawing.Color.Transparent;
            this.imglSubList.Images.SetKeyName(0, "文件夹 (1).png");
            this.imglSubList.Images.SetKeyName(1, "文件夹.png");
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SubjectName";
            this.Column1.HeaderText = "科目名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ClassHour";
            this.Column2.HeaderText = "课时";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GradeName";
            this.Column3.HeaderText = "年级";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FrmSubList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 403);
            this.Controls.Add(this.splSubList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSubList";
            this.Text = "科目信息列表";
            this.Load += new System.EventHandler(this.FrmSubList_Load);
            this.splSubList.Panel1.ResumeLayout(false);
            this.splSubList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splSubList)).EndInit();
            this.splSubList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splSubList;
        private System.Windows.Forms.TreeView tvSubList;
        private System.Windows.Forms.DataGridView dgvSubList;
        private System.Windows.Forms.ImageList imglSubList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}