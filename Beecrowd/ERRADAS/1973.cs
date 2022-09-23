using System;
class Program{
  static void Main(string[] args){
  int carneirosTotal = 0;
  int[] estrelas;
  int estrelasTotal = int.Parse(Console.ReadLine());
  estrelas = new int[estrelasTotal];
  int louco = 0;
  int maior = 0;
  string[] linha = Console.ReadLine().Split(' ');
  for (int i = 0; i < estrelasTotal; i++){
    estrelas[i] = int.Parse(linha[i]);
    carneirosTotal += estrelas[i];
  }
  while (louco >= 0 && louco < estrelasTotal){
    if (louco > maior){
      maior = louco;
    }
    if (estrelas[louco] > 0){
      carneirosTotal--;
    }
    if (estrelas[louco] % 2 == 0){
      if (estrelas[louco] > 0){
        estrelas[louco]--;
      }
      louco--;
    }
    else{
      estrelas[louco]--;
      louco++;
    }
  }
  Console.WriteLine(maior + 1 + " " + carneirosTotal);
  }
}