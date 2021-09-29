namespace UdemyTdd.Abstracts.Inputs
{
    public interface IMouseInputReader : IInputReader
    {
        bool IsLeftButtonDown { get; }
    }
}