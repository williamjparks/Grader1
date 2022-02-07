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
    public partial class frmNewGraduateGrader : Form
    {
        GraduateGrader gg;

        public frmNewGraduateGrader()
        {
            InitializeComponent();
        }

        public GraduateGrader GetNewGraduateGrader()
        {
            this.ShowDialog();
            return gg;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gg = new GraduateGrader();

            gg.ID = txtID.Text;
            gg.FirstName = txtFirstName.Text;
            gg.LastName = txtLastName.Text;
            gg.HourlyPay = decimal.Parse(txtHourlyPay.Text);
            gg.Hours = decimal.Parse(txtHours.Text);
            gg.Stipend = decimal.Parse(txtStipend.Text);
            gg.TotalPay = (gg.HourlyPay * gg.Hours) + gg.Stipend;

            MessageBox.Show(gg.GetDisplayText(" "));

            this.Close();
        }
    }
}
