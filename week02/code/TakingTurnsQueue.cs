public class TakingTurnsQueue
{
    private readonly PersonQueue _people = new();

    public int Length => _people.Length;

    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    public Person GetNextPerson()
    {
        if (_people.IsEmpty())
        {
            throw new InvalidOperationException("No one in the queue.");
        }

        var person = _people.Dequeue();

        int originalTurns = person.Turns;

        if (person.Turns > 0)
        {
            person.Turns--;
            if (person.Turns > 0)
            {
                _people.Enqueue(person);
            }
        }
        else
        {
            _people.Enqueue(person);
        }

        return new Person(person.Name, originalTurns);
    }

    public override string ToString()
    {
        return _people.ToString();
    }
}
