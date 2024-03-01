using BeeCrowd;
using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        Triangulo x = new Triangulo();
        Triangulo y = new Triangulo();

        Console.WriteLine("Insira os valores dos lados do triangulo 1");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Insira os valores dos lados do triangulo 2");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaX = x.Area();
        double areaY = y.Area();

        Console.WriteLine("Area X: {0}\nArea Y: {1}", areaX.ToString("F4", CultureInfo.InvariantCulture), areaY.ToString("F4", CultureInfo.InvariantCulture));

        if (areaX > areaY) {
            Console.WriteLine("Area maior: X");
        }
        else {
            Console.WriteLine("Area maior: Y");
        }
    }
}