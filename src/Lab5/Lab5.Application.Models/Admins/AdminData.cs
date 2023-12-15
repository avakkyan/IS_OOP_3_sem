namespace Lab5.Application.Models.Admins;

public record AdminData(string Name, string Password)
{
    public AdminData()
        : this("1234", "1234") { }
}