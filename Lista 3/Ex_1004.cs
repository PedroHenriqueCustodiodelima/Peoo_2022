using System;
public class MainClass {
  
  public static void Main(string[] args) {
    
    double a, b, x = 0;
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());
    x = a*b;
    Console.WriteLine($"PROD = {x}");
    
  }
}
