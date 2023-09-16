namespace CommandPatternTests
{
    [TestClass]
    public class ReceiverTests
    {
        // Helper method to redirect console output to a string
        private static string CaptureConsoleOutput(Action action)
        {
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            action();  // Invoke the action

            Console.SetOut(new StreamWriter(Console.OpenStandardOutput())); // Restore standard output

            return consoleOutput.ToString().Trim(); // Trim to remove extra spaces and newlines
        }

        [TestMethod]
        public void Action1_ShouldWriteToConsole()
        {
            // Arrange
            Receiver receiver = new Receiver();

            // Act
            string expectedOutput = "Receiver is performing Action 1";

            string actualOutput = CaptureConsoleOutput(() => receiver.Action1());

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Action2_ShouldWriteToConsole()
        {
            // Arrange
            Receiver receiver = new Receiver();

            // Act
            string expectedOutput = "Receiver is performing Action 2";

            string actualOutput = CaptureConsoleOutput(() => receiver.Action2());

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
