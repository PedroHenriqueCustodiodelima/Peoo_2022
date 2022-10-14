using System;
class Program {
  public static void Main(){
    int x = int.Parse(Console.ReadLine());
    int i = 1;
    while (i <= x) {
      Console.WriteLine(i);
      i = i + 2; 
    }
  }
}