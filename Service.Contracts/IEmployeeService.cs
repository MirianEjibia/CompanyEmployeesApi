namespace Service.Contracts;
using Shared.DataTransfareObjects;
public interface IEmployeeService
{
    IEnumerable<EmployeeDto> GetEmployees (Guid companyId, bool trackChanges);
}