class Empleado : Persona {
    private string posicion;
    private int sueldo;
    public Empleado(string? nombre, string apellido, int? edad, string cedula, string posicion, int sueldo) : base(nombre, apellido, edad, cedula) {
        this.posicion = posicion;
        this.sueldo = sueldo;
    }

    public string GetPosicion() => this.posicion;
    public void SetPosicion(string Posicion) => this.posicion = Posicion;
    public int GetSueldo() => this.sueldo;
    public void SetSueldo(int Sueldo) => this.sueldo = Sueldo;
}