public class Athlete
{
    public int GoldMedalsCount;
    public int SilverMedalsCount;
    public int BronzeMedalsCount;

    //Since all fields are initialized at their default value
    //(for int this is 0) anyway, you can leave out the constructor.
    //In this case, .NET will add an empty constructor behind the scenes.
    //public Athlete()
    //{
    //    GoldMedalsCount = 0;
    //    SilverMedalsCount = 0;
    //    BronzeMedalsCount = 0;
    //}
    //What do you think are the default values for:
    // - bools?
    // - doubles?
    // - strings?
    // - objects?

    public void WinFirstPlace() => GoldMedalsCount++;
    public void WinSecondPlace() => SilverMedalsCount++;
    public void WinThirdPlace() => BronzeMedalsCount++;
}