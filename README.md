# GameRPG
Jogo do Naruto no estilo RPG.

### Game criado para exercitar os quatro pilares da POO:
- Herança;
- Encapsulamento;
- Polimorfismo;
- Abstração.

### Abstração:

É o ponto de partida, onde foi criada a classe Ninja com as principais propriedades e métodos que serão reaproveitadas pelas classes EvilNinja e GoodNinja.  

### Herança:

Como dito, as classes EvilNinja e GoodNinja reutilizaram o código da classe Ninja através do conceito de herança, com isso elas herdaram todas as propriedades e métodos da classe Ninja.

### Polimorfismo:

Por meio do conceito de herança, ao herdar os métodos da classe Ninja, foi possível utilizar o conceito do polimorfismo sobrescrevendo alguns alguns métodos. Os métodos continuam com a mesma assinatura, porém, com comportamentos diferentes.  

### Encapsulamento:

Foram utilizados os modificadores de acesso public, protected e private.
Protected foi utilizado nas propriedades da classe Ninja. O acesso a essas propriedades só é permitidos na própria classe Ninja e nas classes que à herdam.
Private foi utilizado na classe EvilNinja. O acesso a essas propriedades só é permitido na própria classe.
Propriedades e métodos com public podem ser acessados diretamente de qualquer lugar.
