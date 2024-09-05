string? S = Console.ReadLine();
if (S == null) S = "";

int index = 0;
bool flag =  true;
char[] alphabet = new char[26];
int[] result = new int[26];

for (var i = 'a'; i <= 'z'; i++) alphabet[index++] = i;
index = 0;

for (int i = 0; i < alphabet.Length; i++)
{
    for (int j = 0; j < S.Length; j++)
    {
        if(alphabet[i].Equals(S[j]))
        {
            result[index] = j;
            flag = false;
            break;
        }
    }

    if(flag)
    {
        result[index] = -1;
    }
    flag = true;
    index++;
}

for (int k = 0; k < result.Length; k++)
{
    if(k < result.Length - 1)
    {
        Console.Write(result[k] + " ");
    }
    else
    {
        Console.Write(result[k]);
    }
}