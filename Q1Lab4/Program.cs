// See https://aka.ms/new-console-template for more information
using Q1Lab4;
using System.Net.Http.Headers;

Console.WriteLine("Question 01 - Lab 04");

// Invokes methods
Question1_1();
Question1_2();
Question1_3();
Question1_4();
Question1_5();
Question1_6();


// 1.1 List the names of the countries in alphabetical order [0.5 mark]
void Question1_1()
{
    Console.WriteLine("1.1 List the names of the countries in alphabetical order");
    List<Country> countries = Country.GetCountries();
    var q1 = (from country in countries
             orderby country.Name
             select country.Name).ToList();
    foreach (var countryName in q1)
    {
        Console.WriteLine(countryName);
    }
        
    Console.WriteLine();
}

// 1.2 List the names of the countries in descending order of number of resources [0.5 mark]
void Question1_2()
{
    Console.WriteLine("1.2 List the names of the countries in alphabetical order");
    var q2 = from country in Country.GetCountries()
             orderby country.Resources.Count() descending
             select new { countries = country.Name, resource = country.Resources.Count };
    foreach (var countryName in q2)
    {
        Console.WriteLine($"Country: {countryName.countries}, Resource: {countryName.resource}");
    }
    Console.WriteLine();
}

// 1.3 List the names of the countries that shares a border with Argentina [0.5 mark]
void Question1_3()
{
    Console.WriteLine("1.3 List the names of the countries that shares a border with Argentina");
    var q3 = from country in Country.GetCountries()
             where country.Borders.Contains("Argentina")
             select country.Name;
    foreach (var countryName in q3)
    {
        Console.WriteLine(countryName);
    }
    Console.WriteLine();
}

// 1.4 List the names of the countries that has more than 10,000,000 population [0.5 mark]
void Question1_4()
{
    Console.WriteLine("1.4 List the names of the countries that has more than 10,000,000 population");
    var q4 = from country in Country.GetCountries()
             where country.Population > 10000000
             select country.Name;
    foreach (var countryName in q4)
    {
        Console.WriteLine(countryName);
    }
    Console.WriteLine();
}

// 1.5 List the country with highest population [1 mark]
void Question1_5()
{
    Console.WriteLine("1.5 List the country with highest population");
    var q5 = (from country in Country.GetCountries()
             orderby country.Population descending
             select country.Name).First();
    
    Console.WriteLine(q5);   
    Console.WriteLine();
}

// 1.6 List all the religion in south America in dictionary order [1 mark]
void Question1_6()
{
    Console.WriteLine("1.6 List all the religion in south America in dictionary order ");
    var q6 = (from country in Country.GetCountries()
             from religion in country.Religions
             orderby religion
             select religion).Distinct();
//orderby country.Religions
//select country.Religions;
    foreach (var religion in q6)
    {
        Console.WriteLine(religion);
    }

    Console.WriteLine();
}
