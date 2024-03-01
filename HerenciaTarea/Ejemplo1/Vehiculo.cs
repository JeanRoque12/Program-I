
class Vehiculo {
    private string Color {get; set;}
    private int? Anos {get; set;}

    public Vehiculo() {
        this.Color = "Aun no se ha establecido el color de este vehiculo.";
        this.Anos = null;
    }
    public void Bocina() {
        Console.WriteLine("BEEEEEP!");
    }
    public string GetColor() {
        return this.Color;
    }
    public void SetColor(string nombreColor) {
        this.Color = nombreColor;
    }
    public int? GetAnos() {
        return this.Anos;
    }
    public void SetAnos(int valorAnos) {
        this.Anos = valorAnos;
    }

    public virtual void Acelerar() {
        Console.WriteLine("El vehiculo acelera;");
    }
    
    public virtual void Frenar() {
        Console.WriteLine("El vehiculo frena.");
    }

}