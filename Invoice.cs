using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Invoice
    {
        private string account;
        private string customer;
        private string provider;
        public string Article { get; set; }
        public int Quantity { get; set; }
        public Invoice()
        {

        }
          public Invoice(string account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer; 
            this.provider = provider;
        }
          public double CostCalculation(bool needEdv, double cost, double count)
        {
           double edv = cost * 0.18;

            if(needEdv == true)
            {
               cost = cost * count + edv;
            }
            else
            {
               cost = cost * count;
            }
            return cost;
        }
    }
}
