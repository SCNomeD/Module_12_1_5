using Module_12_1_5;

class Program
{
    public static void Main(string[] args)
    {
        User[] arr = new User[] {
                new User("Evgen", "Евгений", false),
                new User("Vertuoz", "Алексей", true),
                new User("NomeD", "Владимир", false)
            };

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].Greeting();
            if (arr[i].IsPremium != true)
            {
                ShowAds();
            }
        }
    }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);
        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);
        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000);
        Console.WriteLine();
    }
}