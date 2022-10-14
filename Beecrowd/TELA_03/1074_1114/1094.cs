using System;
class Program{
  static void Main(string[] args){
    int n,num, rato, coelho, sapo, soma;
    double rp, cp, sp, vc, vs, vr;
    string letra;
    coelho = 0;
    rato = 0;
    sapo = 0;
    soma = 0;
    rp = 0;
    cp = 0;
    sp = 0;
    vc = 0;
    vs = 0;
    vr = 0;
    n = int.Parse(Console.ReadLine());
    for (int c = 0; c < n; c++){
      string[] vetor = Console.ReadLine().Split(' ');
      num = int.Parse(vetor[0]);
      letra = vetor[1];

      if(letra =="C"){
        coelho = coelho + num;
      }
      if (letra == "S"){
        sapo = sapo + num;
      }
      if (letra == "R"){
        rato = rato + num;
      }
      soma = soma + num;
    }

    sp = (double)sapo / soma;
    cp = (double)coelho / soma;
    rp = (double)rato / soma;
    vs = (double)sp * 100.0;
    vr = (double)rp * 100.0;
    vc = (double)cp * 100.0;
    
    Console.WriteLine($"Total: {soma} cobaias");
    Console.WriteLine($"Total de coelhos: {coelho}");
    Console.WriteLine($"Total de ratos: {rato}");
    Console.WriteLine($"Total de sapos: {sapo}");
    Console.WriteLine($"Percentual de coelhos: {vc:0.00} %");
    Console.WriteLine($"Percentual de ratos: {vr:0.00} %");
    Console.WriteLine($"Percentual de sapos: {vs:0.00} %");
  }
}