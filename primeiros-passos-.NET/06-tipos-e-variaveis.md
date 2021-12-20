# Tipos de valor

**Variáveis de tipos de valor contêm diretamente seus dados**

As variáveis têm sua própria cópia dos dados e não é possível que as operações afetem outra variável (exceto no caso das variáveis de parâmetro ref e out)

Númericos: sbyte, short, int, long, byte, ushort, uint, ulong
Caracteres Unicode: char
Pontos flutuantes: float, double, decimal
Booleano: bool
enum, struct e tipos nullable(exemplo int?)

**Variáveis de tipos de referência armazenam referências a seus dados**

É possível que duas variáveis façam referência ao mesmo objeto e, portanto, que operações em uma variável afetem o objeto referenciado pela outra variável.

Tipos Classe: class, object, string

Tipos Arrays: int[], int[,], etc...

interface, delegate

## Instruções

Ações de um programa são expressas usando instruções

{
    Um bloco permite que várias instruções sejam escritas em contextos
}

- Declaração de variáveis e constantes
- if
- switch
- while
- do
- for
- foreach
- break
- continue
- return
- try.. catch.. finally
- using


## Array

Um **array** é uma estrutura de dados que contém um número X de elementos, todos do mesmo tipo, que são acessados através de índices computados.

Arrays são tipos de referência e a declaração de uma variável array simplesmente reserva espaço para uma referência de uma instância de array.

Ao criar um array é especificado o tamanho da nova instância, que é fixo durante todo o tempo de vida da instância.

Os índices dos elementos de um array variam de 0 a comprimento do array - 1

Array unidimensional int[] com a quantidade de índices dentro ex.: int[10];

Array multidimensional int[,] com as quantidades de índices ex.: int[10, 5]; 

**Inicializador de array**

int[] a = new int[] {1, 2, 3};

ou

int[] a = {1, 2, 3};