using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.ComputerCaseInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.FormFactor.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Entities;

public class ArdorGamingCase : IComputerCase, ICloneable
{
    private const int _ardorGamingHeight = 290;
    private const int _ardorGamingWidth = 150;
    private const int _ardorGamingCasePowerConsumption = 0;
    private const string _ardorGamingName = "ArdorGamingCase";
    private IList<MyFormFactor> _ardorGamingRareM2ArgbFormFactors = new List<MyFormFactor>();

    public ArdorGamingCase()
    {
        CaseHeightForVideoCard = _ardorGamingHeight;
        CaseWidthForVideoCard = _ardorGamingWidth;
        PowerConsumption = _ardorGamingCasePowerConsumption;
        Name = _ardorGamingName;
        _ardorGamingRareM2ArgbFormFactors.Add(new MicroAtxFormFactor());
        _ardorGamingRareM2ArgbFormFactors.Add(new AtxFormFactor());
        FormFactorList = _ardorGamingRareM2ArgbFormFactors;
    }

    public int CaseHeightForVideoCard { get; private set; }
    public double CaseWidthForVideoCard { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public IList<MyFormFactor> FormFactorList { get; private set; }
    public bool CheckFormFactor()
    {
        foreach (MyFormFactor myFormFactor in FormFactorList)
        {
            if (myFormFactor is MicroAtxFormFactor)
            {
                return true;
            }
        }

        return false;
    }

    public ArdorGamingCase UpdateCaseHeightForVideoCard(int caseHeightForVideoCard)
    {
        var ardorGamingRareM2ArgbCase = (ArdorGamingCase)Clone();
        ardorGamingRareM2ArgbCase.CaseHeightForVideoCard = caseHeightForVideoCard;
        return ardorGamingRareM2ArgbCase;
    }

    public ArdorGamingCase UpdateCaseWidthForVideoCard(int caseWidthForVideoCard)
    {
        var ardorGamingRareM2ArgbCase = (ArdorGamingCase)Clone();
        ardorGamingRareM2ArgbCase.CaseWidthForVideoCard = caseWidthForVideoCard;
        return ardorGamingRareM2ArgbCase;
    }

    public ArdorGamingCase UpdateCaseFormFactorList(IList<MyFormFactor> formFactorList)
    {
        var ardorGamingRareM2ArgbCase = (ArdorGamingCase)Clone();
        ardorGamingRareM2ArgbCase.FormFactorList = formFactorList;
        return ardorGamingRareM2ArgbCase;
    }

    public ArdorGamingCase UpdateCasePowerConsumption(int powerConsumption)
    {
        var ardorGamingRareM2ArgbCase = (ArdorGamingCase)Clone();
        ardorGamingRareM2ArgbCase.PowerConsumption = powerConsumption;
        return ardorGamingRareM2ArgbCase;
    }

    public ArdorGamingCase UpdateCaseName(string name)
    {
        var ardorGamingRareM2ArgbCase = (ArdorGamingCase)Clone();
        ardorGamingRareM2ArgbCase.Name = name;
        return ardorGamingRareM2ArgbCase;
    }

    public object Clone()
    {
        return new ArdorGamingCase();
    }
}