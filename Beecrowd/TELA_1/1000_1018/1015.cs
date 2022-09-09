using System;
class Program{
  static void Main(string[] args){ 
    double x1, x2, y1, y2, distancia; 
    string[] valores;
    valores = Console.ReadLine().Split(' ');
    x1 = double.Parse(valores[0]);              
    y1 = double.Parse(valores[1]);                
    valores = Console.ReadLine().Split(' ');
    x2 = double.Parse(valores[0]);
    y2 = double.Parse(valores[1]);          
    distancia = Math.Sqrt(Math.Pow(x1 - x2, 2.00)+ Math.Pow(y1 - y2, 2.00));
    Console.WriteLine($"{distancia:0.0000}");  
  }
}