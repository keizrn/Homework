// Calculates segment length in a 3D space
Console.WriteLine("Input 3 coordinates of the FIRST point (separated with a blank space)..");
string[] token1 = Console.ReadLine().Split();
int x1 = int.Parse(token1[0]);
int y1 = int.Parse(token1[1]);
int z1 = int.Parse(token1[2]);
Console.WriteLine("Input 3 coordinates of the SECOND point (separated with a blank space)..");
string[] token2 = Console.ReadLine().Split();
int x2 = int.Parse(token2[0]);
int y2 = int.Parse(token2[1]);
int z2 = int.Parse(token2[2]);
double len = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
Console.WriteLine($"The length of this segment is {len:f2}");