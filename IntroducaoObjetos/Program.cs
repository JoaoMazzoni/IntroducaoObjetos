
Pessoa pessoa = new Pessoa(); //Instanciando o objeto "pessoa".

pessoa.Nome = pessoa.definirNome(); //Indicando quem vai receber o retorno do método | "pessoa.Nome" vai receber o dado inserido em "pessoa.definirNome"
pessoa.Idade = pessoa.definirIdade(); //Indicando quem vai receber o retorno do método | "pessoa.Idade" vai receber o dado inserido em "pessoa.definirIdade"

Console.WriteLine(pessoa.Nome); //Imprime os dados salvos no objeto "pessoa" no atributo "Nome".
Console.WriteLine(pessoa.Idade);