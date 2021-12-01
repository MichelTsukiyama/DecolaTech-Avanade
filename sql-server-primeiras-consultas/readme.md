# O que s�o bancos de dados?

S�o dados/informa��es armazenados em algum lugar.
Ex.: Uma planilha de excel pode ser um banco de dados, se voc� tiver nele informa��ees de clientes, produtos, etc. Estas informa��es ser�o utilizadas ou consultadas posteriormente;

# O que s�o SGBDs

SGBDs s�o sistemas de gerenciamento de banco dee dados.

# Tipos de bancos de dados

**Relacionais**: SQL Server, Oracle, MySQL...
**NoSQL**: MongoDB, Neo4j, Firebase...

Bancos relacionais s�o usados quando � necess�rio uma confiabilidade muito alta nos dados ou um forte controle. Ex.: informa��es de compras e vendas, controle de estoquee etc.
Bancos NoSQL s�o voltados para melhor performance e grandes quantidades de dados, armazenamento de v�deos, imagens, links...

# Representa��o banco relacional

Em um banco relacional constitu�do por tabelas, podemos imaginar como no excel. As linhas s�o os registros, com IDs esclusivos chamados de chave, j� as colunas cont�m atributos dos dados.

O banco � formado por entidades e atributos. Que podem ser representados de maneira semelhante a fluxogramas.

Os atributos possuem tipo, podendo ser int(inteiro), varchar(string), bit(bin�rio/booleano)...

**Atomicidade**: garantir que todos os dados est�o corretos para ser inserido dentro de uma tabela.

**Consist�ncia dos dados**: H� a confiabilidade de que os dados estar�o sempre iguais, mesmo ao se utilizar mais de uma base de dados.

# Instala��o

