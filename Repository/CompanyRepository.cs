using Contracts;
using Entities.Models;

public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
{
    public CompanyRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }

    public IEnumerable<Company> GetCompanies(bool trackChanges) => FindAll(trackChanges)
          .OrderBy(c => c.Name)
          .ToList();

    public Company GetCompany(Guid id, bool trackChanges) => FindByCondition(c => c.Id == id, trackChanges).SingleOrDefault();
}