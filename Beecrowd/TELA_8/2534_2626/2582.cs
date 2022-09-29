using System;        
class Program{
  static void Main(string[] args) {
		int n = int.Parse(Console.ReadLine());
		for (int i = 0; i < n; i++){
			string[] v = Console.ReadLine().Split(' ');
			int x = int.Parse(v[0]);
			int y = int.Parse(v[1]);
			switch (x + y){
				case 0:
					Console.WriteLine("PROXYCITY");
					break;
				case 1:
					Console.WriteLine("P.Y.N.G.");
					break;
				case 2:
					Console.WriteLine("DNSUEY!");
					break;
				case 3:
					Console.WriteLine("SERVERS");
					break;
				case 4:
					Console.WriteLine("HOST!");
					break;
				case 5:
					Console.WriteLine("CRIPTONIZE");
					break;
				case 6:
					Console.WriteLine("OFFLINE DAY");
					break;
				case 7:
					Console.WriteLine("SALT");
					break;
				case 8:
					Console.WriteLine("ANSWER!");
					break;
				case 9:
					Console.WriteLine("RAR?");
					break;
				case 10:
					Console.WriteLine("WIFI ANTENNAS");
					break;
			}
		}
	}
}