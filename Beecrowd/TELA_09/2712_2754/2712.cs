using System.Linq;
using System;        
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine().Trim());
    for (int i = 0; i < n; i++){
      string v = Console.ReadLine().Trim();
      string[] v1 = v.Split('-');
      if (v1[0].All(char.IsLetter) 
        && v1[0].All(char.IsUpper)
        && v1[0].Length == 3
        && v1[1].All(char.IsDigit)
        && v1[1].Length == 4) {
          string dia = "";
          char x = v1[1][v1[1].Length - 1];
          if (x == '1' || x == '2'){
            dia = "MONDAY";
          }
          if (x == '3' || x == '4'){
            dia = "TUESDAY";
          }
          if (x == '5' || x == '6'){
            dia = "WEDNESDAY";
          }
          if (x == '7' || x == '8'){
            dia = "THURSDAY";
          }
          if (x == '9' || x == '0'){
            dia = "FRIDAY";
          }
          Console.WriteLine(dia);
          }
          else{
            Console.WriteLine("FAILURE");
      }
    }
  }
}