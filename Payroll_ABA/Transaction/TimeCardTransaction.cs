using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_ABA
{
    public class TimeCardTransaction : Transaction
    {
        private readonly DateTime date;
        private readonly double hours;
        private readonly int empId;

        public TimeCardTransaction(DateTime date, double hours, int empId)
        {
            this.date = date;
            this.hours = hours;
            this.empId = empId;
        }

        public void Execute()
        {
            Employee e = PayrollDatabase.GetEmployee(empId);
            if (e != null)
            {
                HourlyClassification hc = e.Classification as HourlyClassification;
                if (hc != null)
                {
                    hc.AddTimeCard(new TimeCard(date, hours));
                }
                else
                {
                    throw new InvalidOperationException("Попытка добавить карточку табульного учета " + "для работника не на почпсовой оплате");
                }
            }
            else
            {
                throw new InvalidOperationException("Работник не найден.");
            }
        }
    }
}
