using System;
public class MainClass {
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double nota = ((a*3.5) + (b*7.5)) / 11;
    Console.WriteLine($"MEDIA = {nota:0.00000}");
    
  }
}