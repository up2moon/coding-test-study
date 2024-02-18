public class MyQueue
{
    private Stack<int> Main { get; }
    private Stack<int> Sub { get; }

    public MyQueue()
    {
        Main = new Stack<int>();
        Sub = new Stack<int>();
    }

    public void Push(int x)
    {
        Main.Push(x);
    }

    public int Pop()
    {
        if (Empty())
            return 0;

        while (!Empty())
            Sub.Push(Main.Pop());

        var val = Sub.Pop();

        while (Sub.Count != 0)
            Main.Push(Sub.Pop());

        return val;
    }

    public int Peek()
    {
        if (Empty())
            return 0;

        while (!Empty())
            Sub.Push(Main.Pop());
        var val = Sub.Peek();

        while (Sub.Count != 0)
            Main.Push(Sub.Pop());
        return val;
    }

    public bool Empty()
    {
        return Main.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */