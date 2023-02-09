using System;

class Program {
  public static void Main (string[] args) {
   // Faça um algoritmo que leia três notas de um aluno, calcule e escreva a média final deste aluno. Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5. Fórmula para o cálculo da média final é:

String nome, entrada;
 Double n1, n2, media;
//escreval("texto")    
    Console.WriteLine("Nome do aluno");
//leia a (variavel)    
  nome = Console.ReadLine();
//solicita que o usuario digite a nota1

    
     Console.WriteLine("Digite a primeira nota");
//recebe a nota 01 na variavel de texto. Toda a entrada é um texto
    entrada = Console.ReadLine();
//converte a entrada em um Double
    n1 = Double.Parse (entrada);
    
//repete para a nota2    
    Console.WriteLine("Digite a segunda nota");
   entrada = Console.ReadLine();
     n2 = Double.Parse (entrada);
    
//calcula a media
   media = (n1+ n2)/2;
  Console.WriteLine ("Média do aluno(1) aluno (2) " + nome + " é " + media);  
   Console.WriteLine ("PARABÉNS");
  






    
  }
}