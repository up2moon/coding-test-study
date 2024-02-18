public class MyStack
{
    private Queue<int> Queue { get; }

    public MyStack()
    {
        Queue = new Queue<int>();
    }

    public void Push(int x)
    {
        Queue.Enqueue(x);
        int count = Queue.Count;

        while (--count > 0)
            Queue.Enqueue(Queue.Dequeue());
    }

    public int Pop()
    {
        if (Empty())
            return 0;
        return Queue.Dequeue();
    }

    public int Top()
    {
        if (Empty())
            return 0;
        return Queue.Peek();
    }

    public bool Empty()
    {
        return Queue.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */