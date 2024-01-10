namespace Predicate;

public class Validator
{
    public bool CheckCode(Person person)
    {
        return person.Code.Length == 10;
    }

    public bool CheckAge(Person person)
    {
        return person.Age >= 18 && person.Age <= 60;
    }
}
