namespace MarsRoverkata
{
    public class MovementCommand : ICommand
    {
        private ICommandable target;
        private char[] movements;

        public MovementCommand(ICommandable target, char[] movements)
        {
            this.target = target;
            this.movements = movements;
        }

        public void Execute()
        {
            target.ExecuteCommands(movements);
        }
    }
}
