using System; 
class Program{
  static void Main(string[] args) {
    long N = long.Parse(Console.ReadLine());
    if (N.ToString().Contains("13")){
      Console.Write("{0} es de Mala Suerte\n", N);
    }
    else{
      Console.Write("{0} NO es de Mala Suerte\n", N);
    }
  }
}