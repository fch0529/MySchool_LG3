
namespace MySchool
{
    partial class FrmStudent
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblMohu = new System.Windows.Forms.Label();
            this.lvStudent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsKuaijie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDelect = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsKuaijie.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(83, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 21);
            this.txtName.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(359, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(89, 33);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查 询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblMohu
            // 
            this.lblMohu.AutoSize = true;
            this.lblMohu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMohu.Location = new System.Drawing.Point(454, 22);
            this.lblMohu.Name = "lblMohu";
            this.lblMohu.Size = new System.Drawing.Size(88, 17);
            this.lblMohu.TabIndex = 0;
            this.lblMohu.Text = "(支持模糊查询)";
            // 
            // lvStudent
            // 
            this.lvStudent.BackgroundImageTiled = true;
            this.lvStudent.CausesValidation = false;
            this.lvStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvStudent.ContextMenuStrip = this.cmsKuaijie;
            this.lvStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvStudent.FullRowSelect = true;
            this.lvStudent.GridLines = true;
            this.lvStudent.HideSelection = false;
            this.lvStudent.Location = new System.Drawing.Point(0, 51);
            this.lvStudent.Name = "lvStudent";
            this.lvStudent.Size = new System.Drawing.Size(800, 426);
            this.lvStudent.TabIndex = 3;
            this.lvStudent.UseCompatibleStateImageBehavior = false;
            this.lvStudent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "学号";
            this.columnHeader1.Width = 112;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "学员姓名";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "所属年级";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "联系电话";
            this.columnHeader5.Width = 144;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "家庭住址";
            this.columnHeader6.Width = 174;
            // 
            // cmsKuaijie
            // 
            this.cmsKuaijie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdate,
            this.toolStripSeparator1,
            this.tsmiDelect});
            this.cmsKuaijie.Name = "cmsKuaijie";
            this.cmsKuaijie.Size = new System.Drawing.Size(181, 76);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(180, 22);
            this.tsmiUpdate.Text = "修改";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiDelect
            // 
            this.tsmiDelect.Name = "tsmiDelect";
            this.tsmiDelect.Size = new System.Drawing.Size(180, 22);
            this.tsmiDelect.Text = "删除学生信息";
            this.tsmiDelect.Click += new System.EventHandler(this.tsmiDelect_Click);
            // 
            // FrmStudent
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.lvStudent);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMohu);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息列表";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.cmsKuaijie.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblMohu;
        private System.Windows.Forms.ListView lvStudent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip cmsKuaijie;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelect;
    }
}