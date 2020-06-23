using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication {
    public class Savings : Account {
        private double CalculateInterestAmount(int numberOfMonths) {
            return _interestRate / 12 * numberOfMonths * GetBalance();
        }
        public bool CalculateAndDepositInterest(int numberOfMonths) {
            if (numberOfMonths <= 0) {
                Console.WriteLine("Number of months must be greater than zero.");
                return false;
            }
            var interestToBeDeposited = CalculateInterestAmount(numberOfMonths);
            return Deposit(interestToBeDeposited);
        }

        public double _interestRate { get; private set; } = 0;

        public bool InterestRate(double newInterestRate) {
            if (newInterestRate < 0) {
                Console.WriteLine("Interest rate can not be negative!");
                return false;
            } else if (newInterestRate > 10) {
                Console.WriteLine("Interest rate can not be greater than 10.0!");
                return false;
            }
            _interestRate = newInterestRate;
            return true;
        }
        public Savings() : base() {
            Description = "New Savings Account";
        }
    }
}
