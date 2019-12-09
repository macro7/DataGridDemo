namespace BookingStyleDemo
{
    partial class FrmBookingManager
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlWeek = new System.Windows.Forms.Panel();
            this.pnlItemContainer = new System.Windows.Forms.Panel();
            this.pnlNavigater = new System.Windows.Forms.Panel();
            this.btnTimeSet = new System.Windows.Forms.Button();
            this.btnPrevWeek = new System.Windows.Forms.Button();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlNavigater.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWeek
            // 
            this.pnlWeek.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWeek.Location = new System.Drawing.Point(0, 0);
            this.pnlWeek.Name = "pnlWeek";
            this.pnlWeek.Padding = new System.Windows.Forms.Padding(1);
            this.pnlWeek.Size = new System.Drawing.Size(800, 48);
            this.pnlWeek.TabIndex = 0;
            // 
            // pnlItemContainer
            // 
            this.pnlItemContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItemContainer.Location = new System.Drawing.Point(0, 48);
            this.pnlItemContainer.Name = "pnlItemContainer";
            this.pnlItemContainer.Size = new System.Drawing.Size(800, 358);
            this.pnlItemContainer.TabIndex = 1;
            // 
            // pnlNavigater
            // 
            this.pnlNavigater.Controls.Add(this.btnSave);
            this.pnlNavigater.Controls.Add(this.btnNextWeek);
            this.pnlNavigater.Controls.Add(this.btnPrevWeek);
            this.pnlNavigater.Controls.Add(this.btnTimeSet);
            this.pnlNavigater.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNavigater.Location = new System.Drawing.Point(0, 406);
            this.pnlNavigater.Name = "pnlNavigater";
            this.pnlNavigater.Size = new System.Drawing.Size(800, 44);
            this.pnlNavigater.TabIndex = 2;
            // 
            // btnTimeSet
            // 
            this.btnTimeSet.FlatAppearance.BorderSize = 0;
            this.btnTimeSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeSet.Location = new System.Drawing.Point(24, 9);
            this.btnTimeSet.Name = "btnTimeSet";
            this.btnTimeSet.Size = new System.Drawing.Size(75, 23);
            this.btnTimeSet.TabIndex = 0;
            this.btnTimeSet.Text = "时间段设置";
            this.btnTimeSet.UseVisualStyleBackColor = true;
            // 
            // btnPrevWeek
            // 
            this.btnPrevWeek.FlatAppearance.BorderSize = 0;
            this.btnPrevWeek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevWeek.Location = new System.Drawing.Point(114, 9);
            this.btnPrevWeek.Name = "btnPrevWeek";
            this.btnPrevWeek.Size = new System.Drawing.Size(75, 23);
            this.btnPrevWeek.TabIndex = 0;
            this.btnPrevWeek.Text = "往前一周";
            this.btnPrevWeek.UseVisualStyleBackColor = true;
            this.btnPrevWeek.Click += new System.EventHandler(this.btnPrevWeek_Click);
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Location = new System.Drawing.Point(195, 9);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(75, 23);
            this.btnNextWeek.TabIndex = 0;
            this.btnNextWeek.Text = "往后一周";
            this.btnNextWeek.UseVisualStyleBackColor = true;
            this.btnNextWeek.Click += new System.EventHandler(this.btnNextWeek_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(695, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmBookingManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlItemContainer);
            this.Controls.Add(this.pnlNavigater);
            this.Controls.Add(this.pnlWeek);
            this.Name = "FrmBookingManager";
            this.Text = "Form1";
            this.pnlNavigater.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWeek;
        private System.Windows.Forms.Panel pnlItemContainer;
        private System.Windows.Forms.Panel pnlNavigater;
        private System.Windows.Forms.Button btnTimeSet;
        private System.Windows.Forms.Button btnNextWeek;
        private System.Windows.Forms.Button btnPrevWeek;
        private System.Windows.Forms.Button btnSave;
    }
}

