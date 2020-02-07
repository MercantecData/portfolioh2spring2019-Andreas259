using System;
using System.Collections.Generic;
using System.Text;

namespace UserLibrary
{
    public class HourlyPaidJob : Job
    {
        public int HourlyPay { get; set; }

        public HourlyPaidJob(int hourlyPay)
        {
            HourlyPay = hourlyPay;
        }

        public override int GetMonthlyPay()
        {
            return HourlyPay * 160;
        }
    }
}