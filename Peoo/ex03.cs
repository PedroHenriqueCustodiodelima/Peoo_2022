using System;
  class Compra {
    private double total;
    private int num_p;
    public void SetTotal(double t) {
        total = t;
    }
    public void SetNumPrestacoes(int n) {
        num_p = n;
    }
    public double GetTotal() {
        return total;
    }
    public double GetValorPrestacao() {
      double a = total/num_p;
        return a;
    }
    public double GetValorDesconto() {
      double b = total * 0.15;
        return total - b;
    } 
}
class Program {
  static void Main() {   
    Compra c = new Compra();
    Console.WriteLine("Digite o valor total");
    c.SetTotal(double.Parse(Console.ReadLine()));
    Console.WriteLine("Números de prestações");
    c.SetNumPrestacoes(int.Parse(Console.ReadLine()));
    Console.WriteLine($"desconto: {c.GetValorDesconto()} / Valor de cada prestação: {c.GetValorPrestacao()}");
    }
}