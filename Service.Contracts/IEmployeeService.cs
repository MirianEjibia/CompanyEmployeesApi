namespace Service.Contracts;
using Shared.DataTransfareObjects;
public interface IEmployeeService
{
    IEnumerable<EmployeeDto> GetEmployees(Guid companyId, bool trackChanges);
    EmployeeDto GetEmployee(Guid companyId, Guid id, bool trackChanges);
    EmployeeDto CreateEmployee(Guid companyId, EmployeeForCreationDto employeeForCreation, bool trackChanges);
}