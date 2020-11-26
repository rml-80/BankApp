using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    public class account
    {
        public string accountNumber { get; set; }
        public string type { get; set; }
        public int balance { get; set; }
        public string coustomerId { get; set; }
        public List<Transaction> transactions { get; set; }

    }
}
