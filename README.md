### 1 Especifica��o do Problema
	Son Goku � um poderoso Saiyajin (ra�a de poderosos guerreiros). Ele est� na busca pelas 7 esferas do
drag�o1 com o objetivo de ressuscitar seu amigo Kuririn que foi morto por Freeza.

	Goku j� reuniu 6 das 7 esperas. Ele descobriu que a �ltima esfera do drag�o est� em uma caverna
escondida nos confins da selva. At� hoje nenhum guerreiro conseguiu recuperar a esfera, pois ela � bem
guardada por terr�veis monstros. Mas Goku n�o � um guerreiro qualquer e decidiu preparar-se para recuperar
a �ltima esfera que precisa para ressuscitar seu amigo.

	Goku disp�e de uma certa quantidade de Ki (uma esp�cie de energia m�gica) e de uma lista de M magias.
Cada monstro tem um determinado n�mero de pontos de vida. Cada vez que Goku lan�a uma magia contra
um monstro, Goku gasta uma certa quantidade de Ki (o custo da magia) e infringe um certo dano ao monstro.
O dano infrigido provoca a perda de pontos de vida do monstro (o n�mero de pontos perdidos depende da
magia). Um monstro est� morto se tiver zero ou menos pontos de vida. Goku sempre luta contra um monstro
a cada vez. Como � um guerreiro poderoso, ele pode usar a mesma magia v�rias vezes, desde que possua a
quantidade necess�ria de Ki.

	Em suas pesquisas, Goku conseguiu o mapa que leva a esfera do drag�o. A caverna � representada como
um conjunto de sal�es conectados por galerias. Os sal�es s�o identificados sequencialmente de 1 a N. Goku
sempre inicia no sal�o 1 e a esfera do drag�o est� sempre no sal�o N. Existem K monstros identificados
sequencialmente de 1 a K. Cada monstro vive em um sal�o, do qual n�o sai (note que � poss�vel que mais
de um monstro viva no mesmo sal�o). Durante a busca pela esfera, Goku pode sair ou recuperar a esfera de
um sal�o somente se o sal�o estiver vazio (sem monstro). Em outras palavras, Goku deve sempre, antes de
sair ou de recuperar a esfera de um sal�o, matar o(s) monstro(s) que l� viver(em).

	Dadas as descri��es das magias, dos monstros e da caverna, sua tarefa � determinar a quantidade m�nima
inicial de Ki necess�ria para que Goku consiga recuperar a esfera do drag�o. S�o bolas laranjas e cristalinas que podem invocar o Deus Drag�o Shenlong que tem a habilidade de conceder desejos para
quem conseguir juntar as sete esferas.

### 2 Entrada

	A entrada cont�m v�rios casos de teste. A primeira linha de cada caso de teste cont�m quatro inteiros M,
N, G e K, indicando respectivamente o n�mero de magias (1 = M = 1.000), de sal�es (1 = N = 1.000), de
galerias (0 = G = 1.000.000) e de monstros (0 = K = 1.000).
	Cada uma das M linhas seguintes descreve uma magia. A descri��o de uma magia cont�m dois n�meros
inteiros, a quantidade de Ki consumida (entre 1 e 1.000) e o n�mero de pontos de danos provocados (tamb�m
entre 1 e 1.000).

	Em seguida, h� G linhas, cada uma descrevendo uma galeria. Uma galeria � descrita por dois n�meros
inteiros A e B (A 6= B), representando os sal�es que a galeria conecta. Goku pode utilizar a galeria nos dois
sentidos, ou seja, para ir de A para B ou de B para A.
	Finalmente, as �ltimas K linhas de um caso de teste descrevem os monstros. A descri��o de um monstro
cont�m dois n�meros inteiros representando respectivamente o sal�o no qual ele vive (entre 1 e N inclusive)
e o seu n�mero inicial de pontos de vida (entre 1 e 1.000 inclusive).
O final da entrada � indicado por M = N = G = K = 0.
A entrada deve ser lida de um arquivo texto.

### 3 Sa�da

Para cada caso de teste da entrada seu programa deve produzir uma linha na sa�da contendo um n�mero
inteiro, a quantidade m�nima inicial de Ki necess�ria. Caso n�o seja poss�vel recuperar a esfera do drag�o,
voc� deve imprimir -1.

A sa�da deve ser impressa na tela do programa.

### 4 Exemplo

#### Entrada:

3 4 4 2  
7 10  
13 20  
25 50  
1 2  
2 4  
1 3  
3 4  
2 125  
3 160  
3 4 4 1  
7 10  
13 20  
25 50  
1 2  
2 4  
1 3  
3 4  
2 125  
1 3 1 1  
1000 1000  
1 2  
3 1000  
0 0 0 0
  
#### Sa�da:
70  
0  
-1  
