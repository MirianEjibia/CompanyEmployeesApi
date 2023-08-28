using Contracts;
using Service.Contracts;
using LoggerService;
using Entities.Models;
using Shared.DataTransfareObjects;
using AutoMapper;
using Entities.Exceptions;

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

        public IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges)
        {

            var companies = _repository.Company.GetCompanies(trackChanges);
            var companiesDto = _mapper.Map<IEnumerable<CompanyDto>>(companies);
            return companiesDto;
        }

        public CompanyDto GetCompany(Guid id, bool trackChanges)
        {
            var company = _repository.Company.GetCompany(id, trackChanges);
            if (company is null)
                throw new CompanyNotFoundException(id);
            var companyDto = _mapper.Map<CompanyDto>(company);
            return companyDto;
        }

        public CompanyDto CreateCompany(CompanyForCreationDto company)
        {
            var companyEntity = _mapper.Map<Company>(company);

            _repository.Company.Create(companyEntity);
            _repository.Save();

            var companyToReturn = _mapper.Map<CompanyDto>(companyEntity);
            return companyToReturn;
        }

        public IEnumerable<CompanyDto> GetCompanies(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new BadRequestException("Company ids not provided properly");
            var companyEntities = _repository.Company.GetByIds(ids, trackChanges);

            if (ids.Count() != companyEntities.Count())
                throw new BadRequestException("Company ids not provided properly");

            var companiesToReturn = _mapper.Map<IEnumerable<CompanyDto>>(companyEntities);
            return companiesToReturn;

        }

        public (IEnumerable<CompanyDto> companies, string ids) CreateCompanies(IEnumerable<CompanyForCreationDto> companies)
        {
            if (companies is null)
                throw new BadRequestException("Companies list not provided properli");
            var companiesEntities = _mapper.Map<IEnumerable<Company>>(companies);

            foreach (var item in companiesEntities)
            {
                _repository.Company.Create(item);
            }
            _repository.Save();

            var comapniesCollectionToReturn = _mapper.Map<IEnumerable<CompanyDto>>(companiesEntities);
            var ids = string.Join(",", companiesEntities.Select(c => c.Id));
            return (companies: comapniesCollectionToReturn, ids: ids);

        }
    }
}
