double perimetro;
double area;
double volumen;

Console.WriteLine("Calculadora de Perímetro y Área del Triángulo; y Volumen de un Prisma Triangular");

// Entrada de datos para los lados del triángulo
Console.Write("Dame el primer lado del triángulo (en cm): ");
double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame el segundo lado del triángulo (en cm): ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame el tercer lado del triángulo (en cm): ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            // Entrada de datos para la base y la altura del triángulo
            Console.Write("Dame la base del triángulo (en cm): ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame la altura del triángulo (en cm): ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            // Entrada de datos para la altura del prisma
            Console.Write("Dame la altura del prisma triangular (en cm): ");
            double alturaPrisma = Convert.ToDouble(Console.ReadLine());

            // Cálculos
            perimetro = Application.Triangulo.Perimetro(lado1);
            area = Application.Triangulo.Area(lado1* lado1 * lado1);
            volumen = Application.PrismaTriangular.Volumen(area, alturaPrisma);

            // Salida de resultados
            Console.WriteLine();
            Console.WriteLine($"Perímetro del triángulo: {perimetro} cm");
            Console.WriteLine($"Área del triángulo: {area} cm²");
            Console.WriteLine($"Volumen del prisma triangular: {volumen} cm³");
   