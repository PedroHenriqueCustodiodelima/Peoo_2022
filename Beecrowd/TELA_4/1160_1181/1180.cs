using System; 
class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    int[] x = new int[n];
    string[] valores = new string[n];
    valores = Console.ReadLine().Split(' ');
    int contador = 1;
    for (int i = 0; i < n; i++){
      x[i] = int.Parse(valores[i]);
    }
    int posicao = 0;
    for (int j = 1; j < n; j++){
      if (x[j] < x[0]){
        posicao = contador;
        x[0] = x[posicao];                            
      }
        contador++;
      }
      Console.WriteLine($"Menor valor: {x[posicao]}");
      Console.WriteLine($"Posicao: {posicao}");
    }
}