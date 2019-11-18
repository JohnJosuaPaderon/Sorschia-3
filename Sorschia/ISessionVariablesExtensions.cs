using System;

namespace Sorschia
{
    [Obsolete]
    public static class ISessionVariablesExtensions
    {
        public const string DEVELOPMENTMODE = "DevelopmentMode";
        public const string USECACHING = "UseCaching";
        private const bool DEVELOPMENTMOE_DEFAULT = false;
        private const bool USECACHING_DEFAULT = true;

        private static T TryGetValue<T>(ISessionVariables sessionVariables, string key, T valueIfNotExists = default(T))
        {
            if (!string.IsNullOrWhiteSpace(key) && sessionVariables.TryGetValue(key, out T result))
            {
                return result;
            }

            return valueIfNotExists;
        }

        private static T AddOrUpdate<T>(ISessionVariables sessionVariables, string key, T value)
        {
            if (!string.IsNullOrWhiteSpace(key))
            {
                sessionVariables.AddOrUpdate(key, value);
            }

            return value;
        }

        public static bool DevelopmentMode(this ISessionVariables instance)
        {
            return TryGetValue(instance, DEVELOPMENTMODE, DEVELOPMENTMOE_DEFAULT);
        }

        public static bool DevelopmentMode(this ISessionVariables instance, bool value)
        {
            return AddOrUpdate(instance, DEVELOPMENTMODE, value);
        }

        public static bool UseCaching(this ISessionVariables instance)
        {
            return TryGetValue(instance, USECACHING, USECACHING_DEFAULT);
        }

        public static bool UseCaching(this ISessionVariables instance, bool value)
        {
            return AddOrUpdate(instance, USECACHING, value);
        }
    }
}
