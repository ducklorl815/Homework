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
    public partial class Homework_Menu : Form
    {
        public Homework_Menu()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Homework_Hello Hello = new Homework_Hello();
            Hello.TopLevel = false;
            Hello.Top = 0;
            Hello.Dock = DockStyle.Fill;
            Hello.FormBorderStyle = FormBorderStyle.None;
            this.splitContainer1.Panel2.Controls.Clear();

            Homework_Hello x = new Homework_Hello();
            x.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(x);
            x.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Homework_Loan Loan = new Homework_Loan();
            Loan.TopLevel = false;
            Loan.Top = 0;
            Loan.Dock = DockStyle.Fill;
            Loan.FormBorderStyle = FormBorderStyle.None;
            this.splitContainer1.Panel2.Controls.Clear();

            Homework_Loan x = new Homework_Loan();
            x.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(x);
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homework_POS POS = new Homework_POS();
            POS.TopLevel = false;
            POS.Top = 0;
            POS.Dock = DockStyle.Fill;
            POS.FormBorderStyle = FormBorderStyle.None;
            this.splitContainer1.Panel2.Controls.Clear();

            Homework_POS x = new Homework_POS();
            x.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(x);
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Homework_Student_StructForm StructForm = new Homework_Student_StructForm();
            StructForm.TopLevel = false;
            StructForm.Top = 0;
            StructForm.Dock = DockStyle.Fill;
            StructForm.FormBorderStyle = FormBorderStyle.None;
            this.splitContainer1.Panel2.Controls.Clear();

            Homework_Student_StructForm x = new Homework_Student_StructForm();
            x.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(x);
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Homework_StudentsGrade StudentsGrade = new Homework_StudentsGrade();
            StudentsGrade.TopLevel = false;
            StudentsGrade.Top = 0;
            StudentsGrade.Dock = DockStyle.Fill;
            StudentsGrade.FormBorderStyle = FormBorderStyle.None;
            this.splitContainer1.Panel2.Controls.Clear();

            Homework_StudentsGrade x = new Homework_StudentsGrade();
            x.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(x);
            x.Show();
        }

    }
}
