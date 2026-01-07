using System;
namespace Day4OOPDemo
{
    class Employee
    {
        #region Properties
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double BasicSal { get; set; }
        #endregion

        public virtual int CalculateSalary()
        {
            int mySal = 0;
            //NetSalary = Salary-HRA+TA+DA-PF
            mySal = (sal + 15000 + 3000 + 1500 - 2500);
            return mySal;
         }
    }
}
