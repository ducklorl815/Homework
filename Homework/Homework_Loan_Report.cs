using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Homework_Loan_Report : Form
    {
        public Homework_Loan_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("寄信詢問，專人服務","Email", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://i.scdn.co/image/ab6761610000e5eb006ff3c0136a71bfb9928d34");
                Close();
            }else
            Close();
        }

        private void labMoney_Click(object sender, EventArgs e)
        {

        }
    }
}
