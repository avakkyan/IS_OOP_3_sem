using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.XMPProfile.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.XMPProfile.Entities;

public class XMPProfileTwo : IXmpProfile
{
    private const int _xmpVoltageTwo = 20;
    private const int _xmpFrequencyTwo = 21;
    private IList<int> _xmpTimingsTwo = new List<int>();

    public XMPProfileTwo()
    {
        XmpFrequency = _xmpFrequencyTwo;
        XmpVoltage = _xmpVoltageTwo;
        _xmpTimingsTwo.Add(15);
        _xmpTimingsTwo.Add(17);
        _xmpTimingsTwo.Add(17);
        XmpTimings = _xmpTimingsTwo;
    }

    public int XmpVoltage { get; }
    public int XmpFrequency { get; }
    public IList<int> XmpTimings { get; }
}