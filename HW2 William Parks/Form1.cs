using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_William_Parks
{
    public partial class Form1 : Form
    {
        List<Grader> Graders = new List<Grader>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddGrader_Click(object sender, EventArgs e)
        {
            frmNewGrader f = new frmNewGrader();
            Grader g = f.GetNewGrader();
            if (g != null)
            {
                Graders.Add(g);
                GraderDB.SaveGraders(Graders);
                FillGraderListBox();
            }
        }

        private void FillGraderListBox()
        {
            lbxGraders.Items.Clear();
            foreach (Grader g in Graders)
            {
                lbxGraders.Items.Add(g.GetDisplayText("\t"));
            }
        }

        private void btnDeleteGrader_Click(object sender, EventArgs e)
        {
            int index = lbxGraders.SelectedIndex;
            Graders.RemoveAt(index);
            GraderDB.SaveGraders(Graders);
            FillGraderListBox();
        }

        private void btnGradGrader_Click(object sender, EventArgs e)
        {
            frmNewGraduateGrader f = new frmNewGraduateGrader();
            Grader g = f.GetNewGraduateGrader();
            Graders.Add(g);
            GraderDB.SaveGraders(Graders);
            FillGraderListBox();
        }
    }
}
