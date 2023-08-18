using Entities.Exceptions;

namespace Entities.Exceptions
{
    public class EmployeeNotFoundException : NotFoundException
    {
        public EmployeeNotFoundException(Guid EmployeeId)
            : base($"The employee with id: {EmployeeId} doesn't exist in the database.")
        {

        }
    }
}