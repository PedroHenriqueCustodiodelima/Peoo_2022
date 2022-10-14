using System;
class Program{
  static void Main(string[] args){
  int n = int.Parse(Console.ReadLine());
   for (int i = 0; i < n; i++){
    int anos = int.Parse(Console.ReadLine());
    if (anos >= 2015){
      anos = anos - 2014;
      Console.WriteLine(anos + " A.C.");
    }
    else{
      anos = 2015 - anos;
      Console.WriteLine(anos + " D.C.");
      }
    }
  }
}