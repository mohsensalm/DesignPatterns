﻿// See https://aka.ms/new-console-template for more information

using ProtoType.ex2;

namespace ProtoType;

internal class Program
{

    public static void DisplayValues(Person p)
    {
        Console.WriteLine("      Name: {0}, Age: {1:d}, BirthDate: {2:MM/dd/yy} , num : {3}",
            p.Name, p.Age, p.BirthDate,p.num);
        Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
    }

    private static void Main(string[] args)
    {
        var p1 = new Person
        {
            Age = 42,
            num = 33,
            BirthDate = Convert.ToDateTime("1977-01-01"),
            Name = "Jack Daniels",
            IdInfo = new IdInfo(666)
        };

        // Perform a shallow copy of p1 and assign it to p2
        // .
        var p2 = p1.ShallowCopy();
        // Make a deep copy of p1 and assign it to p3.
        var p3 = p1.DeepCopy();

        // Display values of p1, p2 and p3.
        Console.WriteLine("Original values of p1, p2, p3:");
        Console.WriteLine("   p1 instance values: ");
        DisplayValues(p1);
        Console.WriteLine("   p2 instance values:");
        DisplayValues(p2);
        Console.WriteLine("   p3 instance values:");
        DisplayValues(p3);

        // Change the value of p1 properties and display the values of p1,
        // p2 and p3.
        p1.Age = 32;
        p1.BirthDate = Convert.ToDateTime("1900-01-01");
        p1.Name = "Frank";
        p1.IdInfo.IdNumber = 7878;
        Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
        Console.WriteLine("   p1 instance values: ");
        DisplayValues(p1);
        Console.WriteLine("   p2 instance values (reference values have changed):");
        DisplayValues(p2);
        Console.WriteLine("   p3 instance values (everything was kept the same):");
        DisplayValues(p3);



        Console.WriteLine("0000000000000000000");



        var dev = new Developer();
        dev.Name = "Rahul";
        dev.Role = "Team Leader";
        dev.PreferredLanguage = "C#";

        var devCopy = (Developer)dev.Clone();
        devCopy.Name = "Arif"; //Not mention Role and PreferredLanguage, it will copy above

        Console.WriteLine(dev.GetDetails());
        Console.WriteLine(devCopy.GetDetails());

        var typist = new Typist();
        typist.Name = "Monu";
        typist.Role = "Typist";
        typist.WordsPerMinute = 120;

        var typistCopy = (Typist)typist.Clone();
        typistCopy.Name = "Sahil";
        typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

        Console.WriteLine(typist.GetDetails());
        Console.WriteLine(typistCopy.GetDetails());

        Console.ReadKey();


    }
}