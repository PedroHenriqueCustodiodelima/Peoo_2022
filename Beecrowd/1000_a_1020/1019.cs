using System;
class Program{
  static void Main(string[] args){
    int segundos = int.Parse(Console.ReadLine());
    int horas = segundos / 3600;
    segundos = segundos - (horas * 3600);
    int minutos = segundos / 60;
    segundos = segundos - (minutos * 60);
    Console.WriteLine($"{horas}:{minutos}:{segundos}");
  }
}