using System;
using System.Collections.Generic;
using System.ComponentModel;
using theRoof6.Models;
using theRoof6.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace theRoof6.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}