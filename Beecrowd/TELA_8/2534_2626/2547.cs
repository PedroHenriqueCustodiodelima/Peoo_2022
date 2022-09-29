using System;        
class Program{
  static void Main(string[] args) {
		string str;
		while (!string.IsNullOrEmpty(str = Console.ReadLine())){
			string[] linha = str.Split(' ');
			int.TryParse(linha[0], out int n);
			int.TryParse(linha[1], out int aMin);
			int.TryParse(linha[2], out int aMax);
			int total = 0;
			for (int i = 0; i < n; i++){
				int.TryParse(Console.ReadLine(), out int x);
				if (x >= aMin && x <= aMax){
					total++;
				}
			}
			Console.WriteLine(total);
		}
	}
}