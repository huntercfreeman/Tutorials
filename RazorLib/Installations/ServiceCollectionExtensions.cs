using Microsoft.Extensions.DependencyInjection;
using Luthetus.Tutorials.RazorLib.Persons;

namespace Luthetus.Tutorials.RazorLib.Installations;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddLuthetusTutorialsServices(
		this IServiceCollection services,
		Action<LuthetusTutorialsOptions>? configure = null)
	{
		var tutorialsOptions = new LuthetusTutorialsOptions();
		
		if (configure is not null)
			configure.Invoke(tutorialsOptions);
	
		return services.AddScoped<IPersonRepository>(sp => tutorialsOptions.PersonRepositoryFactory.Invoke(sp));
	}
}
