public interface IInsurable
{
    string Insurer { get; set; }
    double Premium { get; set; }
   
    bool isInsured();
}