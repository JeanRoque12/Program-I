public abstract class Tridimensional : Figuras {
    protected double? areaSuperficial {get; set;}
    protected double? volumen {get; set;}

    public double? GetAreaSuperficial() => areaSuperficial;

    public double? GetVolumen() => volumen;

}