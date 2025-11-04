namespace Tests;

public class UnitTest1
{
    [Fact]
    public void UserBankruptTest()
    {
        ICharacters Boat = new Character();
        Boat.Money = 1;
        Assert.False(Boat.IsBankrupt());
    }

    [Fact]
    public void UserContainsPropertyTest()
    {
        ICharacters Boat = new Character();
        Properties ParkPlace = new(_rentPrice: 35, _propertyPrice: 350);
        Boat.properties.Add(ParkPlace);
        Assert.Equal(ParkPlace, Boat.properties[1]);
    }
}
