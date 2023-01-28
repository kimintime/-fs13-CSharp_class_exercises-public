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
            new string[]
            {
                "Finnish",
                "Swedish",
            },
            new string[]
            {
                "Helsinki",
                "Tampere",
                "Lahti",
                "Porvoo",
                "Kemi",
            },
            new string[]
            {
                "Norway",
                "Sweden",
                "Russia"
            }
        );

        Country.HasBorder(Finland);
        Finland.HasBorder("Finland");
        Country.CheckWealth(Finland);

        var FinCities = Finland[0..4];
        var FirstCity = Finland[0];
        /* Write methods to print FinCities and FirstCity */

        Console.Write("Finnish cities: ");
        foreach (var city in FinCities)
        {
            Console.Write(city + " ");
        }
        Console.WriteLine(" ");

        Console.WriteLine($"The capital is {FirstCity}");

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
        public string[] Languages { get; set; }
        public string[] Cities { get; set; }
        public string[] Borders { get; set; }

        public Country(
            string name,
            long population,
            string region,
            string capital,
            double gdp,
            string[] languages,
            string[] cities,
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
            if (countryName == Name && Borders.Length > 0)
            {
                return true;
            }

            return false;
        }

        public static bool HasBorder(Country country)
        {
            if (country.Borders.Length > 0)
            {
                return true;
            }

            return false;
        }

        public string this[Index index]
        {
            get => Cities[index];
        }

        public string[] this[Range range]
        {
            get
            {
                return Cities[range];
            }
        }

        public static string CheckWealth(Country country)
        {
            if (country.GDP > 5000)
            {
                return Wealth.Rich.ToString();
            }
            else if (country.GDP > 1000 && country.GDP < 5000)
            {
                return Wealth.Medium.ToString();
            }
            else
            {
                return Wealth.Poor.ToString();
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

