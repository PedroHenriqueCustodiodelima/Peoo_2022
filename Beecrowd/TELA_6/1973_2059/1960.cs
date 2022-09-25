using System;
class Program{
  static void Main(string[] args){
    int[] numero = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
    string[] romano = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
    int n = int.Parse(Console.ReadLine());
    int i = 0;
    while(n > 0){
      if(n >= numero[i]){
        Console.Write(romano[i]);
        n -= numero[i];
      }
      else{
        i++;
      }
    }
    Console.WriteLine("");
  }
}