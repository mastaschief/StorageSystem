using System;

namespace StorageSystem
{
    class Program
    {

        static void Main(string[] args)
        {
            Storage storage = new Storage();
            bool confirm()
            {
                Console.WriteLine("Bitte mit y(j)/n antworten. Standard ist \"nein\"");
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "y":
                    case "j":
                    case "yes":
                    case "ja":
                        return true;
                    case "n":
                    case "no":
                    case "nein":
                        return false;
                }
                return false;
            }

            void addStuff()
            {
                bool fail = false;
                Console.WriteLine("Bitte Artikel Beschreibung eingeben");
                string name = Console.ReadLine();
                Console.WriteLine("Bitte Einheit(Kg/Liter/Stück) angeben");
                string unit_raw = Console.ReadLine().ToLower();
                quantityUnit unit = new quantityUnit();
                switch (unit_raw)
                {
                    case "kg":
                    case "kilogram":
                        unit = quantityUnit.kg;
                        break;
                    case "liter":
                    case "l":
                        unit = quantityUnit.liter;
                        break;
                    case "stück":
                    case "stueck":
                    case "piece":
                        unit = quantityUnit.piece;
                        break;
                    default:
                        Console.WriteLine("Da hast du dich leider vertippt, halte dich bitte an die vorgeschlagenen Einheiten.");
                        fail = true;
                        break;
                }
                if (!fail)
                {
                    Console.WriteLine("Bitte Menge angeben");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Es sollen {amount}{unit_raw} {name} eingefügt werden?");
                    if (confirm())
                    {
                        storage.CreateArticle(1, name, unit, amount);
                    }
                }
            }


            //Programmbeginn
            do
            {
                addStuff();
                Console.WriteLine("Möchtest Du ein weiteres Produkt hinzufügen?");
            } while (confirm());

            //storage.CreateArticle(1, "Birnen", quantityUnit.kg , 2);
            //storage.CreateArticle(2, "Äpfel", quantityUnit.kg, 10);
            foreach (var item in storage.ArticleStock)
            {
                Console.WriteLine(item.ArticleDescription);
            }
            Console.WriteLine(storage.ArticleStock[1].ArticleDescription);
            storage.ArticleStock.Find(x => x.ArticleDescription.Contains("Äpfel"));
            Console.WriteLine("\nFind: Part where name contains \"Äpfel\": {0}",
            storage.ArticleStock.Find(x => x.ArticleDescription.Contains("Äpfel")));


        }
    }
}
