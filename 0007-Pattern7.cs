/// <pattern>
///         1
///       1 0
///     1 0 1
///   1 0 1 0
/// 1 0 1 0 1
/// </pattern>
public class Pattern7
{
    public void DrawSimple(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int spaces = 1; spaces <= 2 * (n - i); spaces++)
            {
                Console.Write(" ");
            }
            bool flag = true;
            for (int j = 1; j <= i; j++, flag = !flag)
            {
                Console.Write($"{(flag ? 1 : 0)} ");
            }
            Console.WriteLine();
        }
    }

    public void DrawMinimal(int n)
    {
        for (int i = 1;
                i <= n;
                Console.WriteLine($"{new string(' ', 2 * (n - i))}{string.Join(" ", Enumerable.Repeat("1 0", i)).Substring(0, 2 * i - 1)}"), i++
                ) ;
    }
}
