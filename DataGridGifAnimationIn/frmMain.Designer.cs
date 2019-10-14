namespace GifAnimationInDataGrid
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSteps = new System.Windows.Forms.DataGridView();
            this.StatusImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.picProcessing = new System.Windows.Forms.PictureBox();
            this.timGifAnimation = new System.Windows.Forms.Timer(this.components);
            this.timButtonState = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessing)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSteps
            // 
            this.dgvSteps.AllowUserToAddRows = false;
            this.dgvSteps.AllowUserToDeleteRows = false;
            this.dgvSteps.AllowUserToResizeRows = false;
            this.dgvSteps.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSteps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSteps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSteps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusImage,
            this.序号,
            this.Message,
            this.SpentTime,
            this.DetailLink});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.FormatProvider = new System.Globalization.CultureInfo("en-US");
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSteps.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSteps.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSteps.EnableHeadersVisualStyles = false;
            this.dgvSteps.Location = new System.Drawing.Point(0, 45);
            this.dgvSteps.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSteps.Name = "dgvSteps";
            this.dgvSteps.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSteps.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvSteps.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvSteps.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvSteps.RowTemplate.Height = 36;
            this.dgvSteps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSteps.Size = new System.Drawing.Size(530, 261);
            this.dgvSteps.TabIndex = 5;
            this.dgvSteps.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSteps_CellClick);
            this.dgvSteps.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSteps_CellPainting);
            this.dgvSteps.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSteps_RowPostPaint);
            // 
            // StatusImage
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.FormatProvider = new System.Globalization.CultureInfo("en-US");
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.StatusImage.DefaultCellStyle = dataGridViewCellStyle11;
            this.StatusImage.HeaderText = "";
            this.StatusImage.Name = "StatusImage";
            this.StatusImage.ReadOnly = true;
            this.StatusImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StatusImage.Width = 25;
            // 
            // 序号
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.序号.DefaultCellStyle = dataGridViewCellStyle12;
            this.序号.HeaderText = "";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.序号.Width = 12;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.Message.DefaultCellStyle = dataGridViewCellStyle13;
            this.Message.HeaderText = "步骤及消息";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Message.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SpentTime
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.SpentTime.DefaultCellStyle = dataGridViewCellStyle14;
            this.SpentTime.HeaderText = "耗时";
            this.SpentTime.Name = "SpentTime";
            this.SpentTime.ReadOnly = true;
            this.SpentTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SpentTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SpentTime.Width = 80;
            // 
            // DetailLink
            // 
            this.DetailLink.ActiveLinkColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DetailLink.DefaultCellStyle = dataGridViewCellStyle15;
            this.DetailLink.HeaderText = "";
            this.DetailLink.Name = "DetailLink";
            this.DetailLink.ReadOnly = true;
            this.DetailLink.Text = "查看详细";
            this.DetailLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.DetailLink.Width = 60;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(326, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "开始执行(&S)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(425, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "退    出(&X)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 17);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(209, 12);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "单击“开始执行”按钮执行以下步骤：";
            // 
            // picProcessing
            // 
            this.picProcessing.Location = new System.Drawing.Point(280, 16);
            this.picProcessing.Name = "picProcessing";
            this.picProcessing.Size = new System.Drawing.Size(1, 1);
            this.picProcessing.TabIndex = 9;
            this.picProcessing.TabStop = false;
            // 
            // timGifAnimation
            // 
            this.timGifAnimation.Enabled = true;
            this.timGifAnimation.Tick += new System.EventHandler(this.timGifAnimation_Tick);
            // 
            // timButtonState
            // 
            this.timButtonState.Enabled = true;
            this.timButtonState.Tick += new System.EventHandler(this.timButtonState_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 306);
            this.Controls.Add(this.picProcessing);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dgvSteps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "GIF Animation in GridView Column Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSteps;
        private System.Windows.Forms.DataGridViewImageColumn StatusImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpentTime;
        private System.Windows.Forms.DataGridViewLinkColumn DetailLink;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picProcessing;
        private System.Windows.Forms.Timer timGifAnimation;
        private System.Windows.Forms.Timer timButtonState;
    }
}