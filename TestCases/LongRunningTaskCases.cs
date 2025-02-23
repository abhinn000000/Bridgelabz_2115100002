using NUnit.Framework;

[TestFixture]
public class TaskProcessorTests
{
    private TaskProcessor _taskProcessor;

    [SetUp]
    public void Setup()
    {
        _taskProcessor = new TaskProcessor();
    }

    [Test, Timeout(2000)] // Test fails if it takes more than 2 seconds
    public void LongRunningTask_ShouldTimeout()
    {
        _taskProcessor.LongRunningTask();
    }
    public class TaskProcessorTests
    {
        private TaskProcessor _taskProcessor;

        [TestInitialize]
        public void Setup()
        {
            _taskProcessor = new TaskProcessor();
        }

        [TestMethod]
        [Timeout(2000)] // Test fails if it takes more than 2 seconds
        public void LongRunningTask_ShouldTimeout()
        {
            _taskProcessor.LongRunningTask();
        }
    }
