using Luthetus.Tutorials.RazorLib.Persons;

namespace Luthetus.Tutorials.RazorLib.Installations;

public class LuthetusTutorialsOptions
{
	public Func<IServiceProvider, IPersonRepository> PersonRepositoryFactory { get; set; } =
		sp => new InMemoryPersonRepository();
}
