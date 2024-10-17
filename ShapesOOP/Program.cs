namespace ShapesOOP;

class Program
{
    static void Main(string[] args)
    {
        //Här skapar jag två cirkel-objekt med radierna 5 och 6
        Circle circle1 = new Circle(5);
        Circle circle2 = new Circle(6);
        //Här skriver jag ut deras areor med GetArea()-metoden som finns i klassen.
        Console.WriteLine(circle1.GetArea());
        Console.WriteLine(circle2.GetArea());
        //Här skriver jag ut första cirkelns omkrets
        Console.WriteLine(circle1.GetPerimeter());
        //Här skriver jag ut den andra cirkelns volym ifall den hade varit en sfär med samma radie.
        Console.WriteLine(circle2.GetVolumeSphere());
        //Samma sak med ett objekt ifrån triangel-klassen som jag skapat.
        Triangle triangle1 = new Triangle(8, 6);
        Console.WriteLine($"Triangelns bas: 8\nHöjd: 6\n Area: {triangle1.GetArea()}");
    }
}