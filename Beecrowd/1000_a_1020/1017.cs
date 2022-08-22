using System;
class Program{
  static void Main(string[] args){
    int a = 12;
    float h, vm;
    float gc;
    h= float.Parse(Console.ReadLine());
    vm = float.Parse(Console.ReadLine());
    gc = (vm / a) * h;
    Console.WriteLine($"{gc:0.000}");  
  }
}