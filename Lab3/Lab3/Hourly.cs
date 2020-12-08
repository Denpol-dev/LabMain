using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Hourly : OrganizationSalary
    {
        private double Rate;
        public Hourly(int employeeID, EmployeePosition employeePosition, EmployeeType type, double premium, double Rate) 
            : base(employeePosition, type, employeeID, _employeePremium)
        {
            this.Rate = Rate;
            type = employeeType;
            salary = SalaryCalc();
        }
        protected override double SalaryCalc()
        {
            return 20.8 * 8 * Rate + premium;
        }
    }
}
