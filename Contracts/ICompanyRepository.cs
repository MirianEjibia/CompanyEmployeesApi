namespace Contracts;
using Entities.Models;
public interface ICompanyRepository {
 IEnumerable<Company> GetCompanies (bool trackChanges);
 Company GetCompany (Guid id ,bool trackChanges);
}