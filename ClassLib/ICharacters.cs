public interface ICharacters
{
    List<Properties> properties { get; set; }
    int Money { get; set; }
    public bool IsBankrupt();
    
}
