
public class Node<T>
{
    public Node<T> Next { get; set; }
    public T Data { get; set; }

    public Node(T t)
    {
        Next = null;
        Data = t;
    }
}
public class GenericList<T>
{
    private Node<T> head;
    private Node<T> tail;

    public GenericList()
    {
        tail = head = null;
    }
    public Node<T> Head
    {
        get=> head;
    }
    public void Add(T t)
    {
        Node<T> n = new Node<T>(t);
        if (tail == null)
        {
            head=tail= n;
        }
        else
        {
            tail.Next = n;
            tail= n;
        }
    }
    public void ForEach(Action<T> action)
    {
        Node<T>pointer= head;
        while(pointer != null)
        {
            action(pointer.Data);
            pointer=pointer.Next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        GenericList<int> list = new GenericList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(4);
        list.Add(0);
        list.ForEach(x=>Console.WriteLine(x));
        int max=int.MinValue;
        list.ForEach(x => { if (x > max) max = x; });
        Console.WriteLine($"最大值:{max}");
        int min=int.MaxValue;
        list.ForEach(x => { if (x < min) min = x; });
        Console.WriteLine($"最小值:{min}");
        int sum = 0;
        list.ForEach(x => { sum += x; });
        Console.WriteLine($"总和:{sum}");
    }
}