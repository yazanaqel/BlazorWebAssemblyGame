using BlazorWebAssemblyGame.Shared;

namespace BlazorWebAssemblyGame.Client.Services;

public interface IUnitService
{
    public IList<Unit> Units { get;}
    public IList<UserUnit> UserUnits { get; set; }
    void AddUnit(int id);
}
