// See https://aka.ms/new-console-template for more information
using System;

class Motor
{
    private int litros_de_aceite {get; set;}
    private int potencia {get; set;}

    public Motor(int potencia) {
        this.potencia = potencia;
        this.litros_de_aceite = 0;
        
    }
    public int GetAceite() {
        return this.litros_de_aceite;
    }
    public int GetPotencia() {
        return this.potencia;
    }
    public void SetAceite(int cantidad) {
        this.litros_de_aceite = cantidad;
    }
    public void SetPotencia(int cantidad) {
        this.potencia = cantidad;
    }
}

class Coche{
    private Motor motor {get; set;}
    public string marca {get; set;}
    public string modelo {get; set;}
    public  double precio_de_averias {get; set;}
    
    public Coche(string nombreModelo, string nombreMarca) {
        this.motor = new Motor(new Random().Next(0, 5));
        this.modelo = nombreModelo;
        this.marca = nombreMarca;
    }
    public Motor GetMotor() => this.motor;
    public string GetMarca() => this.marca;
    public string GetModelo() => this.modelo;
    public double GetPrecio() => this.precio_de_averias;
    public void acumularAveria(double precio) {
        this.precio_de_averias += precio;
    }
}

class Garaje {
    public Coche? coche {get; set;}
    public string averia {get;set;}
    public int numeroCoches {get;set;}

    public Garaje() {
        this.numeroCoches += 0;
        this.averia = "";
        this.coche = null;
    }
    public bool aceptarCoche(Coche nuevoCoche, string tipoAveria) {
        if (numeroCoches > 0) {
            return false;
        }
        else {
            this.coche = nuevoCoche;
            this.averia = tipoAveria;
            this.numeroCoches++;
            return true;
        }
    }
    public void devolverCoche() {
    this.coche = null;
    this.averia = "";
    this.numeroCoches = numeroCoches - 1;
    }
}

class PracticaPOO {
    public static void Main(string[] args)
    {
        Garaje LaPrincesa = new Garaje();
        Coche coche1 = new Coche("Suzuki", "Swift");
        Coche coche2 = new Coche("Toyota", "Tundra");
        Coche[] coches = [coche1, coche2];
        for (int i = 0; i < 2; i++){
            foreach (Coche coche in coches){
                Console.WriteLine($"Entra el {coche} al garaje, cual es la averia? ");
                string? averia = Console.ReadLine();

                LaPrincesa.aceptarCoche(coche, averia);

                coche.precio_de_averias += new Random().Next(50, 100);

                if (averia == "aceite") {
                    coche.GetMotor().SetAceite(10);
                }
                LaPrincesa.devolverCoche();
                Console.WriteLine($"Marca: {coche.GetMarca()}");
                Console.WriteLine($"Modelo: {coche.GetModelo()}");
                Console.WriteLine($"Cantidad de aceite en el motor: {coche.GetMotor().GetAceite()}");
                Console.WriteLine($"Precio de averias: {coche.precio_de_averias}");
                Console.WriteLine("Continuar: "); Console.ReadLine();

            }
        }
    }
}
