/// <pattern>
///        1
///       2 1 2
///     3 2 1 2 3
///   4 3 2 1 2 3 4
/// 5 4 3 2 1 2 3 4 5
/// </pattern>
public class Pattern9
{
    public void DrawSimple(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int spaces = 1; spaces <= 2 * (n - i); spaces++)
            {
                Console.Write(" ");
            }
            for (int j = i; j >= 1; j--)
            {
                Console.Write($"{j} ");
            }

            for (int j = 2; j <= i; j++)
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
                Console.WriteLine($"{new string(' ', 2 * (n - i))}{string.Join(" ", Enumerable.Range(1,i).OrderByDescending(j => j))} {string.Join(" ", Enumerable.Range(2, i - 1))}"), i++
                ) ;
    }
}
