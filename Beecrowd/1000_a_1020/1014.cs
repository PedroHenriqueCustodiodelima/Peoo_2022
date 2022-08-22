using System;
class Program{
  static void Main(string[] args){
    int dis_total = int.Parse(Console.ReadLine());              
    double combustivel = double.Parse(Console.ReadLine());
    double km = dis_total / combustivel;
    Console.WriteLine($"{km:0.000} km/l");
  }
}