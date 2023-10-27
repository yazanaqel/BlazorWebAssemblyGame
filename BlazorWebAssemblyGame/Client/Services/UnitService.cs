using Blazored.Toast.Services;
using BlazorWebAssemblyGame.Shared;

namespace BlazorWebAssemblyGame.Client.Services;

public class UnitService : IUnitService
{
	private readonly IToastService _toastService;

	public UnitService(IToastService toastService)
    {
		_toastService = toastService;
	}
    public IList<Unit> Units { get; } = new List<Unit>
	{
			new Unit{Id=1,Title="Knight",Attack=10,Defense=15,BananaCost=100},
			new Unit{Id=2,Title="Arch",Attack=15,Defense=20,BananaCost=150},
			new Unit{Id=3,Title="Mage",Attack=20,Defense=25,BananaCost=200}
	};

	public IList<UserUnit> UserUnits { get; set; } = new List<UserUnit>();

	public void AddUnit(int id)
	{
		Unit unit = Units.FirstOrDefault(x => x.Id == id);

		UserUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.HitPoints });

		_toastService.ShowSuccess($"your {unit.Title} has been built!","Unit built");
    }
}
