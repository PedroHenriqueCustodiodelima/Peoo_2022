using System;
class Program {
  public static void Main() {
    Console.Write("Digite um valor:");
    double d = double.Parse(Console.ReadLine());
    int i = (int) d;
    Console.WriteLine(MenorInteiro((d)));
  }
  public static int MenorInteiro(double x){
    int i = (int) x;
    if ( x == i ) return i;
    else return i+1;
  }    
}