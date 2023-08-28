namespace Contracts;

using Entities.Exceptions;
using Entities.Models;
public interface ICompanyRepository
{
    IEnumerable<Company> GetCompanies(bool trackChanges);
    Company GetCompany(Guid id, bool trackChanges);

    void Create(Company company);
    IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
}