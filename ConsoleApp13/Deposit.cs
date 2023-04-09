namespace ProjectBankSystem
{
    public static class Deposit
    {
        public static int DepositSum()
        {
            Console.WriteLine("Введите сумму вклада");
            int sum = Convert.ToInt32(Console.ReadLine());
            return sum;
        }

        public static int DepositYear()
        {
            Console.WriteLine("Введите продолжительность в годах");
            int year = Convert.ToInt32(Console.ReadLine());
            return year;
        }

        public static int DepositProcent()
        {
            Console.WriteLine("Введите процент, начисляемый за год");
            int procent = Convert.ToInt32(Console.ReadLine());
            return procent;
        }

        public static void WriteResult()
        {
            int sumDep = Deposit.DepositSum();
            int yearDep = Deposit.DepositYear();
            int procentDep = Deposit.DepositProcent();

            for (int i = 1; i <= yearDep; i++)
            {
                int procent = sumDep * procentDep/100;
                sumDep += procent;
                Console.WriteLine(sumDep);
            }
        }
    }
}
