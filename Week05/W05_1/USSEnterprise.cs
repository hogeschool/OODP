public class USSEnterprise
{
    public string Name;
    public int WarpSpeed { get; set; }

    public USSEnterprise()
    {
        Name = "USS Enterprise";
        WarpSpeed = 0;
    }

    public void EngageWarpDrive(int speed) => WarpSpeed = speed;
}
