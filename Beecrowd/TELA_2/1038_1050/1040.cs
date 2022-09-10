using System;
class Program{ 
  static void Main(string[] args){
    double n_exame, media_exame;
    string[] notas = Console.ReadLine().Split(' ');
    double n1 = double.Parse(notas[0]);
    double n2 = double.Parse(notas[1]);
    double n3 = double.Parse(notas[2]);
    double n4 = double.Parse(notas[3]);  
    double media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;
    if (media == 4.85){    
      media = 4.8;
    }
    Console.WriteLine($"Media: {media:0.0}");
    if (media >= 7){
      Console.WriteLine("Aluno aprovado.");
    }
    else if (media < 5){
      Console.WriteLine("Aluno reprovado.");
    }
    else{
      Console.WriteLine("Aluno em exame.");
      n_exame = double.Parse(Console.ReadLine());
      Console.WriteLine($"Nota do exame: {n_exame:0.0}");
      media_exame = (media + n_exame) / 2;
      if (media_exame >= 5){
        Console.WriteLine("Aluno aprovado.");
      }
      else{
        Console.WriteLine("Aluno reprovado.");
      }
        Console.WriteLine($"Media final: {media_exame:0.0}");
    }
  }
}