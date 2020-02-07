using System;
using System.Collections.Generic;
using System.Text;

namespace UserLibrary
{
    public class DailyPaidJob : Job
    {
        public int DailyPay { get; set; }

        public DailyPaidJob(int dailyPay)
        {
            DailyPay = dailyPay;
        }

        public override int GetMonthlyPay()
        {
            return DailyPay * 40;
        }
    }
}