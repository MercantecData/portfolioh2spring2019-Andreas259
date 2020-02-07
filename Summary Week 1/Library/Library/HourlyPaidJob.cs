using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class HourlyPaidJob : Job
    {
        public int HourlyPay { get; set; }

        public override int GetMonthlyPay()
        {
            return HourlyPay * 160;
        }
    }
}
