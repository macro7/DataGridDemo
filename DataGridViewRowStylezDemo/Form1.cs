using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestDataGridViewRowStyle
{
    public partial class Form1 : Form
    {
        //定义两种行样式
        private DataGridViewCellStyle m_RowStyleNormal;
        private DataGridViewCellStyle m_RowStyleAlternate;

        //成绩单DataTable
        private DataTable m_GradeTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgvGrade.AutoGenerateColumns = false;
            this.SetRowStyle();
            this.BindData();
        }

        /// <summary>
        /// 设置行样式
        /// </summary>
        private void SetRowStyle()
        {
            //可根据需要设置更多样式属性，如字体、对齐、前景色、背景色等
            this.m_RowStyleNormal = new DataGridViewCellStyle();
            this.m_RowStyleNormal.BackColor = Color.LightBlue;
            this.m_RowStyleNormal.SelectionBackColor = Color.LightSteelBlue;

            this.m_RowStyleAlternate = new DataGridViewCellStyle();
            this.m_RowStyleAlternate.BackColor = Color.LightGray;
            this.m_RowStyleAlternate.SelectionBackColor = Color.LightSlateGray;
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindData()
        {
            //建立一个DataTable并填充数据，然后绑定到DataGridView控件上
            m_GradeTable = new DataTable();
            m_GradeTable.Columns.Add("Class", typeof(string));
            m_GradeTable.Columns.Add("Name", typeof(string));
            m_GradeTable.Columns.Add("Grade", typeof(int));
            m_GradeTable.Rows.Add(new string[] { "Class1", "Jim", "89" });
            m_GradeTable.Rows.Add(new string[] { "Class1", "Jack", "77" });
            m_GradeTable.Rows.Add(new string[] { "Class1", "Bill", "91" });
            m_GradeTable.Rows.Add(new string[] { "Class2", "Tom", "58" });
            m_GradeTable.Rows.Add(new string[] { "Class2", "Rose", "95" });
            m_GradeTable.Rows.Add(new string[] { "Class3", "Peter", "64" });
            m_GradeTable.Rows.Add(new string[] { "Class3", "David", "82" });
            m_GradeTable.Rows.Add(new string[] { "Class3", "Eric", "68" });
            m_GradeTable.Rows.Add(new string[] { "Class3", "Lily", "79" });
            this.bdsGrade.DataSource = m_GradeTable;
        }

        private void dgvDataTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //在此对行样式进行设置
            
            if (e.ColumnIndex == this.dgvGrade.Columns["ColumnClass"].Index)//根据班级设置行样式
            {
                DataGridViewRow CurrentRow = this.dgvGrade.Rows[e.RowIndex];
                CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);//显示行号，也可以设置成显示其他信息
                //CurrentRow.HeaderCell.ToolTipText = "当前第" + Convert.ToString(e.RowIndex + 1) + "行";//设置ToolTip信息

                //以下为根据上一行内容判断所属组的效果
                if (e.RowIndex == 0)//首行必须特殊处理，将其设置为常规样式
                {
                    CurrentRow.DefaultCellStyle = this.m_RowStyleNormal;
                }
                else
                {
                    //判断和上一行是否属于同一个班级，如果是则设置相同样式，否则设置另一种样式
                    //需要定义两个DataGridViewCellStyle，用于交替显示，也可以根据需要隐藏一些和上一行重复的信息
                    //这里当两行是同一个班级时，将下一行的班级信息隐藏掉，选中时则显示班级信息
                    if (CurrentRow.Cells[e.ColumnIndex].Value != DBNull.Value && CurrentRow.Cells[e.ColumnIndex].Value != null
                        && CurrentRow.Cells[e.ColumnIndex].Value.ToString() == this.dgvGrade.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value.ToString())
                    {
                        CurrentRow.DefaultCellStyle = this.dgvGrade.Rows[e.RowIndex - 1].DefaultCellStyle;//设置和上一行的样式相同
                        CurrentRow.Cells[e.ColumnIndex].Style.ForeColor = CurrentRow.DefaultCellStyle.BackColor;//用前景色隐藏信息
                        //如果需要选中时显示完整信息则注释该下面一行
                        //CurrentRow.Cells[e.ColumnIndex].Style.SelectionForeColor = CurrentRow.DefaultCellStyle.SelectionBackColor;//选中时也使前景色等于背景色，将文字隐藏掉
                    }
                    else//当前行和上一行不属于同一个班级时
                    {
                        if (this.dgvGrade.Rows[e.RowIndex - 1].DefaultCellStyle == this.m_RowStyleNormal)//根据上一行的样式设置当前行的样式
                            CurrentRow.DefaultCellStyle = this.m_RowStyleAlternate;
                        else
                            CurrentRow.DefaultCellStyle = this.m_RowStyleNormal;
                    }
                }//if(e.RowIndex == 0)
            }
            else if (e.ColumnIndex == this.dgvGrade.Columns["ColumnGrade"].Index)//根据成绩设置单元格样式
            {
                if (this.dgvGrade.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != DBNull.Value 
                    && Convert.ToInt32(this.dgvGrade.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) < 60)//对不及格的成绩设置特殊样式
                {
                    this.dgvGrade.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;//设置小于60的数字显示为红色
                    this.dgvGrade.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionForeColor = Color.Red;
                    this.dgvGrade.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        //根据内容设置行标头
        private void dgvDataTable_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (this.dgvGrade.Rows[e.RowIndex].Cells["ColumnGrade"].Value == DBNull.Value)
                return;

            int intGrade = Convert.ToInt32(this.dgvGrade.Rows[e.RowIndex].Cells["ColumnGrade"].Value);//获取成绩
            Image RowIcon;//标头图标
            string strToolTip;//提示信息

            if (intGrade >= 90)
            {
                RowIcon = TestDataGridViewRowStyle.Properties.Resources.GradeA;//从资源文件中获取图片
                strToolTip = "Grade A";
            }
            else if (intGrade >= 80)
            {
                RowIcon = TestDataGridViewRowStyle.Properties.Resources.GradeB;
                strToolTip = "Grade B";
            }
            else if (intGrade >= 70)
            {
                RowIcon = TestDataGridViewRowStyle.Properties.Resources.GradeC;
                strToolTip = "Grade C";
            }
            else if (intGrade >= 60)
            {
                RowIcon = TestDataGridViewRowStyle.Properties.Resources.GradeD;
                strToolTip = "Grade D";
            }
            else
            {
                RowIcon = TestDataGridViewRowStyle.Properties.Resources.GradeF;
                strToolTip = "Grade F";
            }

            e.Graphics.DrawImage(RowIcon, e.RowBounds.Left + this.dgvGrade.RowHeadersWidth - 20, e.RowBounds.Top + 4, 16, 16);//绘制图标
            this.dgvGrade.Rows[e.RowIndex].HeaderCell.ToolTipText = strToolTip;//设置提示信息

        }

        private void dgvGrade_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >=0 && e.ColumnIndex == 2)
            {
                if (this.dgvGrade.Rows[e.RowIndex].Cells["ColumnGrade"].Value == DBNull.Value)
                    return;

                int intGrade = Convert.ToInt32(this.dgvGrade.Rows[e.RowIndex].Cells["ColumnGrade"].Value);
                Image img;
                if (intGrade >= 90)
                {
                    img = TestDataGridViewRowStyle.Properties.Resources.high;
                } 
                else if (intGrade >= 80)
                {
                    img = TestDataGridViewRowStyle.Properties.Resources.arrow;
                }
                else if (intGrade >= 70)
                {
                    img = TestDataGridViewRowStyle.Properties.Resources.up;
                }
                else if (intGrade >= 60)
                {
                    img = TestDataGridViewRowStyle.Properties.Resources.down;
                }
                else
                {
                    img = TestDataGridViewRowStyle.Properties.Resources.low;
                }
                Rectangle newRect = new Rectangle(e.CellBounds.X + 3, e.CellBounds.Y + 5, e.CellBounds.Height - 15, 
                    e.CellBounds.Height - 12);

                using (Brush gridBrush = new SolidBrush(this.dgvGrade.GridColor), backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    using (Pen gridLinePen = new Pen(gridBrush, 2))
                    {
                        // Erase the cell.
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        //划线
                        Point p1 = new Point(e.CellBounds.Left + e.CellBounds.Width, e.CellBounds.Top);
                        Point p2 = new Point(e.CellBounds.Left + e.CellBounds.Width, e.CellBounds.Top + e.CellBounds.Height);
                        Point p3 = new Point(e.CellBounds.Left, e.CellBounds.Top + e.CellBounds.Height);
                        Point[] ps = new Point[] { p1, p2, p3 };
                        e.Graphics.DrawLines(gridLinePen, ps);

                        //画图标
                        e.Graphics.DrawImage(img, newRect);
                        //画字符串
                        e.Graphics.DrawString(intGrade.ToString(), e.CellStyle.Font, Brushes.Crimson, 
                            e.CellBounds.Left + 20, e.CellBounds.Top + 5, StringFormat.GenericDefault);
                        e.Handled = true;
                    }
                }
            }
        }
    }
}