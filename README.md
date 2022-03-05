# ProjetoDioAbstracao
## Projeto DIO - Criação de um repositório abstraindo um menu com orientação a objetos.

### Class abstract Menu
- Codificado  métodos para armazenar o  nome (*Name*), ano de lançamenro (*Year*) e gênero do filme (*Genre*).
- Codificado método (*override string ToString()*) para retornar o valor que for dado as var. 
- Codificado método (*public virtual string Synopsis()*) para exibir sinopse do filme.

### Class *Comedy*, *Horror*, *Romance* e *Thriller* (Herdam class abstract Menu)
- Contém a class para criação do objeto *Name* *Year* e *Genre* no MAIN.
- Feito o polimorfismo da class *Synopsis( )* para especificar a sinopse de cada filme.

### Main 

 - Codificado a criação do objeto *Name*, *Year* e *Genre* para cada class (*Comedy*, *Horror*, *Romance* e *Thriller*) atribuindo um valor a cada um.
 - Codificado um while para o usuario navegar nos generos.
 - Codificado  na tela opções para o usuario - de qual genero assistir com a codificão de uma var int *number* para receber o numero de opção do usuario.
 - Codificado um switch para interação desta opção do usuario - ira ser exibido os objetos *name*, *year*, *genre* e  a *synopis()*.
 - Default do switch exibe mensagem para a validação caso o usuario digite um valor invalido no *number*.
 - Codificado if para validação do usuario entrar na opção de iniciar a sessão do filme - sair do while - somente se o *number* for valido.
 - Exibição de mensagem de "Boa sessão" para o usuario.
**fim**



