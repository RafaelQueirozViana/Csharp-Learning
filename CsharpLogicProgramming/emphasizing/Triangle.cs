public class Triangle {

    public double sideA { get; private set; }
    public double sideB { get; private set; }
    public double sideC { get; private set; }


    public Triangle(double a, double b, double c) {
        sideA = a;
        sideB = b;
        sideC = c;
    }

    public string getInfo() {
        return $"A: {sideA} B: {sideB} C: {sideC}";
    }






}