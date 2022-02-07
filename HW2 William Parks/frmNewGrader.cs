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
    public partial class frmNewGrader : Form
    {
        Grader g;

        public frmNewGrader()
        {
            InitializeComponent();
        }

        public Grader GetNewGrader()
        {
            this.ShowDialog();
            return g;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            g = new Grader();

            g.ID = txtID.Text;
            g.FirstName = txtFirstName.Text;
            g.LastName = txtLastName.Text;
            g.HourlyPay = decimal.Parse(txtHourlyPay.Text);
            g.Hours = decimal.Parse(txtHours.Text);
            g.TotalPay = g.HourlyPay * g.Hours;

            MessageBox.Show(g.GetDisplayText(" "));

            this.Close();
            
        }
    }
}
