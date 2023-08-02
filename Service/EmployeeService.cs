using LoggerService;
using Service.Contracts;
using Contracts;
using AutoMapper;

namespace Service
{
    internal sealed class EmployeeService : IEmployeeService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public EmployeeService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public void UpdateEmployees()
        {
            // _repository.Employee.UpdateEmployees();
        }

    }
}