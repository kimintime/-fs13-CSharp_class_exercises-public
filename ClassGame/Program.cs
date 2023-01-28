using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    private static void Main(string[] args)
    {

        //Challenge 1
        /* create variables from these countries
        Finland: 
        - Name: Finland
        - Population: 5530719
        - Region: Europe,
        - Capital: Helsinki
        - GDP: 27.3
        - Languages: Finnish, Swedish
        - Cities: Helsinki, Tampere, Lahti, Porvo, Kemi
        - Borders: Norway, Sweden, Russia
         */
        var Finland = new Country(

            "Finland",
            5530719,
            "Europe",
            "Helsinki",
            27.3,
            new (string, bool)[]
            {
                ("Finnish", true),
                ("Swedish", false)
            },
            new (string, bool)[]
            {
                ( "Helsinki", true),
                ( "Tampere", false),
                ("Lahti", false),
                ("Porvoo", false),
                ("Kemi", false),
            },
            new string[]
            {
                "Norway",
                "Sweden",
                "Russia"
            }
        );

        Console.WriteLine($"About {Finland.Name}: ");
        Console.WriteLine(Country.HasBorder(Finland));
        Console.WriteLine(Finland.HasBorder("China"));
        Console.WriteLine($"GDP: {Finland.GDP}, {Country.CheckWealth(Finland)}");
        Console.WriteLine($"Population: {Finland.Population}");
        Console.WriteLine($"Region: {Finland.Region}");
        Console.Write($"{Finland.Name} borders: ");

        foreach (var border in Finland.Borders)
        {
            Console.Write(border + " ");
        }
        Console.WriteLine(" ");

        Country.PrintLanguages(Finland);

        var FinCities = Finland[0..4];
        var FirstCity = Finland[0];
        /* Write methods to print FinCities and FirstCity */

        Country.PrintCities(Finland);

        //Challenge 2
        /* write your own game */
    }

    class Country
    {
        public string Name { get; init; }
        public long Population { get; set; }
        public string? Region { get; init; }
        public string? Capital { get; init; }
        public double GDP { get; set; }
        public (string Name, bool IsPrimary)[] Languages { get; set; }
        public (string Name, bool IsCapital)[] Cities { get; set; }
        public string[] Borders { get; set; }

        public Country(
            string name,
            long population,
            string region,
            string capital,
            double gdp,
            (string, bool)[] languages,
            (string, bool)[] cities,
            string[] borders)
        {
            Name = name;
            Population = population;
            Region = region;
            GDP = gdp;
            Languages = languages;
            Cities = cities;
            Borders = borders;
        }

        public enum Wealth
        {
            Poor,
            Medium,
            Rich,
        }

        public bool HasBorder(string countryName)
        {
            Console.Write($"{countryName} shares a border: ");

            if (countryName == Name && Borders.Length > 0)
            {
                return true;
            }

            return false;
        }

        public static bool HasBorder(Country country)
        {
            Console.Write($"{country.Name} shares a border: ");

            if (country.Borders.Length > 0)
            {
                return true;
            }

            return false;
        }

        public (string, bool) this[Index index]
        {
            get => Cities[index];
        }

        public (string, bool)[] this[Range range]
        {
            get
            {
                return Cities[range];
            }
        }

        public static string CheckWealth(Country country)
        {
            Console.Write($"{country.Name}'s wealth is classed as: ");

            if (country.GDP > 20)
            {
                return Wealth.Rich.ToString();
            }
            else if (country.GDP > 10 && country.GDP < 20)
            {
                return Wealth.Medium.ToString();
            }
            else
            {
                return Wealth.Poor.ToString();
            }
        }

        public static void PrintLanguages(Country country)
        {
            Console.Write($"{country.Name}'s Languages: ");

            foreach (var language in country.Languages)
            {
                if (language.IsPrimary)
                {
                    Console.Write($"{language.Name} is the primary language, ");
                }
                else if (!language.IsPrimary)
                {
                    Console.Write(language.Name + " ");
                }
            }
            Console.WriteLine(" ");
        }

        public static void PrintCities(Country country)
        {
            Console.Write($"Cities in {country.Name}: ");
            foreach (var city in country.Cities)
            {
                Console.Write(city.Name + " ");
            }
            Console.WriteLine(" ");

            foreach (var city in country.Cities)
            {
                if (city.IsCapital)
                {
                    Console.WriteLine($"The capital is {city.Name}");
                }
            }
        }
    }

    // class Room
    // {
    //     /* provide your code for challenge 2 here */
    // }

    // class Player
    // {
    //     /* provide your code for challenge 2 here */
    // }
}

