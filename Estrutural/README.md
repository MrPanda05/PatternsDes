Pattern Estrutural

Bridge pattern

Intenção:

Bridge é um design pattern estrutural que te deixa dividir uma grande classe ou uma coleção de classes relacionadas in duas hierarquias separadas - abastração e implementação -
na qual podem se desenvolver independentes entre si.

Problema:

Abstração? Implementação? aparece assustador? Fique calmo e vamos considerar um exemplo simples.

Digamos que você tem um classe Forma com um par de subclasses: Circulo e Quadrado. Você quer extender essa classe para que a hierarquia imcorpore cores, então você planeja 
criar uma forma Azul e Vermelho subclasses. Contudo, como você já tem duas subclasses, você tera que criar quatro combinações como CirculoAzul e QuadradoVermelho.

Adcionando novas formas e core para a hierarquia irá faze-la crescer exponencialmente. Adcionando uma forma Triangulo, você tera que adcionar duas subclasses para cada cor.
Se você adcionar outras cores mais subclasses surgiram.

Basicamente um herança dando problemas de herança.


Solução:

O probelma ocorre quando estamos tentando extender a class Forma nesse caso em duas dimensões independentes, for forma e por cor. Isso é um problema com herança.

O bridge pattern tenta resolver o problema usando composição ao invez de herança. Separa uma das dimensão da classe para uma classe separada, assim o objeto apenas contem oque
ele prescisa.

Seguinto essa forma, nos podemos extrair o codigo relacionado a cor em sua propia classe com duas subclasses, Vermelho e Azul. A classe Forma então recebe uma refecencia para o
objeto Cor. Agora a forma pode delegar qualquer trabalho relacionado cor ao objeto linkado. Essa referencia será a ponte entre as classes Forma e Cor. De agora em diante,
adcionar novas cores não irá requerer modificar a hieraquia da forma e vice versa.

No contexto desse patern, abstração ou interface se refere a uma camada de controle para alguma entidade, algo que não faz nada em si mesmo, como uma GUI, já a implementação é
alog que realmente faz algo, tipo a API de um app. Então a abstração deve delegar o trabalho para a implementação.




Basicamente é uma forma de dizer pra preferir composição ao invez de herança.



Codigo:

Exemplo: Video games que podem rodar em qualquer sistema operacional





https://refactoring.guru/design-patterns/bridge










https://refactoring.guru/design-patterns/bridge