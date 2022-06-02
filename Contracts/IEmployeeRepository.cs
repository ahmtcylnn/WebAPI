using Entities;

namespace Contracts
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployeesByProjectId(Guid projectId,bool trackChanges);
        Employee GetEmployee(Guid projectId,Guid id, bool trackChanges);
        void CreateEmployee(Guid projectId, Employee employee);
        void DeleteEmployee(Guid projectId, Employee employee);

    }
}
