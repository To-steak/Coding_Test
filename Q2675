string S = string.Empty;
int R = 0;
string P = string. Empty;

int.TryParse(Console.ReadLine(), out int T);
string[] result = new string[T];

for (int i = 0; i < T; i++)
{
    string[] arr = Console.ReadLine().Split(' ');
    int.TryParse(arr[0], out R);
    S = arr[1];

    string temp = string.Empty;
    for (int j = 0; j < S.Length; j++)
    {
        for (int k = 0; k < R; k++)
        {
            temp += S[j];
        }
    }
    result[i] = temp;
    temp = string.Empty;
}

foreach (var item in result)
{
    Console.WriteLine(item);
}
