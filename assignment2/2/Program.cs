
namespace myAPP
{
    class program
    {
        static void Main()
        {
            int N = 3;
            int[] arr;
            arr=new int[N];
            arr[0] =1;
            arr[1] =2;
            arr[2] =3;
            int max=int.MinValue;int min=int.MaxValue;
            int sum = 0;
            foreach (int i in arr)
            {
                if (i > max) max = i;
                if (i < min) min = i;
                sum += i;
            }
            double average = (double)sum / N;
            Console.WriteLine("max:"+max);
            Console.WriteLine("min:" + min);
            Console.WriteLine("sum:" + sum);
            Console.WriteLine("average:" + average);
        }
    }
}
