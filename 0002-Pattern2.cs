/// <pattern>
///         1
///       2 1
///     3 2 1
///   4 3 2 1
/// 5 4 3 2 1
/// </pattern>
public class Pattern2
{
    public void DrawSimple(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int spaces = 1; spaces <= 2 * (n - i);  spaces++)
            {
                Console.Write(" ");
            }
            for (int j = i; j >= 1; j--)
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
                Console.WriteLine($"{new string(' ', 2 * (n - i))}{string.Join(" ", Enumerable.Range(1, i).OrderByDescending(j => j))}"),i++
                );
    }
}
