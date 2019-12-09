using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingStyleDemo.Models
{
    class GlobalModel
    {
        public readonly static string[] DayOfWeekName = new string[] { "周日", "周一", "周二", "周三", "周四", "周五", "周六", };

        public readonly static string[] StatusName = new string[] { "", "预约中", "已结束", "休息中..." };
    }
}
