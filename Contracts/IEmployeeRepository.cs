using Entities.Models;
 
namespace Contracts
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetEmployees(Guid companyId, bool trackChanges);
        public Employee GetEmployee(Guid companyId, Guid id, bool trackChanges);
        public void CreateEmployeeForCompany(Guid companyId, Employee employee);
    }
}