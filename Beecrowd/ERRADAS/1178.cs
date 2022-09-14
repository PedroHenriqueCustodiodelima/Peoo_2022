using System;
internal class Program{
  static void Main(string[] args){
    int i;
    double[] X = new double[100];
    double n = double.Parse(Console.ReadLine());
    X[0] = n;
    for (i = 0; i < 100; i++){
      X[i] = n;
      n = n / 2;
    }
    for (i = 0; i < 100; i++){
      Console.WriteLine($"N[{i}] = {X[i]:0.0000}");
    }
  }
}
