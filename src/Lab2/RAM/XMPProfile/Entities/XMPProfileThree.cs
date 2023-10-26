using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.XMPProfile.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.XMPProfile.Entities;

public class XMPProfileThree : IXmpProfile
{
    private const int _xmpVoltageThree = 20;
    private const int _xmpFrequencyThree = 21;
    private IList<int> _xmpTimingsThree = new List<int>();

    public XMPProfileThree()
    {
        XmpFrequency = _xmpFrequencyThree;
        XmpVoltage = _xmpVoltageThree;
        _xmpTimingsThree.Add(15);
        _xmpTimingsThree.Add(17);
        _xmpTimingsThree.Add(17);
        XmpTimings = _xmpTimingsThree;
    }

    public int XmpVoltage { get; }
    public int XmpFrequency { get; }
    public IList<int> XmpTimings { get; }
}