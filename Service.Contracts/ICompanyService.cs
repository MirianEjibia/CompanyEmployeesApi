namespace Service.Contracts;
using Entities.Models;
using Shared.DataTransfareObjects;

public interface ICompanyService
{
    void DeleteAllCompanies();
    IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges);
    CompanyDto GetCompany (Guid id ,bool trackChanges);
}