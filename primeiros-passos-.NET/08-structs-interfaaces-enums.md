# Structs

Como as classes, as *structs* são estruturas de dados que podem conter membros de dados e membros de ação, mas, diferentemente das classes, as structs são tipos de valor e não requeremalocação de heap.

Uma variável de um tipo de struct armaazena diretamentee os dados da estrutura, enquanto uma variável de um tipo de classe armazena um referência  a um objeto alocado na memória.

Structs não aceitam herança determinada pelo desenvolvedor

São úteis para pequenas estruturas de dados que possuem semântica de valor: números complexos, pontos em um sistema de coordenadas ou pares de chave-valor em um dicionário são bons exemplos de utiliização.

O uso de structs em vez de classes para pequeenas estruturas de dados pode fazer uma grande diiferença no número de alocações de memória.

Construtores de uma struct são chamados com o operador new, seemelhante a um construtor de classe, mas em vez de alocar dinamicamente um objeto no heap gerenciado e retornar uma referência a ele, um coonstrutor  struct simplesmente retorna o próprio valor struct (normalmente em um local temporário na stack), e esse valor é copiado conforme necessário.

Ex. de implementação:

    public struct Ponto
    {
        //intruções
    }

# Interface

Uma interface define um ccontrato quee pode ser implementado por classes e structs

Uma interfacee pode conter métodos, propriedades, eventos ee indexadores.

Uma interfacee não fornece implementações dos membros que definee - apenas suas "assinaturas"

As interfaces podem empregar herança múltipla.

Ex. de interface:

    interface IControl
    {
        void Paint();
    }

# Enum

Um *enum* é um tipo dee valor distinto com um conjuto de constantes nomeadas

Você deefine enumerações quando precisa definir um tipo que pode ter um conjunto de valores discretos.
Eles usam um dos tipos de valor integral como armazenamento subjacente. Eles fornecem significado sêmantico aos valores discretos.

    enum Cor
    {
        Vermelho,
        Verde,
        Azul

    }

Cada tipo de enum possui um tipo integral correspondente chamado tipo subjacente do tipo de enum

Um tipo de enumeração que não declara explicitamnete um tipo subjacente tem um tipo subjacente int