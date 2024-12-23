# Pattern Criacional

## Factory method pattern

### **Intenção**:

Factory method é um pattern criacional que prove um interface para criação de objetos em um super classe, contudo permite que subclasses permitam alternar
o tipo de objeto que será criado


### **Problema**:

Imagine que você está criando uma aplicação de gerencição de logisticas. A primeira versão do seu app pode somemente lidar com transportação de caminhões, então a maioria
do codigo vive dentro da classe Caminhao.

Apos um tempo, seu app fica muito popular. A cada dia você recebe dezenas de pedidos de empresas transportadoras marinhas para imcorporar logisticas marinha no seu app
Otimas noticia, certo? Mas e o codigo? agora, a maior parte do seu codigo esta coplado a classe caminhao. Adcionando Barcos no seu app iria requirir fazer mudanças para o
seu projeto inteiro. Contudo, if depois você decidir adcionar outro meio de transporte no seu app, você ira provavelmente fazer mudanças denovo.

Como resultado, você ficara com um codigo tão spagetificado que é melhor jogar fora e começar denovo.

### **Solução**:

O Factory method pattern sugere que você substitua a chamada de criação direta(usando o operador new) por uma chamada especial. Não se preocupe: os objects continuam sendo
criado pelo operator new, mas são chamada dendro de um metodo fabrica. Objetos retornado por um factory methodo são geralmente chamados de produtos.

A primeira vista, essa mudança parece inutil, so moveu-se a chamada do construtor de uma parte do programa para outra. Contudo, considere que agora você consegue dar um override 
no factory method em uma subclasse e mudar a classe de produtos sendo criada pelo metodo.

Tem uma pequena limitação, a subclasse pode retornar diferentes tipos de produtos se esses produtos possuem uma classe ou interface comun. Tambem, o factory method na base class
deve ter seu retorno como o tipo declarado na sua interface



## Codigo:

### Descrição de Exemplo: Tipos de impressoras, e cada fabrica cria a impressora que nescessita.

IPrinter.cs{
 interface de oque a impressora deve imprimir

 propriedades Nome e Quantidade

 methodos Impressao()
}

ImpressoraDeDinheiro.cs{

Implementação concreta de IPrinter

Propriedade Nome recebe o nome do dinheiro sendo impresso
Propriedade Quantidade Recebe o quanto deve ser imprimido

methodos Impressao() retorna o quanto foi imprimido

}

Impressora3D.cs{

Implementação concreta de IPrinter

Propriedade Nome recebe o nome da carne falsa sendo imprimida
Propriedade Quantidade Recebe o quanto deve ser imprimido

methodos Impressao() retorna o quanto foi imprimido

}


Impressor.cs{
Classe abstrata, é quem cria as fabrica

Metodo abastrato FactoryMethod que retorna um IPrinter

metodo ResultadoImpressao() que imprime o resultado da impresão ao criar um produto
}

Governo.cs{
Implementação concreta de Impressor

Override no Factory method para criar uma nova instancia de ImpressoraDeDinheiro
}

CarneVegana.cs{
Implementação concreta de Impressor

Override no Factory method para criar uma nova instancia de Impressora3D

}

Program.cs da linha 30 à 33{
Cria instancia de CarneVegana chamada veganMeat
Cria instancia de Governo chamada brazil
Chama o resultado de impressão de veganMeat
Chama o resultado de impressão de brazil

}

[Refactoring guro factory method](https://refactoring.guru/design-patterns/factory-method)