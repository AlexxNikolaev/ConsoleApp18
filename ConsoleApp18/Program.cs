using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Car myCar = new Car("Toyota", "Camry", 2010, "1234567890");
        Wheel myWheel = new Wheel("Michelin", "17", 32);
        Engine myEngine = new Engine("Бензиновый", 2.4, "Рабочий");

        Console.WriteLine(myCar);
        Console.WriteLine(myWheel);
        Console.WriteLine(myEngine);
    }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string VIN { get; set; }

    public Car(string brand, string model, int year, string vin)
    {
        Brand = brand;
        Model = model;
        Year = year;
        VIN = vin;
    }

    public override string ToString()
    {
        return $"Автомобиль: {Brand} {Model}, Год: {Year}, VIN: {VIN}";
    }
}

class Wheel
{
    public string Brand { get; set; }
    public string Size { get; set; }
    public int Pressure { get; set; }

    public Wheel(string brand, string size, int pressure)
    {
        Brand = brand;
        Size = size;
        Pressure = pressure;
    }

    public override string ToString()
    {
        return $"Колесо: {Brand}, Размер: {Size}, Давление: {Pressure} psi";
    }
}

class Engine
{
    public string Type { get; set; }
    public double Volume { get; set; }
    public string Status { get; set; }

    public Engine(string type, double volume, string status)
    {
        Type = type;
        Volume = volume;
        Status = status;
    }

    public override string ToString()
    {
        return $"Двигатель: {Type}, Объем: {Volume} л, Состояние: {Status}";
    }
}

