﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EccobanckAdmin.ViewModel;

namespace EccobanckAdmin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mainmenu : ContentPage
    {
        public Mainmenu()
        {
            InitializeComponent();
            BindingContext = new VMmainmenu(Navigation);
        }
    }
}