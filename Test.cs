using Xunit;
public class Test
{
    [Fact]
    public void PassDailyLogic()
    {
        Assert.Equal(107.59 , Program.Q2W6_Monday_DailyLogic(12000.0, 40.0, 57.89, 134.52));
        // Assert.Equal( , Program.Q2W6_Monday_DailyLogic(12000.0, 40.0, 57.89, 134.52));
    }
}