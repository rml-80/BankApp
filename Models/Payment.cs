using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    public class Payment : account
    {
        public List<Reciver> recivers { get; set; }
    }
}
