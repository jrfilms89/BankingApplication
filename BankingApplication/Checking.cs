using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication {
    public class Checking : Account {
        public  int nextElectronicCheckNumber { get; private set; } = 10000;
        
        
        public bool WriteCheck(string payee, double amount, int? paperCheckNum = null) {
            var checkNumber = (paperCheckNum == null) ? 
                nextElectronicCheckNumber++ : paperCheckNum.Value;
            //if null; if it is, an electronic check which must be assigned.
            if (!Withdraw(amount))
            { Console.WriteLine("ERROR: Write check failed. Check Log.");
                    return false; }
            return true;
        }

        public Checking() : base() {
            Description = "New Checking Account";
        }
    }
}
