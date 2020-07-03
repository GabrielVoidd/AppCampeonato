using Campeonato_App.Models;
using Campeonato_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        PrincipalViewModel vm = new PrincipalViewModel();

        public Principal()
        {
            InitializeComponent();

            this.BindingContext = vm;
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Confronto selectedItem = e.SelectedItem as Confronto;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Confronto tappedItem = e.Item as Confronto;
        }
    }
}