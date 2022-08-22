using System;

class Circulo {
  public double raio;      // Atributo
  public double Area() {   // Métodos
    return Math.PI * raio * raio;
  }
  public double Circunferencia() {
    return 2 * Math.PI * raio;
  }
}

class Program {
  public static void Main() {
    Circulo a = new Circulo();
    Circulo b = new Circulo();
    Circulo c = new Circulo();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(a.raio);
    Console.WriteLine(b.raio);
    Console.WriteLine(c.raio);
    Console.WriteLine("Digite o raio do 1º círculo");
    a.raio = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o raio do 2º círculo");
    b.raio = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o raio do 3º círculo");
    c.raio = double.Parse(Console.ReadLine());
    Console.WriteLine("Raios");
    Console.WriteLine(a.raio);
    Console.WriteLine(b.raio);
    Console.WriteLine(c.raio);
    Console.WriteLine("Áreas");
    Console.WriteLine(a.Area());
    Console.WriteLine(b.Area());
    Console.WriteLine(c.Area());
    Console.WriteLine("Circunferências");
    Console.WriteLine(a.Circunferencia());
    Console.WriteLine(b.Circunferencia());
    Console.WriteLine(c.Circunferencia());
  }
}