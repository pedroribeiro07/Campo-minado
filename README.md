Campo minado 9x9 criado por Jhonata Souza e Pedro Guilherme. O objetivo è conseguir o maior número de pontuação, ao mesmo tempo em que terá que evitar as bombas para nao perder o jogo

Codigo em Português Estruturado:
Algoritmo "Campo Minado"
 Var
 matrizP: vetor[1..9,1..9] de caractere
 i, j, p, a, b:inteiro
 Inicio
      p <- 0
      repita
      para i de 1 ate 9 faca
      para j de 1 ate 9 faca
           se(p >= 1)entao
                matrizP[1, 2] <- ("[ ]")
                matrizP[2, 8] <- ("[ ]")
                matrizP[7, 3] <- ("[ ]")
                matrizP[3, 4] <- ("[ ]")
                matrizP[7, 5] <- ("[ ]")
                matrizP[5, 1] <- ("[ ]")
                matrizP[1, 7] <- ("[ ]")
                matrizP[6, 8] <- ("[ ]")
                matrizP[8, 4] <- ("[ ]")
                matrizP[9, 1] <- ("[ ]")
                matrizP[a, b] <- ("[0]")
           escreva(matrizP[i,j])
           senao
                matrizP[1, 2] <- ("[*]")
                matrizP[2, 8] <- ("[*]")
                matrizP[7, 3] <- ("[*]")
                matrizP[3, 4] <- ("[*]")
                matrizP[7, 5] <- ("[*]")
                matrizP[5, 1] <- ("[*]")
                matrizP[1, 7] <- ("[*]")
                matrizP[6, 8] <- ("[*]")
                matrizP[8, 4] <- ("[*]")
                matrizP[9, 1] <- ("[*]")
                matrizP[i, j] <- ("[ ]")
           escreva(matrizP[i,j])
           fimse
           se(p >= 1)entao
                matrizP[1, 2] <- ("[*]")
                matrizP[2, 8] <- ("[*]")
                matrizP[7, 3] <- ("[*]")
               matrizP[3, 4] <- ("[*]")
                matrizP[7, 5] <- ("[*]")
                matrizP[5, 1] <- ("[*]")
                matrizP[1, 7] <- ("[*]")
                matrizP[6, 8] <- ("[*]")
                matrizP[8, 4] <- ("[*]")
                matrizP[9, 1] <- ("[*]")
           fimse
      fimpara
      escreval(" ")
      fimpara
      escreva("Digite um número: ")
      leia(a)
      escreva("Digite um numero: ")
      leia(b)
      se(matrizP[a,b] = "[*]")entao
           escreva("VOCÊ PERDEU!!!")
           escreval(" ")
           escreva(matrizP[a,b])
           escreval(" ")
      fimse
      se(matrizP[a,b] = "[ ]")entao
          P <- P + 1
           escreva("Você ganhou mais um ponto de 71 pontos")
           escreval(" ")
           escreva("Pontos:", p)
           escreval(" ")
      fimse
      se(p = 70)entao
           escreva("VOCÊ GANHOU!!!")
           escreval(" ")
      fimse
     ate(matrizP[a,b] = "[*]")ou(p = 70)
     Fimalgoritmo 
