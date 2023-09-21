# buscabinaria
Busca Binaria em C#

O algoritmo começa com dois índices, esquerda e direita, que representam o subarray onde a busca está sendo realizada, inicialmente abrangendo todo o array.

Em cada iteração do loop while, o algoritmo calcula o índice do elemento do meio (meio) do subarray.

O valor do elemento no meio é comparado com o valor alvo. Se forem iguais, o algoritmo retorna a posição do elemento.

Se o valor alvo for menor do que o valor do meio, isso significa que o elemento alvo está na metade esquerda do subarray, então o índice direita é ajustado para meio - 1.

Se o valor alvo for maior do que o valor do meio, isso significa que o elemento alvo está na metade direita do subarray, então o índice esquerda é ajustado para meio + 1.

O algoritmo repete as etapas 2 a 5 até que o subarray se torne vazio (quando esquerda é maior do que direita) ou até que o elemento alvo seja encontrado.

Se o elemento não for encontrado, o método BuscaBinaria retorna -1 para indicar que o elemento alvo não está no array.

A busca binária é eficiente porque a cada iteração, ela reduz pela metade o tamanho do subarray onde está procurando, o que resulta em um tempo de busca muito rápido para arrays ordenados.
