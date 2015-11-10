using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll_ABA
{
    public class MonthlySchedule : PaymentSchedule
    {
        public override string ToString()
        {
            return "monthly";
        }
    }
}
