class Cliente : Persona{
    private string? asunto;
    private int posicionEspera;
    public Cliente(string? nombre, string apellido, string cedula, string asunto, int posicionEspera) : base(nombre, apellido, null, cedula) {
        this.asunto = asunto;
        this.posicionEspera = posicionEspera;
    }
    public string? GetAsunto() => this.asunto;
    public void SetAsunto(string? asunto) => this.asunto = asunto;
    public int GetPosicionEspera() => posicionEspera;
    public void SetPosicionEspera(int posicionEspera) => this.posicionEspera = posicionEspera;
}