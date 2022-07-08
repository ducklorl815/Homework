using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class POS
    {
        public string Wine;
        public int Price;
        public POS(String wine,int price)
        {
            this.Wine = wine;
            this.Price = price;
        }

        //method
        public void Buying(POS bwine,int money)
        {
            bwine.Price += money;
        }
            
    }
}
