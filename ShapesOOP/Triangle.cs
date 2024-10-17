namespace ShapesOOP;

public class Triangle
{
    private double sideBase;
    private double sideHeight;
    public Triangle(double sideBase, double sideHeight)
    {
        this.sideBase = sideBase;
        this.sideHeight = sideHeight;
    }

    public double GetArea()
    {
        double area = (this.sideBase * this.sideHeight) / 2;
        return Math.Round(area, 2);
    }
}