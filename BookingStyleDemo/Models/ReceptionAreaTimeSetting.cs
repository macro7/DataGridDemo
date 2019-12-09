using System;

namespace BookingStyleDemo.Models
{
    class ReceptionAreaTimeSetting
    {
        /// <summary>
        /// 时间段
        /// </summary>
        public string TimeQuantum { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime TimeStartDate { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime TimeEndDate { get; set; }
        /// <summary>
        /// 是否开启
        /// </summary>
        public int IsShow { get; set; }
        /// <summary>
        /// 预约人数
        /// </summary>
        public int AppoitmentNum { get; set; }
        public string CompanyId { get; set; }
        public string UserDataId { get; set; }
    }
}
