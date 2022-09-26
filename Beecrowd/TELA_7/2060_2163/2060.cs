using System; 
class Program{
  static void Main(string[] args) { 
    int cnt2 = 0;
    int cnt3 = 0;
    int cnt4 = 0;
    int cnt5 = 0;
    int n = int.Parse(Console.ReadLine());
    string[] v = Console.ReadLine().Split(' ');
    for (int i = 0; i < v.Length; i++) {        
      int t = int.Parse(v[i]);
      if(t % 2 == 0) cnt2++;
      if(t % 3 == 0) cnt3++;
      if(t % 4 == 0) cnt4++;
      if(t % 5 == 0) cnt5++;
    }
    Console.WriteLine($"{cnt2} Multiplo(s) de 2");
    Console.WriteLine($"{cnt3} Multiplo(s) de 3");
    Console.WriteLine($"{cnt4} Multiplo(s) de 4");
    Console.WriteLine($"{cnt5} Multiplo(s) de 5");
  }
}