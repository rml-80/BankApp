using BankApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BankApp
{
    class user
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
        public void PopulateUser(string name)
        {
            string folderPath = $"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{name}\\";

            string[] details = File.ReadAllLines(folderPath + $"{name}.txt");

            socialSecurityNumber = details[0];
            firstName = details[2];
            lastName = details[3];
            address = details[4];
            zipCode = details[5];
            city = details[6];
            phoneNumber = details[7];
            password = details[8];
            email = details[1];
        }
    }
}
