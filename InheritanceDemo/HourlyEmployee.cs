using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class HourlyEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        
        public HourlyEmployee()
        {
            HourlyRate = 15.0M;
        }

        public override string GetPaySummary
        {
            get { return "This employee is payed " + HourlyRate + " per hour."; }
        }
    }
}
