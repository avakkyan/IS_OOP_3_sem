namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.XMPProfile.JEDEC;

public class JedecEight : IJedec
{
    private const int Jedec8Frequency = 1037;
    public JedecEight()
    {
        JedecFrequency = Jedec8Frequency;
    }

    public int JedecFrequency { get; }
}