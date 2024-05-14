using DotnetInterviewTask.Models;

namespace DotnetInterviewTask.Contracts
{
    public interface IApplicationResponseRepository
    {
        Task<ApplicationResponse> CreateAsync(ApplicationResponse applicationResponse);

    }
}