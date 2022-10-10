using System;

namespace UpCastingDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAcount(1004, "Ana", 0.0, 0.01);


            //DOWCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            //Gera um erro em tempo de execução, pois SavingsAcount  não é subclasse de BusinessAccount.
            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if(acc3 is BusinessAccount) // Verifica se é uma instancia de BusinessAccount
            {
                BusinessAccount acc5 = acc3 as BusinessAccount; //Maneira alternativa de Casting.
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            if(acc3 is BusinessAccount)// Verifica se é uma instancia de BusinessAccount
            {
                SavingsAcount acc5 = (SavingsAcount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            
        }
    }
}
