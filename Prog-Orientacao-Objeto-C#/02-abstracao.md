# Abstração

Abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.

Devemos abstrair somente o que é necessário para cada caso, ex.:

Ao criar uma classe "Pessoa", para uma escola, devemos colocar apenas atributos relevantes para um escola.

No caso acima teríamos os atributos: Nome, data de nascimento, tipo de pessoa (docente/aluno), turma, etc..
Não sendo necessário saber a cor do cabelo, altura, etc...

# Criando projeto POO

Na linha de comando, acesse a pasta onde vai criar o projeto e digite:

    dotnet new sln --name <nomeDoArquivo>

O comando acima cria um arquivo .sln

Em seguida crie uma pasta usado:

    mkdir <nomeDaPasta>

Acesse a pasta usado o comando cd nomeDaPasta e crie um projeto C#:

    dotnet new console

Após adicione seu projeto a sln:

    dotnet sln add. <caminho até o arquivo .csproj que você criou>

# Recomendação de extensões



