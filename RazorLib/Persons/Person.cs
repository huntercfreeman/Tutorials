namespace Luthetus.Tutorials.RazorLib.Persons;

public class Person
{
	public Person(string firstName, string lastName)
	{
		FirstName = firstName;
		LastName = lastName;
	}

	public Guid PersonId { get; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	
	public string DisplayName => $"{FirstName} {LastName}";
}
