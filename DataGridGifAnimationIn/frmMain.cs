using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GifAnimationInDataGrid
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        
        #region Private Variables & Constants


        //current processing step
        private int _CurrentStep = 0;

        //whether btnExit & btnStart is enabled
        //when any step is processing, the two buttons should be disabled
        private bool _ButtonDisabled = false;

        //count of the steps
        //you may not have this variable in a real scenario
        private int _StepCount = 5;
        
        private const string PROCESSING = "处理正在进行中……";

        private const string READY = "尚未开始。";

        private const string FINISHED = "处理完成";

        private const string RIGHT = "，该步骤的处理返回了正确结果。";

        private const string WRONG = "，但该步骤处理过程中发生了错误。";

        private const string VIEWDETAIL = "查看详细";


        #endregion
                

        #region Custom Functions


        //init rows of dgvSteps
        private void InitDgvRows()
        {
            this.dgvSteps.Rows.Clear();

            //in a real scenario, you may need to add different rows
            for (int intLoop = 1; intLoop <= this._StepCount; intLoop++)
            {
                this.dgvSteps.Rows.Add(
                    GifAnimationInDataGrid.Properties.Resources.PROCESS_READY,
                    intLoop.ToString(),
                    "第" + intLoop.ToString() + "个步骤&" + READY,
                    String.Empty,
                    String.Empty
                    );
            }
        }

        //start the processing of all steps
        private void Process()
        {

            this._ButtonDisabled = true;

            do
            {
                //record the time when current step begins to process
                DateTime dtStart = DateTime.Now;

                this._CurrentStep++;

                //temporary string to store the name of current step
                string strTemp = this.dgvSteps.Rows[this._CurrentStep - 1].Cells[2].Value.ToString();
                strTemp = strTemp.Substring(0, strTemp.IndexOf("&"));

                this.dgvSteps.Rows[this._CurrentStep - 1].Cells[2].Value = strTemp + "&" + PROCESSING;

                Random rndIntValue = new Random();

                //let current process sleep for several seconds
                //it is only for the purpose of a demo
                //in a real scenario, it is not necessary for current step itself may take several seconds or more to finish processing
                System.Threading.Thread.Sleep(rndIntValue.Next(8) * 1000);

                //simulate two states of current step: success or failure
                if (Convert.ToBoolean((rndIntValue.Next(2))))
                {
                    strTemp = this.dgvSteps.Rows[this._CurrentStep - 1].Cells[2].Value.ToString();
                    strTemp = strTemp.Substring(0, strTemp.IndexOf("&"));
                    this.dgvSteps.Rows[this._CurrentStep - 1].Cells[2].Value = strTemp + "&" + FINISHED + RIGHT;
                    this.dgvSteps.Rows[this._CurrentStep - 1].Cells[0].Value = GifAnimationInDataGrid.Properties.Resources.PROCESS_RIGHT;
                }
                else
                {
                    strTemp = this.dgvSteps.Rows[this._CurrentStep - 1].Cells[2].Value.ToString();
                    strTemp = strTemp.Substring(0, strTemp.IndexOf("&"));
                    this.dgvSteps.Rows[this._CurrentStep - 1].Cells[2].Value = strTemp + "&" + FINISHED + WRONG;
                    this.dgvSteps.Rows[this._CurrentStep - 1].Cells[0].Value = GifAnimationInDataGrid.Properties.Resources.PROCESS_WRONG;
                    this.dgvSteps.Rows[this._CurrentStep - 1].Cells[4].Value = VIEWDETAIL;
                }

                this.dgvSteps.Rows[this._CurrentStep - 1].Cells[3].Value = ((TimeSpan)(DateTime.Now - dtStart)).TotalMilliseconds.ToString("#,##0.00") + "ms";

                if (this._CurrentStep >= this._StepCount)
                    this.timGifAnimation.Enabled = false;

            }
            while (this._CurrentStep < this._StepCount);

            this._ButtonDisabled = false;

        }


        #endregion


        //delegate of process() function for the purpose of multithreading
        delegate void ProcessDelegate();


        #region Events


        #region Button Events


        //start all steps
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.InitDgvRows();

            this.timGifAnimation.Enabled = true;
            this._CurrentStep = 0;

            ProcessDelegate pdSteps = new ProcessDelegate(Process);
            pdSteps.BeginInvoke(null, null);
        }

        //exit the demo
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        #endregion

        
        #region Timer Tick Event


        //enable animation of a gif file in a gridview column
        private void timGifAnimation_Tick(object sender, EventArgs e)
        {
            if (this.dgvSteps.Rows.Count > 0 && this._CurrentStep > 0)
            {
                this.dgvSteps.Rows[this._CurrentStep - 1].Cells[0].Value = this.picProcessing.Image;
                this.dgvSteps.InvalidateCell(0, this._CurrentStep - 1);
            }
        }
        
        //set the enabled property of btnExit & btnStart according to the fact whether a step is processing
        private void timButtonState_Tick(object sender, EventArgs e)
        {
            this.btnStart.Enabled =
                this.btnExit.Enabled =
                !this._ButtonDisabled;
        }
        

        #endregion


        #region GridView Events


        //draw names and state messages of steps in different lines
        private void dgvSteps_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                Graphics gpcEventArgs = e.Graphics;
                Color clrFore = e.CellStyle.ForeColor;
                Color clrBack = e.CellStyle.BackColor;
                Font fntText = e.CellStyle.Font;

                string strFirstLine;
                string strSecondLine;

                if (e.Value == null || e.Value.ToString().Trim() == String.Empty || e.Value.ToString().IndexOf("&") == -1)
                {
                    strFirstLine = String.Empty;
                    strSecondLine = String.Empty;
                }
                else
                {
                    strFirstLine = e.Value.ToString().Substring(0, e.Value.ToString().IndexOf("&"));
                    strSecondLine = e.Value.ToString().Substring(e.Value.ToString().IndexOf("&") + 1);
                }

                Size sizText = TextRenderer.MeasureText(e.Graphics, strFirstLine, fntText);

                int intX = e.CellBounds.Left + e.CellStyle.Padding.Left;
                int intY = e.CellBounds.Top + e.CellStyle.Padding.Top;
                int intWidth = e.CellBounds.Width - (e.CellStyle.Padding.Left + e.CellStyle.Padding.Right);
                int intHeight = sizText.Height + (e.CellStyle.Padding.Top + e.CellStyle.Padding.Bottom);

                gpcEventArgs.FillRectangle(new SolidBrush(clrBack), e.CellBounds);

                clrFore = System.Drawing.Color.Black;

                //the first line
                TextRenderer.DrawText(e.Graphics, strFirstLine, fntText, new Rectangle(intX, intY, intWidth, intHeight), clrFore, TextFormatFlags.PreserveGraphicsClipping | TextFormatFlags.EndEllipsis);

                fntText = e.CellStyle.Font;
                intY = intY + intHeight - 1;

                clrFore = System.Drawing.Color.SteelBlue;

                //the seconde line
                TextRenderer.DrawText(e.Graphics, strSecondLine, fntText, new Rectangle(intX, intY, intWidth, intHeight), clrFore, TextFormatFlags.PreserveGraphicsClipping | TextFormatFlags.EndEllipsis);

                e.Handled = true;
            }
        }
        
        //draw parting lines among steps
        private void dgvSteps_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (Pen penLightGray = new Pen(Color.LightGray))
            {
                e.Graphics.DrawRectangle(penLightGray, e.RowBounds);
            }
        }

        //when a step result in a failure, you may click the last cell of the step to see the detailed message
        private void dgvSteps_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 &&
                e.RowIndex >= 0 &&
                this.dgvSteps.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == VIEWDETAIL)
            {
                MessageBox.Show(
                    "第" + System.Convert.ToString(e.RowIndex + 1) + "个步骤发生了错误：\r\n\r\nThe description of the error follows here...",
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }


        #endregion
        

        #region Form Events


        //when any step is processing, you cannot close the form
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._ButtonDisabled)
            {
                e.Cancel = true;
                return;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.picProcessing.Image = GifAnimationInDataGrid.Properties.Resources.PROCESS_PROCESSING;

            this.InitDgvRows();
        }
        

        #endregion


        #endregion

    }
}