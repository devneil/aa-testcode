namespace DesignPatterns.Command
{
    public class Client
    {
        static void Main()
        {
            var receiver = new Receiver();
            var command = new ConcreteCommand(receiver);
            var invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }

    }
}