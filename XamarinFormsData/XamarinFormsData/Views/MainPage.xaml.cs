﻿using Xamarin.Forms;
using XamarinFormsData.ViewModels;

namespace XamarinFormsData.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(this.Navigation);
        }
    }
}
