namespace Sorschia.Process
{
    public abstract class ProcessBase
    {
        // Obsolete: Version 0.3.0
        //private ISessionVariables _sessionVariables;

        //protected ISessionVariables SessionVariables
        //{
        //    get
        //    {
        //        if (_sessionVariables == null)
        //        {
        //            _sessionVariables = Global.DependencyProvider.Get<ISessionVariables>(true);
        //        }

        //        return _sessionVariables;
        //    }
        //}

        public virtual void Dispose()
        {
        }
    }
}
