namespace Tests;

public class UnitTest1
{
    [Fact]
    public void UserMoneyTest()
    {
        Boat boat = new();
        boat.Money = 1;
        Assert.Equal(true, IsBankrupt);
    }
}
