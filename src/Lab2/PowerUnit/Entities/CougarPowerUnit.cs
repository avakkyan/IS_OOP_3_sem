using System;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.PowerUnitInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Entities;

public class CougarPowerUnit : ICougarPowerUnit, ICloneable
{
    private const int _cougarPowerUnitpeakLoad = 800;
    private const int _cougarPowerUnitPowerConsumtion = 0;
    private const string _cougarPowerUnitName = "CougarPowerUnit";

    public CougarPowerUnit()
    {
        PeakLoad = _cougarPowerUnitpeakLoad;
        PowerConsumption = _cougarPowerUnitPowerConsumtion;
        Name = _cougarPowerUnitName;
    }

    public int PeakLoad { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }

    public CougarPowerUnit UpdatePeakLoad(int peakLoad)
    {
        var cougarVte600 = (CougarPowerUnit)Clone();
        cougarVte600.PeakLoad = peakLoad;
        return cougarVte600;
    }

    public CougarPowerUnit UpdatePowerConsumption(int powerConsumption)
    {
        var cougarVte600 = (CougarPowerUnit)Clone();
        cougarVte600.PowerConsumption = powerConsumption;
        return cougarVte600;
    }

    public CougarPowerUnit UpdateName(string name)
    {
        var cougarVte600 = (CougarPowerUnit)Clone();
        cougarVte600.Name = name;
        return cougarVte600;
    }

    public object Clone()
    {
        return new CougarPowerUnit();
    }
}