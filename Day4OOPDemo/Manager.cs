namespace Day4OOPDemo
{
    class Manager : Employee
    {
        public int MrgID { get; set; }

        public int Incentive { get; set; }

        public int CalculateSalary(int sal)
        {
            int mySal = 0;
            //NetSalary = Salary-HRA+TA+DA-PF
            mySal = (sal + 35000 + 12000 + 4500 - 8500);
            return mySal;
         }
        
    }

}
