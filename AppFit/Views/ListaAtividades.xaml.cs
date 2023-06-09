﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppFit.ViewModels;
using AppFit.Models;

namespace AppFit.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaAtividades : ContentPage
    {
        public ListaAtividades()
        {
            BindingContext = new ListaAtividadesViewModel();

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            var vm = (ListaAtividadesViewModel)BindingContext;

            vm.AtualizarLista.Execute(null);

        }

    }
}

