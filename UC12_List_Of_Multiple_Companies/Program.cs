using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC12_List_Of_Multiple_Companies
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            //creating object for each company
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("TVSNEXT", 20, 10, 10);
            empWageBuilder.addCompanyEmpWage("HCL", 20, 10, 10);
            empWageBuilder.computeEmpWage();
        }
    }
}