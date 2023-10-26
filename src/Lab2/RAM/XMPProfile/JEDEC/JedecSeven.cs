namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.XMPProfile.JEDEC;

public class JedecSeven : IJedec
{
    private const int Jedec7Frequency = 1066;
    public JedecSeven()
    {
        JedecFrequency = Jedec7Frequency;
    }

    public int JedecFrequency { get; }
}