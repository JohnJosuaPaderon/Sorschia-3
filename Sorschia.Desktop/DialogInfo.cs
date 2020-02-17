using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;

namespace Sorschia
{
    public sealed class DialogInfo
    {
        public DialogInfo(string name, Action<IDialogResult> callback)
        {
            Name = name;
            Callback = callback;
            Parameters = new Dictionary<string, object>();
        }

        public string Name { get; }
        public Action<IDialogResult> Callback { get; }
        public IDictionary<string, object> Parameters { get; }

        public DialogInfo AddParameter(string name, object value)
        {
            Parameters.Add(name, value);
            return this;
        }
    }
}
