using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyTest
{
    class Employees : ManagerCompany
    {
        public double wageHour { get; set; }

        public byte totalHours { get; set; }

        public double SalaryCalcul()
        {
            return wageHour * totalHours;
        }

        public  string Print()
        {
            return string.Format("full name  : {0} {1} \nAge : {2} \nWageHour : {3} \nTotal Hours : {4} \nSalary : {5}",
                              name, lastName, age, wageHour, totalHours, SalaryCalcul().ToString());

        }
        
    }
    
    
}
