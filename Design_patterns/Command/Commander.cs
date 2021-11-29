namespace Design_patterns.Command
{
    public abstract class Commander
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
