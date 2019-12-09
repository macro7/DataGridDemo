using BookingStyleDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookingStyleDemo
{
    public partial class FrmBookingManager : Form
    {
        List<RegistryAppoitmentSetting> RegistryAppoitmentSettings = new List<RegistryAppoitmentSetting>();
        Color weekItemBackColor = Color.White;
        int lblSizeHeight = 48;

        public FrmBookingManager()
        {
            InitializeComponent();

            InitWeekItems(DateTime.Today);

            RegistryAppoitmentSettings = FakerAppointmentDt();
            LoadAppointMentItems(RegistryAppoitmentSettings);
            BindEvent_AppointMentItems();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }

        #region 伪造数据
        List<RegistryAppoitmentSetting> FakerAppointmentDt()
        {
            var registryAppoitmentSettings = new List<RegistryAppoitmentSetting>();
            var start = DateTime.Today.AddYears(-1);
            var end = DateTime.Today.AddYears(+1);
            string companyId = Guid.NewGuid().ToString().Replace("-", "");
            string userDataId = Guid.NewGuid().ToString().Replace("-", "");
            while (start < end)
            {
                var random = new Random().Next(1, 9);
                for (var i = 1; i < random; i++)
                {
                    registryAppoitmentSettings.Add(new RegistryAppoitmentSetting()
                    {
                        /// <summary>
                        /// 预约日期
                        /// </summary>
                        AppointmentTime = start,
                        /// <summary>
                        /// 开始时间
                        /// </summary>
                        AppointmentStartTime = start.AddHours(8 + i),
                        /// <summary>
                        /// 结束时间
                        /// </summary>
                        AppointmentEndTime = start.AddHours(8 + i + 1),
                        /// <summary>
                        /// 公司ID
                        /// </summary>
                        CompanyId = companyId,
                        /// <summary>
                        /// 用户ID
                        /// </summary>
                        UserDataId = userDataId,
                        /// <summary>
                        /// 预约人数
                        /// </summary>
                        AppoitmentNum = 9,
                        /// <summary>
                        /// 已预约人数
                        /// </summary>
                        AppoitmentAfterNum = 6,
                        /// <summary>
                        /// 预约状态  1-预约中；2-已结束 ；3-休息中...
                        /// </summary>
                        Status = new Random().Next(1, 4)
                    });
                }
                start = start.AddDays(1);
            }
            return registryAppoitmentSettings;
        }
        #endregion

        #region 加载日期、切换上一周下一周
        /// <summary>
        /// 加载头部日期（星期）
        /// </summary>
        /// <param name="currentDay"></param>
        private void InitWeekItems(DateTime currentDay)
        {
            this.pnlWeek.Tag = currentDay;
            //如果星期时间没有初始化，则初始化
            if (pnlWeek.Controls.Count == 0)
            {
                var weekItemWith = (this.pnlWeek.Width - 8) / 8;
                var weekItemHeight = pnlWeek.Height;
                var x = 1;
                for (var day = 0; day < 8; day++)
                {
                    if (day == 0)
                    {
                        var bookingTimeItem = CreateWeekItem(currentDay, weekItemWith, weekItemHeight, x, "时间");
                        this.pnlWeek.Controls.Add(bookingTimeItem);
                        this.pnlWeek.Controls.SetChildIndex(bookingTimeItem, 8 - day);
                    }
                    else
                    {
                        // 显示星期几
                        //var text = string.Format("{0}{2}{1}", System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(currentDay.DayOfWeek), currentDay.ToString("yyyy-MM-dd"), Environment.NewLine);
                        var text = string.Format("{0} {1}", GlobalModel.DayOfWeekName[Convert.ToInt16(currentDay.DayOfWeek.ToString("D"))], currentDay.ToString("yyyy-MM-dd"));// System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(currentDay.DayOfWeek);
                        var bookingTimeItem = CreateWeekItem(currentDay, weekItemWith, weekItemHeight, x, text);
                        this.pnlWeek.Controls.Add(bookingTimeItem);
                        currentDay = currentDay.AddDays(1);
                    }
                    x += weekItemWith + 1;
                }
            }
            else
            {
                //如果已经初始化了，则直接变更其内容即可
                for (var i = 1; i < 8; i++)
                {
                    Label biookingTimeItem = pnlWeek.Controls[i] as Label;
                    //var text = string.Format("{0}{2}{1}", System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(currentDay.DayOfWeek), currentDay.ToString("yyyy-MM-dd"), Environment.NewLine);
                    biookingTimeItem.Text = string.Format("{0} {1}", GlobalModel.DayOfWeekName[Convert.ToInt16(currentDay.DayOfWeek.ToString("D"))], currentDay.ToString("yyyy-MM-dd"));
                    currentDay = currentDay.AddDays(1);
                }
            }
        }

        /// <summary>
        /// 创建星期控件
        /// </summary>
        /// <param name="currentDay"></param>
        /// <param name="weekItemWith"></param>
        /// <param name="weekItemHeight"></param>
        /// <param name="locationX"></param>
        /// <returns></returns>
        private Label CreateWeekItem(DateTime currentDay, int weekItemWith, int weekItemHeight, int locationX, string text)
        {
            Label bookingTimeItem = new Label()
            {
                Size = new Size(weekItemWith, weekItemHeight),
                Location = new Point(locationX, 1),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = text,
                BackColor = weekItemBackColor,
                Tag = currentDay,
            };
            return bookingTimeItem;
        }

        /// <summary>
        /// 往前一周
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevWeek_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                this.btnPrevWeek.Enabled = this.btnNextWeek.Enabled = false;

                var currDay = pnlWeek.Tag == null ? DateTime.Today : ((DateTime)pnlWeek.Tag);
                InitWeekItems(currDay.AddDays(7));

                LoadAppointMentItems(RegistryAppoitmentSettings);
                BindEvent_AppointMentItems();
            }
            finally
            {
                this.btnPrevWeek.Enabled = this.btnNextWeek.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// 往后一周
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                this.btnPrevWeek.Enabled = this.btnNextWeek.Enabled = false;

                var currDay = pnlWeek.Tag == null ? DateTime.Today : ((DateTime)pnlWeek.Tag);
                InitWeekItems(currDay.AddDays(-7));

                LoadAppointMentItems(RegistryAppoitmentSettings);
                BindEvent_AppointMentItems();
            }
            finally
            {
                this.btnPrevWeek.Enabled = this.btnNextWeek.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region 加载预约排班数据
        /// <summary>
        /// 加载预约数据
        /// </summary>
        private void LoadAppointMentItems(List<RegistryAppoitmentSetting> registryAppoitments)
        {
            var appointTimeList = registryAppoitments.Select(a => a.AppointmentItem).Distinct().ToList();

            this.pnlItemContainer.Controls.Clear();
            int x = 1, y = 1;
            //遍历时间段
            foreach (var appointTime in appointTimeList)
            {
                //根据时间段将没行记录填充
                for (var i = 0; i < 8; i++)
                {
                    var lblSizeWidth = pnlWeek.Controls[i].Width;
                    if (i == 0)
                    {
                        Label timeItem = new Label()
                        {
                            Location = new Point(x, y),
                            AutoSize = false,
                            Size = new Size(lblSizeWidth, lblSizeHeight),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Text = appointTime,
                            BackColor = weekItemBackColor,
                        };
                        this.pnlItemContainer.Controls.Add(timeItem);
                        x += pnlWeek.Controls[i].Width + 1;
                    }
                    else
                    {
                        var appointmentTime = (DateTime)pnlWeek.Controls[i].Tag;
                        var appointTimeItem = registryAppoitments.FirstOrDefault(a => a.AppointmentTime == appointmentTime && a.AppointmentItem == appointTime);
                        //var timeItem = new AppointmentItem(appointTimeItem)
                        //{
                        //    Location = new Point(x, y),
                        //    Size = new Size(lblSizeWidth, lblSizeHeight),
                        //};
                        //timeItem.Click += TimeItem_Click;
                        //this.pnlItemContainer.Controls.Add(timeItem);

                        if (appointTimeItem == null)
                        {
                            // 如果该时间段没有排班，则显示未排班
                            var timeItem = CreateEmptyAppointItem(x, y, lblSizeWidth, lblSizeHeight, weekItemBackColor);
                            this.pnlItemContainer.Controls.Add(timeItem);
                        }
                        else
                        {
                            var text = $"{appointTimeItem.AppoitmentAfterNum}/{appointTimeItem.AppoitmentNum}";
                            Label timeItem1 = CreateAppointItem(appointTimeItem, x, y, lblSizeWidth, lblSizeHeight, ContentAlignment.BottomCenter, text, this.ForeColor);
                            this.pnlItemContainer.Controls.Add(timeItem1);

                            Color foreColor = GetStatusColor(appointTimeItem.Status);
                            text = appointTimeItem.StatusName;
                            Label timeItem2 = CreateAppointItem(appointTimeItem, x, y + timeItem1.Height, lblSizeWidth, lblSizeHeight, ContentAlignment.TopCenter, text, foreColor);
                            this.pnlItemContainer.Controls.Add(timeItem2);
                        }

                        x += pnlWeek.Controls[i].Width + 1;
                    }
                }
                y += lblSizeHeight + 1;
                x = 1;
            }
            Application.DoEvents();
        }

        /// <summary>
        /// 创建预约资源项
        /// </summary>
        /// <param name="registryAppoitmentSetting"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="lblSizeWidth"></param>
        /// <param name="lblSizeHeight"></param>
        /// <param name="contentAlignment"></param>
        /// <param name="text"></param>
        /// <param name="foreColor"></param>
        /// <returns></returns>
        private Label CreateAppointItem(RegistryAppoitmentSetting registryAppoitmentSetting, int x, int y, int lblSizeWidth, int lblSizeHeight, ContentAlignment contentAlignment, string text, Color foreColor)
        {
            return new Label()
            {
                Location = new Point(x, y),
                AutoSize = false,
                Size = new Size(lblSizeWidth, lblSizeHeight / 2),
                TextAlign = contentAlignment,
                Text = text,
                BackColor = weekItemBackColor,
                ForeColor = foreColor,
                Tag = registryAppoitmentSetting,
                Cursor = Cursors.Hand,
            };
        }

        /// <summary>
        /// 创建空项
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="lblSizeWidth"></param>
        /// <param name="lblSizeHeight"></param>
        /// <returns></returns>
        private Label CreateEmptyAppointItem(int x, int y, int lblSizeWidth, int lblSizeHeight, Color backColor)
        {
            Label timeItem = new Label()
            {
                Location = new Point(x, y),
                AutoSize = false,
                Size = new Size(lblSizeWidth, lblSizeHeight),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "未排班",
                BackColor = backColor,
            };
            return timeItem;
        }

        /// <summary>
        /// 根据预约状态显示颜色
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        private Color GetStatusColor(int status)
        {
            switch (status)
            {
                case 1:
                    return Color.DarkGreen;
                case 2:
                    return Color.DarkGray;
                case 3:
                    return Color.Gold;
            }
            return weekItemBackColor;
        }


        /// <summary>
        /// 绑定事件
        /// </summary>
        private void BindEvent_AppointMentItems()
        {
            foreach (Control control in pnlItemContainer.Controls)
            {
                if (control.Tag is RegistryAppoitmentSetting)
                {
                    control.Click += TimeItem_Click;
                }
            }
        }
        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeItem_Click(object sender, EventArgs e)
        {
            //点击事件、拿到对象
            var registryAppoitmentSetting = (sender as Label).Tag as RegistryAppoitmentSetting;

            if (registryAppoitmentSetting == null)
            {
                return;
            }
            //todo

        }

        #endregion
    }
}
