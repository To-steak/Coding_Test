string S = Console.ReadLine();
int result = 0;
string[] arr = S.Split(' ');
foreach (var item in arr)
{
    if(item != string.Empty)
    {
        result ++;
    }
}
Console.WriteLine(result);
