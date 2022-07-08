using System;
using System.Collections;
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
    public partial class Homework_StudentsGrade : Form
    {
        public Homework_StudentsGrade()
        {
            InitializeComponent();
        }
        static string FixedWidth(object value, int width, bool leftAlign)
        {
            var s = value == null ? string.Empty : value.ToString();
            return leftAlign ? s.PadRight(width) : s.PadLeft(width);

            // todo ask
            //var s = value;
            //if (value == null)
            //{
            //    value =string.Empty;
            //}
            //else
            //{
            //    value.ToString();
            //}
            //if (leftAlign == true)
            //{
            //    return s.PadRight(width);
            //}
            //else
            //{
            //    return value.PadLeft(width);
            //}

        }
        Product pro;
        ArrayList boxpro = new ArrayList();
        int ch,eng,math,i; //,maxC,minC
        decimal totalC, totalE, totalM, avg,total, EveryonetotalC, EveryonetotalE, EveryonetotalM;


        Random rnd = new Random();
        string name, low, high;

        private void btnRnd20_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            labState.Visible = false;
            btnEveryone.Enabled = true;
            labName.Visible = true;


            for (int i=0;i<20;i++)
            {
                int count = boxpro.Count+1;
                pro.GradeName = count.ToString();
                pro.GradeChinese = rnd.Next(0, 100);
                pro.GradeEnglish = rnd.Next(0, 100);
                pro.GradeMath = rnd.Next(0, 100);
                boxpro.Add(pro);
            }
            
            labelLayout();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnEveryone.Enabled = false;
            labName.Visible = false;
            boxpro.Clear();

            totalC = 0;
            totalE = 0;
            totalM = 0;
            total = 0;
            ch = 0;
            eng = 0;
            math = 0;
            avg = 0;
            i = 0;

            txtName.Text = "";
            txtChinese.Text = "";
            txtEnglish.Text = "";
            txtMath.Text = "";
            name = "";
            low = "";
            high = "";
            labState.Text = "";
            labName.Text = "";
            label6.Text = "";
            label7.Text = "";
        }

        private void btnEveryone_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            labState.Visible = true;
            btnEveryone.Enabled = false;
            string TwomaxCN = ((Product)boxpro[0]).GradeName;
            string maxCN = ((Product)boxpro[0]).GradeName;
            
            int TwomaxC = ((Product)boxpro[0]).GradeChinese;
            int maxC = ((Product)boxpro[0]).GradeChinese;
            
            for (int i = 1; i < boxpro.Count; i++)
            {
                //string resultC = (ch < 10) ? " " + ch : ch.ToString();
                //if (maxC > ((Product)boxpro[i]).GradeChinese);
                //else maxC = ((Product)boxpro[i]).GradeChinese;
                if (maxC > ((Product)boxpro[i]).GradeChinese) { }
                else if (maxC < ((Product)boxpro[i]).GradeChinese)
                {
                    maxCN = ((Product)boxpro[i]).GradeName;
                    maxC = ((Product)boxpro[i]).GradeChinese;
                }
                else // maxC = GradeChinese
                {
                    if (TwomaxC == maxC && boxpro.Count!=0)
                        TwomaxCN += "," + ((Product)boxpro[i]).GradeName;
                    else //(TwomaxC < maxC)
                    {
                        TwomaxC = maxC;
                        TwomaxCN = maxCN;
                    }
                }
            }

            int TwomaxE = ((Product)boxpro[0]).GradeEnglish;
            int maxE = ((Product)boxpro[0]).GradeEnglish;
            string TwomaxEN = ((Product)boxpro[0]).GradeName;
            string maxEN = ((Product)boxpro[0]).GradeName;
            for (int i = 1; i < boxpro.Count; i++)
            {
                if (maxE > ((Product)boxpro[i]).GradeEnglish) { }
                else if (maxE < ((Product)boxpro[i]).GradeEnglish)
                {
                    maxEN = ((Product)boxpro[i]).GradeName;
                    maxE = ((Product)boxpro[i]).GradeEnglish;
                }
                else
                {
                    if (TwomaxE == maxE && boxpro.Count != 0)
                        TwomaxEN += "," + ((Product)boxpro[i]).GradeName;
                    else
                    {
                        TwomaxE = maxE;
                        TwomaxEN = maxEN;
                    }
                }
            }

            int TwomaxM = ((Product)boxpro[0]).GradeMath;
            int maxM = ((Product)boxpro[0]).GradeMath;
            string TwomaxMN = ((Product)boxpro[0]).GradeName;
            string maxMN = ((Product)boxpro[0]).GradeName;
            for (int i = 1; i < boxpro.Count; i++)
            {
                if (maxM > ((Product)boxpro[i]).GradeMath) { }
                else if (maxM < ((Product)boxpro[i]).GradeMath)
                {
                    maxMN = ((Product)boxpro[i]).GradeName;
                    maxM = ((Product)boxpro[i]).GradeMath;
                }
                else
                {
                    if (TwomaxM == maxM && boxpro.Count != 0)
                        TwomaxMN += "," + ((Product)boxpro[i]).GradeName;
                    else
                    {
                        TwomaxM = maxM;
                        TwomaxMN = maxMN;
                    }
                }
            }

            int TwominC = ((Product)boxpro[0]).GradeChinese;
            int minC = ((Product)boxpro[0]).GradeChinese;
            string TwominCN = ((Product)boxpro[0]).GradeName;
            string minCN = ((Product)boxpro[0]).GradeName;
            for (int i = 1; i < boxpro.Count; i++)
            {
                if (minC < ((Product)boxpro[i]).GradeMath) { }
                else if (minC > ((Product)boxpro[i]).GradeMath)
                {
                    minCN = ((Product)boxpro[i]).GradeName;
                    minC = ((Product)boxpro[i]).GradeMath;
                }
                else
                {
                    if (TwominC == minC && boxpro.Count != 0)
                        TwominCN += "," + ((Product)boxpro[i]).GradeName;
                    else
                    {
                        TwominC = minC;
                        TwominCN = minCN;
                    }
                }
            }

            int TwominE = ((Product)boxpro[0]).GradeEnglish;
            int minE = ((Product)boxpro[0]).GradeEnglish;
            string TwominEN = ((Product)boxpro[0]).GradeName;
            string minEN = ((Product)boxpro[0]).GradeName;
            for (int i = 1; i < boxpro.Count; i++)
            {
                if (minE < ((Product)boxpro[i]).GradeEnglish) { }
                else if (minE > ((Product)boxpro[i]).GradeEnglish)
                {
                    minEN = ((Product)boxpro[i]).GradeName;
                    minE = ((Product)boxpro[i]).GradeEnglish;
                }
                else
                {
                    if (TwominE == minE && boxpro.Count != 0)
                        TwominEN += "," + ((Product)boxpro[i]).GradeName;
                    else
                    {
                        TwominE = minE;
                        TwominEN = minEN;
                    }
                }
            }

            int TwominM = ((Product)boxpro[0]).GradeMath;
            int minM = ((Product)boxpro[0]).GradeMath;
            string TwominMN = ((Product)boxpro[0]).GradeName;
            string minMN = ((Product)boxpro[0]).GradeName;
            for (int i = 1; i < boxpro.Count; i++)
            {
                if (minM < ((Product)boxpro[i]).GradeMath) { }
                else if (minM > ((Product)boxpro[i]).GradeMath)
                {
                    minMN = ((Product)boxpro[i]).GradeName;
                    minM = ((Product)boxpro[i]).GradeMath;
                }
                else
                {
                    if (TwominM == minM && boxpro.Count != 0)
                        TwominMN += "," + ((Product)boxpro[i]).GradeName;
                    else
                    {
                        TwominM = minE;
                        TwominMN = minEN;
                    }
                }
            }

            EveryonetotalC = totalC;
            EveryonetotalE = totalE;
            EveryonetotalM = totalM;

            for (int i = 0; i < boxpro.Count; i++)
            {
                //totalC += ch;
                //totalE += eng;
                totalC += ((Product)boxpro[i]).GradeChinese;
                totalE += ((Product)boxpro[i]).GradeEnglish;
                totalM += ((Product)boxpro[i]).GradeMath;
            }

            totalC -= EveryonetotalC;
            totalE -= EveryonetotalE;
            totalM -= EveryonetotalM;

            string resultmaxCN = TwomaxCN == ((Product)boxpro[0]).GradeName ? maxCN : TwomaxCN;
            string resultmaxEN = TwomaxEN == ((Product)boxpro[0]).GradeName ? maxEN : TwomaxEN;
            string resultmaxMN = TwomaxMN == ((Product)boxpro[0]).GradeName ? maxMN : TwomaxMN;
            string resultminCN = TwominCN == ((Product)boxpro[0]).GradeName ? minCN : TwominCN;
            string resultminEN = TwominEN == ((Product)boxpro[0]).GradeName ? minEN : TwominEN;
            string resultminMN = TwominMN == ((Product)boxpro[0]).GradeName ? minMN : TwominMN;

            label6.Text = $"{FixedWidth("", 10, true)}{FixedWidth("國文", 9, true)}{FixedWidth("英文", 9, true)}{FixedWidth("數學", 12, true)}";
            label7.Text = $"{FixedWidth("樣本數:" + boxpro.Count, 0, true)}";
            labState.Text = $"{FixedWidth("總分", 23, true)}{FixedWidth(totalC, 25, true)}{FixedWidth(totalE, 26, true)}{FixedWidth(totalM, 0, true)}\n" +
                           $"{FixedWidth("平均", 23, true)}{FixedWidth(decimal.Round(totalC / boxpro.Count,2), 25 ,true)}{FixedWidth(decimal.Round(totalE / boxpro.Count,2), 26, true)}{FixedWidth(decimal.Round(totalM / boxpro.Count,2), 0, true)}\n\n" +
                           $"{FixedWidth("最高分", 10, true)}{FixedWidth("姓名:"+ resultmaxCN, 22, true)}{FixedWidth("姓名:" + resultmaxEN, 23, true)}{FixedWidth("姓名:" + resultmaxMN, 0, true)}\n" +
                           $"{FixedWidth(" ", 32, true)}{FixedWidth(maxC, 27, true)}{FixedWidth(maxE, 27, true)}{FixedWidth(maxM, 0, true)}\n\n" +
                           $"{FixedWidth("最低分", 10, true)}{FixedWidth("姓名:" + resultminCN, 22, true)}{FixedWidth("姓名:" + resultminEN, 23, true)}{FixedWidth("姓名:" + resultminMN, 0, true)}\n"+
                           $"{FixedWidth(" ", 33, true)}{FixedWidth(minC, 29, true)}{FixedWidth(minE, 28, true)}{FixedWidth(minM, 0, true)}";

                //MessageBox.Show(name.FirstOrDefault().ToString());

               
        }

        private void btnRnd_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            labState.Visible = false;
            btnEveryone.Enabled = true;
            labName.Visible = true;
            int count=boxpro.Count + i+1;
            pro.GradeName = count.ToString();
            pro.GradeChinese = rnd.Next(0, 100);
            pro.GradeEnglish = rnd.Next(0, 100);
            pro.GradeMath = rnd.Next(0, 100);
            boxpro.Add(pro);
            labelLayout();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            labName.Visible = true;
            if (txtName.Text == "")
            {
                MessageBox.Show("請輸入姓名");
            }
            else if (txtName.Text != "")
            {
                bool[] arr = new bool[3];
                arr[0] = int.TryParse(txtChinese.Text, out int chinese);
                arr[1] = int.TryParse(txtEnglish.Text, out int english);
                arr[2] = int.TryParse(txtMath.Text, out int math);
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
                    {       // i=1        j=3              k=5  
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
                else if (arr[0] == false || arr[1] == false || arr[2] == false)
                {
                    int count = 0;
                    if (arr[0] == false)
                    {
                        for (int i = 1; i <= 2; i++)
                            count += 1;
                    }
                    if (arr[1] == false)
                    {
                        for (int i = 1; i <= 2; i++)
                            count += 3;
                    }
                    if (arr[2] == false)
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
                }
                else
                {
                    btnEveryone.Enabled = true;
                    label6.Visible = false;
                    labState.Visible = false;
                    pro.GradeName = txtName.Text;
                    pro.GradeChinese = int.Parse(txtChinese.Text);
                    pro.GradeEnglish = int.Parse(txtEnglish.Text);
                    pro.GradeMath = int.Parse(txtMath.Text);
                    boxpro.Add(pro);
                    //包起來就是用集合
                    labelLayout();
                }

                
            }
        }
        private void label5_Layout(object sender, LayoutEventArgs e)
        {
            label5.Text = $"{FixedWidth("姓名", 9, true)}{FixedWidth("國文", 7, true)}{FixedWidth("英文", 7, true)}{FixedWidth("數學", 7, true)}" +
                          $"{FixedWidth("總分", 7, true)}{FixedWidth("平均",7, true)}{FixedWidth("最低", 7, true)}{FixedWidth("最高", 0, true)}";
        }
        void labelLayout()
        {

            labName.Text = "";
            for (int i = 0; i < boxpro.Count; i++)
            {
                //把實作鎖定義的方法 解開 包起來的東西 
                name = ((Product)boxpro[i]).GradeName;
                ch = ((Product)boxpro[i]).GradeChinese;
                eng = ((Product)boxpro[i]).GradeEnglish;
                math = ((Product)boxpro[i]).GradeMath;
                total = ((Product)boxpro[i]).GradeChinese + ((Product)boxpro[i]).GradeEnglish + ((Product)boxpro[i]).GradeMath;
                avg = decimal.Round(total/3,1);
                string HNa = "";
                string LNa = "";
                int high = 0;
                int low = 0;

                if (ch > eng && ch > math)
                {
                    high = ch;
                    HNa = "國文" + high;
                }

                else if (eng > ch && eng > math)
                {
                    high = eng;
                    HNa = "英文" + high;
                }

                else if (math > ch && math > eng)
                {
                    high = math;
                    HNa = "數學" + high;
                }

                if (ch < eng && ch < math)
                {
                    low = ch;
                    LNa = "國文" + low;
                }

                else if (eng < ch && eng < math)
                {
                    low = eng;
                    LNa = "英文" + low;
                }

                else if (math < ch && math < eng)
                {
                    low = math;
                    LNa = "數學" + low;
                }

                if (ch == eng && eng != math)
                {
                    if (ch > math)
                    {
                        high = ch;
                        HNa = "國英" + high;
                        low = math;
                        LNa = "數學" + low;
                    }
                    else
                    {
                        high = math;
                        HNa = "數學" + high;
                        low = ch;
                        LNa = "國英" + low;
                    }
                }

                if (ch == math && ch != eng)
                {
                    if (ch > eng)
                    {
                        high = ch;
                        HNa = "國數" + high;
                        low = eng;
                        LNa = "英文" + low;
                    }
                    else
                    {
                        high = eng;
                        HNa = "英文" + high;
                        low = ch;
                        LNa = "國數" + low;
                    }
                }

                if (eng == math && eng != ch)
                {
                    if (eng > ch)
                    {
                        high = eng;
                        HNa = "英數" + high;
                        low = ch;
                        LNa = "國文" + low;
                    }
                    else
                    {
                        high = ch;
                        HNa = "國文"+ high;
                        low = eng;
                        LNa = "英數"+low;
                    }
                }

                if (ch == eng && eng == math)
                {
                    high = ch;
                    low = eng;
                    HNa = "國英數" + high;
                    LNa = "國英數" + low;
                }

                string resultC = (ch < 10) ? " " + ch : ch.ToString();
                string resultE = (eng < 10) ? " " + eng : eng.ToString();
                string resultM = (math < 10) ? " " + math : math.ToString();
                string resultTotal = (total < 100) ? "  " + total : total.ToString();
                string resultAvg = (avg < 100) ? " " + avg : avg.ToString();

                labName.Text += $"{FixedWidth(name, 26, true)}{FixedWidth(resultC, 0, false)}{FixedWidth(resultE, 20, false)}{FixedWidth(resultM, 19, false)}" +
                                $"{FixedWidth(resultTotal, 20, false)}{FixedWidth(resultAvg, 18, false)}{FixedWidth(LNa, 16, false)}{FixedWidth(HNa, 14, false)}\n";
                if (label7.Visible == true)
                    label7.Text = $"{FixedWidth("樣本數:" + boxpro.Count, 0, true)}";
            }
        }
    }
}
