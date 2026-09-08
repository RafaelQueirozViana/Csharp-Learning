public class Triangle {

    public double SideA { get; private set; }
    public double SideB { get; private set; }
    public double SideC { get; private set; }


    public Triangle(double a, double b, double c) {
        SideA = a;
        SideB = b;
        SideC = c;
    }

    public double getArea() {
        double area = (SideA + SideB + SideC) / 2.0;

        return area;


    }









}