namespace Sorschia.SystemBase.Security
{
    public interface IAccessTokenStorage
    {
        void Set(AccessToken accessToken);
        AccessToken Get();
    }
}
