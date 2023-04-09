namespace ProjectBankSystem
{
    public static class Clients
    {
        public static string ClientName()
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            return name;
        }

        public static int ClientAge()
        {
            Console.WriteLine("Введите возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

        public static int ClientCountProduct()
        {
            Console.WriteLine("Введите количество продукта");
            int count = Convert.ToInt32(Console.ReadLine());
            return count;
        }

        public static int ClientSumMoney()
        {
            Console.WriteLine("Введите сумму средств");
            int sumMoney = Convert.ToInt32(Console.ReadLine());
            return sumMoney;
        }

        public static void WriteResult()
        {
            string name = Clients.ClientName();
            int age = Clients.ClientAge();
            int count = Clients.ClientCountProduct();
            int sum = Clients.ClientSumMoney();

            if (age > 60 || sum > 1000000 || (sum > 400000 && count >= 3))
            {
                Console.WriteLine("Этому клиенту предоставляются акционные предложения!");
            }
            else
            {
                Console.WriteLine("Этому клиенту не предоставляются акционные предложения!");
            }
        }
    }
}
