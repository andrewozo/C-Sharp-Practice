// See https://aka.ms/new-console-template for more information

using System;

class Car
{
    public string company;
    public string model;
    public int year;

    public Car(string companyName, string modelName, int carYear)
    {
        company = companyName;
        model = modelName;
        year = carYear;
    }

    static void Main()
    {
        Car Honda = new Car("Honda", "Civic", 1998);

        Console.WriteLine(
            $"this is a {Honda.company} {Honda.model} and it came out in the year {Honda.year}"
        );
    }
}
