namespace ShapesOOP;

public class Circle
{
    private double radius;
    //Konstruktor som tar in cirkelns radie
    public Circle(double Radius)
    {
        this.radius = Radius;
    }
    //Metod som räknar ut area utifrån radien på cirkeln
    public double GetArea()
    {
        double area = this.radius * this.radius * Math.PI;
        return Math.Round(area, 2); //Jag hittade Math.Round()-metoden som låter en avrunda ett decimaltal
                                    //till valfritt antal decimaler och användar det i alla metoder för att det ska se bättre ut i konsolen
    }
    //Räknar ut omkretsen
    public double GetPerimeter()
    {
        double perimeter = this.radius * 2 * Math.PI;
        return Math.Round(perimeter, 2);
    }
    //Räknar ut volymen.
    public double GetVolumeSphere()
    {
        double volume = (4/3) * Math.PI * this.radius * this.radius * this.radius;
        return Math.Round(volume, 2);
    }
}