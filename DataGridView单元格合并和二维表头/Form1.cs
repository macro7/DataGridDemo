﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CancelButton = this.button1;
            DataTable dt = new DataTable();
            dt.Columns.Add("1");
            dt.Columns.Add("2");
            dt.Columns.Add("3");
            dt.Columns.Add("4");
            dt.Rows.Add("中国", "上海", "5000", "7000");
            dt.Rows.Add("中国", "北京", "3000", "5600");
            dt.Rows.Add("美国", "纽约", "6000", "8600");
            dt.Rows.Add("美国", "华劢顿", "8000", "9000");
            dt.Rows.Add("英国", "伦敦", "7000", "8800");
            this.rowMergeView1.DataSource = dt;
            this.rowMergeView1.ColumnHeadersHeight = 40;
            this.rowMergeView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rowMergeView1.MergeColumnNames.Add("Column1");
            this.rowMergeView1.AddSpanHeader(2, 2, "XXXX");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}