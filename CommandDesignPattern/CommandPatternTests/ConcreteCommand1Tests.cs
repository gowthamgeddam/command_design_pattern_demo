
namespace CommandPatternTests
{
    [TestClass]
    public class ConcreteCommand1Tests
    {
        [TestMethod]
        public void Execute_ShouldPerformAction1()
        {
            // Arrange
            Receiver receiver = new Receiver();
            ConcreteCommand1 command = new ConcreteCommand1(receiver);

            // Act
            command.Execute();

            // Assert - Add appropriate assertions based on your implementation
        }
    }
}

