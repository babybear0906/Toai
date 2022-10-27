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
                        case 0: Operation(); break;
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
            var transactions = new List<Transactions>() {
                new Transactions() {
                    code = "1234",
                    amount = 100000,
                    day = 10,
                    kind = "W" },
                new Transactions()
                {
                    code = "1235",
                    amount = 100000,
                    day = 10,
                    kind = "D"
                }
            };

            var account = new Account()
            {
                accNumber = "123123",
                balance = 100000,
                code = { "1234", "1235" },
            };


            Console.WriteLine("Account Number: " + account.accNumber);
            Console.WriteLine("Account balance: " + account.balance);
            Console.WriteLine("List Transaction: ");
            foreach (var transactionCode in account.code)
            {
                
                var codeTrans = from code in transactions
                                where code.code.Equals(transactionCode)
                                select code;
                foreach (var transaction in codeTrans)
                {
                    Console.WriteLine("Transaction code: " + transaction.code);
                    Console.WriteLine("Transaction date: " + transaction.day);
                    Console.WriteLine("Transaction amount: " + transaction.amount);
                    Console.WriteLine("Transaction kind: " + transaction.kind); 
                }

            }


        }
    }
}