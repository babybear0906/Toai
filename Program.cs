using Toai.Models;

namespace Toai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var done = false;
            int menu;
            while (!done)
            {
                try
                {
                    Console.WriteLine("0 = Print");
                    Console.WriteLine("1 = create quetions");
                    Console.WriteLine("2 = read question");
                    Console.Write("Your choice: ");
                    menu = int.Parse(Console.ReadLine());
                    switch (menu)
                    {
                        case 0: Operation();break;
                        //case 0: done = true; break;
                        //case 1: QuestionOperation.CreateQuestions(); break;
                        //case 2: QuestionOperation.ReadQuestion(); break;
                        default: break;
                    }
                }
                catch (FormatException format)
                {
                    Console.WriteLine("Wrong format, please try again. Error message: " + format.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while running, please try again. Error message: " + ex.ToString());
                }
            }

        }


        public static void Operation()
        {
            var transactions = new List<Transactions>() {new Transactions() { code="123213",amount=100000, date= 10, kind= true } };
            
            var accounts = new List<Account>()
            {
                new Account()
                { accNumber = "123123",
                    balance = 100000,
                    transactions = transactions
                }
            };
            foreach (var account in accounts)
            {
                Console.WriteLine(account.accNumber);
                Console.WriteLine(account.balance);
                foreach (var transaction in account.transactions)
                {
                    Console.WriteLine(transaction.code);
                    Console.WriteLine(transaction.amount);
                    Console.WriteLine(transaction.date);
                    Console.WriteLine(transaction.kind);
                }

            }
        }
    }
}