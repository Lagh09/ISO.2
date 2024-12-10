using System;
using Xunit;
using Application;
using System.Runtime.InteropServices;

namespace Application.UnitTest
{
    public class UnitTestTriangulo
    {
        // Test para el cálculo del perímetro del triángulo equilátero
        [Theory]
        [InlineData(4, 12)]   // lado = 4,  perímetro = 12
        [InlineData(5, 15)]   // lado = 5,  perímetro = 15
        [InlineData(10, 30)]   // lado = 10, perímetro = 30 
        [InlineData(7, 21)]   // lado = 7,  perímetro = 21
        [InlineData(8, 24)]   // lado =) 8, perimetro = 24
        public void TestPerimetro(double lado, double perimetroEsperado)
        {
            // Arrange – Configuración de los datos

            // Act – Calcular el perímetro
            double resultado = Triangulo.Perimetro(lado);

            // Assert – Verificar que el perímetro es el esperado
            Assert.Equal(perimetroEsperado, resultado);
        }

        // Test para el cálculo del área del triángulo equilátero
        [Theory]
        [InlineData(4, 6.92820323)]   // lado = 4, área ≈ 6.93
        [InlineData(5, 10.82531755)]  // lado = 5, área ≈ 10.83
        [InlineData(7, 21.21762239)]  // lado = 7, área = 21.22
        [InlineData(10, 43.30127019)] // lado = 10, área = 43.31
        [InlineData(2, 1.732050808)]  // lado = 2, área = 1.73
        public void TestArea(double lado, double areaEsperada)
        {
            // Arrange – Configuración de los datos

            // Act – Calcular el área
            double resultado = Triangulo.Area(lado);

            // Assert – Verificar que el área es la esperada
            Assert.Equal(areaEsperada, resultado, 6);  // Comparamos con 6 decimales de precisión
        }
    }
}