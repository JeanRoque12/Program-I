class Figuras {
    private int numeroVertices {get; set;}
    private int numeroAristas {get; set;}

    private int numeroCaras {get; set;}

    public Figuras(int vertices, int aristas, int caras) {
        this.numeroVertices = vertices;
        this.numeroAristas = aristas;
        this.numeroCaras = caras;
    }

    public int GetVertices() {
        return numeroVertices;
    }
    public virtual void SetVertices(int vertices) {
        this.numeroVertices = vertices;
    }
    public int GetAristas() {
        return numeroAristas;
    }
    public virtual void SetAristas(int aristas) {
        this.numeroAristas = aristas;
    }
    public int GetCaras() {
        return numeroCaras;
    }
    public virtual void SetCaras(int caras) {
        this.numeroCaras = caras;
    }

    public virtual void Calculo() 
    {
    }
}
