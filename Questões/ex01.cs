using System;
  class SOMA{
    private double n1;
    private double n2;
    public void SetN1(double p) {
        n1 = p;
    }
    public void SetN2(double a) {
        n2 = a;
    }
    public double GetN1() {
        return n1;
    }
    public double GetN2() {
        return n2;
    }
    public double CalcSoma() {
        double a = n1 + n2;
        return a;
    } 
}
class Program {
  static void Main() {  
    SOMA soma = new SOMA();
    Console.WriteLine("Digite um número:");
    soma.SetN1(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite outro número");
    soma.SetN2(double.Parse(Console.ReadLine()));
    Console.WriteLine($"SOMA: {soma.CalcSoma()}");
    }
}