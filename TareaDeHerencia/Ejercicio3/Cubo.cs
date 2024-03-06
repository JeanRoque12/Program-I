class Cubo : Tridimensional {
    private double lado;
    public Cubo(double lado) : base(8, 12, 6) {
        this.Calculo();
    }
    
    public double GetLado() {
        return lado;
    }
    public void SetLado(double lado) {
        this.lado = lado;
        this.Calculo();
    }
    public override void Calculo() {
        this.SetVolumen((int)lado^3);
        this.SetAreaSuperficial(6*(int)lado^2);       
    }
    public override void SetCaras(int caras)
    {
        return;
    }
    public override void SetAristas(int aristas)
    {
        return;
    }
    public override void SetVertices(int vertices)
    {
        return;
    }
}