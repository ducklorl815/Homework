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
 // todo OUT  
    public partial class Homework_Loan : Form
    {

        public Homework_Loan()
        {
            InitializeComponent();
        }

     

        private void btnMonth_Click(object sender, EventArgs e)
        {
            btnReport.Enabled = true;
            int M = int.Parse(txtMoney.Text) - int.Parse(txtFirst.Text);//貸款本金
            double R = 1 + double.Parse(txtRate.Text) / 12 / 100; //月利率
            int N = int.Parse(txtYear.Text) * 12; //還款月數

            double RPN = Math.Pow(R, N);  //月利率^還款月數
            double PMT = M * RPN * (R - 1) / (RPN - 1);
            //PMT = x * rpn * (r - 1) / (rpn - 1);
            MessageBox.Show("需月付 " + Math.Floor(PMT) + " 金額");
        }

        private void btnAllPay_Click(object sender, EventArgs e)
        {
            btnReport.Enabled = true;
            int M = int.Parse(txtMoney.Text) - int.Parse(txtFirst.Text); //貸款本金
            double R = 1 + double.Parse(txtRate.Text) / 12 / 100; //月利率
            int N = int.Parse(txtYear.Text) * 12; //還款月數

            double RPN = Math.Pow(R, N);  //月利率^還款月數
            double ALLPMT = M * RPN * (R - 1) / (RPN - 1) * 24;
            MessageBox.Show("應付總金額為 " + Math.Floor(ALLPMT));
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            btnReport.Enabled = false;
            Homework_Loan_Report LP = new Homework_Loan_Report();
            int M = int.Parse(txtMoney.Text) - int.Parse(txtFirst.Text); //貸款本金
            double R = 1 + double.Parse(txtRate.Text) / 12 / 100; //月利率
            int N = int.Parse(txtYear.Text) * 12; //還款月數

            double RPN = Math.Pow(R, N);  //月利率^還款月數
            double PMT = M * RPN * (R - 1) / (RPN - 1);
            double ALLPMT = PMT * 24;

            LP.TopLevel = true;
            LP.Show();
            
            LP.labMoney.Text = Convert.ToString(int.Parse(txtMoney.Text));
            LP.labYear.Text = Convert.ToString(N);
            LP.labRate.Text = Convert.ToString(double.Parse(txtRate.Text));
            LP.labMonthPay.Text = Convert.ToString(Math.Floor(PMT));
            LP.labAllPay.Text = Convert.ToString(Math.Floor(ALLPMT));
        }
    }
}
