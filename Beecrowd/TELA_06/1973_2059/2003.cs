using System;
class Program{
  static void Main(string[] args){
    int atraso = 0;
    while (true){        
      string a = Console.ReadLine();
      if (string.IsNullOrEmpty(a)){
        break;
      }
      string[] horario = a.Split(':');
      int hora = int.Parse(horario[0]);
      int minuto = int.Parse(horario[1]);
      atraso = ((hora+1)-8)*60 + minuto;
      if(hora < 7 || (hora == 7 && minuto == 0)){
        Console.WriteLine($"Atraso maximo: 0");
      }
      else{
        Console.WriteLine($"Atraso maximo: {atraso}");
      }
    }
  }
}