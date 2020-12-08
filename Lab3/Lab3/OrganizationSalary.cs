using System;
using System.Collections.Generic;

namespace Lab3
{
    public abstract class OrganizationSalary
    {
        public enum EmployeeType
        {
            Fixed,
            Hourly
        }
        
        public enum EmployeePosition
        {
            Директор,
            Программист,
            Уборщик
        }

        private static readonly Dictionary<EmployeePosition, double> _employeePremium =
            new Dictionary<EmployeePosition, double>
            {
                [EmployeePosition.Директор] = 40000,
                [EmployeePosition.Программист] = 30000,
                [EmployeePosition.Уборщик] = 10000
            };

        public readonly int employeeID;
        
        public string name;
        public double _employeePremium;
        protected EmployeePosition employeePosition;
        protected EmployeeType employeeType;
        public double salary;

        protected abstract double SalaryCalc();

        public OrganizationSalary(EmployeePosition employeePosition, EmployeeType type, int employeeID, double _employeePremium)
        {
            this.employeeType = type;
            this.employeeID = employeeID;
        }

        public EmployeeType GetEmployeeType()
        {
            return employeeType;
        }
    }
}
