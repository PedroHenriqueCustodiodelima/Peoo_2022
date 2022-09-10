using System;
class Program{
  static void Main(string[] args){
    double area, p;
    string[] valores = Console.ReadLine().Split(' ');
    double a = double.Parse(valores[0]);
    double b = double.Parse(valores[1]);
    double c = double.Parse(valores[2]);
    if ( a < b + c && b < a + c && c < a + b){
      p = a + b + c;
      Console.WriteLine($"Perimetro = {p:0.0}");
    }
    else{
      area = ((a + b) * c) / 2;
      Console.WriteLine($"Area = {area:0.0}");
    }
  }
}
