namespace Luthetus.Tutorials.RazorLib.Persons;

public interface IPersonRepository
{
	public Task<List<Person>> GetPeopleAsync();
}
