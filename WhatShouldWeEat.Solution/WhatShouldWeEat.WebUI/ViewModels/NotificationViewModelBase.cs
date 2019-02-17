using System;
using System.Collections.Generic;

namespace WhatShouldWeEat.WebUI.ViewModels
{
    public class NotificationViewModelBase<T>
    {
        public List<T> Items { get; set; }
        public string Title { get; set; }
        public bool IsRedirecting { get; set; }
        public string RedirectingUrl { get; set; }

        public NotificationViewModelBase()
        {
            Title = "Yönlendiriliyorsunuz..";
            IsRedirecting = true;
            RedirectingUrl = "/Home/Index";
            Items = new List<T>();
        }
    }
}
