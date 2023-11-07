using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.ComputerCaseInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.FormFactor.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Entities;

public class ComputerCase : IComputerCase, ICloneable
{
    public ComputerCase(
        int caseHeight,
        double caseWidth,
        int casePowerConsumption,
        string name,
        IList<MyFormFactor> formFactors)
    {
        CaseHeightForVideoCard = caseHeight;
        CaseWidthForVideoCard = caseWidth;
        PowerConsumption = casePowerConsumption;
        Name = name;
        FormFactorList = formFactors;
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

    public ComputerCase UpdateCaseHeightForVideoCard(int caseHeightForVideoCard)
    {
        var computerCase = (ComputerCase)Clone();
        computerCase.CaseHeightForVideoCard = caseHeightForVideoCard;
        return computerCase;
    }

    public ComputerCase UpdateCaseWidthForVideoCard(int caseWidthForVideoCard)
    {
        var computerCase = (ComputerCase)Clone();
        computerCase.CaseWidthForVideoCard = caseWidthForVideoCard;
        return computerCase;
    }

    public ComputerCase UpdateCaseFormFactorList(IList<MyFormFactor> formFactorList)
    {
        var computerCase = (ComputerCase)Clone();
        computerCase.FormFactorList = formFactorList;
        return computerCase;
    }

    public ComputerCase UpdateCasePowerConsumption(int powerConsumption)
    {
        var computerCase = (ComputerCase)Clone();
        computerCase.PowerConsumption = powerConsumption;
        return computerCase;
    }

    public ComputerCase UpdateCaseName(string name)
    {
        var computerCase = (ComputerCase)Clone();
        computerCase.Name = name;
        return computerCase;
    }

    public object Clone()
    {
        return new ComputerCase(
            CaseHeightForVideoCard,
            CaseWidthForVideoCard,
            PowerConsumption,
            Name,
            FormFactorList);
    }
}