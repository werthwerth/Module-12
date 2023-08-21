using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program {
    public static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }
    static void Main()
    {
        Hashtable userList = new Hashtable();
        userList.Add("John", "1");
        userList.Add("Jack", "0");
        userList.Add("Johan", "1");
        userList.Add("Jey", "1");
        userList.Add("Joan", "0");
        userList.Add("Jimm", "0");
        Console.WriteLine("Enter username");
        string login = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", login);
        if (userList[login] != "1")
        {
            ShowAds();
        }
        
    }
}
