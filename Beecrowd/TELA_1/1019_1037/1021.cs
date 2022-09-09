using System;
using System.Globalization;
  class Program{
    static void Main(string[] args){ 
      double n, r;
      int resultado, nota, moeda;
      n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      r = (int) (n*100 + 0.5);
      Console.WriteLine("NOTAS:");
      nota = 100;
      resultado = (int)r / (nota *100);
      Console.WriteLine(resultado + " nota(s) de R$ 100.00");
      r = (int)r % (nota*100);        
      nota = 50;
      resultado = (int)r / (nota * 100);

      Console.WriteLine(resultado + " nota(s) de R$ 50.00");
      r = (int)r % (nota * 100);         
      nota = 20;
      resultado = (int)r / (nota * 100);

      Console.WriteLine(resultado + " nota(s) de R$ 20.00");
      r = (int)r % (nota * 100);
      nota = 10;
      resultado = (int)r / (nota * 100);

      Console.WriteLine(resultado + " nota(s) de R$ 10.00");
      r = (int)r % (nota * 100);         
      nota = 5;
      resultado = (int)r / (nota * 100);
    
      Console.WriteLine(resultado + " nota(s) de R$ 5.00");
      r = (int)r % (nota * 100); 
      nota = 2;
      resultado = (int)r / (nota * 100);
      
      Console.WriteLine(resultado+" nota(s) de R$ 2.00");
      r = (int)r % (nota * 100);
      Console.WriteLine("MOEDAS:");       
      moeda = 100;
      resultado = (int)r / moeda;
      
      Console.WriteLine(resultado + " moeda(s) de R$ 1.00");
      r = (int)r % moeda;
      moeda = 50;
      resultado = (int)r / moeda;
      
      Console.WriteLine(resultado + " moeda(s) de R$ 0.50");
      r = (int)r % moeda;
      moeda = 25;
      resultado = (int)r / moeda;

      Console.WriteLine(resultado + " moeda(s) de R$ 0.25");
      r = (int)r % moeda;
      moeda = 10;
      resultado = (int)r / moeda;
      Console.WriteLine(resultado + " moeda(s) de R$ 0.10");
      r = (int)r % moeda;
      moeda = 5;
      resultado = (int)r / moeda;
      Console.WriteLine(resultado + " moeda(s) de R$ 0.05");
      r = (int)r % moeda;
      Console.WriteLine(r + " moeda(s) de R$ 0.01");
  }
}