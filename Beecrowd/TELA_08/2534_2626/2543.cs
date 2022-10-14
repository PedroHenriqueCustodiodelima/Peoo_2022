using System;        
class Program{
  static void Main(string[] args) {
    string str;
		while (!string.IsNullOrEmpty(str = Console.ReadLine())){
			string[] l = str.Split(' ');
      int n = int.Parse(l[0]);
      int x = int.Parse(l[1]);
			int p = 0;
			for (int i = 0; i < n; i++){
				string[] c = Console.ReadLine().Split(' ');
				if (c[0] == x.ToString() && c[1] == "0"){
					p++;
			  }
			}
			Console.WriteLine(p);
		}
  }
}