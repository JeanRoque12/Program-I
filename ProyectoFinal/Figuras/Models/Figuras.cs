

public abstract class Figuras {
    protected string tipo {get; set;}
    protected int numeroVertices {get; set;}
    protected int numeroAristas {get; set;}

    protected int? numeroCaras {get; set;}


    public int GetVertices() {
        return numeroVertices;
    }
    public int GetAristas() {
        return numeroAristas;
    }
    public int? GetCaras() {
        return numeroCaras;
    }
    public string GetTipo()
    {
        return tipo;
    }


}
