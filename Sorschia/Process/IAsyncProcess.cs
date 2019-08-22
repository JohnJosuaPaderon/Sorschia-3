using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    public interface IAsyncProcess : IDisposable
    {
        Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public interface IAsyncProcess<T> : IDisposable
    {
        Task<T> ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
