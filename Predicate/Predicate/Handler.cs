namespace Predicate;

public class Handler
{
    public void CheckValidation()
    {
        Person person = new()
                        { Name = "Ali", Code = "1414253600", Age = 17 };

        Validator validator = new();

        Predicate<Person> predicate = validator.CheckCode;
        bool result = predicate.Invoke(person);


        List<Predicate<Person>> predicates = new();
        predicates.Add(validator.CheckCode);
        predicates.Add(validator.CheckAge);

        foreach(var item in predicates)
        {
            if(!item(person)) // item(person) || item.Invoke(person)
            {
                Console.WriteLine("Person is invalid!");
                break;
            }
        }

    }
}
