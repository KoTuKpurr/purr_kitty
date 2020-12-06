using System;

namespace Classwork1
{
    class Account
    {
        public Account(decimal sum, decimal rate)
        {
            if (sum < MinSum) throw new Exception("Недопустимая сумма");
            Sum = sum;
            Rate = rate;
        }
        private static decimal minSum = 100;
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }
        public decimal Sum { get; private set; }
        public decimal Rate { get; private set; }
        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;
        }
    }


    class Account
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Account.MinSum);
            Account.MinSum = 560;
            Console.WriteLine(Account.MinSum);

            decimal result = Account.GetSum(1000, 10, 50);

            Console.WriteLine(result);

            Account.MinSum = 1;
            Console.WriteLine(Account.MinSum);

            decimal result1 = Account.GetSum(10, 1, 2);
            Console.WriteLine(result1);

            Account account1 = new Account(4, 9);
           // Console.WriteLine(account1.GetSum(2,4,5));
            


            Console.ReadKey();
        }
    }
}
