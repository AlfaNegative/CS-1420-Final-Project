
public class Character : ICharacters
{
    public List<Properties> properties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Money { get; set; } = 100;

    public bool IsBankrupt()
    {
        return Money <= 0;
    }
}