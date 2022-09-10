using System;
class Program {
  public static void Main() {
  int numeros_pares = 0; 
  int numeros_impares = 0;
  int soma = 0;
  int numeros_positivos = 0;
  int numeros_negativos = 0;
    for (int i = 1; i <= 5; i++) {
      int x = int.Parse(Console.ReadLine());
      if (x % 2 == 0){
        numeros_pares += 1;
      }
      if (x % 2 == 1){
        numeros_impares += 1;
      }
      if (x > 0){
        soma = soma + x;
        numeros_positivos = numeros_positivos + 1;
      }
      if (x < 0){
        soma = soma + x;
        numeros_negativos = numeros_negativos + 1;
      }
    }
    Console.WriteLine($"{numeros_pares} valor(es) par(es)");
    Console.WriteLine($"{numeros_impares} valor(es) impar(es)");
    Console.WriteLine($"{numeros_positivos} valor(es) positivo(s)");
    Console.WriteLine($"{numeros_negativos} valor(es) negativo(s)");
  }
}