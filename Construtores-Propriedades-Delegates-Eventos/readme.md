# Objetivo do curso

Apresentar como funciona um construtor, seu uso e funcionalidades, tipos e modos de usar na linguagem C#.

Apresentar também delegates e eventos.

## Construtores

Um construtor é um método especial, que contém o mesmo nome do seu tipo classe, e tem o objetivo de definir valores padrão, limitar uma instância e facilitar a instaciação de um objeto.

- Um construtor não possui retorno
- Um construtor padrão é sempre definido quando não declaramos nenhum para sua classe.
- Uma classe pode ter mais de um construtor

# Criando exemplo:

No terminal 

    dotnet new sln --name ExemploConstrutores

Em seguida

    dotnet new console --name ExemploConstrutores

## Get e Set

O Get e o Set serve para que você posso atribuir um valor em uma variável de maneira controlada e com validações.

## Modificadores

O Modificador **Readonly** (Somente leitura) bloqueia um campo contra alterações que não sejam em sua inicialização ou pelo próprio construtor.

Uma **Constante** representa um valor que somente pode ser atribuído no momento de sua inicialização, e não pode ser modificado posteriormente.

Um **Delegate** é uma maneira de passar um método como referênciia, podendo ser usado como um callback, aceeitando qualquer método que contenha a mesma assinatura.

**Eventos** é um mecanismo de comunicação entre objetos, onde existe um publisher, que realiza o evento e o subscriber, que se inscreve em um evento.





