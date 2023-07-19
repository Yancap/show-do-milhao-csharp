SHOW DO MILH�O - Requisitos

### Requisitos Funcionais 
Se refere a uma funcionalidade espec�fica do sistema, 
ou seja, uma a��o que o sistema deve ser capaz de realizar.

### Regras de Neg�cios
Se refere as regras e valida��es da aplica��o, sendo elas
Valida��o de senha ou chaves, autentica��o, permiss�es, o que se
pode ou n�o fazer.

### Requisitos N�o-Funcionais 
Se refere a uma caracter�stica ou qualidade do sistema, 
como desempenho, seguran�a, usabilidade, confiabilidade, etc.

# Funcionais

	- [X] Deve ser possivel digitar seu nome
	- [X] Deve ser possivel salvar sua pontua��o
	- [X] Deve se ter 4 alternativas para cada quest�o
	- [X] Deve se possivel pedir ajudar das Cartas, dos Universit�rios e Remover alternativas
	- [X] Se errar, a pontua��o deve ser 1/4 do valor da pergunta atual
	- [X] Deve ser possivel desistir, caso a dessistencia, ficar� com a metade do valor atual.

# Regras de N�gocios

	- [X] N�o pode escolher outra alternativa al�m de "A, B, C, D"
	- [X] Cada ajuda s� pode ser escolhida 1 vez

# N�o Funcionais

	- [X] As ordem das perguntas devem ser aleat�rias
	- [X] Deve ser possivel armazenar a pontua��o do usu�rio
	- [X] Deve ter 15 perguntas cada partida e total de 30 perguntas armazenadas.
	- [X] Cada pergunta ser� gerada aleatoriamente, de acordo com o indice onde ela se encontrar
	- [X] A Resposta do usuario ser� do tipo 'CHAR', em caso de digito de uma 'String', deve-se 
	tratar o erro e faze-lo digitar novamente (while).
	- [X] Colocar cores no Console para cada sess�o, incluido acertos, erros e desistencia.