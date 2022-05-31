using System;
public class MainClass {
  public static void Main(string[] args) {
    
    Console.WriteLine("Informe o número do mês");
    int n = int.Parse(Console.ReadLine());
    string mes = "";
    string tri = "";
    switch (n) {
      case 1 : mes = "janeiro" ; tri = "primeiro" ; break;
      case 2 : mes = "fevereiro" ; tri = "primeiro" ; break;
      case 3 : mes = "Março" ; tri = "primeiro" ; break;
      case 4 : mes = "abril" ; tri = "segundo" ; break;
      case 5 : mes = "maio" ; tri = "segundo" ; break;
      case 6 : mes = "junho" ; tri = "segundo" ; break;
      case 7 : mes = "julho" ; tri = "terceiro" ; break;
      case 8 : mes = "agosto" ; tri = "terceiro" ; break;
      case 9 : mes = "setembro" ; tri = "terceiro" ; break;
      case 10 : mes = "outubro" ; tri = "quarto" ; break;
      case 11 : mes = "novembro" ; tri = "quarto" ; break;
      case 12 : mes = "dezembro" ; tri = "quarto" ; break;
    }
      Console.WriteLine($"O mês de {mes} é do {tri} trimestre do ano");
  }
}
  