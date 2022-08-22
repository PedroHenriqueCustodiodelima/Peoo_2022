using System;
class Program {
  public static void Main() {
    Ingresso x = new Ingresso();
    Console.WriteLine(x);
    Console.WriteLine(x.dia);
    Console.WriteLine(x.hora);
    Console.WriteLine("Informe o dia da sessão");
    Console.WriteLine("(dom, seg, ter, qua, qui, sex, sab)");
    x.dia = Console.ReadLine();
    Console.WriteLine("Informe a hora da sessão");
    x.hora = int.Parse(Console.ReadLine());
    Console.WriteLine(x.dia);
    Console.WriteLine(x.hora);
    Console.WriteLine($"Inteira = R$ {x.Inteira():f2}");
    Console.WriteLine($"Meia    = R$ {x.Meia():0.00}");
  }
}
class Ingresso {
  public string dia = "dom";
  public int hora = 14;
  public double Inteira() {
    double valor = 0;
    switch(dia) {
      case "sex":
      case "sab":
      case "dom": valor = 20; break;
      case "seg":
      case "ter":
      case "qui": valor = 16; break;
      case "qua": return 8; 
    }
    if (hora == 0 || hora >= 17) valor = valor * 1.5;
    return valor;
  }
  public double Meia() {
    if (dia == "qua") return 8;
    return Inteira()/2;
  }
}