using Lab5.Application.Models.OperationsDetail;

namespace Lab5.Application.Abstraction.Repositories;

public interface IOperationDetailRepository
{
   IEnumerable<OperationDetail> GetAllOperation();
   void UpdateOperationInformation(long? id, decimal value);
}