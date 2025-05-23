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

**Override-** Serve para sobreescrever um código da classe pai, se eu chamar um metodo da classe pai já com um valor se eu quiser sobreescrever o mesmo preciso usar o override e o metodo para ser sobreescrito precisa ser declarado com o **Virtual**.

**Modificadores de acesso:**
- **Private -** Só é visível dentro da classe, qualquer coisa criada sem informar o modificador de acesso tem como padrão ser **Private**
- **Protected -** É transmitido por herança. quando um membro for Protected caso alguém precise acessar o mesmo antes precisara realizar uma herança.
- **Internal -** Só podera ser acessado dentro do projeto.
- **Public -** Qualquer lugar até fora do projeto podera usar os membros declarados como publico (variavel, metdo, calass e afins).

**Tipos Complexos -** São as coisas que nos criamos que não veem por padrão do .NET por exemplo as **classes**, diferente das string, int, double que são built in types coisas que já são do .NET

**Propriedades -**  Propriedades tem informado os acessores **{Get; Set;}**. Variaveis não tem os acessores informados.

**Métodos**
- **Sobrecarga de Métodos -** São os métodos com o mesmo nome porém com uma assinatura diferente. (O metodo recebe diferentes propriedades)
- **SobreEscrita de Método -** Para o método ser sobreescrito o metodo original tem que ser criado com Virtual e o método que vai sobreescrever ele precisa ter o Override.
- **Para chamar um método do pai -** Base.NomeDoMetodo
- **Método Construtor -** Ele é criado com o mesmo nome da classe , é criado assim que a classe for instânciada. instancia é a criação do objeto usando a classe como molde.

**garbage collector -** Ele roda automaticamente aplicações .NET e fica verificando na memória se tem algum objeto criado que não esteja em uso, caso não esteja em uso ele exclui esse objeto da memória liberando espaço.

**Using e Dispose -** **Dispose** é utilizado para destruir um objeto após ele já ter sido utilizado. **Using** quando eu faço algo dentro do using ele irá criar o objeto e ao final destruir ele. Geralmente usamos o using quando vamos acessar o banco de dados assim ele cria a conexão com o banco de dados e depois destroi esse objeto assim liberando o acesso ao banco para outro usuário.

**Upcast/Downcast -** Upcast seria eu eu ter uma variavel do tipo da classe pai e nessa mesma variavel eu conseguir colocar um objeto da classe filha, isso acontece pq a classe filha herda a classe pai com isso tem as mesmas propriedades e metodos. Downcast seria o contrário a variavel ser do tipo da classe filha e a mesma receber um objeto do tipo da classe pai.

**Classes**
- **Classe Estática -** Quando a classe for marcada com Static siginifca que ela não pode ser instânciada, assim que a aplicação for iniciada essa classe já será registrada na memória.
- **Classe Selada -** Quando a classe for marcada com Sealed ela é selada e não poderá ser feito a herança.
- **Partial Class -** Quando a classe for marcada com Partial significa que eu divido a minha classe, sendo assim eu posso ter a mesma classe em dois arquivos diferentes.
- **Interfaces -** Quando é uma Interface significa que vai ser um contrato ela NÃO irá conter as funcionalidades ela apenas monta a estrutura do método, a classe que faz a implementação desses metodos.
- **Classes Abstratas -** Quando a classe for marcada com Abstract significa que a classe não pode ser instânciada, ela servirá apenas para ser herdada pelas demais classes.

**Comparando Objetos -** Na minha classe eu faço ela herdar o **IEquatable<Classe>** e ao implementar o IEquatable dentro dele eu faço a validação dos objetos dando um return se é True ou False, se for fazer ObjetoA == ObjetoB a validação será feita por referência de memória e sempre irá retornar false.

**Delegates -**  Quando o metodo é marcadao com delegate significa que a implementação do metodo sera feita por outro metodo é uma função que aponta para outra função elas precisam ter a mesma estrurura de privacidade e assinatura podendo ter outro nome.

**Generics(<>) -** Permitem que você escreva classes, métodos, interfaces e structs que funcionam com tipos genéricos, ou seja, você só define o tipo na hora de usar.

**Listas**
- **IEnumerable -** é a lista mais simples só tem como fazer consulta na lista.
- **IList -** tem como inserir, remover, adicionar itens na lista.

**Tipo de Lista / Coleção	Situação Ideal de Uso**
- **List<T> -** Quando precisa adicionar/remover dados livremente e acessar por índice
- **Array     -** Quando tem um número fixo de elementos e quer mais performance
- **HashSet<T> -** Quando não pode haver itens duplicados e precisa de performance em buscas
- **Dictionary<TKey, TValue> -** Quando precisa armazenar pares chave/valor e acessar rapidamente por chave
- **Queue<T> -** Quando precisa de uma fila (FIFO: primeiro a entrar, primeiro a sair)
- **Stack<T> -** Quando precisa de uma pilha (LIFO: último a entrar, primeiro a sair)
- **ObservableCollection<T> -** Quando precisa que a lista notifique mudanças (ex: interface WPF/Blazor)
- **IEnumerable<T> -** Quando quer apenas iterar sobre os dados em memória
- **IQueryable<T> -** Quando quer montar uma consulta dinâmica (ex: com Entity Framework)