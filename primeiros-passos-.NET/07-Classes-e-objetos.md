# Classes

Classes são os tipos mais fundamentais de C#;

Uma classe é uma estrutura de dados que combina estado (campos) e ações (métodos)

# Objetos

São instânciias de uma classe

As classes suportam herança e polimorfismo, mecanismos pelos quais as classes derivadas podem estender e especializar as classes base

## Exemplo de classes e objetos

    public class Ponto
    {
        public int x, y;
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

Instâncias de classes (objetos) são criadas usando o operador new, que aloca memória para uma nova instância, chama um construtor para inicializar a instância e retorna uma referência à instância

    Ponto p1 = new Ponto(0,0);

    Ponto p2 = new Ponto(10, 20);

A memória ocupada por um objeto é recuperada automaticamente quando o objeto não está mais acessível. Não é necessárionem possível desaaloar explicitamente objetos em C#.

## Membros

Os membros de uma classe podem ser estáticos ou membros da instância.

Membros estáticos pertecem a classe e membros de instânccia pertecem ao objeto

Constantes, variáveis, métodos, propriedades, ontrututores, etc...

## Acessibilidade

Cada membro de um classe tem uma acessibilidade associada, que controla as reegiões do texto do programa que podem aceessar o membro.

Podem ser:

- public
- protected
- internal
- private

## Herança

Uma declaração de classe pode especificar uma classe base, herdando os meembros public, internal e protected daa classe base.

Omitir uma especificação de classe base é o mesmo que derivar do tipo object.

## Métodos

Um método é um membro que implementa uma computação ou ação quee pode ser executada por um objeto ou classe.

Os métodos podem ter umaa lista de parâmetros, que represeentam valores ou referêencias de variáaveeis passados para o méetodo, e um tipo de retorno, que especifia o tipo do valor calculado e retornado pelo método.



