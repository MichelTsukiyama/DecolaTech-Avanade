# CLI .NET

## Help

Utilize o comando abaixo para ver a lista de comandos do .NET:

    dotnet --help

Obs.: Você pode utilizar o "--help" para ter ajuda referente aos comandos de um comando específico.

Ex.:

    dotnet new --help

## Criando uma aplicação console

Utilize o comando:

    dotnet new console -n NomeDoArquivo

Será criada uma pasta com os conteúdos obj, Program.cs e um arquivo .csproj

Abra a pasta criada (NomeDoArquivo) no terminal, e o próprio VS Code vai soliicitar para instalar alguns pacotes, escolher a opção "Sim/Yes"

**Outros comandos muito utilizados**

    dotnet restore

Restaura e baixa pacotes utilizados no projeto.

    dotnet build

Crias os arquivos .dll, .exe e .pdb para que a aplicação funcione

    dotnet run

Roda os códigos do arquivo


