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
    public partial class Homework_POS : Form
    {
        // MOUSE PRICE 
        public int winpic1, winpic2, winpic3, winpic4,Price;
        public int win1 = 60;
        public int win2 = 80;
        public int win3 = 30;
        public int win4 = 85;
        public int bag = 2;
        public string Wine1, Wine2, Wine3, Wine4;


    private void btnCase_Click(object sender, EventArgs e)
        {

            MessageBox.Show("總共為 " + Price + " 元");
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總共為 " + Math.Round(Price *0.9) + " 元");
        }

        private void labList_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void labList_TextChanged(object sender, EventArgs e)
        {

        }

        private void labPrice_TextChanged(object sender, EventArgs e)
        {
            if (labPrice.Text=="")
            {
                btnCase.ForeColor = Color.DimGray;
                btnCredit.ForeColor = Color.DimGray;
                btnCase.Enabled = false;
                btnCredit.Enabled = false;
                ckPag.Visible = false;
                ckHot.Visible = false;
            }
            else
            {
                btnCase.ForeColor = Color.Black;
                btnCredit.ForeColor = Color.Black;
                btnCase.Enabled = true;
                btnCredit.Enabled = true;
                ckPag.Visible = true;
                ckHot.Visible = true;
            }

        }

        private void ckPag_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPag.Checked == true)
            {
                Price= Price + bag;
            }
            else
            {
                Price = Price - bag;
            }
            labPrice.Text = "NT " + Price.ToString() + " 元";
        }

        private void btnDlvy_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("總共為 " + Price+ " 元\n是否使用信用卡結帳?", "外送!!!",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("總共為 " + Math.Round(Price *0.9) + " 元\n外送電話0968280480");
            }
            else
            {
                MessageBox.Show("總共為 " + Price + " 元\n外送電話0968280480");
            }
        }

        private void ckHot_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHot.Checked == true)
            {
                pcboxHot.Visible = true;
            }
            else
            {
                pcboxHot.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnDlvy.Enabled = false;
            btnDlvy.Visible = false;
            ckPag.Checked = false;
            ckHot.Checked = false;
            winpic1 = 0;
            winpic2 = 0;
            winpic3 = 0;
            winpic4 = 0;
            Price = 0;
            Wine1 = "";
            Wine2 = "";
            Wine3 = "";
            Wine4 = "";
            labPrice.Text ="";
            labList.Text = "";
            labList.Text = (Wine1 + Wine2 + Wine3 + Wine4);

        }

        private void labPrice_Click(object sender, EventArgs e)
        { 

        }

        private void btnPic4_Click(object sender, EventArgs e)
        {
            winpic4 += 1;
            if (winpic4 >= 0)
            {
                Wine4 ="黑糖珍珠鮮奶"+ winpic4 +"杯 "+ winpic4*win4 + " 元"+"\n";
            }
            labList.Text = (Wine1 + Wine2 + Wine3 + Wine4);
            Price = winpic1 * win1 + winpic2 * win2 + winpic3 * win3 + winpic4 * win4;

            labPrice.Text = "NT " + Price.ToString() +" 元";
            if (Price >= 500)
            {
                btnDlvy.Enabled = true;
                btnDlvy.Visible = true;
            }

        }

        public Homework_POS()
        {
            InitializeComponent();
        }

        private void btnPic3_Click(object sender, EventArgs e)
        {
            winpic3 += 1;
            if (winpic3 >= 0)
            {
                Wine3 = "無糖綠茶"+ winpic3 + "杯 " + winpic3*win3+" 元"+"\n";
            }
            labList.Text = Wine1 + Wine2 + Wine3 + Wine4;
            Price = winpic1 * win1 + winpic2 * win2 + winpic3 * win3 + winpic4 * win4;

            labPrice.Text = "NT " + Price.ToString() + " 元";
            if (Price >= 500)
            {
                btnDlvy.Enabled = true;
                btnDlvy.Visible = true;
            }
        }

        
        private void btnPic1_Click(object sender, EventArgs e)
        {
            winpic1 += 1;           
            if (winpic1 >= 0)
            {
                    Wine1 = "鹹酥雞" + winpic1 + "份 " + winpic1 * win1 + " 元" + "\n";
            }
            labList.Text = Wine1 + Wine2 + Wine3 + Wine4;
            Price = winpic1 * win1 + winpic2 * win2 + winpic3 * win3 + winpic4 * win4;

            labPrice.Text = "NT " + Price.ToString() + " 元";
            if (Price >= 500)
            {
                btnDlvy.Enabled = true;
                btnDlvy.Visible = true;
            }

        }

        private void btnPic2_Click(object sender, EventArgs e)
        {
            winpic2 += 1;
            if (winpic2 > 0)
            {
                    Wine2 = "雞排" + winpic2 + "份 " + winpic2 * win2 + "元" + "\n";
            }
            labList.Text = Wine1 + Wine2 + Wine3 + Wine4;
            Price = winpic1 * win1 + winpic2 * win2 + winpic3 * win3 + winpic4 * win4;

            labPrice.Text = "NT " + Price.ToString() + " 元";
            if (Price >= 500)
            {
                btnDlvy.Enabled = true;
                btnDlvy.Visible = true;
            }
            else
            {
                btnDlvy.Enabled = false;
                btnDlvy.Visible = false;
            }

        }
    }
}
