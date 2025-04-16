É a representação do mundo real dentro de uma aplicação.

**Objeto** - Ele é composto de propriedades(Altura, Largura, Cor, Peso….), Métodos(Ex Microfone: Gravar Som, Reproduzir Som, Ajustar Volume) e Eventos(Ao começar a gravar fazer algo, ao clicar no botão de mute fazer outra coisa) e é um tipo de referência irá ter a referência do endereço onde se encontra o dados irá pegar os dados na memoria **HEAP**, enquanto as referência por valor pega na memória **STACK**.

**Class x Struct** - Class armazena uma referência de endereço de memória, a Struct armazena o dado em sí.

**Classe x Objeto** - A classe é um molde para o objeto.

Os 4 pilares da orientação a objetos são:
**Encapsulamento** - agrupar as informações que fazem sentido estarem juntas se eu tiver uma classe de produto não faz sentido ter variavel e métodos relacionado a temperatura.
**Abstração** - Esconder as informações que não queremos mostrar do nosso objeto, para esconder utilizamos o Private sendo assim só a classes onde o objeto está terá acesso as informações classes externas não terão acesso.
**Herança** - É capacidade de um objeto herdar propriedades, métodos e eventos de outro objeto mesmo elas sendo privadas.
**Polimorfismo** - Ele pode ser divido em duas partes Estatica e Dinamico
- Estatica - Funciona como uma sobrecarga de metodo, dois metodos com o mesmo nome dentro do mesmo contexto porém com a assinatura diferente.
- Dinamico - Serve para instancaiar um tipo mais especifico para atribuir um tipo mais generico.
