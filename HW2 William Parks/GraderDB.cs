using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_William_Parks
{
    class GraderDB
    {

        static public void SaveGraders(List<Grader> graders)
        {
            StreamWriter textOut = new StreamWriter
            (new FileStream("Grader.txt", FileMode.Create, FileAccess.Write));

            foreach (Grader g in graders)
            {
                textOut.WriteLine(g.GetDisplayText("|"));
            }
            textOut.Close();
        }
    }
}
