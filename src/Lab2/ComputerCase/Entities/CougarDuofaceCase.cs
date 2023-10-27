using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.ComputerCaseInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.FormFactor.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Entities;

public class CougarDuofaceCase : IComputerCase, ICloneable
{
    private const int _cougarDuofaceProRgbHeight = 390;
    private const int _cougarDuofaceProRgbWidth = 150;
    private const int _cougarDuofaceProRgbCasePowerConsumption = 0;
    private const string _cougarDuofaceCaseName = "CougarDuofaceCase";
    private IList<MyFormFactor> _cougarDuofaceProRgbFormFactors = new List<MyFormFactor>();

    public CougarDuofaceCase()
    {
        CaseHeightForVideoCard = _cougarDuofaceProRgbHeight;
        CaseWidthForVideoCard = _cougarDuofaceProRgbWidth;
        PowerConsumption = _cougarDuofaceProRgbCasePowerConsumption;
        Name = _cougarDuofaceCaseName;
        _cougarDuofaceProRgbFormFactors.Add(new MicroAtxFormFactor());
        _cougarDuofaceProRgbFormFactors.Add(new AtxFormFactor());
        FormFactorList = _cougarDuofaceProRgbFormFactors;
    }

    public int CaseHeightForVideoCard { get; private set; }
    public double CaseWidthForVideoCard { get; private set; }

    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public IList<MyFormFactor> FormFactorList { get; private set; }
    public bool CheckFormFactor()
    {
        foreach (MyFormFactor formFactor in FormFactorList)
        {
            if (formFactor is MicroAtxFormFactor)
            {
                return true;
            }
        }

        return false;
    }

    public CougarDuofaceCase UpdateCaseHeightForVideoCard(int caseHeightForVideoCard)
    {
        var cougarDuofaceProRgbCase = (CougarDuofaceCase)Clone();
        cougarDuofaceProRgbCase.CaseHeightForVideoCard = caseHeightForVideoCard;
        return cougarDuofaceProRgbCase;
    }

    public CougarDuofaceCase UpdateCaseWidthForVideoCard(int caseWidthForVideoCard)
    {
        var cougarDuofaceProRgbCase = (CougarDuofaceCase)Clone();
        cougarDuofaceProRgbCase.CaseWidthForVideoCard = caseWidthForVideoCard;
        return cougarDuofaceProRgbCase;
    }

    public CougarDuofaceCase UpdateCaseFormFactorList(IList<MyFormFactor> formFactorList)
    {
        var cougarDuofaceProRgbCase = (CougarDuofaceCase)Clone();
        cougarDuofaceProRgbCase.FormFactorList = formFactorList;
        return cougarDuofaceProRgbCase;
    }

    public CougarDuofaceCase UpdateCasePowerConsumption(int powerConsumption)
    {
        var cougarDuofaceProRgbCase = (CougarDuofaceCase)Clone();
        cougarDuofaceProRgbCase.PowerConsumption = powerConsumption;
        return cougarDuofaceProRgbCase;
    }

    public CougarDuofaceCase UpdateCaseName(string name)
    {
        var cougarDuofaceProRgbCase = (CougarDuofaceCase)Clone();
        cougarDuofaceProRgbCase.Name = name;
        return cougarDuofaceProRgbCase;
    }

    public object Clone()
    {
        return new CougarDuofaceCase();
    }
}