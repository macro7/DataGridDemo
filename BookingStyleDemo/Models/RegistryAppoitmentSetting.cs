using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingStyleDemo.Models
{
    public partial class RegistryAppoitmentSetting
    {
        /// <summary>
        /// 预约日期
        /// </summary>
        public DateTime AppointmentTime { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime AppointmentStartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime AppointmentEndTime { get; set; }
        string appointmentItem;
        public string AppointmentItem
        {
            get
            {
                if (string.IsNullOrEmpty(appointmentItem))
                {
                    appointmentItem = $"{AppointmentTime.ToString("HH:mm")}～{AppointmentEndTime.ToString("HH:mm")}";
                }
                return appointmentItem;
            }
            set
            {
                appointmentItem = value;
            }
        }
        /// <summary>
        /// 公司ID
        /// </summary>
        public string CompanyId { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserDataId { get; set; }
        /// <summary>
        /// 预约人数
        /// </summary>
        public int AppoitmentNum { get; set; }
        /// <summary>
        /// 已预约人数
        /// </summary>
        public int AppoitmentAfterNum { get; set; }
        /// <summary>
        /// 预约状态  1-预约中；2-已结束 ；3-休息...
        /// </summary>
        public int Status { get; set; }
        string statusName;
        /// <summary>
        /// 预约状态名称
        /// </summary>
        public string StatusName
        {
            get
            {
                if (string.IsNullOrEmpty(statusName))
                {
                    statusName = GlobalModel.StatusName[Status];
                }
                return statusName;
            }
            set
            {
                statusName = value;
            }
        }
    }
}
