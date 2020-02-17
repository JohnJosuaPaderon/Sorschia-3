using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.SystemBase.Security.Entities
{
    public class UserModule
    {
        public long Id { get; set; }
        public int? UserId { get; set; }
        public int? ModuleId { get; set; }

        public User User { get; private set; }
        public Module Module { get; private set; }

        public async Task<User> GetUserAsync(ISystemBaseSecurityRepository repository, CancellationToken cancellationToken = default)
        {
            var id = UserId;

            if (id > 0 && repository != null)
            {
                User = await repository.GetUserAsync(id.Value, cancellationToken);
            }

            return User;
        }

        public async Task<Module> GetModuleAsync(ISystemBaseSecurityRepository repository, CancellationToken cancellationToken = default)
        {
            var id = ModuleId;

            if (id > 0 && repository != null)
            {
                Module = await repository.GetModuleAsync(id.Value, cancellationToken);
            }

            return Module;
        }

        public static bool operator ==(UserModule left, UserModule right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserModule left, UserModule right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is UserModule value)
            {
                return (Equals(Id, default(long)) && Equals(value.Id, default(long))) ? false : Equals(Id, value.Id);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
