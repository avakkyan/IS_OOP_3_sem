using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.XMPProfile.Interfaces;

public interface IXmpProfile
{
    int XmpVoltage { get; }
    int XmpFrequency { get; }
    IList<int> XmpTimings { get; }
}