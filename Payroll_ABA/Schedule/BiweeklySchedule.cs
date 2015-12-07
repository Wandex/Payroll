using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_ABA
{
    public class BiweeklySchedule : PaymentSchedule
    {
        public override string ToString()
        {
            return "Biweekly";
        }
    }
}
