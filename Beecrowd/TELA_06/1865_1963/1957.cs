using System;
class Program{
  static void Main(string[] args){
  int numero = int.Parse(Console.ReadLine());
  string hexadecimal = numero.ToString("X");
  Console.WriteLine(hexadecimal);
  }
}