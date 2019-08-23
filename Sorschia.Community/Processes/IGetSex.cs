using Sorschia.Community.Entities;
using Sorschia.Process;

namespace Sorschia.Community.Processes
{
    public interface IGetSex : IProcess<Sex>, IAsyncProcess<Sex>
    {
        int Id { get; set; }
    }
}
