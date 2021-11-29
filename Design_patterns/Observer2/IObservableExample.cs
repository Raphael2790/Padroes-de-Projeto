namespace Design_patterns.Observer2
{
    public interface IObservableExample
    {
        string Name { get; }
        void Notify(Investiment investiment);
    }
}