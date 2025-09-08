/*
Create a CarFactory class that cannot be instantiated and stores
the top speed of a Fiat (200) and a Bugatti (420).
The class should be able to produce 
blue Fiats and red Bugattis with the stored top speeds
*/
public static class CarFactory
{
    public static int TopSpeedFiat = 200;
    public static int TopSpeedBugatti = 420;

    public static Car CreateBlueFiat() => new("Fiat", "Blue", TopSpeedFiat);
    public static Car CreateRedBugatti() => new("Bugatti", "Red", TopSpeedBugatti);
}