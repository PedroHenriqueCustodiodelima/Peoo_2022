using System;
class Program{
  static void Main(string[] args){          
    string[] valores;
    valores = Console.ReadLine().Split(' ');
    double x1 = double.Parse(valores[0]);              
    double y1 = double.Parse(valores[1]);                
    double x2 = double.Parse(valores[2]);
    double y2 = double.Parse(valores[3]);          
    double resposta = ((x1 + x2 + y1 + y2)-3);
    Console.WriteLine(resposta);  
  }
}