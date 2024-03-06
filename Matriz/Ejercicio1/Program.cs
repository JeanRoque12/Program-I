static void AgregarElemento(int[] fila, int columna, int elemento) {
    fila[columna] = elemento;
}
static int numeroRandom(Random random) {
    return random.Next(2, 20);
}
static int numeroIntroducido(int fila, int columna) {
    Console.WriteLine($"Fila actual = {fila}. Columna actual {columna}."); 
    Console.Write($"Introduce el elemento a anadir: ");
    return int.Parse(Console.ReadLine());
}
static void Matriz(int[][] matriz, int grado, Func<int> method) {
    for (int i = 0; i < grado; i++) {
        int[] arregloFila = new int[grado];
        for (int k = 0; k < grado; k++) {
            int elemento = method();
            AgregarElemento(arregloFila, k, elemento);
        }
        matriz[i] = arregloFila;
    }
}

static int[][]? CrearMatriz() {
    Random randomNum = new Random();
    Console.Write("Introduzca el grado de la matriz (2-9): ");
    int grado = int.Parse(Console.ReadLine());
    if (grado >=2 && grado<=9) {
        if (grado % 2 == 0) {
            int[][] matrizCreada = new int [grado][];
            Console.WriteLine("Ya que el grado es par, los numeros generados serán aleatorios.");
            Matriz(matrizCreada, grado, () => numeroRandom(randomNum));
            return matrizCreada;
        }
    }
    else {
        return null;
    }
    return null;
}

static void ImprimirMatriz(int[][] matriz) {
    int grado = matriz.GetLength(0);

    for (int row = 0; row < grado; row++) {
        for (int col = 0; col < grado; col++)               
        Console.Write(String.Format("{0}\t", matriz[row][col]));
    Console.WriteLine();
    } 
}

ImprimirMatriz(CrearMatriz());