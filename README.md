# Design patterns

O codigo esta organizado da seguinte forma.

Program.cs é o main file, que quando executado, nesse arquivo esta apenas um exemplo concreto de cada pattern.

Cada pattern está organizado em sua pasta especifica, com um readme explicando oque o pattern é.

foi usando [Refactoring guru](https://refactoring.guru/usando)

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

# Pattern Estrutural

## Bridge pattern

### **Intenção**:

Bridge é um design pattern estrutural que te deixa dividir uma grande classe ou uma coleção de classes relacionadas in duas hierarquias separadas - abastração e implementação -
na qual podem se desenvolver independentes entre si.

### **Problema**:

Abstração? Implementação? aparece assustador? Fique calmo e vamos considerar um exemplo simples.

Digamos que você tem um classe Forma com um par de subclasses: Circulo e Quadrado. Você quer extender essa classe para que a hierarquia imcorpore cores, então você planeja 
criar uma forma Azul e Vermelho subclasses. Contudo, como você já tem duas subclasses, você tera que criar quatro combinações como CirculoAzul e QuadradoVermelho.

Adcionando novas formas e core para a hierarquia irá faze-la crescer exponencialmente. Adcionando uma forma Triangulo, você tera que adcionar duas subclasses para cada cor.
Se você adcionar outras cores mais subclasses surgiram.

Basicamente um herança dando problemas de herança.


### **Solução**:

O probelma ocorre quando estamos tentando extender a class Forma nesse caso em duas dimensões independentes, for forma e por cor. Isso é um problema com herança.

O bridge pattern tenta resolver o problema usando composição ao invez de herança. Separa uma das dimensão da classe para uma classe separada, assim o objeto apenas contem oque
ele prescisa.

Seguinto essa forma, nos podemos extrair o codigo relacionado a cor em sua propia classe com duas subclasses, Vermelho e Azul. A classe Forma então recebe uma refecencia para o
objeto Cor. Agora a forma pode delegar qualquer trabalho relacionado cor ao objeto linkado. Essa referencia será a ponte entre as classes Forma e Cor. De agora em diante,
adcionar novas cores não irá requerer modificar a hieraquia da forma e vice versa.

No contexto desse patern, abstração ou interface se refere a uma camada de controle para alguma entidade, algo que não faz nada em si mesmo, como uma GUI, já a implementação é
alog que realmente faz algo, tipo a API de um app. Então a abstração deve delegar o trabalho para a implementação.

Basicamente é uma forma de dizer pra preferir composição ao invez de herança.

## Codigo:

### Descrição de Exemplo: Video games que podem rodar em qualquer sistema operacional

IPlatform.cs{
interface que server como um sistema operacional deve rodar o game

Propriedade Name, nome do sistema

Metodo RunGame() como se deve rodar o game
}

Bintows12.cs{
Implementação concreta de IPlatform

Prorpiedade Name recebe "Bintows12"

Metodo RunGame() roda um game qualquer no sistema operacional Bintows12
}

Bubunto.cs{
Implementação concreta de IPlatform

Prorpiedade Name recebe "Bubunto"

Metodo RunGame() roda um game qualquer no sistema operacional Bubunto
}

Game.cs {
Classe abstrata que representa um vidoe game qualquer.

Tem um propriedade que recebe um IPlatform

metodo Operation(), chama o RunGame de Iplatform 
}

Chess2.cs {
implementação concreta de Game

metodo operation tome override pra dizer que esta rodando em tal platforma
}

MeguminAdventures.cs {
implementação concreta de Game

metodo operation tome override pra dizer que esta rodando em tal platforma
}

Program.cs da linha 37 até 46{
Cria intancia de Bintows12 chama bintows12
Cria intancia de Bubunto chama bubunto
Cria instancia de MeguminAdventures que sera rodando no Bubunto, chamada meguminBubunto e recebe bubunto no constructor
Cria instancia de MeguminAdventures que sera rodando no Bintows12, chamada meguminBubunto e recebe bintows12 no constructor
Cria instancia de Chess2 que sera rodando no Bubunto, chamada chess2Bubunto e recebe bubunto no constructor
Cria instancia de Chess2 adventures que sera rodando no Bintows12, chamada chess2Bubunto e recebe bintows12 no constructor
Chama o metodo operation() de cada instancia de Game
}

[Refactoring guru Bridge](https://refactoring.guru/design-patterns/bridge)

# Pattern comportamental

## Observer pattern

### **Intenção**:

Observer pattern é um padrão comportamental, que deixa você definir um mecanismo de assinatura para notificar multiplos objetos sobre quaisquer eventos, que ocorreram em tal objeto
sendo observado

### **Problema**:

Imagine que tu possua dois tipos de objetos, um Cliente e um Loja. O cliente é super interesado em uma marca particular de um produto(O novo modelo do iPhone por exemplo) que deve
estar disponivel nas lojas em breve.

O Cliente poderia visitar a loja todo o dia e conferir a disponivilidade do produto. Contudo, enquanto o produto está em tramite, a maioria das visitas seriam sem sentido.

Por outro lado, a loja poderia enviar multiplos emails(que podem ser considerados spam) para todos os seus clientes cada vez que um novo produto esteja disponivel. Issou iria
salvar de alguns clientes de uma ida continua à loja. Ao mesmo tempo porém, isso iria deixar muitos clientes insastisfeitoz, feito que muitos não estão interessados no produto.

Parece que temos um conflito. Ou o cliente desperdica o seu tempo conferindo a disponivilidade do produto ou a loja desperdica recursos notificando os clientes não interessados.

Basicamente, temos um objeto de tipo qualquer, Loja por exemplo. esse objeto quer notificar objetos de outro tipo, cliente por exemplo, que algo aconteceu, contudo, o objeto Loja não quer
notificar todoas as instancias do tipo cliente, mas somente os clientes que estão inscritas em um lista. Assim, quando algo acontecer na loja, a loja so notifica aquelas instancias de cliente
que aquilo aconteceu.


### **Solução**:

O objeto que tem um estado interessante é geralmente chamado de subject, mas como este também é quem irá notificar outros objetos sobre sua mudança de estado, chamaremos-o de
publisher. Todos os outros objetos que queiram saber de mudanças do estado do publisher são chamados de subscribers.

O observer pattern sugere que você adcione um mecanismo de assinatura para a class publisher para que, objetos indiviuais possam se increver or se desemcrever da linha de eventos
vindo do publisher. Não tema! Tudo não é complicado como parece. Na realidade, esse mecanismo consiste em 1) um vetor para guarda a lista de referencias dos objetos incritos e 2)
Vários methodos publicos que permite adcionar e remover inscritos da lista.


