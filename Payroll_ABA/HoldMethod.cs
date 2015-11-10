using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_ABA
{
    public class HoldMethod : PaymentMethod
    {
        public override string ToString()
        {
            return "hold";
        }
    }
}
