using UdemyTdd.Abstracts.Factories;
using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Inputs;

public class DirectionInputFactory : Factory<IDirectionInputReader>
{
    public override IDirectionInputReader Create()
    {
        return new DirectionInputReader();
    }
}