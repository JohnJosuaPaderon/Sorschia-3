using Sorschia.Process;
using Sorschia.SystemBase.Security.Entities;

namespace Sorschia.SystemBase.Security.Processes
{
    public interface IDeleteModule : IAsyncProcess<bool>
    {
        DeleteModuleModel Model { get; set; }
    }

    public sealed class DeleteModuleModel
    {
        public Module Module { get; set; }
        public bool CascadeDelete { get; set; }
    }
}
