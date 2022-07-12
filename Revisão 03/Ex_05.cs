using System; 
public class Program {
  public static void Main(String[] args){
    int a = 1;
    int b = 1;
    while (a <= 10){
      Console.Write($"{b} ");
      b += a;
      a++;
    }
  }
} 