/*
    Athlete
    -------
    An Athlete has a collection of medals, 
    a total amount of earnings, a record of 
    whether they are a gold medalist and how
    many gold medals they have earned. Of course,
    an Athlete starts out with no medals. When they 
    receive a medal, their data is updated.

    * default values, default constructor
*/
public class Athlete
{
    public List<Medal> Medals = [];
    public double TotalEarnings;
    public bool IsGoldMedalist;
    public int NumGoldMedals;

    // public Athlete()
    // {
    //     Medals = [];
    //     TotalEarnings = 0;
    //     IsGoldMedalist = false;
    //     NumGoldMedals = 0;
    // }

    public void ReceiveMedal(Medal newMedal)
    {
        if (newMedal == null)
            return;

        Medals.Add(newMedal);
        TotalEarnings += newMedal.Value;
        CheckForGoldMedal(newMedal);
    }

    public void CheckForGoldMedal(Medal newMedal)
    {
        if (newMedal.Color.ToLower() == "gold")
        {
            IsGoldMedalist = true;
            NumGoldMedals++;
        }
    }
}