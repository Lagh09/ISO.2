using System;

namespace Application;

public class Triangulo
{
    // Calcula el perímetro de un triángulo equilátero (todos los lados iguales)
    public static double Perimetro(double lado)
    {
        return lado * 3;  // El perímetro es 3 veces el valor del lado
    }

    // Calcula el área de un triángulo equilátero
    public static double Area(double lado)
    {
        return (Math.Sqrt(3) / 4) * lado * lado;  // Fórmula del área para un triángulo equilátero
    }
}