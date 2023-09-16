
namespace CommandPatternTests
{
    [TestClass]
    public class InvokerTests
    {
        [TestMethod]
        public void SetCommand_ShouldSetCommand()
        {
            // Arrange
            Invoker invoker = new Invoker();
            ICommand command = new ConcreteCommand1(new Receiver());

            // Act
            invoker.SetCommand(command);

            // Assert - Add appropriate assertions based on your implementation
        }

        [TestMethod]
        public void ExecuteCommand_ShouldExecuteCommand()
        {
            // Arrange
            Invoker invoker = new Invoker();
            ICommand command = new ConcreteCommand1(new Receiver());
            invoker.SetCommand(command);

            // Act
            invoker.ExecuteCommand();

            // Assert - Add appropriate assertions based on your implementation
        }
    }
}
