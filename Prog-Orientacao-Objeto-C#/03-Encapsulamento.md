# Encapsulamento

O encapsulamento serve para proteger uma classe e definir limites para alteração de suas propriedades.

Serve para ocultar seu comportamento e expor somete o necessário.

**Tabela Resumo**

Local do chamador|public|protected internal|protected|internal|private protected| private|
-----------------|------|------------------|---------|--------|-----------------|--------|
Dentro da classe|x|x|x|x|x|x|
Classe derivada (mesmo assembly)|x|x|x|x|x|-|
Classe não derivada (mesmo assembly)|x|x|-|x|-|-|
Classe derivada (assembly diferente)|x|x|x|-|-|-|
Classe não derivada (assembly diferente)|x|-|-|-|-|-|

