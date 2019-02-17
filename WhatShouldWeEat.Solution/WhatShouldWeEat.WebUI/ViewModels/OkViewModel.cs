using System;
namespace WhatShouldWeEat.WebUI.ViewModels
{
    public class OkViewModel : NotificationViewModelBase<string>
    {
        public OkViewModel()
        {
            Title = "İşlem Başarılı";
        }
    }
}
