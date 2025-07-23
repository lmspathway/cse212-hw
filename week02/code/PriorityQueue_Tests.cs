using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue them all
    // Expected Result: Items dequeued in order of descending priority
    // Defect(s) Found: None (new test)
    public void TestPriorityQueue_DequeueByPriorityOrder()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("medium", 5);
        priorityQueue.Enqueue("high", 10);

        Assert.AreEqual("high", priorityQueue.Dequeue());
        Assert.AreEqual("medium", priorityQueue.Dequeue());
        Assert.AreEqual("low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same highest priority and check FIFO dequeue order
    // Expected Result: Items dequeued in the same order they were enqueued among same priority
    // Defect(s) Found: None (new test)
    public void TestPriorityQueue_SamePriorityMaintainsFIFO()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("first", 7);
        priorityQueue.Enqueue("second", 7);
        priorityQueue.Enqueue("third", 5);

        Assert.AreEqual("first", priorityQueue.Dequeue());
        Assert.AreEqual("second", priorityQueue.Dequeue());
        Assert.AreEqual("third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue throws exception
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: None (new test)
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with mixed priorities and check dequeue order
    // Expected Result: Items dequeued by priority, FIFO for ties
    // Defect(s) Found: None (new test)
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 5);
        priorityQueue.Enqueue("D", 1);

        Assert.AreEqual("B", priorityQueue.Dequeue()); // highest priority 5, first enqueued
        Assert.AreEqual("C", priorityQueue.Dequeue()); // second highest 5
        Assert.AreEqual("A", priorityQueue.Dequeue()); // priority 2
        Assert.AreEqual("D", priorityQueue.Dequeue()); // priority 1
    }
}
