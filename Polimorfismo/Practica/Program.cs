public abstract class Perro {
    public string? tamano;
    public virtual string Ladrar() => "Perro ladrando!";
    public virtual string Dormir() => "Perro durmiendo.";

}

public class Perro_Salchicha : Perro {
    public override string Ladrar() => "Perro Salchicha ladrando!";
    public override string Dormir() => "Perro Salchicha durmiendo.";

    public Perro_Salchicha() {
        this.tamano = "Pequeno.";
    }
}

public class Pastor_Alemano : Perro {
    public override string Ladrar() => "Pastor Aleman Ladrando!";
    public override string Dormir() => "Pastor Aleman durmiendo.";
    public Pastor_Alemano() {
        this.tamano = "Grande.";
    }
}