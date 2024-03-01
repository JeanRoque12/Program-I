class Coche : Vehiculo {
    private string Marca {get; set;}
    private string Modelo {get; set;}

    public Coche(string valorMarca, string valorModelo) {
        this.Marca = valorMarca;
        this.Modelo = valorModelo;
    }

    public override void Acelerar() {
        Console.WriteLine("El coche acelera.");
    }

    public override void Frenar() {
        Console.WriteLine("El coche frena.");
    }
}