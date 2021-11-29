namespace Design_patterns.Composite
{
    public interface IMessage
    {
        string Description { get; set; }
        void ShowMessages(int sub);
    }
}
