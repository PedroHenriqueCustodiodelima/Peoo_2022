using System;
public class MainClass {
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double x = (a*a)*3.14159;
    Console.WriteLine($"A={x:0.0000}");
    
  }
}