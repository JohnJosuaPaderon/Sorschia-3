using System.Windows;

namespace Sorschia
{
    public sealed class MessageDisplayPayload
    {
        public string HeaderText { get; set; }
        public string Content { get; set; }
        public MessageBoxButton Button { get; set; } = MessageBoxButton.OK;
        public MessageBoxImage Image { get; set; } = MessageBoxImage.Information;
    }
}
