﻿using soannpcn_apppassword.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace soannpcn_apppassword.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformationPage : ContentPage
    {
        public InformationPage()
        {
            InitializeComponent();
            this.BindingContext = new InformationViewModel();
        }
    }
}