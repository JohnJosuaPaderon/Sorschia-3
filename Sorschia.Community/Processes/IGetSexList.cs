using Sorschia.Community.Entities;
using Sorschia.Process;
using System.Collections.Generic;

namespace Sorschia.Community.Processes
{
    public interface IGetSexList : IProcess<GetSexesResult>, IAsyncProcess<GetSexesResult>
    {
        GetSexesModel Model { get; set; }
    }

    public sealed class GetSexesModel : PaginatedModel
    {
    }

    public sealed class GetSexesResult : PaginatedResult
    {
        public IEnumerable<Sex> Sexes { get; set; }
    }
}
