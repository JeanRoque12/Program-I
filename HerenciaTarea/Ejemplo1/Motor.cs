class Motor : Vehiculo {
    private string Marca {get; set;}
    private string Modelo {get; set;}

    public Motor(string valorMarca, string valorModelo) {
        this.Marca = valorMarca;
        this.Modelo = valorModelo;
    }

    public override void Acelerar() {
        Console.WriteLine("El motor acelera.");
    }

    public override void Frenar() {
        Console.WriteLine("El motor frena.");
    }
}