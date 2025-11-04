
public class Character : ICharacters
{
    public List<Properties>? properties { get; set; }
    public int Money { get; set; } = 100;

    public bool IsBankrupt()
    {
        return Money <= 0;
    }
}