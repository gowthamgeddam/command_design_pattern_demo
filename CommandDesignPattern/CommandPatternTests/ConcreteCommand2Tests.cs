
namespace CommandPatternTests
{
    [TestClass]
    public class ConcreteCommand2Tests
    {
        [TestMethod]
        public void Execute_ShouldPerformAction2()
        {
            // Arrange
            Receiver receiver = new Receiver();
            ConcreteCommand2 command = new ConcreteCommand2(receiver);

            // Act
            command.Execute();

            // Assert - Add appropriate assertions based on your implementation
        }
    }
}
