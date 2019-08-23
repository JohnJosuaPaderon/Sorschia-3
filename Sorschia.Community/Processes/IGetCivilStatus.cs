using Sorschia.Community.Entities;
using Sorschia.Process;

namespace Sorschia.Community.Processes
{
    public interface IGetCivilStatus : IProcess<CivilStatus>, IAsyncProcess<CivilStatus>
    {
        int Id { get; set; }
    }
}
