namespace Sorschia.Community.Entities
{
    public sealed class CivilStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static bool operator ==(CivilStatus left, CivilStatus right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CivilStatus left, CivilStatus right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is CivilStatus value)
            {
                return (Equals(Id, default(int)) && Equals(value.Id, default(int))) ? false : Equals(Id, value.Id);
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

        public override string ToString()
        {
            return Name;
        }
    }
}
