using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Fixed : OrganizationSalary
    {
        private double Rate;

        public Fixed(int employeeID, EmployeePosition employeePosition, EmployeeType type, double premium) 
            : base(employeePosition, type, employeeID, premium)
        {
            

        }

        protected override double SalaryCalc()
        {
            return _employeePremium
        }
    }
}
