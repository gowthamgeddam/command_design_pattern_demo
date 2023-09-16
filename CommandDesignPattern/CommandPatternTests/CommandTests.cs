namespace CommandPatternTests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void Command_Execution_ShouldSucceed()
        {
            // Arrange
            Receiver receiver = new Receiver();
            ICommand command1 = new ConcreteCommand1(receiver);

            // Act
            command1.Execute();

            // Assert - You can add appropriate assertions based on your implementation
        }
    }
}