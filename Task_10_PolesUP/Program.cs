internal class Program
{
    private static void Main(string[] args)
    {
        int a = 2;
        int r = 3;
        int n = 5;
        Console.WriteLine(SumN(a,r,n));
    }
    public static int SumN(int a, int r,int n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += a + r*i;
        }
        return sum;
    }
}