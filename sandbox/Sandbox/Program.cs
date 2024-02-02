using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public class Car {
    public int MilesPerGallon;
    public int gallons;
    public string make;
    public string model;

    public string owner;

    public int phone;

    public int TotalRange() 
    {
    return gallons = MilesPerGallon;
    }

    public void Display() {
        System.Console.WriteLine($"{make} {model}: Range= {gallons * MilesPerGallon}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        var count = 23;
        var car = new Car();
        car.make = "Honda";
        car.model = "Civic";
        car.gallons = 10;
        car.MilesPerGallon = 30;

        count = 45;
        car = new Car();
        car.make = "Ford";
        car.model = "F-150";
        car.gallons = 30;
        car.MilesPerGallon = 5;

        var cars = new List <Car>();

        cars.Add(car);

        foreach (var c in cars)
        {
            System.Console.WriteLine($"{c.make} {c.model}: Range= {c.gallons * c.MilesPerGallon}");
        }
    }

}



