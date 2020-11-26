using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    public class Transaction
    {
        //public string id { get; set; }
        public string accountNumber { get; set; }
        public DateTime date { get; set; }
        public string type { get; set; }
        public string fromAccount { get; set; }
        public string toAccount { get; set; }
        public string note { get; set; }
        public double amount { get; set; }
        //public double amountAfter { get; set; } //Maybe
    }
}
