using System;

namespace sedova7._3
{
    class Program
    {
        struct worker
        {
            public string name;
            public string post;
            public string DateOfSign;
            public int validity;
            public decimal pay;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество работников:");
            int n = int.Parse(Console.ReadLine());
            worker[] workers = new worker[n];
            for (int i = 0; i < workers.Length; i++)
            {
                Console.Write("Введите фамилию :");
                workers[i].name = Console.ReadLine();
                Console.Write("Введите должность :");
                workers[i].post = Console.ReadLine();
                Console.Write("Дата подписания контракта :");
                workers[i].DateOfSign = Console.ReadLine();
                Console.Write("Срок действия контракта :");
                workers[i].validity = int.Parse(Console.ReadLine());
                Console.Write("Введите оклад :");
                workers[i].pay = decimal.Parse(Console.ReadLine());
            }
            foreach (worker item in workers)
            {
                string[] dmy = item.DateOfSign.Split(".");
                int day = int.Parse(dmy[0]);
                int month = int.Parse(dmy[1]);
                int year = int.Parse(dmy[2]);
                int nowYear = DateTime.Now.Year;
                int nowMonth = DateTime.Now.Month;
                int nowDay = DateTime.Now.Day;
                if ((nowYear - year == 1 && month == nowMonth && nowDay < day) || (nowYear == year))
                {
                    Console.WriteLine(item.name + "," + item.post + "," + item.DateOfSign +
                        "," + item.validity + "," + item.pay);
                }
            }
        }
    }
}
