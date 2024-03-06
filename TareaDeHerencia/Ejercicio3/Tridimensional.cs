class Tridimensional : Figuras {
    private double? areaSuperficial;
    private double? volumen;

    public Tridimensional(int vertices, int aristas, int caras) : base(vertices, aristas, caras) {
        this.areaSuperficial = null;
        this.volumen = null;
    }
    public double? GetAreaSuperficial() => areaSuperficial;
    public virtual void SetAreaSuperficial(double area) {
        this.areaSuperficial = area;
    }
    public double? GetVolumen() => volumen;
    public virtual void SetVolumen(double Volumen) {
        this.volumen = Volumen;
    }
}