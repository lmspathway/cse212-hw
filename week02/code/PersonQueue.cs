public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    public void Enqueue(Person person)
    {
        _queue.Add(person); // FIFO
    }

    public Person Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("No one in the queue.");
        }

        var person = _queue[0];
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}
