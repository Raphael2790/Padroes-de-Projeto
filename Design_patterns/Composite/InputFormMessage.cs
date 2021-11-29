namespace Design_patterns.Composite
{
    internal class InputFormMessage : IMessage
    {
        public InputFormMessage(string description)
        {
            Description = description;
        }

        public string Description { get; set; }

        public void ShowMessages(int sub)
        {
            System.Console.WriteLine(new string('-', sub) + Description);
        }
    }
}