using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Homework
{

    public partial class Homework_Student_StructForm : Form
    {
        public Homework_Student_StructForm()
        {
            InitializeComponent();
        }
        Product pro;

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnShow.Enabled = true;
            labHighLow.Text = "";
            labGrade.Text = "";
            bool isNumC = int.TryParse(txtChinese.Text, out int chinese);
            bool isNumE = int.TryParse(txtEnglish.Text, out int english);
            bool isNumM = int.TryParse(txtMath.Text, out int math);
            if (txtName.Text == string.Empty || chinese > 100 || english > 100 || math > 100 || chinese < 0 || english < 0 || math < 0)
            {
                if (txtName.Text == string.Empty)
                {
                    MessageBox.Show("請輸入姓名再按確認");
                }
                else if (chinese > 100 || english > 100 || math > 100)
                {       // i=1              j=3              k=5  
                    int count = 0;
                    if (chinese > 100)
                        count += 1;
                    if (english > 100)
                        count += 3;
                    if (math > 100)
                        count += 5;
                    switch (count)
                    {
                        case 1:
                            txtChinese.Clear();
                            break;
                        case 3:
                            txtEnglish.Clear();
                            break;
                        case 5:
                            txtMath.Clear();
                            break;
                        case 4:
                            txtChinese.Clear();
                            txtEnglish.Clear();
                            break;
                        case 6:
                            txtChinese.Clear();
                            txtMath.Clear();
                            break;
                        case 8:
                            txtEnglish.Clear();
                            txtMath.Clear();
                            break;
                        case 9:
                            txtChinese.Clear();
                            txtEnglish.Clear();
                            txtMath.Clear();
                            break;
                    }

                }
                if (chinese < 0 || english < 0 || math < 0)
                {       // i=1              j=3              k=5  
                    int count = 0;
                    if (chinese < 0)
                        count += 1;
                    if (english < 0)
                        count += 3;
                    if (math < 0)
                        count += 5;
                    switch (count)
                    {
                        case 1:
                            txtChinese.Clear();
                            break;
                        case 3:
                            txtEnglish.Clear();
                            break;
                        case 5:
                            txtMath.Clear();
                            break;
                        case 4:
                            txtChinese.Clear();
                            txtEnglish.Clear();
                            break;
                        case 6:
                            txtChinese.Clear();
                            txtMath.Clear();
                            break;
                        case 8:
                            txtEnglish.Clear();
                            txtMath.Clear();
                            break;
                        case 9:
                            txtChinese.Clear();
                            txtEnglish.Clear();
                            txtMath.Clear();
                            break;
                    }
                }

            }

            else if (isNumC == false || isNumE == false || isNumM == false)
            {           // i=1                j=3                 k=5           
                int count = 0;
                if (isNumC == false)
                {
                    for (int i = 1; i <= 2; i++)
                        count += 1;
                }
                if (isNumE == false)
                {
                    for (int i = 1; i <= 2; i++)
                        count += 3;
                }
                if (isNumM == false)
                {
                    for (int i = 1; i <= 2; i++)
                        count += 5;
                }

                switch (count)
                {
                    case 2:
                        MessageBox.Show("請正確輸入國文");
                        txtChinese.Clear();
                        break;
                    case 6:
                        MessageBox.Show("請正確輸入英文");
                        txtEnglish.Clear();
                        break;
                    case 10:
                        MessageBox.Show("請正確輸入數學");
                        txtMath.Clear();
                        break;
                    case 8:
                        MessageBox.Show("請正確輸入國文英文");
                        txtChinese.Clear();
                        txtEnglish.Clear();
                        break;
                    case 12:
                        MessageBox.Show("請正確輸入國文數學");
                        txtChinese.Clear();
                        txtMath.Clear();
                        break;
                    case 16:
                        MessageBox.Show("請正確輸入英文數學");
                        txtEnglish.Clear();
                        txtMath.Clear();
                        break;
                    case 18:
                        MessageBox.Show("請正確輸入國英數");
                        txtChinese.Clear();
                        txtMath.Clear();
                        txtEnglish.Clear();
                        break;
                }

                //MessageBox.Show(count.ToString());

            }
            else
            {
                pro.GradeChinese = chinese;
                pro.GradeEnglish = english;
                pro.GradeMath = math;
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnHighLow.Enabled = true;
            labGrade.Text = $"姓名: {txtName.Text}\n" +
                            $"國文: {pro.GradeChinese}分\n" +
                            $"英文: {pro.GradeEnglish}分\n" +
                            $"數學: {pro.GradeMath}分\n";
        }


        private void btnHighLow_Click(object sender, EventArgs e)
        {
            btnHighLow.Enabled = false;
            btnShow.Enabled = false;
            string HNa="";
            string LNa = "";
            int ch = pro.GradeChinese;
            int eng = pro.GradeEnglish;
            int math = pro.GradeMath;
            int high = 0;
            int low = 0;
            if (ch > eng && ch > math)
            {
                high = ch;
                HNa = "國文";
            }
                
            else if (eng > ch && eng > math)
            {
                high = eng;
                HNa = "英文";
            }
                
            else if (math > ch && math > eng)
            {
                high = math;
                HNa = "數學";
            }

            if (ch < eng && ch < math)
            {
                low = ch;
                LNa = "國文";
            }
                
            else if (eng < ch && eng < math)
            {
                low = eng;
                LNa = "英文";
            }
                
            else if (math < ch && math < eng)
            {
                low = math;
                LNa = "數學";
            }

            if (ch == eng && eng != math)
            {
                if (ch > math)
                {
                    high = ch;
                    HNa = "國文與英文";
                    low = math;
                    LNa = "數學";
                }
                else
                {
                    high = math;
                    HNa = "數學";
                    low = ch;
                    LNa = "國文與英文";
                }
            }

            if (ch == math && ch != eng)
            {
                if (ch > eng)
                {
                    high = ch;
                    HNa = "國文與數學";
                    low = eng;
                    LNa = "英文";
                }
                else
                {
                    high = eng;
                    HNa = "英文";
                    low = ch;
                    LNa = "國文與數學";
                }
            }

            if (eng == math && eng != ch)
            {
                if (eng > ch)
                {
                    high = eng;
                    HNa = "英文與數學";
                    low = ch;
                    LNa = "國文";
                }
                else
                {
                    high = ch;
                    HNa = "國文";
                    low = eng;
                    LNa = "英文與數學";
                }
            }

            if (ch == eng && eng == math)
            {
                high = ch;
                low = eng;
                HNa = "國英數";
                LNa = "國英數";
            }

            //MessageBox.Show(high.ToString() + low.ToString());
            labHighLow.Text = $"最高科目成績為 {HNa} : {high} 分\n"+
                                  $"最低科目成績為 {LNa} : {low} 分";

        }
    }
}
