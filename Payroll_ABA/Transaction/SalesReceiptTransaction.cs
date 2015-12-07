using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_ABA
{
    class SalesReceiptTransaction : Transaction
    {
        private readonly DateTime date;
        private readonly double amount;
        private readonly int empId;

        public SalesReceiptTransaction(DateTime date, double amount, int empId)
        {
            this.date = date;
            this.amount = amount;
            this.empId = empId;
        }

        public void Execute()
        {
            Employee e = PayrollDatabase.GetEmployee(empId);
            if (e != null)
            {
                CommissionedClassification hc = e.Classification as CommissionedClassification;
                if (hc != null)
                {
                    hc.AddSalesReceipt(new SalesReceipt(date, amount));
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
