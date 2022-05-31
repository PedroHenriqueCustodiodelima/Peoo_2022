public class MainClass {
  public static void Main(string[] args) {
    int a, b, c, d, x = 0;
    Console.WriteLine("Digite quatro valores inteiros"); 
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    d = int.Parse(Console.ReadLine());
    x = (a+b+c+d)/4;
    Console.WriteLine("Média = " + x);   
    Console.WriteLine("Números menores que a média");
    if (a < x)
    {
      Console.WriteLine(a);
    }
    if (b < x)
    {
      Console.WriteLine(b);
    }
    if (c < x)
    {
      Console.WriteLine(c);
    }
    if (d < x)
    {
      Console.WriteLine(d);
    }
    Console.WriteLine("Números maiores ou iguais à média");
    if (a >= x)
    {
      Console.WriteLine(a);
    }
    if (b >= x)
    {
      Console.WriteLine(b);
    }
    if (c >= x)
    {
      Console.WriteLine(c);
    }
    if (d >= x)
    {
      Console.WriteLine(d);
    }
  }
                                        
}