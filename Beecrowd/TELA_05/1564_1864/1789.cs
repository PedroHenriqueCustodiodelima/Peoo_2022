using System;
class Program{
  static void Main(string[] args){
    string entrada = Console.ReadLine();
    do{
      if (!string.IsNullOrEmpty(entrada)){
        int maiorVelocidade = 0;
        int lesma = 0;
        int lesmas = Int32.Parse(entrada);
        string[] velocidades = Console.ReadLine().Split(' ');
        while (lesmas > 0){
          int velocidadeTartaruga = Int32.Parse(velocidades[lesma]);
          if (maiorVelocidade < velocidadeTartaruga){
            maiorVelocidade = velocidadeTartaruga;
          }
          lesmas--;
          lesma++;
        }
        int maisVeloz = maiorVelocidade;
         if (maisVeloz >= 20){
            Console.WriteLine("3");
          }
          else if (maisVeloz >= 10 && maisVeloz < 20){
            Console.WriteLine("2");
          }
          else{
            Console.WriteLine("1");
          }
        }
        entrada = Console.ReadLine();
        }
      while (!string.IsNullOrEmpty(entrada));  
  }
}