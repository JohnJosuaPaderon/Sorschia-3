using Sorschia.SystemBase.Security.Entities;
using System.Collections.Generic;

namespace Sorschia.SystemBase.Security
{
    public interface IAccessTokenGenerator
    {
        AccessToken Generate(User user, IEnumerable<Permission> permissions);
    }
}
