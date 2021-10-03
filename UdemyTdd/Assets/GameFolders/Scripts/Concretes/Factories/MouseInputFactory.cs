using UdemyTdd.Abstracts.Factories;
using UdemyTdd.Abstracts.Inputs;

public class MouseInputFactory : Factory<IMouseInputReader>
{
    public override IMouseInputReader Create()
    {
        return new MouseInputReader();
    }
}