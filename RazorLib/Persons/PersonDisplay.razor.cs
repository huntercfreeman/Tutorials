using Microsoft.AspNetCore.Components;

namespace Luthetus.Tutorials.RazorLib.Persons;

public partial class PersonDisplay : ComponentBase
{
	[Parameter, EditorRequired]
	public Person Person { get; set; } = null!;
}