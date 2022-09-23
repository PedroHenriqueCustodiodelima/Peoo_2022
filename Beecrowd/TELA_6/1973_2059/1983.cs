using System;
class Program{
  static void Main(string[] args){
  int alunos = int.Parse(Console.ReadLine());
  double maior = 0;
  string escolhido = "";
  for (int aluno = 0; aluno < alunos; aluno++){
    string[] linha = Console.ReadLine().Split(' ');
    string matricula = linha[0];
    double nota = double.Parse(linha[1]);  
    if (nota > maior){
      maior = nota;
      escolhido = matricula;
    }            
  }
    if (maior >= 8){
      Console.WriteLine(escolhido);
    }
    else{
      Console.WriteLine("Minimum note not reached");
    }
  }
}