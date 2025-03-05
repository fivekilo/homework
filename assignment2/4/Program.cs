
namespace myAPP
{
    class program
    {
        static bool judge(int[,] arr,int N)
        {
            for (int i = 1; i < N; i++)
            {
                if (arr[i, i] != arr[0, 0]) return false;
            }
            return true;
        }
        static void Main()
        {
            int[,] arr;
            int n = 2;int m = 3;
            arr = new int[m, n];
            int N = int.Min(n, m);
            Console.WriteLine(judge(arr, N));
        }
    }
}
