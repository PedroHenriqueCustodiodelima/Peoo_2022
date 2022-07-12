using System;
class Program {
  public static void Main() {
    int a;
    a = int.Parse(Console.ReadLine());
    for (int i = 1; i <=10; i++){
    int resultado = i * a;
    Console.WriteLine(i+ " x " + a + " = " + resultado);
    } 
  }
}