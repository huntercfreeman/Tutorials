namespace Luthetus.Tutorials.RazorLib.Persons;

public class InMemoryPersonRepository : IPersonRepository
{
	private readonly SemaphoreSlim _semaphore = new(1, 1);
	private readonly List<Person> _people = new();
    
    public InMemoryPersonRepository()
    {
    	_people.Add(new Person("John", "Doe"));
    }
    
    public async Task<List<Person>> GetPeopleAsync()
    {
    	await _semaphore.WaitAsync();
    
    	try
    	{
    		// Return a shallow copy
	    	return new List<Person>(_people);
    	}
    	finally
    	{
    		_semaphore.Release();
    	}
    }
}
