using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestPrismaTriangular
    {
        // Test para calcular el volumen del Prisma Triangular
        [Theory]
        [InlineData(10, 5, 50)]    // Área base = 10, altura = 5, volumen esperado = 50
        [InlineData(20, 3, 60)]    // Área base = 20, altura = 3, volumen esperado = 60
        [InlineData(15, 8, 120)]   // Área base = 15, altura = 8, volumen esperado = 120
        [InlineData(25, 4, 100)]   // Área base = 25, altura = 4, volumen esperado = 100
        [InlineData(8,  7,  56)]   // Área base = 8,  altura = 5, volumen esperado = 40 
        public void TestVolumen(double areaBase, double altura, double volumenEsperado)
        {
            // Arrange – Configuración de los datos

            // Act – Ejecutar el cálculo del volumen
            double resultado = PrismaTriangular.Volumen(areaBase, altura);

            // Assert – Verificar que el volumen calculado es el esperado
            Assert.Equal(volumenEsperado, resultado);
        }
    }
}