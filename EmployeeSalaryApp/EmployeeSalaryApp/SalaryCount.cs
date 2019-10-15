using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    public class SalaryCount
    {
        private string name;
        private double salary;
    

    public SalaryCount(string name)
    {
        this.name = name;
    }

    public string ShowSalary(double basicSalary, int rentSalaryPercentage, int allowanceSalaryPercentage)
    {
        salary = basicSalary + basicSalary * (rentSalaryPercentage /100.00) +
                                basicSalary * (allowanceSalaryPercentage / 100.00);
        return name + " your salary is : " + salary;
    }
  }

}
