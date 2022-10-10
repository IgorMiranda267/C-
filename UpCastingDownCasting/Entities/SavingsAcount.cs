using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastingDownCasting
{
    class SavingsAcount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAcount()
        {
        }

        public SavingsAcount(int number, string holder, double balance, double interestRate) : base()
        {
            InterestRate = interestRate;
        }

        //Taxa de Juros.
        public void UpdateBalance ()
        {
            Balance += Balance * InterestRate;
        }
    }
}
