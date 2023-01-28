# C Sharp Classess

This little Country class is my first forray into proper class building in C#. I have previous experience from a C#
course, a little bit of which resides here on Github, but now with proper teachers, I'm really truly learning it here.
That previous course was only "How to do other things you've learned in other languages." And this is actually learning all the options you truly have with C#.

The requirements are below. I've only plugged in one country, but really I was just playing with building the class, and accessing the data from inside and outside the class, what goes into it, how to solve errors, etc.,

This is by no means the only approach. The Country could be further subdivided into a Cities class, Languages class, and/or utils for printing. Check out the instructions below if you'd like to run it. It does assume you have Microsoft's .Net SDK installed.

<img width="548" alt="Screenshot 2023-01-29 at 0 05 38" src="https://user-images.githubusercontent.com/40215472/215293180-b86f9741-531c-47bc-ab1f-8cda29692d41.png">

### CountryGame

1. Defining a class to represent a country. Each country has the following:

    - Name
    - Population (millions of people)
    - Region (such as: Western Europe, East Asia etc)
    - Capital
    - GDP
    - An array of languages which has the following details:
        - Name
        - IsPrimary (If the language is the main language)
    - An array of cities where each has:
        - Name
        - IsCapital (If the city is the capital)
    - Population
    - List of countries that border with this country

2. Defining these methods:

    - HasBorder: Check if a country has border with another country, given the country name or a country object (use overloading)
    - Indexer methods to get back cities/city of the country
    - CheckWealth: Get the country’s wealthiness level (use an enum, such as: SuperPoor, Poor, Medium, Rich, SuperRich) based on the GDP per capita - GDPP (you define the range freely)
NOTES:
You may need to define extra classes/structs to represent different entity/object types (think about real life)
Use method overloading if needed
When defining properties, think about what should be: readonly, init-only or with private setter.


## Run the program

`dotnet run --project ClassGame`
