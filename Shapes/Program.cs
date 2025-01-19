
abstract class Shape
{
    // Propiedades comunes para todas las formas
    public double Ancho { get; set; }
    public double Alto { get; set; }

    // Método abstracto para calcular el área
    public abstract double CalculateSurface();
}

// Clase Rectangulo que hereda de Shape
class Rectangulo : Shape
{
    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public override double CalculateSurface()
    {
        return Ancho * Alto;
    }
}

// Clase Triangulo que hereda de Shape
class Triangulo : Shape
{
    public Triangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public override double CalculateSurface()
    {
        return (Ancho * Alto) / 2;
    }
}

// Clase Circulo que hereda de Shape
class Circulo : Shape
{
    public Circulo(double radio)
    {
        Ancho = Alto = radio; // Ambos se inicializan con el valor del radio
    }

    public override double CalculateSurface()
    {
        return Math.PI * Math.Pow(Ancho, 2); // Área del círculo: π * radio²
    }
}

class Program
{
    static void Main()
    {
        // Crear una matriz de formas diferentes (Rectangulo, Triangulo y Circulo)
        Shape[] shapes = new Shape[]
        {
            new Rectangulo(10, 5),
            new Triangulo(8, 4),
            new Circulo(3)
        };

        // Crear una matriz para almacenar las áreas calculadas
        double[] areas = new double[shapes.Length];

        // Calcular el área de cada forma y almacenarla en la matriz
        for (int i = 0; i < shapes.Length; i++)
        {
            areas[i] = shapes[i].CalculateSurface();
        }

        // Mostrar las áreas calculadas
        Console.WriteLine("Áreas de las formas:");
        for (int i = 0; i < areas.Length; i++)
        {
            Console.WriteLine($"Forma {i + 1}: {areas[i]:F2}");
        }
    }
}