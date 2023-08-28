namespace Service.Contracts;
using Entities.Models;
using Shared.DataTransfareObjects;

public interface ICompanyService
{
    void DeleteAllCompanies();
    IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges);
    CompanyDto GetCompany(Guid id, bool trackChanges);
    CompanyDto CreateCompany(CompanyForCreationDto company);
    IEnumerable<CompanyDto> GetCompanies(IEnumerable<Guid> ids, bool trackChanges);
    (IEnumerable<CompanyDto> companies, string ids) CreateCompanies(IEnumerable<CompanyForCreationDto> companies);
}