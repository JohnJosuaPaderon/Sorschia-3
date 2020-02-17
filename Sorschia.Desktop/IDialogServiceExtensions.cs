using Prism.Services.Dialogs;
using System;
using System.Windows;

namespace Sorschia
{
    public static class IDialogServiceExtensions
    {
        public static void ShowDialog(this IDialogService instance, DialogInfo dialogInfo)
        {
            var parameters = new DialogParameters();

            foreach (var pair in dialogInfo.Parameters)
            {
                parameters.Add(pair.Key, pair.Value);
            }

            instance.ShowDialog(dialogInfo.Name, parameters, dialogInfo.Callback);
        }

        public static void Show(this IDialogService instance, DialogInfo dialogInfo)
        {
            var parameters = new DialogParameters();

            foreach (var pair in dialogInfo.Parameters)
            {
                parameters.Add(pair.Key, pair.Value);
            }

            instance.Show(dialogInfo.Name, parameters, dialogInfo.Callback);
        }

        public static void ShowMessageDisplay(this IDialogService instance, MessageDisplayPayload payload, Action<IDialogResult> callback = null)
        {
            instance.Show(new DialogInfo(DialogConstants.MessageDisplay, callback)
                .AddParameter(DialogConstants.MessageDisplay_Payload, payload));
        }

        public static void ShowMessageDisplay(this IDialogService instance, string headerText, string content, MessageBoxButton button, MessageBoxImage image, Action<IDialogResult> callback = null)
        {
            instance.ShowMessageDisplay(new MessageDisplayPayload
            {
                HeaderText = headerText,
                Content = content,
                Button = button,
                Image = image
            }, callback);
        }

        public static void ShowMessageDisplay(this IDialogService instance, string content, Action<IDialogResult> callback = null)
        {
            instance.ShowMessageDisplay(DialogConstants.DefaultMessageDisplayHeaderText, content, MessageBoxButton.OK, MessageBoxImage.Information, callback);
        }

        public static void ShowMessageDisplay(this IDialogService instance, string headerText, string content, Action<IDialogResult> callback = null)
        {
            instance.ShowMessageDisplay(headerText, content, MessageBoxButton.OK, MessageBoxImage.Information, callback);
        }

        public static void ShowMessageDisplay(this IDialogService instance, string headerText, string content, MessageBoxButton button, Action<IDialogResult> callback)
        {
            instance.ShowMessageDisplay(headerText, content, button, MessageBoxImage.Information, callback);
        }

        public static void ShowMessageDisplay(this IDialogService instance, string headerText, Exception exception, Action<IDialogResult> callback = null)
        {
            string message;

            if (exception is SorschiaException sorschiaException && sorschiaException.ViewSafeMessage)
            {
                message = sorschiaException.Message;
            }
            else
            {
                message = $"An exception of type '{exception.GetType().FullName}' has been thrown";
            }

            instance.ShowMessageDisplay(headerText, message, MessageBoxButton.OK, MessageBoxImage.Error, callback);
        }

        public static void ShowMessageDisplay(this IDialogService instance, Exception exception, Action<IDialogResult> callback = null)
        {
            instance.ShowMessageDisplay(exception.GetType().Name, exception, callback);
        }
    }
}
