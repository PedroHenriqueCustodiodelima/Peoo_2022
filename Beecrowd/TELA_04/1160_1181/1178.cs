using System;
class Program{
  static void Main(string[] args){
    decimal x = decimal.Parse(Console.ReadLine());
    decimal[] n = new decimal[100];
    n[0] = x;
    for (int i = 1; i < n.Length; i++){
      n[i] = n[i - 1] / 2;
    }
    for (int j = 0; j < n.Length; j++){
      Console.WriteLine($"N[{j}] = {Math.Round(n[j], 4).ToString("F4")}");
    }
  }
}