namespace TestDataGridViewRowStyle
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.ColumnClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsGrade = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrade
            // 
            this.dgvGrade.AllowUserToOrderColumns = true;
            this.dgvGrade.AllowUserToResizeRows = false;
            this.dgvGrade.AutoGenerateColumns = false;
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnClass,
            this.ColumnName,
            this.ColumnGrade});
            this.dgvGrade.DataSource = this.bdsGrade;
            this.dgvGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrade.Location = new System.Drawing.Point(0, 0);
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.RowHeadersWidth = 60;
            this.dgvGrade.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGrade.RowTemplate.Height = 23;
            this.dgvGrade.Size = new System.Drawing.Size(779, 539);
            this.dgvGrade.TabIndex = 0;
            this.dgvGrade.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvGrade_CellPainting);
            this.dgvGrade.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDataTable_CellFormatting);
            this.dgvGrade.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDataTable_RowPostPaint);
            // 
            // ColumnClass
            // 
            this.ColumnClass.DataPropertyName = "Class";
            this.ColumnClass.HeaderText = "班级";
            this.ColumnClass.Name = "ColumnClass";
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "姓名";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnGrade
            // 
            this.ColumnGrade.DataPropertyName = "Grade";
            this.ColumnGrade.HeaderText = "成绩";
            this.ColumnGrade.Name = "ColumnGrade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 539);
            this.Controls.Add(this.dgvGrade);
            this.Name = "Form1";
            this.Text = "自定义DataGridView行样式及行标题示例";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrade;
        private System.Windows.Forms.BindingSource bdsGrade;
    }
}

