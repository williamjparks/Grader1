using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_William_Parks
{
    public class GraduateGrader:Grader
    {
        private decimal stipend;

        public decimal Stipend { get => stipend; set => stipend = value; }

        public override string GetDisplayText(string sep)
        {
            return base.GetDisplayText(sep) + sep + stipend;
        }
    }
}
