using System;
class Program{
  static void Main(string[] args){
    string entrada;
    while (!string.IsNullOrEmpty(entrada = Console.ReadLine())){
      string[] str = entrada.Split(' ');
      int mes = int.Parse(str[0]);
      int dia = int.Parse(str[1]);
        if (dia == 25 && mes == 12){
          Console.WriteLine("E natal!");
        }
        else if (dia == 24 && mes == 12){
          Console.WriteLine("E vespera de natal!");
        }
        else if (mes == 12 && dia > 25){
          Console.WriteLine("Ja passou!");
        }
        else{
          var d = new DateTime(2016, mes, dia);
          var natal = new DateTime(2016, 12, 25);
          TimeSpan t = natal.Subtract(d);
          Console.WriteLine($"Faltam {t.TotalDays} dias para o natal!");
      }
    }
  }
}