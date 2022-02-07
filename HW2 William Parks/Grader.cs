using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_William_Parks
{
    public class Grader
    {
        private string iD;
        private string firstName;
        private string lastName;
        private decimal hourlyPay;
        private decimal hours;
        private decimal totalPay;

        public string ID { get => iD; set => iD = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public decimal HourlyPay { get => hourlyPay; set => hourlyPay = value; }
        public decimal Hours { get => hours; set => hours = value; }
        public decimal TotalPay { get => totalPay; set => totalPay = value; }

        public virtual string GetDisplayText(string sep)
        {
            return iD + sep + firstName + sep + lastName + sep + hourlyPay.ToString("c")
                + sep + hours.ToString("n") + sep + totalPay.ToString("c");
        }
    }
}
