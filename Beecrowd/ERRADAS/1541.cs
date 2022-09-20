using System;
class Program{
  static void Main(string[] args){
    while(true){
      int comprimento = int.Parse(Console.ReadLine());
      if(comprimento == 0){
        break;
      }
      else{
        int largura = int.Parse(Console.ReadLine());
        if(largura == 0){
          break;
      }
      else{
        int porcentagem = int.Parse(Console.ReadLine());
        if(porcentagem == 0){
          break;
      }
      else{
        int area = comprimento * largura;
        int r1 = (area * 100) / porcentagem;
        double r2 = Math.Sqrt(r1);
        Console.WriteLine(r2);
        }
        }
      }
    }
  }
}