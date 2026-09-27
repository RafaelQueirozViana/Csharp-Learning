public class Client
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public DateTime BirthDate { get; private set; }

    public Client(string name, string email, DateTime birth)
    {
        Name = name;
        Email = email;
        BirthDate = BirthDate;
    }

    public bool IsAdult()
    {
        bool isAdult;
        if (DateTime.Now.Year - BirthDate.Year >= 18)
        {
            isAdult = true;
        }

        else
        {
            isAdult = false;
        }

        return isAdult;
    }

}