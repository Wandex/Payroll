using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll_ABA;

namespace TestEmployeeToString
{
    [TestClass]
    public class TestEmployeeToString
    {
        [TestMethod]
        public void TestToString()
        {
            int empId = 2;
            Employee e = new Employee(empId, "TestEmployee", "TestAddress");
            e.ToString();
        }
    }
}
