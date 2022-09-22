using System;
class Program{
  static void Main(string[] args){
    string[] s = Console.ReadLine().Split(' ');
    double a = int.Parse(s[0]);
    double b = int.Parse(s[1]);
    double r = a % b;
    if(r < 0) {
      r += Math.Abs(b);
    }   
    double q = (a - r) / b;        
    Console.Write("{0} ", q);
    Console.WriteLine(r);
  }
}