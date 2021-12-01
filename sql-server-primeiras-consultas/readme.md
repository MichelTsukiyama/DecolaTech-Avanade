# O que são bancos de dados?

São dados/informações armazenados em algum lugar.
Ex.: Uma planilha de excel pode ser um banco de dados, se você tiver nele informaçõees de clientes, produtos, etc. Estas informações serão utilizadas ou consultadas posteriormente;

# O que são SGBDs

SGBDs são sistemas de gerenciamento de banco dee dados.

# Tipos de bancos de dados

**Relacionais**: SQL Server, Oracle, MySQL...
**NoSQL**: MongoDB, Neo4j, Firebase...

Bancos relacionais são usados quando é necessário uma confiabilidade muito alta nos dados ou um forte controle. Ex.: informações de compras e vendas, controle de estoquee etc.
Bancos NoSQL são voltados para melhor performance e grandes quantidades de dados, armazenamento de vídeos, imagens, links...

# Representação banco relacional

Em um banco relacional constituído por tabelas, podemos imaginar como no excel. As linhas são os registros, com IDs esclusivos chamados de chave, já as colunas contêm atributos dos dados.

O banco é formado por entidades e atributos. Que podem ser representados de maneira semelhante a fluxogramas.

Os atributos possuem tipo, podendo ser int(inteiro), varchar(string), bit(binário/booleano)...

**Atomicidade**: garantir que todos os dados estão corretos para ser inserido dentro de uma tabela.

**Consistência dos dados**: Há a confiabilidade de que os dados estarão sempre iguais, mesmo ao se utilizar mais de uma base de dados.

# Instalação

Faça o donwload da versão Express [nesta página](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) ou clique [aqui](https://go.microsoft.com/fwlink/?linkid=866658) para iniciar o download.

Execute o arquivo baixado, selecione a instalação básica e aceite os termos de licença e clique em instalar.
Obs. Salve em um bloco de notas ou outro lugar o campo "cadeia de conexão", será usado posteriormente.

Após a instalação, selecionar **Instalar o SSMS** ou faça o donwload [nesta página](https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN&view=sql-server-ver15) ou [clique aqui](https://aka.ms/ssmsfullsetup) para iniciar o download.
SSMS é um ambiente inteegrado para gerenciar qualquer infraestrutura de SQL, fornecendo ferramentas para cconfigurar, monitorar e administrar instâncias do SQL Server e bancos de dados.

Execute o arquivo e selecione **Instalar**, após a instalação reinicie seu computador.

Após reiniciar abra o SQL Server Management Studio e após selecione conectar.

# Conceito iniciais

**Para criar um novo banco de dados**

No menu lateral, clique com o botão esquerdo na pasta banco de dados, "novo banco de dados"
Pela linha de comonado:
	
	create database nomeDoBanco

Após utilize o "refresh" no menu lateral ou "F5" para atualizar o conteúdo e visualizar o banco

**Para excluir um banco de dados**

No menu lateral, clique com o botão esquerdo na pasta com o nome do banco a ser excluído e selecione "excluír"

**Alternando bancos de dados**

Para alternanar entre bancos (semelhante a trocar branchs no GitHub desktop), selecione no menu superior a caixa onde está escrito "master" e clique no banco desejado
Pela linha de comando (semelhante a trocar branchs no Git):

	use nomeDoBanco

**Criar tabelas**

Clique com o botão direito na pasta tabela, selecione "novo", "tabela";
Complete os dados "coluna", "tipo de dados" e "null"
Salve a tabela
Na linha de comando:

	create table nomeDaTabela
	(
		nomeDaColuna tipoDeDado(tamanho) null,
		Descricao varchar(50) not null,  <= exemplo
	)

Obs. bancos relacionais são altamente tipados

**Tipos**
* int - números inteiros
* bigint - números inteiros com muitos caracteres
* float - números com ponto flutuante, ex.: 2.12
* varchar(tamanho) - caracteres alfanuméricos (o tamanha varia até o limite colocado nos parenteses)
* char(tamanho) - caracteres alfanuméricos (tamanho fixo, se coloca um único caractere, ele completa o resto com espaços vazios)
* bit - apenas 0 ou 1
* datetime - data

**null e not null**

* null - aceita valores nulos
* not null - não aceita valores nulos.
Obs. null é um valor vazio

**Apagar tabelas**

Na linha de comando:

	drop table nomeDaTabela

# Comandos

**Selecionar tabela**

	select * from nomeDaTabela

Obs.: Vc pode selecionar o nome da tabela e usar alt + f1 para ver mais informações

**Inserir dados na tabela**

	insert into nomeDaTabela (nomeDacoluna, nomeDaColuna) values (123, 'abc');

Se você omitir os nomes das colunas, ele vai inserir os dados de acordo com a ordem das colunas na tabela.

	insert nomeDaTabela values (123, 'abc')

Obs. também é possivel omitir o into
**Mas o ideal é sempre colocar o nome da coluna**

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

**Atenção!!** se não utilizar o 'where' você vai atualizar todos os registros da tabela

**Apagar registros**

Apaga todos os itens da tabela
	
	delete 
	from nomeDaTabela

Apaga os registro selecionados

	delete
	from nomeDaTabela
	where nomeDaColuna in(valor1, valor2...)

Obs. 'where' é muito importante!!


# Operadores AND e OR

Os operadores AND e OR podem ser usados, exemplo:

	select *
	from nomeDaTabela
	where nomeDaColuna1 = valor
	AND	  nomeDaColuna2 = valor

Tabelas verdade

AND
1ªcondição| operador | 2ª condição| resultado|
--|-----|---|--|
V | AND | V | V|
V | AND | F | F|
F | AND | V | F|
F | AND | F | F|

OR
1ªcondição| operador | 2ª condição| resultado|
--|-----|---|--|
V | OR | V | V|
V | OR | F | V|
F | OR | V | V|
F | OR | F | F|

**Chave primária e estrangeira**

Chave primária é uma forma de identificar um registro, ela deve ser única e gera melhor performance na busca, pois faz a indexação dos registros

Chave estrangeira faz a relação de uma tabela com outra tabela.

Ex.: criar chave primária

	alter table nomeDaTabela add constraint pk_nomeDaChave primary key (nomeDaColuna)

Ex.: criar chave estrangeira

	alter table nomeDaTabela add constrait fk_nomeDaChave (nomeDaColuna) references nomeDaTababela2(nomeDaColuna2)

Obs. Uma chave estrangeira sempre será uma cópia de uma chave primária de mesmo tipo e de mesma quantidade, se a chave primária de uma tabela for uma só coluna a foreing key (chave estrangeira) será uma única coluna. Os tipos também devem ser iguais.


# Normalização de dados

* Não deve haver colunas repetidas
* Não deve haver um conjunto de informações em apenas uma propriedade;


# Comando Join

O comando join serve para fazer consultas interligando tabelas. è um operador de junção que combina colunas de uma ou mais tabelas em um banco de dados relacional.

**inner join** compara cada linha da tabela A com as linhas da tabela B para encontrar todos os pares de linhas que satisfazem a condição de junção: 

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

