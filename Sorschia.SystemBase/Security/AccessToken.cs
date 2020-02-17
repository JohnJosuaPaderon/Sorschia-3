using System;

namespace Sorschia.SystemBase.Security
{
    public class AccessToken
    {
        public string TokenString { get; set; }
        public DateTime? Expiration { get; set; }
    }
}
