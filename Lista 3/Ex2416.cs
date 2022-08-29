using System;
  class Program{
    static void Main(string[] args){
      int x1, y1;
      string[] valores;
      valores = Console.ReadLine().Split(' ');
      x1 = int.Parse(valores[0]);              
      y1 = int.Parse(valores[1]);                
      if (x1 > y1){
        Console.WriteLine(x1 % y1);
      }
      else{
        Console.WriteLine(y1 % x1);
      }           
  }
}