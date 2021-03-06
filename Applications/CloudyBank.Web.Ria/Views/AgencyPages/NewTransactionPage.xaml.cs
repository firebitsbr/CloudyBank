using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using CloudyBank.Web.Ria.ViewModels;
using CloudyBank.Web.Ria.Views.Pages;
using CloudyBank.Web.Ria.Views.Windows;


namespace CloudyBank.Web.Ria.Views
{
    public partial class NewTransactionPage : Page
    {
        public NewTransactionPage()
        {
            InitializeComponent();
            FromAccountComboBox.Loaded += new RoutedEventHandler(FromAccountComboBox_Loaded);
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (DataContext.GetType()!= typeof(NewOperationViewModel) || DataContext == null)
            {
                this.DataContext = new NewOperationViewModel();
            }
            base.OnNavigatedTo(e);
        }


        //This is a hack - the VM behind has to correct value which should be selected in the combobox,
        //but the collection of items to ItemsSource of the combobox arrives later -> thus the correct item
        //is not selected.
        void FromAccountComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            FromAccountComboBox.SelectedItem = (DataContext as NewOperationViewModel).From;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChooseReceiverWindow window = new ChooseReceiverWindow();
            window.DataContext = Customer.Data;
            window.Show();
            window.Closed += new EventHandler(window_Closed);
        }

        //Receiver (account or partner) can be selected in a pop-up window, this is event handler to event
        //fired when the window was closed - has to copy the selected partner of account.
        void window_Closed(object sender, EventArgs e)
        {
            NewOperationViewModel vm = this.DataContext as NewOperationViewModel;

            ChooseReceiverWindow window = sender as ChooseReceiverWindow;
            if ((bool)window.DialogResult)
            {
                if (window.SelectedAccount != null)
                {
                    var account = (AccountViewModel)window.SelectedAccount;
                    vm.To = account;
                    vm.CreditAccountIban = account.Iban;
                    vm.PartnerName = null;
                }

                if (window.SelectedPartner != null)
                {
                    var partner = ((BusinessPartnerViewModel)window.SelectedPartner);
                    vm.To = null;
                    vm.CreditAccountIban = partner.Iban;
                    vm.PartnerName = partner.Title;
                }
            }
        }
    }
}