Fa�a o donwload da vers�o Express [nesta p�gina](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) ou clique [aqui](https://go.microsoft.com/fwlink/?linkid=866658) para iniciar o download.

Execute o arquivo baixado, selecione a instala��o b�sica e aceite os termos de licen�a e clique em instalar.
Obs. Salve em um bloco de notas ou outro lugar o campo "cadeia de conex�o", ser� usado posteriormente.

Ap�s a instala��o, selecionar **Instalar o SSMS** ou fa�a o donwload [nesta p�gina](https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN&view=sql-server-ver15) ou [clique aqui](https://aka.ms/ssmsfullsetup) para iniciar o download.
SSMS � um ambiente inteegrado para gerenciar qualquer infraestrutura de SQL, fornecendo ferramentas para cconfigurar, monitorar e administrar inst�ncias do SQL Server e bancos de dados.

Execute o arquivo e selecione **Instalar**, ap�s a instala��o reinicie seu computador.

Ap�s reiniciar abra o SQL Server Management Studio e ap�s selecione conectar.

# Conceito iniciais

**Para criar um novo banco de dados**

No menu lateral, clique com o bot�o esquerdo na pasta banco de dados, "novo banco de dados"
Pela linha de comonado:
	
	create database nomeDoBanco

Ap�s utilize o "refresh" no menu lateral ou "F5" para atualizar o conte�do e visualizar o banco

**Para excluir um banco de dados**

No menu lateral, clique com o bot�o esquerdo na pasta com o nome do banco a ser exclu�do e selecione "exclu�r"

**Alternando bancos de dados**

Para alternanar entre bancos (semelhante a trocar branchs no GitHub desktop), selecione no menu superior a caixa onde est� escrito "master" e clique no banco desejado
Pela linha de comando (semelhante a trocar branchs no Git):

	use nomeDoBanco

**Criar tabelas**

Clique com o bot�o direito na pasta tabela, selecione "novo", "tabela";
Complete os dados "coluna", "tipo de dados" e "null"
Salve a tabela
Na linha de comando:

	create table nomeDaTabela
	(
		nomeDaColuna tipoDeDado(tamanho) null,
		Descricao varchar(50) not null,  <= exemplo
	)

Obs. bancos relacionais s�o altamente tipados

**Tipos**
* int - n�meros inteiros
* bigint - n�meros inteiros com muitos caracteres
* float - n�meros com ponto flutuante, ex.: 2.12
* varchar(tamanho) - caracteres alfanum�ricos (o tamanha varia at� o limite colocado nos parenteses)
* char(tamanho) - caracteres alfanum�ricos (tamanho fixo, se coloca um �nico caractere, ele completa o resto com espa�os vazios)
* bit - apenas 0 ou 1
* datetime - data

**null e not null**

* null - aceita valores nulos
* not null - n�o aceita valores nulos.
Obs. null � um valor vazio

**Apagar tabelas**

Na linha de comando:

	drop table nomeDaTabela

# Comandos

**Selecionar tabela**

	select * from nomeDaTabela

Obs.: Vc pode selecionar o nome da tabela e usar alt + f1 para ver mais informa��es

**Inserir dados na tabela**

	insert into nomeDaTabela (nomeDacoluna, nomeDaColuna) values (123, 'abc');

Se voc� omitir os nomes das colunas, ele vai inserir os dados de acordo com a ordem das colunas na tabela.

	insert nomeDaTabela values (123, 'abc')

Obs. tamb�m � possivel omitir o into
**Mas o ideal � sempre colocar o nome da coluna**

**selecionar coluna**

	select nomeDaColuna
	from nomeDaTabela

ou

	select *
	from cliente
	where TipoPessoa = valor

Obs. "where" mostra um local especifico

**Atualizar dados nas colunas**

	update nomeDaTabela
	set nomeDaColuna = valorA,
		nomeDeOutraColuna = valorB
	where nomeDaColuna3 = valorC

**Aten��o!!** se n�o utilizar o 'where' voc� vai atualizar todos os registros da tabela

**Apagar registros**

Apaga todos os itens da tabela
	
	delete 
	from nomeDaTabela

Apaga os registro selecionados

	delete
	from nomeDaTabela
	where nomeDaColuna in(valor1, valor2...)

Obs. 'where' � muito importante!!


# Operadores AND e OR

Os operadores AND e OR podem ser usados, exemplo:

	select *
	from nomeDaTabela
	where nomeDaColuna1 = valor
	AND	  nomeDaColuna2 = valor

Tabelas verdade

AND
1�condi��o| operador | 2� condi��o| resultado|
--|-----|---|--|
V | AND | V | V|
V | AND | F | F|
F | AND | V | F|
F | AND | F | F|

OR
1�condi��o| operador | 2� condi��o| resultado|
--|-----|---|--|
V | OR | V | V|
V | OR | F | V|
F | OR | V | V|
F | OR | F | F|

**Chave prim�ria e estrangeira**

Chave prim�ria � uma forma de identificar um registro, ela deve ser �nica e gera melhor performance na busca, pois faz a indexa��o dos registros

Chave estrangeira faz a rela��o de uma tabela com outra tabela.

Ex.: criar chave prim�ria

	alter table nomeDaTabela add constraint pk_nomeDaChave primary key (nomeDaColuna)

Ex.: criar chave estrangeira

	alter table nomeDaTabela add constrait fk_nomeDaChave (nomeDaColuna) references nomeDaTababela2(nomeDaColuna2)

Obs. Uma chave estrangeira sempre ser� uma c�pia de uma chave prim�ria de mesmo tipo e de mesma quantidade, se a chave prim�ria de uma tabela for uma s� coluna a foreing key (chave estrangeira) ser� uma �nica coluna. Os tipos tamb�m devem ser iguais.


# Normaliza��o de dados

* N�o deve haver colunas repetidas
* N�o deve haver um conjunto de informa��es em apenas uma propriedade;


# Comando Join

O comando join serve para fazer consultas interligando tabelas. � um operador de jun��o que combina colunas de uma ou mais tabelas em um banco de dados relacional.

**inner join** compara cada linha da tabela A com as linhas da tabela B para encontrar todos os pares de linhas que satisfazem a condi��o de jun��o: 

	SELECT <select_list>
	FROM Tabela A
	INNER JOIN Tabela B
	ON A.Key = B.Key

**left join** retorna todos os registros da tabela esquerda e os registros orrespondentes da tabela direita:

	SELECT <select_list>
	FROM Tabela A
	LEFT JOIN Tabela B
	ON A.Key = B.Key

**right join** retorna todos os registros da tabela direita e os registros correspondentes da tabela esquerda:

	SELECT <select_list>
	FROM Tabela A
	RIGHT JOIN Tabela B
	ON A.Key = B.Key

