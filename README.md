SHOW DO MILHÂO - Requisitos

### Requisitos Funcionais 
Se refere a uma funcionalidade específica do sistema, 
ou seja, uma ação que o sistema deve ser capaz de realizar.

### Regras de Negócios
Se refere as regras e validações da aplicação, sendo elas
Validação de senha ou chaves, autenticação, permissões, o que se
pode ou não fazer.

### Requisitos Não-Funcionais 
Se refere a uma característica ou qualidade do sistema, 
como desempenho, segurança, usabilidade, confiabilidade, etc.

# Funcionais

	- [X] Deve ser possivel digitar seu nome
	- [X] Deve ser possivel salvar sua pontuação
	- [X] Deve se ter 4 alternativas para cada questão
	- [X] Deve se possivel pedir ajudar das Cartas, dos Universitários e Remover alternativas
	- [X] Se errar, a pontuação deve ser 1/4 do valor da pergunta atual
	- [X] Deve ser possivel desistir, caso a dessistencia, ficará com a metade do valor atual.

# Regras de Négocios

	- [X] Não pode escolher outra alternativa além de "A, B, C, D"
	- [X] Cada ajuda só pode ser escolhida 1 vez

# Não Funcionais

	- [X] As ordem das perguntas devem ser aleatórias
	- [X] Deve ser possivel armazenar a pontuação do usuário
	- [X] Deve ter 15 perguntas cada partida e total de 30 perguntas armazenadas.
	- [X] Cada pergunta será gerada aleatoriamente, de acordo com o indice onde ela se encontrar
	- [X] A Resposta do usuario será do tipo 'CHAR', em caso de digito de uma 'String', deve-se 
	tratar o erro e faze-lo digitar novamente (while).
	- [X] Colocar cores no Console para cada sessão, incluido acertos, erros e desistencia.