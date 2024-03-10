namespace Bank_in_c_;

public class Manager : Bank, IOrganize
{
    public Manager()
    {
        salary = Salary;
        position = Position;

    }
    public void organize()
    {
        Console.WriteLine("Iorganize");

    }
    private int salary;

    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    private string position;

    public string Position
    {
        get { return position; }
        set { position = value; }
    }
    public void Calculate_Salary()
    {
    Console.WriteLine("Calculate");
    
    }

}
