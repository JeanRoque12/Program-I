class Arbol : Planta{
    protected string colorTronco {get; set;}
    protected double espesorTronco {get; set;}
    public Arbol(string colorHojas, string altura, bool frutos, string colorTronco, double espesorTronco) : base(colorHojas, altura, frutos) {
        this.colorTronco = colorTronco;
        this.espesorTronco = espesorTronco;
    }
    
    public string GetColorTronco() => colorTronco;
    public void SetColorTronco(string colorTronco) => this.colorTronco = colorTronco;
    public double GetEspesorTronco() => espesorTronco;
    public void SetEspesorTronco(double espesorTronco) => this.espesorTronco = espesorTronco;
}