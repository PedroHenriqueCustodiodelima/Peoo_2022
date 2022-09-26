using System;
class Program{
  static void Main(string[] args){
    int total = 1;
    int caso = 1;
    while (true){            
    string input = Console.ReadLine();
      if (string.IsNullOrEmpty(input)){
        break;
      }
      long valor = long.Parse(input);
      if (valor == 0){
        Console.WriteLine($"Caso {caso}: 1 numero");
        Console.Write("0 ");
      }
      else{
        for (int i = 1; i <= valor; i++){
          total += 1;
        }                   
        Console.WriteLine($"Caso {caso}: {total} numeros");
        Console.Write("0 ");
        for (int i = 1; i <= valor; i++){
          for (int j = 1; j <= i; j++){
            Console.Write(i + " ");
          }
        }
      }
      caso++;
    }
  }
}