using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class DailyPaidJob : Job
    {
        public int DailyPay { get; set; }

        public override int GetMonthlyPay()
        {
            return DailyPay * 40;
        }
    }
}
