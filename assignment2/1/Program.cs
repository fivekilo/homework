
namespace myAPP
{
    class program
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());    
            for(int i = 2; n >= i;)
            {
                if(n % i == 0)
                {
                    n = n / i;
                    Console.WriteLine(i);
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
