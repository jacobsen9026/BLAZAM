﻿using BLAZAM.Helpers;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BLAZAM.Notifications.Services
{
    public class AppDialogService
    {
        private IDialogService _dialog { get; set; }
        DialogOptions DialogOptions { get; set; } = new DialogOptions() { };

        public async Task ShowMessage<TComponent>(DialogParameters parameters , string? title = null, string? yesText = null, string? noText = null, string? cancelText = null) where TComponent : ComponentBase, new()
        {
            await _dialog.ShowAsync<TComponent>(title, parameters, DialogOptions);
        }


        private async Task ShowMessage(MarkupString message, string? title = null, string? yesText = null, string? noText = null, string? cancelText = null)
        {
            await _dialog.ShowMessageBox(title, message, yesText, noText, cancelText,DialogOptions);
        }

        private async Task ShowMessage(string message, string? title = null)
        {
            await ShowMessage(message.ToMarkupString(), title);
        }


        public AppDialogService(IDialogService dialog)
        {
            _dialog = dialog;
        }

        

        public async Task Error(string message, string? title = null)
        {
            
            await ShowMessage(message, title);
        }


        public async Task Info(string message, string? title = null)

        {
            await ShowMessage(message, title);

        }
        public async Task Warning(string message, string? title = null)

        {
            await ShowMessage(message, title);

        }
        public async Task Success(string message, string? title = null)

        {

            await ShowMessage(message, title);


        }
        public async Task<bool> Confirm(string message, string? title = null)

        {
            return await _dialog.ShowMessageBox(title, message, "OK", null, "Cancel") == true;


        }


    }
}
