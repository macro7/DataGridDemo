using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.CellPainting += DataGridView1_CellPainting;
        }

        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex < 2 && e.ColumnIndex >= 0)
            {
                using (Brush gridBrush = new SolidBrush(dataGridView1.GridColor), backColorBrush = new SolidBrush(SystemColors.Window))
                {
                    using (Pen gridLinePen = new Pen(gridBrush))
                    {
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left - 1, e.CellBounds.Bottom - 1, e.CellBounds.Right - 2, e.CellBounds.Bottom - 1);
                        //e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top + e.ClipBounds.Height, e.CellBounds.Right - 1, e.CellBounds.Bottom);

                        //int scale = ;
                        //scale = e.CellBounds.Height;
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left - 1, e.CellBounds.Bottom - e.CellBounds.Height - 2, e.CellBounds.Right - 2, e.CellBounds.Bottom - e.CellBounds.Height-1);

                        //if (e.Value != null)
                        //{
                        var cellwidth = e.CellBounds.Width;
                        SolidBrush fontBrush = new SolidBrush(e.CellStyle.ForeColor);
                        int fontwidth = (int)e.Graphics.MeasureString(e.Value.ToString(), e.CellStyle.Font).Width;
                        e.Graphics.DrawString("操作", e.CellStyle.Font, fontBrush, 74, e.CellBounds.Y / 2 + 5);
                        //}
                        e.Handled = true;
                    }
                }
            }
            return;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //'创建一个显示textBox的列()  
            var col1 = new DataGridViewTextBoxColumn();
            col1.Name = "Name";
            col1.HeaderText = "姓名";//'设置标题中显示的文本  

            var col3 = new DataGridViewTextBoxColumn();
            col3.Name = "sex";
            col3.HeaderText = "性别";

            //'将新建的列添加到控件中  
            dataGridView1.Columns.Add(col1);
            dataGridView1.Columns.Add(col3);

            //'添加行  
            //'创建新行   
            var row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            //'设置单元格的值  
            row.Cells[0].Value = "添加";
            row.Cells[1].Value = "删除";
            row.Cells[2].Value = "李四";
            row.Cells[3].Value = "男";
            dataGridView1.Rows.Add(row);

            //'添加第二行  
            var row1 = new string[] { "添加", "删除", "李四", "男" };
            dataGridView1.Rows.Add(row1);
        }
    }
}
