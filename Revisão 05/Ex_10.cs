using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite um texto");
    string a = Console.ReadLine();
    Console.WriteLine(Vogais(a));
  }
  public static string Vogais(string s){
    int b = 0;
    string c = "";
    string[] x = s.Split();
    foreach (string f in x){
      b = f.Length;
      for(int i = 0; i < b; i++){
        if(f[i] == 'a' || f[i] == 'e' || f[i] == 'i' || f[i] == 'o' || f[i] == 'u' || f[i]         == 'A' || f[i] == 'E' || f[i] == 'I' || f[i] == 'O' || f[i] == 'U') c += f[i];
      }
      c += " ";
    } 
    return c;
  }
}