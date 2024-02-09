using System;
//Zasymuluj kontrolę dostępu do zasobów na podstawie wieku. Użytkownik jest proszony o podanie swojego wieku.
//Niech program na tej podstawie podejmie decyzję, czy użytkownik może dostać dostęp. Rozważ trzy przypadki:
//Jeżeli użytkownik ma +18 lat, niech program wypisze w konsoli "Access granted"
//Jeżeli użytkownik ma 15 - 18 lat, niech program zada dodatkowe pytanie "Do you have parental consent?".
//Jeżeli tak, niech program wypisze w konsoli "Access granted, jeżeli nie - "Access denied"
//Jeżeli użytkownik ma mniej niż 15 lat, niech program wypisze w konsoli "Access denied"
class KontrolaDostępu {
    static void Main()
    {
        Console.WriteLine("Wprowadź swój wiek: ");
        if (int.TryParse(Console.ReadLine(), out int userAge))
        {
            if (userAge > 18)
            {
                Console.WriteLine("Dostęp został przyznany.");
            }
            else if (userAge >= 15 && userAge <= 18)
            {
                Console.WriteLine("Czy posiadasz zgodę rodzica? (tak/nie): ");
                string consent = Console.ReadLine().ToLower();
                if (consent == "tak")
                {
                    Console.WriteLine("Dostęp przyznany za zgodą rodzica.");
                }
                else
                {
                    Console.WriteLine("Dostęp nie został przyznany - brak zgody rodzica.");
                }
            }
            else
            {
                Console.WriteLine("Dostęp nie został przyznany");
            }
        }
    }
}