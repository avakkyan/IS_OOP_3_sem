using Itmo.ObjectOrientedProgramming.Lab2.DataBase;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class Repository
{
    private ComponentsDatabase _datailStorage = new ComponentsDatabase();

    public void UpdateDataile(IComputerDetail detail)
    {
        _datailStorage.Update(detail);
    }

    public IComputerDetail? FindMyDetail(string detailName)
    {
        return _datailStorage.FindDetail(detailName);
    }
}