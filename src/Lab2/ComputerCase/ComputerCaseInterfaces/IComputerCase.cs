using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.DataBase;
using Itmo.ObjectOrientedProgramming.Lab2.FormFactor.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.ComputerCaseInterfaces;

public interface IComputerCase : IComputerDetail
{
     int CaseHeightForVideoCard { get; }
     double CaseWidthForVideoCard { get; }
     IList<MyFormFactor> FormFactorList { get; }
     bool CheckFormFactor();
}