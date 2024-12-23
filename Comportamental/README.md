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