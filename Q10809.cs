string? S = Console.ReadLine();
if (S == null) S = "";
int[] result = new int[]
{
    -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1
};
for (int i = 0; i < S.Length; i++)
{
    var index = S[i] - 'a';
    if(index >= 0 && index <= 25)
    {
        if(result[index] == -1)
            result[index] = i;
    }
}
Console.WriteLine(string.Join(" ", result));

/*
string? S = Console.ReadLine();
if (S == null) S = "";
IEnumerable<int> temp = Enumerable.Repeat(-1, 26);
int[] result = temp.ToArray();
for (int i = 0; i < S.Length; i++)
{
    var index = S[i] - 'a';
    if (result[index] == -1) result[index] = i;
}
Console.WriteLine(string.Join(" ", result));
*/
