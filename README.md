# ProjetoDioAbstracao
## Projeto DIO - Criação de um repositório abstraindo um menu com orientação a objetos.

### class abstract Menu
- Codificado  métodos para armazenar o  nome (*Name*), ano de lançamenro (*Year*) e gênero do filme (*Genre*).
- Codificado método (*override string ToString()* para retornar o valor que for dado as var. 
- Codificado método (* public virtual string Synopsis()*) para exibir sinopse do filme.

### class *Comedy*, *Horror*, *Romance* e *Thriller* (Herdam class abstract Menu)
- Contém a class para criação do objeto *Name* *Year* e *Genre* no MAIN.
- Feito o polimorfismo da class *Synopsis()* para especificar a sinopse de cada filme.

### Main 

 - Codificado o objeto *Name* *Year* e *Genre* para cada class (*Comedy*, *Horror*, *Romance* e *Thriller*) atribuindo um valor cada um.
 - Codificado um while para o usuario navegar nos generos.
 - Codificado  na tela opções para o usuario - de qual genero assistir com a codificão de uma var int *number* para receber o numero de opção do usuario.
 - Codificado um switch para interação desta opção do usuario - ira ser exibido os objetos *name* *year* *genre* e  a *synopis()*.
 - default do switch codifica a solução de um problema caso o usuario digite um valor invalido no *number*.
 - codificado no if interação para o usuario navegar entre os generos ou iniciar a sessão do filme - sair do while.
 - exibição de mensagem de "Boa sessão" para o usuario.
**fim* 



