using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public class Student
    {
        public string Name;
        public int Chinese;
        public int English;
        public int Math;
    }
    public struct Product
    {
        public string GradeName;
        public int GradeChinese;
        public int GradeEnglish;
        public int GradeMath;

        public Product(string Name,int Chinese, int English, int Math)
        {
            GradeName = Name;
            GradeChinese = Chinese;
            GradeEnglish = English;
            GradeMath = Math;
        }
    }
}
