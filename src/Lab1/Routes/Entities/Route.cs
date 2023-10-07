using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;

public class Route
{
    private readonly List<Section> _sections = new();

    public Route(IReadOnlyCollection<Section> sections)
    {
        if (sections is null)
        {
            throw new ArgumentException("Sections is null");
        }

        foreach (Section section in sections)
        {
            AddSection(section);
        }
    }

    public IReadOnlyCollection<Section> Sections => _sections.AsReadOnly();

    public void AddSection(Section section)
    {
        _sections.Add(section);
    }
}