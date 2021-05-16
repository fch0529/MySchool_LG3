
namespace MySchool
{
    partial class FrmInsertGrade
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
            this.gboInGrade = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.lblExamDate = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.dgvSelectResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dtpExamTime = new System.Windows.Forms.DateTimePicker();
            this.gboInGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gboInGrade
            // 
            this.gboInGrade.Controls.Add(this.dtpExamTime);
            this.gboInGrade.Controls.Add(this.btnInsert);
            this.gboInGrade.Controls.Add(this.txtResult);
            this.gboInGrade.Controls.Add(this.cboSubject);
            this.gboInGrade.Controls.Add(this.lblExamDate);
            this.gboInGrade.Controls.Add(this.lblResult);
            this.gboInGrade.Controls.Add(this.lblSubject);
            this.gboInGrade.Location = new System.Drawing.Point(12, 26);
            this.gboInGrade.Name = "gboInGrade";
            this.gboInGrade.Size = new System.Drawing.Size(487, 124);
            this.gboInGrade.TabIndex = 0;
            this.gboInGrade.TabStop = false;
            this.gboInGrade.Text = "输入成绩";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(354, 89);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "添 加";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(122, 56);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(213, 21);
            this.txtResult.TabIndex = 2;
            // 
            // cboSubject
            // 
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(122, 24);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(213, 20);
            this.cboSubject.TabIndex = 1;
            // 
            // lblExamDate
            // 
            this.lblExamDate.AutoSize = true;
            this.lblExamDate.Location = new System.Drawing.Point(35, 94);
            this.lblExamDate.Name = "lblExamDate";
            this.lblExamDate.Size = new System.Drawing.Size(53, 12);
            this.lblExamDate.TabIndex = 0;
            this.lblExamDate.Text = "考试时间";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(35, 59);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(29, 12);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "成绩";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(35, 27);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(29, 12);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "科目";
            // 
            // dgvSelectResult
            // 
            this.dgvSelectResult.AllowUserToAddRows = false;
            this.dgvSelectResult.AllowUserToDeleteRows = false;
            this.dgvSelectResult.AllowUserToResizeRows = false;
            this.dgvSelectResult.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSelectResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.dgvSelectResult.Location = new System.Drawing.Point(12, 178);
            this.dgvSelectResult.Name = "dgvSelectResult";
            this.dgvSelectResult.ReadOnly = true;
            this.dgvSelectResult.RowHeadersVisible = false;
            this.dgvSelectResult.RowTemplate.Height = 23;
            this.dgvSelectResult.Size = new System.Drawing.Size(487, 265);
            this.dgvSelectResult.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StudentName";
            this.Column1.HeaderText = "学生姓名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SubjectName";
            this.Column4.HeaderText = "科目名称";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StudentResult";
            this.Column2.HeaderText = "成绩";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ExamDate";
            this.Column3.HeaderText = "考试时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(409, 449);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "返 回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtpExamTime
            // 
            this.dtpExamTime.Location = new System.Drawing.Point(122, 88);
            this.dtpExamTime.Name = "dtpExamTime";
            this.dtpExamTime.Size = new System.Drawing.Size(213, 21);
            this.dtpExamTime.TabIndex = 4;
            // 
            // FrmInsertGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 484);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvSelectResult);
            this.Controls.Add(this.gboInGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmInsertGrade";
            this.Text = "添加学生成绩";
            this.Load += new System.EventHandler(this.FrmInsertGrade_Load);
            this.gboInGrade.ResumeLayout(false);
            this.gboInGrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboInGrade;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Label lblExamDate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvSelectResult;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DateTimePicker dtpExamTime;
    }
}