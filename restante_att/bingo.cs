using System;
class Program{
  static void Main(string[] args){
    Bingo b = new Bingo();
    b.Iniciar(10);
    Console.WriteLine(b.Proximo());
    Console.WriteLine(b.Proximo());
    Console.WriteLine(b.Proximo());
    Console.WriteLine(b.Proximo());
    Console.WriteLine(b.Proximo());
    Console.WriteLine(b.Proximo());
    Console.WriteLine(b.Proximo());
    foreach(int i in b.Sorteados())
      Console.Write(i + "-");
    Console.WriteLine();
    int r = b.Proximo();
    if (r == -1) Console.WriteLine("Game Over!!");
    Console.WriteLine(b.Proximo());
    Console.WriteLine(b.Proximo());
    Console.WriteLine(b.Proximo());
  }
}
class Bingo{
  private int k;
  private int numBolas;
  private int[] numeros;
  public void Iniciar(int numBolas){
    if(numBolas >= 10 && numBolas <= 100)
      this.numBolas = numBolas;
    else
      this.numBolas = 50;
    numeros = new int[numBolas];
    k = 0;
  }
  public int Proximo(){
    if (k == numBolas) return -1;
    Random r = new Random();
    int n = r.Next(1, numBolas + 1);
    int pos = Array.IndexOf(numeros, n);
    while(pos != -1){
      n = r.Next(1, numBolas + 1);
      pos = Array.IndexOf(numeros, n);
    }
    numeros[k] = n;
    k++;
    return n;
  }
  public int[] Sorteados(){
    int[] vetor = new int[k];
    Array.Copy(numeros, vetor, k);
    Array.Sort(vetor);
    return vetor;
  }
}