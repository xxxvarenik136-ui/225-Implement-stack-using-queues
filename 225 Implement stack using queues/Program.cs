using System.Collections;

public class MyStack
{
    public MyStack()
    {

    }
    private Queue<int> queue1 = new Queue<int>();
    private Queue<int> queue2 = new Queue<int>();
    public void Push(int x)
    {
        if (queue1.Count == 0)
        {
            queue1.Enqueue(x);
            for (int i = 0; i < queue2.Count; i++)
            {
                queue1.Enqueue(queue2.Dequeue());
            }
            return;
        }
        if (queue2.Count == 0)
        {
            queue2.Enqueue(x);
            for (int i = 0; i < queue1.Count; i++)
            {
                queue2.Enqueue(queue1.Dequeue());
            }
            return;
        }

    }

    public int Pop()
    {
        if (queue1.Count == 0)
        {
            return queue2.Dequeue();
        }
        if (queue2.Count == 0)
        {
            return queue1.Dequeue();
        }
        return -1;
    }

    public int Top()
    {
        if (queue1.Count == 0)
        {
            return queue2.Peek();
        }
        if (queue2.Count == 0)
        {
            return queue1.Peek();
        }
        return -1;
    }

    public bool Empty()
    {
        return queue1.Count == 0 && queue2.Count == 0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyStack obj = new MyStack();

        obj.Push(1);
        obj.Push(2);
        Console.WriteLine(obj.Top());
        Console.WriteLine(obj.Pop());
        Console.WriteLine(obj.Empty());
    }
}