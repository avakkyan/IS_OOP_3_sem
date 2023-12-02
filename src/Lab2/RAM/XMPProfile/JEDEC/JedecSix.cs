namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.XMPProfile.JEDEC;

public class JedecSix : IJedec
{
    private const int Jedec6Frequency = 1066;
    public JedecSix()
    {
        JedecFrequency = Jedec6Frequency;
    }

    public int JedecFrequency { get; }
}