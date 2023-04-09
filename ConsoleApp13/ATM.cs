namespace ProjectBankSystem
{
    public static class ATM
    {
        public static int ATMSum()
        {
            Console.WriteLine("Введите сумму");
            int sum = Convert.ToInt32(Console.ReadLine());
            return sum;
        }

        public static int ATMBillOne()
        {
            int billOne = 1000;
            return billOne;
        }

        public static int ATMBillTwo()
        {
            int billTwo = 500;
            return billTwo;
        }

        public static int ATMBillThree()
        {
            int billThree = 100;
            return billThree;
        }

        public static void WriteResult()
        {
            int a = ATM.ATMBillOne();
            int b = ATM.ATMBillTwo();
            int c = ATM.ATMBillThree();
            int sum = ATM.ATMSum();

            int sumOne = sum / 1000;
            int sumTwo = sum - sumOne * 1000;
            int sumThree = sumTwo / 500;
            int sumFour = sumTwo - sumThree * 500;
            int sumFive = sumFour / 100;

            Console.WriteLine($"1000 - {sumOne}");
            Console.WriteLine($"500 - {sumThree}");
            Console.WriteLine($"100 - {sumFive}");
        }
    }
}
