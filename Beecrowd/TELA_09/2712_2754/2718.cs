using System;
class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++) {
      long x = long.Parse(Console.ReadLine());
      int sequenciaMaxima = 0;
    	int sequenciaAtual = 0;
      while(x > 0){
        if (x % 2 == 1) {
          sequenciaAtual++;
        }
        else{
          if (sequenciaAtual > sequenciaMaxima){
            sequenciaMaxima = sequenciaAtual;
          }
          sequenciaAtual = 0;
        }
        x /= 2;
      }
      if (sequenciaAtual > sequenciaMaxima) {	
				sequenciaMaxima = sequenciaAtual;
			}
      Console.WriteLine(sequenciaMaxima);
    }
  }
}