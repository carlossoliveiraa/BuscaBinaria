internal class Program
{
    private static void Main(string[] args)
    {
        // Defina um array ordenado.
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Especifique o elemento que você deseja encontrar.
        int alvo = 6;

        // Chame o método BuscaBinaria para encontrar o elemento no array.
        int resultado = BuscaBinaria(array, alvo);

        // Verifique o resultado da busca.
        if (resultado != -1)
            Console.WriteLine($"Elemento {alvo} encontrado na posição {resultado}");
        else
            Console.WriteLine($"Elemento {alvo} não encontrado no array");
    }

    static int BuscaBinaria(int[] array, int alvo)
    {
        int esquerda = 0;          // Índice do elemento mais à esquerda do subarray.
        int direita = array.Length - 1; // Índice do elemento mais à direita do subarray.

        // O loop continuará enquanto o subarray não estiver vazio.
        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2; // Calcula o índice do meio.

            // Verifique se o valor do meio é igual ao alvo.
            if (array[meio] == alvo)
                return meio; // O elemento foi encontrado, retorne a posição.

            // Se o alvo for menor que o valor do meio, continue procurando na metade esquerda.
            if (array[meio] > alvo)
                direita = meio - 1;
            // Se o alvo for maior que o valor do meio, continue procurando na metade direita.
            else
                esquerda = meio + 1;
        }

        // Se o elemento não for encontrado, retorne -1.
        return -1;
    }
}