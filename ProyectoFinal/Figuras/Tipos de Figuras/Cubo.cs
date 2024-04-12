public class Cubo : Tridimensional {
    protected double lado;
    public Cubo(string tipo, double lado) {
        this.tipo = tipo;
        this.numeroCaras = 6;
        this.numeroAristas = 12;
        this.numeroVertices = 8;
        this.lado = lado;
        this.volumen = Math.Pow(lado, 3);
        this.areaSuperficial = this.numeroCaras*Math.Pow(lado, 2);
    }
    
    public double GetLado() {
        return lado;
    }

}