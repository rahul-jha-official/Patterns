/// <pattern>
/// 0
/// 1 0
/// 0 1 0
/// 1 0 1 0
/// 0 1 0 1 0
/// </pattern>
public class Pattern6
{
    public void DrawSimple(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            bool flag = i % 2 == 0;
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
                Console.WriteLine($"{string.Join(" ", Enumerable.Repeat(i % 2 == 0 ? "1 0" : "0 1", i)).Substring(0, 2 * i - 1)}"), i++
                ) ;
    }
}
