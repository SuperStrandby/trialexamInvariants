using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialExamInvariantUnitTest
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }

        public BankAccount(string owner)
        {
            Owner = owner;
        }

        public BankAccount(string owner, double interestRate)
        {
            Owner = owner;
            InterestRate = interestRate;
        }

        public BankAccount(string owner, double interestRate, double balance)
        {
            Owner = owner;
            InterestRate = interestRate;
            Balance = balance;
            
        }
        public string CheckOwner()
        {
            if (string.IsNullOrEmpty(Owner))
            {
                throw new Exception("Owner can not be null or empty");
            }
            return Owner;  
        }

        public double CheckInterestRate()
        {
            if (InterestRate < 0)
            {
                throw new Exception("Interest rate must be >= 0");
            }
            return InterestRate;
        }
    }
}
