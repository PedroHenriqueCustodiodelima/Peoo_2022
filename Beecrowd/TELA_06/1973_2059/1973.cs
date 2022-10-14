using System; 
class Program{
  static void Main(string[] args) {
    long i;
    long totalCarneiros = 0;
    long totalEstrelasAtacadas = 0;
    int totalEstrelas = int.Parse(Console.ReadLine());
      string[] valores = Console.ReadLine().Split();
      long[] estrelas = new long[totalEstrelas];
      long[] estrelasAtacadas = new long[totalEstrelas];
      for (i = 0; i < valores.Length; i++){
        estrelas[i] = long.Parse(valores[i]);
        totalCarneiros += estrelas[i];
        estrelasAtacadas[i] = 0;
      }
      for (i = 0; i < totalEstrelas;){
        if (i >= 0 && i < totalEstrelas){
          if (estrelasAtacadas[i] == 0){
            totalEstrelasAtacadas += 1;
            estrelasAtacadas[i] = 1;
          }
          if (estrelas[i] > 0){
            totalCarneiros -= 1;
          }
          estrelas[i] -= 1;
          if (estrelas[i] % 2 == 0)
            i += 1;
          else
            i -= 1;
          }
          else
            break;
        }
    Console.WriteLine("{0} {1}", totalEstrelasAtacadas, totalCarneiros);
  }
}