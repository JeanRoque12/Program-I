class Persona {
    private string? nombre {get; set;}
    private string? apellido {get; set;}
    private int? edad {get; set;}
    private string? cedula {get; set;}
    
    public Persona(string? nombre, string apellido, int? edad, string cedula) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.cedula = cedula;
    }

    public string? GetNombre() => this.nombre;
    public void SetNombre(string? Nombre) {
        this.nombre = Nombre;
    }
    public string? GetApellido() => this.apellido;
    public void SetApellido(string? Apellido) {
        this.apellido = Apellido;
    }
    public int? GetEdad() => edad;
    public void SetEdad(int Edad) {
        this.edad = Edad;
    }
    public string? GetCedula() => cedula;
    public void SetCedula(string? Cedula) {
        this.cedula = Cedula;
    }

}
