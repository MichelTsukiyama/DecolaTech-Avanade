# Polimorfismo

O Polimorfismo vem do grego e significa "muitas formas".

Com o polimorfismo, podemos sobrescrever métodos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação.

Há 2 tipos de polimorfismo:

**Polimorfismo em tempo de compilação**(Overload/Early Binding)

Ex.:

    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Somar (int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

Só há alteração nas parametros, neste caso a quantidade.

**Polimorfismo em tempo de execução**(Override/Late Binding)

Ex.:

    public virtual void Apresentar()
    {
        System.Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos")
    }
    
    public override void Apresentar()
    {
        System.Console.WriteLine($"Olá meu nome é {Nome}.Sou aluno de nota {Nota}")
    }
Obs. o virtual significa que pode ser sobrescrito e o override sobrescreve o método Apresentar()