public static class PersonService
{
    public static List<Person> PersonsList { get; private set; } = [];

    public static void AddPerson(Person person)
    {
        PersonsList.Add(person);
    }
}