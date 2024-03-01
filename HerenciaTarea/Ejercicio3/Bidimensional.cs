class Bidimensional : Figuras {
    private double? area;
    private double? parametro;
    public Bidimensional(int vertices, int aristas) : base(vertices, aristas, 2) 
    {
        area = null;
        parametro = null;
    }
    public double? GetArea() {
        return area;
    }
    public virtual void SetArea(double Area) {
        this.area = Area;
    }
    public double? GetParametro() {
        return parametro;
    }
    public virtual void SetParametro(double Parametro) {
        this.parametro = Parametro;
    }
    public override void SetCaras(int caras)
    {
        return;
    }
}