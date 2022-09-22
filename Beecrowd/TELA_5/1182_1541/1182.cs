using System;
class Program{
  static void Main(string[] args){
    int c = int.Parse(Console.ReadLine());
    char t = char.Parse(Console.ReadLine());
    double[,] matriz = new double[12, 12];
    for (int i = 0; i < 12; i++){
      for (int j = 0; j < 12; j++){
        double x = double.Parse(Console.ReadLine());
        matriz[i, j] = x;
      }
    }
    double media = 0;
    double soma = 0.0;
    for (int i = 0; i < 12; i++){
      if (t == 'S'){
        soma = soma + matriz[i, c];
      }
      else if (t == 'M'){
        soma = soma + matriz[i, c];
      }
    }
    if (t == 'S'){
      Console.WriteLine($"{soma:0.0}");
    }
    else{
      media = soma / 12.0;
      Console.WriteLine($"{media:0.0}");
    }
  }
}