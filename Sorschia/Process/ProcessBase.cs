﻿namespace Sorschia.Process
{
    public abstract class ProcessBase
    {
        private ISessionVariables _sessionVariables;
        
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
    }
}
