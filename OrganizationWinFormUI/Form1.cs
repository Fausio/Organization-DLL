using Reusable_Component_DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationWinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                Name = "Fausio",
                SalaryPerDay = 300,
                HRA = 6.2
            };


            label1.Text = "The gross salary of " + employee.Name + " is " + employee.GetSalary(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
