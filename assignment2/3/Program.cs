
namespace myAPP
{
    class program
    {
        static void Main()
        {
            int N = 100;
            bool[] prime;
            prime = new bool[N];
            for(int i = 1; i < N; i++)
            {
                prime[i] = true;
            }
            for(int i= 1; i < N; i++)
            {
                if (prime[i])
                {
                    int x = 2;
                    while ((i+1) * x <= N)
                    {
                        prime[(i + 1) * x-1] = false;
                        x++;
                    }
                }
            }
            for(int i = 1; i < N;i++)
            {
                if (prime[i])
                {
                    Console.WriteLine(i+1);
                }
            }
        }
    }
}
