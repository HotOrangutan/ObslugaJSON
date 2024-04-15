using System;
using System.Text.Json;

public class Ksiazka
{
    public int Id { get; set; }
    public string Tytul { get; set; }
    public string Autor { get; set; }
    public int RokWydania { get; set; }
    public string Gatunek { get; set; }

}

public class Ksiegarnia
{
    public static void Main(string[] args)
    {
        menu();
    }

    static void menu()
    {
        Console.Clear();
        Console.WriteLine("Wybierz opcje aby uruchomic funkcje\n1. Dodaj ksiazke \n2. Usun ksiazke \n3. Sprawdz dostepne ksiazki\n4. Wyjdz");

        int option = Convert.ToInt16(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.Clear();
                DodajKsiazke();
                break;
            case 2:
                Console.Clear();
                UsunKsiazke();
                break;
            case 3:
                Console.Clear();
                DostepneKsiazki();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("cya");
                break;
            default:
                Console.WriteLine("Nie ma takiej opcji koleżko");
                Console.ReadKey();
                menu();
                break;
        }
    }

    static async void DodajKsiazke()
    {
        Console.WriteLine("Aby dodać książkę, proszę podać ID, tytuł, autora, rok wydania oraz gatunek.");
        Console.Clear();
        Console.WriteLine("Podaj ID Ksiazki");
        string Id = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Podaj tytuł Ksiazki");
        string Tytul = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Podaj autora Ksiazki");
        string Autor = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Podaj rok wydania Ksiazki");
        string Rok = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Podaj gatunek Ksiazki");
        string Gatunek =  Console.ReadLine();
        Console.WriteLine("*tutaj bedzie info czy sie dodalo czy nie*");
        Console.WriteLine("\n1. Wróc do menu");
        int powrot = Convert.ToInt16(Console.ReadLine());
        switch (powrot)
        {
            default:
                Console.Clear();
                menu();
                break;
        }
        
        
        
    }




    static void UsunKsiazke()
    {

    }



    static void DostepneKsiazki()
    {
        var obecneKsiazki = new List<Ksiazka>();
        using (StreamReader r = new StreamReader("ksiazki.json"))
        {
            string json = r.ReadToEnd();
            obecneKsiazki = JsonSerializer.Deserialize<List<Ksiazka>>(json);

        }

        if (obecneKsiazki != null && obecneKsiazki.Count > 0)
        {
            foreach (var ksiazka in obecneKsiazki)
            {
                Console.WriteLine($"Id: {ksiazka.Id}");
                Console.WriteLine($"Tytul: {ksiazka.Tytul}");
                Console.WriteLine($"Autor: {ksiazka.Autor}");
                Console.WriteLine($"Rok wydania: {ksiazka.RokWydania}");
                Console.WriteLine($"Gatunek: {ksiazka.Gatunek}\n");
            }
        }
        Console.WriteLine("\n1. Wróc do menu");
        int powrot = Convert.ToInt16(Console.ReadLine());
        switch (powrot)
        {
            default:
                Console.Clear();
                menu();
                break;
        }
       
    }
}
