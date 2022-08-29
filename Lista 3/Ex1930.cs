using System;
  class Program{
    static void Main(string[] args){
      double x1, x2, y1, y2, resposta;
      string[] valores;
      valores = Console.ReadLine().Split(' ');
      x1 = double.Parse(valores[0]);              
      y1 = double.Parse(valores[1]);                
      x2 = double.Parse(valores[2]);
      y2 = double.Parse(valores[3]);          
      resposta = ((x1 + x2 + y1 + y2)-3);
      Console.WriteLine(resposta);  
    }
}