using System;        
class Program{
  static void Main(string[] args) {
		string[] v = Console.ReadLine().Split(' ');
    int bolas = 0;
    for (int i = 0; i < 9; i++){
      int temp = int.Parse(v[i]);
      bolas += temp;
    }
    switch (bolas % 9){
      case 0:
        Console.WriteLine("Rudolph");
        break;
      case 1:
        Console.WriteLine("Dasher");
        break;
      case 2:
        Console.WriteLine("Dancer");
        break;
      case 3:
        Console.WriteLine("Prancer");
        break;
      case 4:
        Console.WriteLine("Vixen");
        break;
      case 5:
        Console.WriteLine("Comet");
        break;
      case 6:
        Console.WriteLine("Cupid");
        break;
      case 7:
        Console.WriteLine("Donner");
        break;
      case 8:
        Console.WriteLine("Blitzen");
        break;
    }
  }
}