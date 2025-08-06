public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == this.Data)
        {
            return true;
        }
        else if (value < this.Data)
        {
            return this.Left != null && this.Left.Contains(value);
        }
        else // value > this.Data
        {
            return this.Right != null && this.Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        return 1 + Math.Max(
                    Left?.GetHeight() ?? 0,
                    Right?.GetHeight() ?? 0);
    }
}