using System;
class Program {
  public static void Main() {
    Console.Write("Digite um valor para x:");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Digite um valor para y:");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(MMC(a, b));
  }
  public static int MMC(int x, int y){
    int m = x;
    while(!(m % x == 0 && m % y == 0))m++;
    return m;
    }    
  }