public class MyStack
{
    private List<int> List { get; }

    public MyStack()
    {
        List = new List<int>();
    }

    public void Push(int x)
    {
        List.Add(x);
    }

    public int Pop()
    {
        int item = 0;
        if (List.Count != 0)
        {
            item = List[List.Count - 1];
            List.RemoveAt(List.Count - 1);
        }
        return item;
    }

    public int Top()
    {
        int item = 0;
        if (List.Count != 0)
            item = List[List.Count - 1];
        return item;
    }

    public bool Empty()
    {
        return List.Count == 0;
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