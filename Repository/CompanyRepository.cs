using Contracts;
using Entities.Models;

public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
{
    public CompanyRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }

    public void CreateCompany(Company company) => Create(company);

    public IEnumerable<Company> GetCompanies(bool trackChanges) => FindAll(trackChanges)
          .OrderBy(c => c.Name)
          .ToList();

    public Company GetCompany(Guid id, bool trackChanges) => FindByCondition(c => c.Id == id, trackChanges).SingleOrDefault();

    public IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
        FindByCondition(x => ids.Contains(x.Id), trackChanges).ToList();
}