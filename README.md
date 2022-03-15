# Servico.Ordenacao
Serviço para ordenação dinâmica
O serviço se propõe a ordenar uma quantidade de livros de forma dinâmica, sendo essa ordenação por uma ou mais de uma propriedade.
Para a realização desse processo foi criado um console Application com as seguintes camadas :
 1 - Camada de execução. 
    1.1 - Responsável por executar o projeto com as primeiras regras propostas.
    1.2 - Chamada para a camada e negocio por meio de Injeção de dependência ( A injeção de dependência foi criada para que fosse possível evoluir de forma mais facil a camada de teste)
    1.3 - responsável por printar e tela a resolução do problema inicial
    1.4 - Criação do Objeto livro inicial.
 2 - Camada de Negocio:
    2.1 - Responsável por realizar as regras de ordenação conforme parâmetros de entrada.
    2.1 - realiza validação no objeto de entrada
 3 - Camada intermediaria:
    3.1 - Realiza a injeção dependência 
    3.2 - Camada repensável por intermediará informações de outras camadas.
    
 4 - Teste unitário utilizando Xunit.
