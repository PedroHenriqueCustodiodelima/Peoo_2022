using System;
class Program{
  static void Main(string[] args){
    int a, b, c = 0, i, j, l = 0, m = 0, x = 0, n, p;
    int[] Par = new int[5];
    int[] Impar = new int[5];
    int[] Ara = new int[15];
    for (b = 0; b < 15; b++){
      Ara[b] = int.Parse(Console.ReadLine());
    }
    for (a = 0; a < 15; a++){
      if (l == 5){
        for (n = 0; n < 5; n++)
        Console.WriteLine("impar[{0}] = {1}", n, Impar[n]);
        l = 0;
      }
      if (m == 5){
        for (p = 0; p < 5; p++)
        Console.WriteLine("par[{0}] = {1}", p, Par[p]);
        m = 0;
      }
      if (Ara[a] % 2 != 0){
        Impar[c] = Ara[a];
        ++c;
        l++;
        if (c == 5) c = 0;
      }
      if (Ara[a] % 2 == 0){
        Par[x] = Ara[a];
        ++x;
        m++;
        if (x == 5) x = 0;
      }
    }
    for (i = 0; i < l; i++){
      Console.WriteLine("impar[{0}] = {1}", i, Impar[i]);
    }
    for (j = 0; j < m; j++){
      Console.WriteLine("par[{0}] = {1}", j, Par[j]);
    }
  }
}
