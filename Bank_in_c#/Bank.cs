namespace Bank_in_c_;

public abstract class Bank
{
    private string name, surname ;
    private int age;
    public Bank()
    {
        age = Age;
        name = Name;
       
        surname = SurName;
        id=Guid.NewGuid();
    }
    public Guid id;

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length > 0 && value.Length < 10)
            {
                name = value;
            }

        }
    }
    public string SurName
    {
        get { return surname; }
        set
        {
            if (value.Length > 0 && value.Length < 10)
            {
                surname = value;
            }

        }
    }
    
    
    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0 && value < 100)
            {
                age = value;
            }

        }
    }
}

