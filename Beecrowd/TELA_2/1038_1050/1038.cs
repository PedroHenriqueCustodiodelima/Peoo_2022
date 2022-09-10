using System;
class Program{
  static void Main(string[] args){ 
    int codigo, quantidade;
    string[] vet = Console.ReadLine().Split(' ');
    codigo = int.Parse(vet[0]);
    quantidade = int.Parse(vet[1]);
    double total, preco;
    switch (codigo){   
        case 1:
          preco = 4.00;
          break;

        case 2:
          preco = 4.50;
          break;

        case 3:
          preco = 5.00;
          break;

        case 4:
          preco = 2.00;
          break;              
                    
        default:
          preco = 1.50;
          break;
        }
        total = preco * quantidade;
        Console.WriteLine($"Total: R$ {total:0.00}");        
  }
}