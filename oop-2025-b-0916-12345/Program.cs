// See https://aka.ms/new-console-template for more information
using oop_2025_b_0916_12345.Models;

//string Greeting = "Hello";
//string MyName = "John";
//int Age = 63;
//Console.WriteLine($"{Greeting},{MyName}! You are {Age} years old");

//string SuperHero1_Name = "Tony Stark";
//string SuperHero1_Alias = "Iron Man";
//string SuperHero2_Name = "Peter Parker";
//string SuperHero2_Alias = "SpiderMan";

//Console.WriteLine($"{SuperHero1_Alias},{SuperHero1_Name}");
//Console.WriteLine($"{SuperHero2_Alias},{SuperHero2_Name}");

SuperHero superHero1 = new();
superHero1.Name = "Tony Stark";
superHero1.Alias = "Iron Man";

SuperHero superHero2 = new();
superHero2.Name = "Peter Parker";
superHero2.Alias = "SpiderMan";

SuperHero superHero3 = new() { 
    Alias = "Deadpool", 
    Name = "Wade Wilson" 
};

Console.WriteLine($"{superHero1.Alias},{superHero1.Name}");
Console.WriteLine($"{superHero2.Alias},{superHero2.Name}");
Console.WriteLine($"{superHero3.Alias},{superHero3.Name}");

Console.WriteLine($"{superHero1.ToString()}");
Console.WriteLine($"{superHero2}");