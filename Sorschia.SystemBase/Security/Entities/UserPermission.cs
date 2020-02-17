using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.SystemBase.Security.Entities
{
    public class UserPermission
    {
        public long Id { get; set; }
        public int? UserId { get; set; }
        public int? PermissionId { get; set; }

        public User User { get; private set; }
        public Permission Permission { get; private set; }

        public async Task<User> GetUserAsync(ISystemBaseSecurityRepository repository, CancellationToken cancellationToken = default)
        {
            var id = UserId;

            if (id > 0 && repository != null)
            {
                User = await repository.GetUserAsync(id.Value, cancellationToken);
            }

            return User;
        }

        public async Task<Permission> GetPermissionAsync(ISystemBaseSecurityRepository repository, CancellationToken cancellationToken = default)
        {
            var id = PermissionId;

            if (id > 0 && repository != null)
            {
                Permission = await repository.GetPermissionAsync(id.Value, cancellationToken);
            }

            return Permission;
        }

        public static bool operator ==(UserPermission left, UserPermission right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserPermission left, UserPermission right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is UserPermission value)
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
