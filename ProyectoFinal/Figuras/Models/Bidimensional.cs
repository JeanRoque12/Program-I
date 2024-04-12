public abstract class Bidimensional : Figuras {
    protected double? area {get; set;}
    protected double? perimetro {get; set;}

    public double? GetArea() {
        return area;
    }
    public double? GetPerimetro() {
        return perimetro;
    }
}