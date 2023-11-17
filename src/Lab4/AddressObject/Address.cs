namespace Itmo.ObjectOrientedProgramming.Lab4.AddressObject;

public class Address
{
    public string Value { get; private set; } = string.Empty;

    public void Update(string value)
    {
        Value = value;
    }
}