Criar duas interfaces, uma para os Subscribers/ observers e outra para o Publisher. na Publisher contem methodos de adcionar, remover e notificar. Na observer um methodo que sera chamado
pela publisher ao ser notificado.

Na implementação concreta do observer, apenas implementar o metodo que será chamado quando for notificado de mudança pela publisher.
Na implementação concreta da Publisher, implementar um vetor que guarda todos os objetos inscritos. Implementar o metodo de adcionar, remover e notificar os subscribers da lista.

Nota: Em c# há uma forma de implementar basicamente a mesma coisa por meio de delegates, contudo a versao usando interface é uma forma mais generica.


## Codigo:

### Descrição de Exemplo: Youtuber notificando seus inscritos que postou um video novo

INotifier.cs{

interface exemplo de uma publisher

com metodos

Subscribe, UnSubscribe e Notify
}

Youtuber.cs{
Exemplo concredo de um INotifier

Possue um private fiel que é a lista de seus subscribers

Metodo Subscribe() adciona um novo subscriber a list
Metodo UnSubscribe() remove um subscriber da list
Metodo Notify() loopa pela lista de subscribers e chama o metodo Update() de cada um
}

IObserver.cs{

interface exemplo de um observer

com metodo Update()

}

Inscrito.cs{

Exemplo concreto de um IObserver

Metodo Update() é overrided para printar que algum video novo foi lançado
}

Program.cs da linha 16 à 27{
Cria uma instancia Youtuber chamada enaldinho
Cria 3 instancia inscrito, Incrito1, Inscrito2 e Inscrito3
instancia Enaldinho inscreve cada inscrito respectivamente.
instancia Enaldinho desemscreve o incrito2
Enaldinho avisa aos incritos
}

[Refactoring guru observer](https://refactoring.guru/design-patterns/observer)

