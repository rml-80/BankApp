﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    class customer
    {
        public string socialSecurityNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string zipCode { get; set; }
        public string city { get; set; }
        public string phoneNumber { get; set; }
        public List<account> accounts { get; set; }
        public string password { get; set; }
        public string email { get; set; }


    }
}
