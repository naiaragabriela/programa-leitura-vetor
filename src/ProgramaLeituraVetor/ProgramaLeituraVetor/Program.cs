int[] A = new int[5];
int[] B = new int[5];
int[] C = new int[10];

LerVetor(A, " Vetor A");
LerVetor(B, "Vetor B");
LerVetor(C, "Vetor C");

C = ConcatenarVetor(A, B);

ImprimirVetor(A, "Vetor A");
ImprimirVetor(B, "Vetor B");
ImprimirVetor(C, "Vetor C");


OrdenarVetor(C);
ImprimirVetor(C, "Vetor C");

void OrdenarVetor(int[] C)
{
    int i, j;
    for (i = 0; i < C.Length - 1; i++)
    {

        for (j = 1; j < C.Length; i++)
        {
            if (C[i] > C[j])
            {
                int aux = C[i];
                C[i] = C[j];
                C[j] = aux;
            }
        }
    }

}


int[] ConcatenarVetor(int[] A, int[] B)
{
    int[] aux = new int[10];
    for (int i = 0; i < A.Length; i++)
    {
        aux[i] = A[i];

    }
    for (int i = 0; i < B.Length; i++)
    {
        aux[i + 5] = B[i];
        return aux;
    }
}


void LerVetor(int[] aux, string texto)
{
    Console.WriteLine("Informe os valores do {0}: ", texto);
    for (int i = 0; i < aux.Length; i++)
    {
        Console.WriteLine("Vetor [{0}] = ", i);
        aux[i] = int.Parse(Console.ReadLine());
    }
}

void ImprimirVetor(int[] aux, string texto)
{

    Console.WriteLine("Os valores do {0} são: ", texto);
    for (int i = 0; i < aux.Length; i++)
    {
        Console.WriteLine("\nVetor [{0}] = ", i);
    }

}

