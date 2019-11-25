using System;

namespace Sorschia.Process
{
    public abstract class ProcessBase
    {
        [Obsolete]
        private ISessionVariables _sessionVariables;

        [Obsolete]
        protected ISessionVariables SessionVariables
        {
            get
            {
                if (_sessionVariables == null)
                {
                    _sessionVariables = Global.DependencyProvider.Get<ISessionVariables>(true);
                }

                return _sessionVariables;
            }
        }

        public virtual void Dispose()
        {
        }
    }
}
