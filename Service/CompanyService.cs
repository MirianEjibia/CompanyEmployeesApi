using Contracts;
using Service.Contracts;
using LoggerService;
using Entities.Models;
using Shared.DTOs;
using AutoMapper;

namespace Service
{
    internal sealed class CompanyService : ICompanyService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CompanyService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public void DeleteAllCompanies()
        {
            // _repository.Company.DeleteAllCompanies();
        }

        public IEnumerable<CompanyDto> GetAllCompanies (bool trackChanges) {
     
                var companies = _repository.Company.GetCompanies(trackChanges);
                var companiesDto = _mapper.Map<IEnumerable<CompanyDto>>(companies);
                return companiesDto;
        }  

        public CompanyDto GetCompany (Guid id, bool trackChanges) {
            var company = _repository.Company.GetCompany(id, trackChanges);
            var companyDto = _mapper.Map<CompanyDto>(company);
            return companyDto;
        }
    }
}