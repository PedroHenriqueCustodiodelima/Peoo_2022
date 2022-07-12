using System; 
public class Program {
  public static void Main(String[] args) {
  Console.WriteLine("Digite um texto");
  string x = Console.ReadLine();
  int a = x.IndexOf(' ');
  while (a != -1){
    x = x.Substring(a + 1);
    Console.WriteLine(x);
    a = x.IndexOf(' ');
    }
  }
}