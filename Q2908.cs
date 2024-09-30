char[] S = Console.ReadLine().ToArray();
Array.Reverse(S);
string[] str = new string(S).Split(' ');
int.TryParse(str[0], out int A);
int.TryParse(str[1], out int B);
Console.WriteLine(A > B ? A : B);
