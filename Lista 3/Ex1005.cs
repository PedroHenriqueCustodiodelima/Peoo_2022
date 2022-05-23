using System;
public class MainClass {
  public static void Main(string[] args) {
    double a, b, x = 0;
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());
    x = ((a*3.5) + (b*7.5)) / 11;
    Console.WriteLine($"MEDIA = {x:0.00000}");
    
  }
}