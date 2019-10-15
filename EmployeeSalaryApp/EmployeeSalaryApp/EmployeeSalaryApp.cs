using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryApp : Form
    {
        public SalaryCount salarycount;
        public EmployeeSalaryApp()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            bool flag1 = Regex.IsMatch(basicSalaryTextBox.Text, "[0-9.]{1,}$");
            bool flag2 = Regex.IsMatch(houseRentSalaryTextBox.Text, "[0-9]{1,}$");
            bool flag3 = Regex.IsMatch(allowanceSalaryTextBox.Text, "[0-9]{1,}$");
            bool flag4 = Regex.IsMatch(cutomerNameTextBox.Text, "[0-9a-zA-Z]{1,}$");
            if (flag4)
            {
                salarycount=new SalaryCount(cutomerNameTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please input your name");
                return;
            }

            if (flag1==true&& flag2==true&&flag3==true)
            {
                double basicSalary = Convert.ToDouble(basicSalaryTextBox.Text);
                int rentSalaryPercentage = Convert.ToInt32(houseRentSalaryTextBox.Text);
                int allowanceSalaryPercentage = Convert.ToInt32(allowanceSalaryTextBox.Text);
               string mySalary= salarycount.ShowSalary(basicSalary, rentSalaryPercentage, allowanceSalaryPercentage);
               MessageBox.Show(mySalary);
            }
            else
            {
                MessageBox.Show("Please enter all field properly.");
                return;
            }

        }
    }
}
