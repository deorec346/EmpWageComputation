using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC13_DailyWages
{
    internal class CompanyEmpWage
    {
            public string company;
            public int emp_Rate_Per_Hr, no_Of_Working_Days, max_Hrs_Per_Month, total_Emp_Wage;

            public CompanyEmpWage(string company, int emp_Rate_Per_Hr, int no_Of_Working_Days, int max_Hrs_Per_Month)
            {
                this.company = company;
                this.emp_Rate_Per_Hr = emp_Rate_Per_Hr;
                this.no_Of_Working_Days = no_Of_Working_Days;
                this.max_Hrs_Per_Month = max_Hrs_Per_Month;
                this.total_Emp_Wage = 0;
            }

            public void setTotalEmpWage(int total_Emp_Wage)
            {
                this.total_Emp_Wage = total_Emp_Wage;
            }

            public string ToString()
            {
                return "Total Emp Wage For Company " + this.company + " is " + this.total_Emp_Wage;
            }
        

    }
}
