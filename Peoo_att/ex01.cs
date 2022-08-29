using System;
  class imc{
    private double peso;
    private double altura;
    public void SetPeso(double p) {
        peso = p;
    }
    public void SetAltura(double a) {
        altura = a;
    }
    public double GetPeso() {
        return peso;
    }
    public double GetAltura() {
        return altura;
    }
    public double CalcIMC() {
        double a = altura * altura;
        return peso/a;
    } 
}
class Program {
  static void Main() {  
    imc imc = new imc();
    Console.WriteLine("Digite o seu peso");
    imc.SetPeso(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite sua altura");
    imc.SetAltura(double.Parse(Console.ReadLine()));
    Console.WriteLine($"Seu imc é: {imc.CalcIMC():0.00}");
    }
}