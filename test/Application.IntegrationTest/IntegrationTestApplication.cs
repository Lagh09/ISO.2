namespace Application.IntegrationTest
{
    public class IntegrationTestApplication
    {
        // Test para calcular el volumen del Prisma Triangular (con base de triángulo equilátero)
        [Theory]
        [InlineData(4, 6, 41.569)]   // Lado del triángulo = 4, altura del prisma = 6, volumen esperado = 41.569
        [InlineData(5, 8,  86.602999999999994)]   // Lado del triángulo = 5, altura del prisma = 8, volumen esperado = 86.602999999999994
        [InlineData(6, 10,   155.88499999999999)]  // Lado del triángulo = 6, altura del prisma = 10, volumen esperado =   155.88499999999999
        [InlineData(3, 7,  27.280000000000001 )]   // Lado del triángulo = 3, altura del prisma = 7, volumen esperado =  27.280000000000001 
        [InlineData(8, 9, 249.41499999999999 )]                // Lado del triamgulo = 8, altura del prisma 9, volumen esperado = 249.41499999999999 
        public void TestVolumen(double lado, double altura, double volumenEsperado)
        {
            // Arrange – Configurar la entrada
            double area = Application.Triangulo.Area(lado);  // Calcular el área del triángulo equilátero

            // Act – Realizar el cálculo del volumen usando el área y la altura
            double resultado = Application.PrismaTriangular.Volumen(area, altura);

            // Assert – Verificar que el volumen calculado es el esperado
            Assert.Equal(volumenEsperado, resultado, precision: 3);  // Comprobamos con 3 decimales de precisión
        }
    }
}