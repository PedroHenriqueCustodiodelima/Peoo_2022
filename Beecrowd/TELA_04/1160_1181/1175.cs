using System; 
class Program{
  static void Main(string[] args){
    int[] vetor = new int[20];
    for (int i = 0; i < 20; i++){
      int x = int.Parse(Console.ReadLine());
      vetor[i] = x;
    }
    for (int i = 0; i < 20 / 2; i++){
      int temp = vetor[i];
      vetor[i] = vetor[19 - i];
      vetor[19 - i] = temp;
    }
    for (int i = 0; i < 20; i++){
      Console.WriteLine("N["+i+"]"+" = "+vetor[i]);
    }
  }
}