using System;
public class MainClass {
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double raio = (4/3.0)* 3.14159 * (Math.Pow(a,3));
    Console.WriteLine($"VOLUME = {raio:0.000}");
  }
}