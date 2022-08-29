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
    Console.WriteLine("Digite o seu peso em kg:");
    imc.SetPeso(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite sua altura em metros");
    imc.SetAltura(double.Parse(Console.ReadLine()));
    Console.WriteLine($"Seu imc é: {imc.CalcIMC():0.00}");
    Console.WriteLine("IMC é: O índice de massa corporal é uma medida internacional usada para calcular se uma pessoa está no peso idea");
    }
}