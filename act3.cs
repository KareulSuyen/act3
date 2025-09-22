using System;
public class Gnenob {
    public static void Main(String[] args) {
        Console.WriteLine("Welcome to DDS(Daily Dose of Stupidity)");
        Console.WriteLine("____________________________________");
        Console.WriteLine();

        Console.WriteLine("___Menus___");
        string[] lists = [
            "1. SupaFl-ash Drive 1tb - ",
            "2. Romualdez beloved DVD - ",
            "3. Charlie Kirk's freedom T-shirt - ",
            "4. Viy Cortez Shopping cart - ",
        ];

        Console.WriteLine();

        decimal[] prices = [
            500m,
            50.000000m,
            1000m,
            200m
        ];

        foreach (string list in lists) {
            Console.WriteLine(list);
        }

        Console.Write("Pick an item : (1-4) : ");
        string response = Console.ReadLine() ?? "";
        int order = int.Parse(response);

        Console.Write("Enter your name : ");
        string name = Console.ReadLine() ?? "";

        switch (order) {
            case 1:
                order--;
                Console.WriteLine($"Hi {name}, Your order is item #{lists[order]}, a total of {prices[order]}");
                break;
            case 2:
                order--;
                Console.WriteLine($"Hi {name}, Your order is item #{lists[order]}, a total of {prices[order]}");
                break;
            case 3:
                order--;
                Console.WriteLine($"Hi {name}, Your order is item #{lists[order]}, a total of {prices[order]}");
                break;
            case 4:
                order--;
                Console.WriteLine($"Hi {name}, Your order is item #{lists[order]}, a total of {prices[order]}");
                break;
        }
    }
}
