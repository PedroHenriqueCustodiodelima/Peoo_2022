using System; 
class Program{
  static void Main(string[] args) { 
    string n = Console.ReadLine();
    double x = double.Parse(n);
    char[] a = x.ToString("0.0000E+00").ToCharArray();
    if (n == "-0")
      Console.WriteLine("-{0}", x.ToString("0.0000E+00"));
    else if (a[0] != '-')
      Console.WriteLine("+{0}", x.ToString("0.0000E+00"));            
    else
      Console.WriteLine("{0}", x.ToString("0.0000E+00"));
  }
}