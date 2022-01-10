# Projeto Criando um APP simples de cadastro de séries em .NET

O projeto cria os métodos de um sistema CRUD, create, read, update, delete, em C#.

Este projeto auxiliou a elucidar e praticar a utilização de classe abstrata, interface, enum, métodos etc.

# Inicializando o projeto

Para rodar o projeto clone esta pasta usando *git clone* ou baixe os arquivos em seu computador.

Abra o terminal dentro desta pasta (DIO.Series) e digite:

    dotnet run

Utilize os números e letras indicados no menu que aparecerá no terminal e digite enter para confirmar sua opção.


## Dificuldade durante o projeto:

- A primeira vez que rodei a build, aparecia a mensagem "Enviroment" não existe no contexto atual, por falha minha escrevi Environment errado.
- Também aparecia que AtualizarSerie, ExcluirSerie e VisualizarSerie não existiam, neste caso foi por ter colocado os métodos do switch, mas ainda não ter escrito nenhum deles.

- Após corrigir estas falhas, meu próximo problema foi que ao selecionar alguma opção no menu, por exemplo 1- listar séries, entrava em loop infinito.
Neste caso a resolução foi chamar no fim do laço o método do menu. Uma vez ue se digitava uma opção, a variavel ficava com o valor armazenado e o chamava infinitas vezes.

- Meu próximo desafio foi ao tentar atualizar os dados de uma série, ao digitar o número do ID apareciia uma mensagem dizendo que o Index tinha que ser maior ou igual a zero e menor que o argumento da lista. Inicialmente acreditei ue o problema estava na entrada dos dados, engano meu, o problema estava dentro do foreach, na hora de escrever a saída me esqueci de colocar um "i".

- Por fim depois de corrigir este último item minha build não rodava, aparentemente depois de utilizar o debuger, este não foi finalizado corretamente e eu recebia a mensagem de que algum outro processo estava utilizando os arquivos. Neste caso apenas fiz uma reinicialização dos programas para que voltassem a funcionar.

