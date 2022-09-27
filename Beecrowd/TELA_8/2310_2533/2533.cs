using System;        
class Program{
  static void Main(string[] args) {
    string a = Console.ReadLine();
    while (!string.IsNullOrEmpty(a)){
      int.TryParse(a, out int m);
      double[] n = new double[m];
      double[] c = new double[m];
      double numerador = 0;
      double denominador = 0;
      for (int i = 0; i < m; i++){
        string[] v = Console.ReadLine().Split(' ');
        double.TryParse(v[0], out n[i]);
        double.TryParse(v[1], out c[i]);
        numerador += n[i] * c[i];
        denominador += c[i] * 100.0;
      }
      Console.WriteLine($"{numerador/denominador:0.0000}");
      a = Console.ReadLine();
    }
  }
}