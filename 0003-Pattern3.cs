/// <pattern>
/// 5 4 3 2 1
/// 5 4 3 2
/// 5 4 3
/// 5 4
/// 5
/// </pattern>
public class Pattern3
{
    public void DrawSimple(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = n; j >= i; j--)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }

    public void DrawMinimal(int n)
    {
        for (int i = 1;
                i <= n;
                Console.WriteLine($"{string.Join(" ", Enumerable.Range(i, n - i + 1).OrderByDescending(j => j))}"), i++
                ) ;
    }
}
