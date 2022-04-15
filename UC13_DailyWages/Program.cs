using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC13_DailyWages
{
    public class program
    {
            public static void Main(string[] args)
            {
                EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
                empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
                empWageBuilder.computeEmpWage();
                Console.WriteLine("Total Emp Wage for Dmart Company :" + empWageBuilder.getTotalWage("Dmart"));
                Console.WriteLine("Total Emp Wage for Reliance Company :" + empWageBuilder.getTotalWage("Reliance"));


            }
        
    }
}