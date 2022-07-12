using System; 
public class Program {
public static void Main(String[] args){
    int x = 1;
    while (x <= 30){
      Console.Write($"{x} ");
      if (x %3 == 0){
      int a = x + x - 1 + x - 2;
        Console.Write(a);
      }
      x++;
      
    }
  }
} 