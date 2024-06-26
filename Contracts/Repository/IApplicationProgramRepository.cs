using DotnetInterviewTask.Models;

namespace DotnetInterviewTask.Contracts
{
    public interface IApplicationProgramRepository
    {
        Task<ApplicationProgram> CreateAsync(ApplicationProgram applicationProgram);
        Task<IReadOnlyList<ApplicationProgram>> GetAllAsync();
        Task<ApplicationProgram?> GetAsync (Guid id);
        ApplicationProgram Update(ApplicationProgram applicationProgram);
    }
}