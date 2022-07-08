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

    public partial class Homework_Hello : Form
    {

        public Homework_Hello()
        {
            InitializeComponent();
        }
        internal void button1_Click(object sender, EventArgs e)
        {

            String Name = txrName.Text;
            String Eng = txtEng.Text;
            String Sex = txtSex.Text;
            String Star = txtStar.Text;

            MessageBox.Show("Hello \n" + Name + "( " +Eng +" )\n" + Sex + "  " + Star+ "\n\n" + "歡迎請坐");
        }

        private void Homework_Hello_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String Name = txrName.Text;
            String Eng = txtEng.Text;
            String Sex = txtSex.Text;
            String Star = txtStar.Text;
            MessageBox.Show("Hi \n" + Name + "( " + Eng + " )\n" + Sex + "  " + Star + "\n\n" + "歡迎請坐");
        }
    }
}
