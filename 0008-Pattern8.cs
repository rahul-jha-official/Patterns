/// <pattern>
///         1
///       2 2 2
///     3 3 3 3 3
///   4 4 4 4 4 4 4
/// 5 5 5 5 5 5 5 5 5
/// </pattern>
public class Pattern8
{
    public void DrawSimple(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int spaces = 1; spaces <= 2 * (n - i); spaces++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j < 2 * i; j++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }

    public void DrawMinimal(int n)
    {
        for (int i = 1;
                i <= n;
                Console.WriteLine($"{new string(' ', 2 * (n - i))}{string.Join(" ", Enumerable.Repeat(i, 2 * i - 1))}"), i++
                ) ;
    }
}
